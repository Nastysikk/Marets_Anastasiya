using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Character
    {
        String typeofcharacter = "Unknown character";
        String name = "Unknown";
        int power = 1;
        public String Typeofcharacter
        {
            set { typeofcharacter = value; }
        }
        public String Name
        {
            set { name = value; }
        }
        public virtual String GetTypeofcharacter()
        {
            return typeofcharacter;
        }
        public virtual String GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return "Тип персонажа - " + GetTypeofcharacter() + Environment.NewLine + "Ім'я -" + GetName();
        }
    }
}
}
