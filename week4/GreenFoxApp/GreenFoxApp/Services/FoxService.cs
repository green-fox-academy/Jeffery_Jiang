using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFoxApp.Models;
using GreenFoxApp.Repo;
using GreenFoxApp.Services;

namespace GreenFoxApp.Servers
{
    public class FoxService:IFoxService
    {
        private readonly IFoxRepository foxRepository;
        public FoxService(IFoxRepository foxRepository)
        {
            this.foxRepository = foxRepository;
        }
        public Fox FindFox(string name)
        {
            return foxRepository.Find(name);
        }

        public List<Fox> FindAll()
        {
            return foxRepository.FindAll();
        }

        public void Add(Fox newFox)
        {
            foxRepository.Add(newFox);
            foxRepository.Save();
        }

        public void ChangeFood(string name,string food)
        {
            var fox = foxRepository.Find(name);
            fox.Foods = food;
            foxRepository.Save();
        }

        public void ChangeTrick(string name, string trick)
        {
            var fox = foxRepository.Find(name);
            fox.Tricks.Add(trick);
            foxRepository.Save();
        }

        public void UnlearnTrick(string name, string trick)
        {
            var fox = foxRepository.Find(name);
            fox.Tricks.Remove(trick);
            foxRepository.Save();
            
        }

       

        public List<string> ReadAction(string name)
        {

            return foxRepository.ReadAction(name);
        }

        public void RecordAction(string action,string name)
        {
            foxRepository.RecordAction(action,name);
        }
    }
}
