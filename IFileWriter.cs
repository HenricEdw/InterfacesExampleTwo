using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookInterfaceExample
{
    //Det finns många sätt för oss att spara saker till filer
    //vi låtsas att det är precis det vi försöker göra här
    interface IFileWriter
    {
        string Extension { get; }

        string WriteToFile(string fileName);
    }
}
