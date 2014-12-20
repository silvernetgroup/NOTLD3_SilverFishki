using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Media.Imaging;

namespace SilverFiszki
{
    public class Row
    {
        public string Polski { get; set; }
        public string Angielski { get; set; }
        public string ZdaniePolski { get; set; }
        public string ZdanieAngielski { get; set; }
        public BitmapImage Image { get; set; }

        public int Level { get; set; }
    }

    public class PolishEanglishDictionary
    {
        private Random random = new Random();
        public List<Row> list = new List<Row>();

        public PolishEanglishDictionary()
        {
            list.Add(new Row() { Level = 1, Angielski = "account", Polski = "konto", ZdanieAngielski = "Tom has opened his account today.", ZdaniePolski = "Tomek otworzył dzisiaj konto" });
            list.Add(new Row() { Level = 1, Angielski = "acid", Polski = "kwas", ZdanieAngielski = "Caution! This is dangerous acid.", ZdaniePolski = "Ostrożnie! to niebezpieczny kwas" });
            list.Add(new Row() { Level = 1, Angielski = "adjustment", Polski = "regulacja", ZdanieAngielski = "Please adjust your radio, it is not playing well.", ZdaniePolski = "Proszę wyreguluj swoje radio, ono nie gra dobrze." });
            list.Add(new Row() { Level = 1, Angielski = "advertisement", Polski = "reklama", ZdanieAngielski = "I hate TV advertisements.", ZdaniePolski = "Nienawidzę reklam telewizyjnych." });
            list.Add(new Row() { Level = 1, Angielski = "agreement", Polski = "umowa", ZdanieAngielski = "I've signed this agreement yesterday.", ZdaniePolski = "Podpisałem tą umowę wczoraj." });
            list.Add(new Row() { Level = 1, Angielski = "angle", Polski = "kąt", ZdanieAngielski = "Draw this line with good angle please.", ZdaniePolski = "Proszę narysuj tę linię pod dobrym kątem." });
            list.Add(new Row() { Level = 1, Angielski = "ant", Polski = "mrówka", ZdanieAngielski = "Oh no! There are ants in my sandwich!", ZdaniePolski = "O nie! W mojej kanapce są mrówki!" });
            list.Add(new Row() { Level = 1, Angielski = "apple", Polski = "jabłko", ZdanieAngielski = "How much costs four kilograms of apples?", ZdaniePolski = "Jak dużo kosztują cztery kilogramy jabłek?" });
            list.Add(new Row() { Level = 1, Angielski = "arch", Polski = "łuk", ZdanieAngielski = "Look at him! He is a master of arch!", ZdaniePolski = "Spójrz na niego jak mistrzowsko włada łukiem!" });
            list.Add(new Row() { Level = 1, Angielski = "argument", Polski = "spór", ZdanieAngielski = "We had an argument last night, today I sleep on the couch...", ZdaniePolski = "Mieliśmy kłótnię wczoraj w nocy, dziś śpię na kanapie..." });
            list.Add(new Row() { Level = 1, Angielski = "arm", Polski = "ręka, ramię", ZdanieAngielski = "Tom if you overbalance just give me your hand.", ZdaniePolski = "Tomek, jeśli stracisz równowagę po prostu podaj mi rękę." });
            list.Add(new Row() { Level = 2, Angielski = "army", Polski = "wojsko, armia", ZdanieAngielski = "My grandfather was in army.", ZdaniePolski = "Mój dziadek byuł w wojsku" });
            list.Add(new Row() { Level = 2, Angielski = "art", Polski = "sztuka", ZdanieAngielski = "I am not very interested in art.", ZdaniePolski = "Nie jestem zbytnio zainteresowany sztuką" });
            list.Add(new Row() { Level = 2, Angielski = "baby", Polski = "niemowlę", ZdanieAngielski = "Tom and Ann have a baby.", ZdaniePolski = "Tomek i Ania mają dziecko." });
            list.Add(new Row() { Level = 2, Angielski = "back", Polski = "plecy", ZdanieAngielski = "Look at his muscular back!", ZdaniePolski = "Spójrz na jego umięśnione plecy!" });
            list.Add(new Row() { Level = 2, Angielski = "bag", Polski = "worek, torba, torebka", ZdanieAngielski = "Help me! Somebody stole my bag!", ZdaniePolski = "Pomóżcie mi! Ktoś ukradł moją torebkę!" });
            list.Add(new Row() { Level = 2, Angielski = "ball", Polski = "piłka, kłębek, kula", ZdanieAngielski = "Take your ball, we are going to the playground.", ZdaniePolski = "Weź piłkę, idziemy na boisko." });
            list.Add(new Row() { Level = 2, Angielski = "band", Polski = "zespół muzyczny, orkiestra", ZdanieAngielski = "I love music of this band!", ZdaniePolski = "Kocham muzykę tego zespołu!" });
            list.Add(new Row() { Level = 2, Angielski = "basin", Polski = "miednica, umywalka, misa", ZdanieAngielski = "My washing mashine is broken so I had to wash it in a basin.", ZdaniePolski = "Moja pralka jest zepsuta więc musiałem uprać to w misce." });
            list.Add(new Row() { Level = 2, Angielski = "recycle bin", Polski = "kosz", ZdanieAngielski = "Throw that rubbish to the basket.", ZdaniePolski = "Wrzuć te śmieci do kosza." });
            list.Add(new Row() { Level = 2, Angielski = "bath", Polski = "wanna, kąpiel", ZdanieAngielski = "I just wanna get bath and go sleep.", ZdaniePolski = "Chcę już tylko wziąć kąpiel i iść spać." });
            list.Add(new Row() { Level = 3, Angielski = "bed", Polski = "łóżko, grządka", ZdanieAngielski = "Exam in ten minutes?! I am still in my bed!", ZdaniePolski = "Egzamin za dziesięć minut? Ja wciąż jestem w łóżku!" });
            list.Add(new Row() { Level = 3, Angielski = "bee", Polski = "pszczoła", ZdanieAngielski = "I am really scared of bees.", ZdaniePolski = "Naprawdę boję się pszczół." });
            list.Add(new Row() { Level = 3, Angielski = "bell", Polski = "dzwonek, dzwon", ZdanieAngielski = "This bell traditionaly rings everyday at 3 pm.", ZdaniePolski = "Ten dzwon tradycyjnie dzwoni codziennie o piętnastej" });
            list.Add(new Row() { Level = 3, Angielski = "berry", Polski = "jagoda", ZdanieAngielski = "Are those berries good with ice creams?", ZdaniePolski = "Czy te jagody będą smaczne z lodami?" });
            list.Add(new Row() { Level = 3, Angielski = "bike", Polski = "rower", ZdanieAngielski = "Mommy I want a bike!", ZdaniePolski = "Mamo, ja chcę rower!" });
            list.Add(new Row() { Level = 3, Angielski = "bird", Polski = "ptak", ZdanieAngielski = "Everyday small bird sings next to my window.", ZdaniePolski = "Codziennie mały ptaszek śpiewa pod moim oknem." });
            list.Add(new Row() { Level = 3, Angielski = "blade", Polski = "ostrze", ZdanieAngielski = "Be carefull with this blade, it is really dangerous.", ZdaniePolski = "Bądź ostrożny z tym ostrzem, ono jest naprawdę niebezpieczne." });
            list.Add(new Row() { Level = 3, Angielski = "blood", Polski = "krew", ZdanieAngielski = "I had car accident, my shirt is all in blood.", ZdaniePolski = "Miałem wypadek samochodowy, cała moja koszula jest we krwi." });
            list.Add(new Row() { Level = 3, Angielski = "boat", Polski = "łódź, statek", ZdanieAngielski = "Get on my boat, we will fish.", ZdaniePolski = "Wskakuj na moją łódkę, będziemy łowić." });


            for (int i = 0; i < list.Count; i++)
            {
                Uri uri = new Uri("ms-appx:/Assets/Data/" + (i + 1) + ".png");
                list[i].Image = new BitmapImage(uri);
            }
        }

        public Row getRanodmRow()
        {
            return list[random.Next(list.Count)];
        }

        public Row getRanodmRow(int dificult)
        {
            Row row = null;

            do
            {
                row = list[random.Next(list.Count)];
            } while (row.Level != Data.PoziomNumer);

            return row;
        }
    }
}

#region Stare komentarze
//public List<Row> Data = new List<Row>()
        //{
        //    new Row(){
        //        Polish = "Słoń",
        //        English = "Elephant",
        //        Image = new BitmapImage(new Uri("1.png"))
        //    }
        //};

        //private Row lastRow = new Row();

        //public Row GetNewPair() {
        //    var result = new Row();
        //    bool isFirst = true;

        //    while (isFirst || result != lastRow )
        //    {
        //        if (isFirst)
        //        {
        //            isFirst = false;
        //        }
        //        result = Data[new Random().Next(Data.Count - 1)];
        //    }

        //    return result;            
        //}

//account			konto							Tom has opened his account today.								Tomek otworzył dzisiaj konto
//acid 			kwas							Caution! This is dangerous acid.								Ostrożnie! to niebezpieczny kwas			
//adjustment 		regulacja						Please adjust your radio, it is not playing well.				Proszę wyreguluj swoje radio, ono nie gra dobrze.
//advertisement 	reklama							I hate TV advertisements.										Nienawidzę reklam telewizyjnych	.			
//agreement 		umowa							I've signed this agreement yesterday.							Podpisałem tą umowę wczoraj.
//angle 			kąt								Draw this line with good angle please.							Proszę narysuj tę linię pod dobrym kątem.							
//ant 			mrówka							Oh no! There are ants in my sandwich!							O nie! W mojej kanapce są mrówki!		
//apple 			jabłko							How much costs four kilograms of apples?						Jak dużo kosztują cztery kilogramy jabłek? 		
//arch 			łuk								Look at him! He is a master of arch!							Spójrz na niego jak mistrzowsko włada łukiem!		
//argument 		spór							We had an argument last night, today I sleep on the couch...	Mieliśmy kłótnię wczoraj w nocy, dziś śpię na kanapie...
//arm 			ręka, ramię						Tom if you overbalance just give me your hand.					Tomek, jeśli stracisz równowagę po prostu podaj mi rękę.
//army 			wojsko, armia					My grandfather was in army.										Mój dziadek byuł w wojsku
//art 			sztuka							I am not very interested in art.								Nie jestem zbytnio zainteresowany sztuką											
//baby 			niemowlę						Tom and Ann have a baby.										Tomek i Ania mają dziecko.			
//back 			plecy							Look at his muscular back!										Spójrz na jego umięśnione plecy!			
//bag 			worek, torba, torebka			Help me! Somebody stole my bag!									Pomóżcie mi! Ktoś ukradł moją torebkę!
//ball 			piłka, kłębek, kula				Take your ball, we are going to the playground.					Weź piłkę, idziemy na boisko.			
//band 			zespół muzyczny, orkiestra		I love music of this band!										Kocham muzykę tego zespołu!
//basin 			miednica, umywalka, misa		My washing mashine is broken so I had to wash it in a basin.	Moja pralka jest zepsuta więc musiałem uprać to w misce.			
//recycle bin 		kosz							Throw that rubbish to the basket.								Wrzuć te śmieci do kosza.			
//bath 			wanna, kąpiel					I just wanna get bath and go sleep.								Chcę już tylko wziąć kąpiel i iść spać.				
//bed 			łóżko, grządka					Exam in ten minutes?! I am still in my bed!						Egzamin za dziesięć minut? Ja wciąż jestem w łóżku!
//bee 			pszczoła						I am really scared of bees.										Naprawdę boję się pszczół.
//bell 			dzwonek, dzwon					This bell traditionaly rings everyday at 3 pm.					Ten dzwon tradycyjnie dzwoni codziennie o piętnastej	
//berry 			jagoda							Are those berries good with ice creams?							Czy te jagody będą smaczne z lodami?
//bike 			rower							Mommy I want a bike!											Mamo, ja chcę rower!
//bird 			ptak							Everyday small bird sings next to my window.					Codziennie mały ptaszek śpiewa pod moim oknem.		
//blade 			ostrze							Be carefull with this blade, it is really dangerous.			Bądź ostrożny z tym ostrzem, ono jest naprawdę niebezpieczne.
//blood 			krew							I had car accident, my shirt is all in blood.					Miałem wypadek samochodowy, cała moja koszula jest we krwi.
//boat 			łódź, statek					Get on my boat, we will fish.									Wskakuj na moją łódkę, będziemy łowić.
#endregion Stare komentarze