using dogDoor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogDoor
{
    public class dogDoor
    {
        public static void Main() {





            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.pressButton();
            Console.WriteLine("\nFido has gone outside...");
            remote.pressButton();
            Console.WriteLine("\nFido’s all done...");
            remote.pressButton();
            Console.WriteLine("\nFido’s back inside...");
            remote.pressButton();
        }
    }
}
