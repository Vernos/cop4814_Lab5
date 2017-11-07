using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab2
{
    public class GameFactory
    {
        public List<Game> GameList = new List<Game>();
        public string FilePath { get; set; }
        

        public GameFactory() { }


        public void CreateGameList()
        {
            for (int i = 1; i <= 10; i++)
            {
                Game SampleGame = new Game("Team:"+ ((char)(64+i)).ToString(),"Team:"+ ((char)(65 + i)).ToString(), i, 10-i );
                GameList.Add(SampleGame);
            }
        }

        public bool SerializeGameList()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer serial = new XmlSerializer(GameList.GetType());
            serial.Serialize(sw, GameList);
            sw.Close();

            return true;
        }

        public List<Game> DeserializeGameList()
        {
            List<Game> newList = new List<Game>();
            StreamReader sw = new StreamReader(FilePath);
            XmlSerializer serial = new XmlSerializer(newList.GetType());

            newList = (List<Game>)serial.Deserialize(sw);
            sw.Close();


            return newList;
        }

    }


}
