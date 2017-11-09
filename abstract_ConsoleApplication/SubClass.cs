using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace abstract_ConsoleApplication
{                   // C# kennt keine Mehrfachvererbung, deswegen nur eine Klasse, aber Interfaces, so viel ich mag
    class SubClass : ClassMaster
    {
        public SubClass()
        {
            WriteLine("Ich bin eine SubClass");
        }

        public override void melden()
        {
            WriteLine("Ich die SubClass, melde mich");
        }
    }
}
