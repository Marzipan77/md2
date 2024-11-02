using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace md2.Models { 
public interface IDataManager
{
    string Print();
    void Save(string filePath);
    void Load(string filePath);
    void CreateTestData();
    void Reset();
}
}