using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace abstract_ConsoleApplication
{
    abstract class ClassMaster
    {
        public int zahl;
        public void hallo()
        {
            WriteLine("hello world");
        }
        public abstract void melden();
        
    }
}
