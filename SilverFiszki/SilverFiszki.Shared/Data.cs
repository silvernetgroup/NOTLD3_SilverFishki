using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Windows.Storage;

namespace SilverFiszki
{
    public static class Data
    {
        public static int Suma { get { return Znam + Nieznam; } }
        public static int Znam { get; set; }
        public static int Nieznam { get; set; }

        public static string Jezyk { get; set; }
        public static string Poziom { get; set; }
        public static int PoziomNumer { get; set; }

        public static Score LastScore { get; set; }

        #region Highscore

        private static List<Score> highscore = new List<Score>();
        public static List<Score> Highscore
        {
            get
            {
                highscore.Sort(); 
                return highscore;
            }
        }

        private static ApplicationDataContainer appSettings = null;
        public static ApplicationDataContainer AppSettings
        {
            get { return appSettings; }
            set
            {
                appSettings = value;
                LoadHighscore();
            }
        }

        private static void LoadHighscore()
        {
            string highscoreXml = null;

            if (AppSettings.Values.ContainsKey("Highscore"))
            {
                highscoreXml = (string)AppSettings.Values["Highscore"];
                highscore = highscoreXml.ScoreFromXml();
            }
            else
            {
                highscore = new List<Score>();
            }
        }
        private static void SaveHighscore()
        {
            KeyValuePair<string, object> pair = new KeyValuePair<string, object>("Highscore", highscore.ScoreToXml());

            if (AppSettings.Values.ContainsKey("Highscore"))
            {
                AppSettings.Values.Remove("Highscore");
            }

            AppSettings.Values.Add(pair);
        }
        private static void AddScore(Score newScore)
        {
            highscore.Add(newScore);
            SaveHighscore();
        }
        public static Score CreateScore()
        {
            Score score = new Score()
            {
                GameEndTime = DateTime.Now,
                GoodAnswerCount = Znam,
                WrongAnswerCount = Nieznam
            };

            LastScore = score;

            return score;
        }
        public static void AddScoreToHighscores()
        {
            AddScore(CreateScore());
        }

        #endregion Highscore

        /// <summary>
        /// Score serialization to xml.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ScoreToXml(this List<Score> value)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Score>));
            StringBuilder stringBuilder = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                OmitXmlDeclaration = true,
            };


            using (XmlWriter xmlWriter = XmlWriter.Create(stringBuilder, settings))
            {
                serializer.Serialize(xmlWriter, value);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Score deserialization from xml.
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static List<Score> ScoreFromXml(this string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Score>));
            List<Score> value;
            using (StringReader stringReader = new StringReader(xml))
            {
                object deserialized = serializer.Deserialize(stringReader);
                value = (List<Score>)deserialized;
            }

            return value;
        }
    }

    public enum Poziom
    {
        Łatwy = 1,
        Średni = 2,
        Trudny = 3,
    }
}
