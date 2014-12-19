using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SilverFiszki
{
    public class Score : IComparable<Score>
    {
        [XmlAttribute]
        public int GoodAnswerCount { get; set; }
        [XmlAttribute]
        public int WrongAnswerCount { get; set; }
        public int AllAnswers { get { return GoodAnswerCount + WrongAnswerCount; } }

        [XmlAttribute]
        public DateTime GameEndTime { get; set; }
        public string GamrEndTimeAsString { get { return string.Format("{0}/{1}/{2}", GameEndTime.Day, GameEndTime.Month, GameEndTime.Year); } }
        
        public int CompareTo(Score other)
        {
            if (this.GoodAnswerCount > other.GoodAnswerCount)
            {
                return -1;
            }
            else if (this.GoodAnswerCount < other.GoodAnswerCount)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        
        public override string ToString()
        {
            return string.Format("Znane słowa: {0}, Nie znane słowa: {1}, Data ukończenia gry: {2}",GoodAnswerCount, WrongAnswerCount, GamrEndTimeAsString);
        }
    }
}
