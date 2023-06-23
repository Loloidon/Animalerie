using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Crude;
namespace Crude
{
   
        public struct Dog {
            public string name;
            public int age;
            public DogRace Race;

            public Dog(string name, int age, DogRace race)
            {
                this.name = name;
                this.age = age;
                Race = race;
            }
        public override string ToString()
        {
            return $"_______________________________\n" +
                   $"Name : {name}\n" +
                   $"Age : {age}\n" +
                   $"Race : {Race}\n" +
               
                   $"_______________________________\n";
        }
    }


 

        public enum DogRace {
        Bordercollie,
        Dalmatien,
        Tekkel,
        Chihuaha,
    }

    }

