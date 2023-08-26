using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
namespace dogDoor.Classes
{
    public  class Remote
    {
        private DogDoor door { get; set; }

        public Remote(DogDoor door) {
            this.door = door;   
        }


        public void pressButton() {
            Console.WriteLine("Pressing the remote control button");
            if (door.isOpen())
            {
                door.close();
            }
            else {
                door.Open();
                Task task = Task.Run(() =>
                {
                    // demonstrate flexibility of anonymous methods
                    while (true)
                    {
                        
                    }
                }
                );
                if (task.Wait(TimeSpan.FromSeconds(5)))
                { }
                else {
                    door.close();
                }

                
            }
        }
    }
}
