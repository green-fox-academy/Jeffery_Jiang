using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenFoxApp.Models;

namespace GreenFoxApp.Repo
{
    public interface IFoxRepository
    {
        List<Fox> FindAll();
        void Save();
        void Add(Fox fox);
        Fox Find(string name);
        void RecordAction(string action,string name);
        List<string> ReadAction(string name);

    }
}
