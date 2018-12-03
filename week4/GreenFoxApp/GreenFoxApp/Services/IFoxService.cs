using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFoxApp.Models;

namespace GreenFoxApp.Services
{
   public interface IFoxService
    {
        Fox FindFox(string name);
        List<Fox> FindAll();

        void Add(Fox newFox);
        void ChangeFood(string name,string food);
        void ChangeTrick(string name, string trick);
        void UnlearnTrick(string name, string trick);
        //void AddAction(string name, string action);
        List<string> ReadAction(string name);
        void RecordAction(string action,string name);
    }
}
