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



            alternatePath();

            Task endApp = Task.Run(() => {
                while (!Remote.timerFinishedEvent) ;
                
            });

            endApp.Wait();


        }


        public static void mainPath() {


            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.pressButton();
            Console.WriteLine("\nFido has gone outside...");
            Console.WriteLine("\nFido’s all done...");
            Console.WriteLine("\nFido’s back inside...");
        }


        public static void alternatePath()
        {


            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);
            Console.WriteLine("Fido barks to go outside...");
            remote.pressButton();
            Console.WriteLine("\nFido has gone outside...");
            Thread.Sleep(10000);
            Console.WriteLine("Fido Stuck outside");
            Console.WriteLine("Fido start barking to go inside...");
            Console.WriteLine("So Gina grabs the remote Control");
            remote.pressButton();
            Console.WriteLine("\nFido’s back inside...");
        }
    }
}
