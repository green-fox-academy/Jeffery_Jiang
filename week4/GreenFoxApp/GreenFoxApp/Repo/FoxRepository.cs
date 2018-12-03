using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GreenFoxApp.Models;
using System.Text;

namespace GreenFoxApp.Repo
{
    public class FoxRepository:IFoxRepository
    {

        //private static readonly Fox fox1 = new Fox();
        private static readonly List<Fox> foxs = new List<Fox>();
        private  const string filePath = "TextFile.txt";
        //private static readonly List<string> actions= new List<string>();

        public List<Fox> FindAll()
        {
            foxs.Clear();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var contents = line.Split(";");
                List<string> trickList =new List<string>();
                for (int i = 2; i < contents.Length; i++)
                {
                    trickList.Add(contents[i]);
                }
                foxs.Add(new Fox()
                {
                    Foods = contents[0],
                    Name = contents[1],
                    Tricks = trickList                                           
                });

            }

            return foxs;
        }

        public void Save()
        {
            var lines= new List<string>();
            
            foreach (var fox in foxs)
            {
                string tricks = String.Join(";", fox.Tricks);
                lines.Add($"{fox.Foods};{fox.Name};{tricks}");
            }
           File.WriteAllLines(filePath,lines);

        }

        public void Add(Fox fox)
        {
            //foxs = FindAll();
            foxs.Add(fox);
        }


        public Fox Find(string name)
        {
            var _foxs = FindAll();
            foreach (var fox in _foxs)
            {
                if (fox.Name == name)
                {
                    return fox;
                }
            }

            return null;
        }

       
        public void RecordAction(string action,string name)
        {
            var fox = Find(name);
            if (fox.ActionRecord) == null)
            {
                fox.ActionRecord = new List<string>()
                {
                    "No record yet"
                };
            }
            else
            {
                fox.ActionRecord.Add(action);
            }
        }
    

        public List<string> ReadAction(string name)
        {
            var fox = Find(name);
            if (fox.ActionRecord == null)
            {
                fox.ActionRecord=new List<string>()
                {
                    "No record yet"
                };
            }

            return fox.ActionRecord;
        }
    }
}
