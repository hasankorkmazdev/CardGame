using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame.ApplicationFiles
{
    class Game
    {
        List<Card> mainDeck = new List<Card>();
        Gamer gamer1;
        Gamer gamer2;

        public Game(Gamer gamer1, Gamer gamer2)
        {

            this.gamer1 = gamer1;
            this.gamer2 = gamer2;
            mainDeck = CreateDeck(20);
            ShuffleList(ref mainDeck);

        }

        internal List<Card> MainDeck { get { return mainDeck; } set => mainDeck = value; }
        /// <summary>
        /// Yeni Bir Kart Destesi Oluştur
        /// </summary>
        /// <param name="numberOfCard"> Destedeki ÇİFT KART Sayısı</param>
        /// <returns></returns>
        public List<Card> CreateDeck(int numberOfCard)
        {
           
            List<Card> NewDeck = new List<Card>();
            int counter = 0;
            for (int i = 0; i < numberOfCard * 2; i++)
            {
                if (i == numberOfCard)
                {
                    counter = 0;
                }
                NewDeck.Add(new Card() { Id = counter, Image = Application.StartupPath + "\\..\\..\\ApplicationData\\" + counter + ".jpg", Status = -1 });
                counter++;
            }
            return NewDeck;
        }
        /// <summary>
        /// Desteyi Karıştır
        /// </summary>
        /// <typeparam name="Card"></typeparam>
        /// <param name="inputList"></param>
        private void ShuffleList<Card>(ref List<Card> inputList)
        {
            List<Card> ShuffleList = new List<Card>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                ShuffleList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }
            inputList = ShuffleList;
        }
        public int CheckCard(Gamer gamer, int firstCard, int SecondCard)
        {
            //Oyun Devam Ediyor

            if (mainDeck.ToList().Where(x => x.Id == firstCard).FirstOrDefault().Id == mainDeck.ToList().Where(x => x.Id == SecondCard).LastOrDefault().Id)
            {
                gamer.Score += 10;
                mainDeck.RemoveAll(x => x.Id == firstCard);
                if (mainDeck.Count==0)
                {
                    return 0;
                }
                return 1;

            }
            else
            {
                gamer.Score -= 10;
                return -1;
            }
            


        }
        public string FindCardImage(int CardID)
        {
            return mainDeck.ToList().Where(x => x.Id == CardID).FirstOrDefault().Image;
        }
    }
}
