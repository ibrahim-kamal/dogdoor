using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
namespace dogDoor.Classes
{
    public  class Remote
    {
        public static System.Timers.Timer _timer;
        public static bool timerFinishedEvent = false;

        private DogDoor door { get; set; }

        public Remote(DogDoor door) {
            this.door = door;
            _timer = new System.Timers.Timer();
    }


        public void pressButton() {
            Console.WriteLine("Pressing the remote control button");
            if (door.isOpen())
            {
                door.close();
            }
            else {
                door.Open();
                _timer.Interval = 5000; // Set the interval in milliseconds
                _timer.Elapsed += new System.Timers.ElapsedEventHandler(closeDoor);
                _timer.Enabled = true; // Enable the timer
                _timer.Start();



            }

            
        }

        private void closeDoor(object? sender, System.Timers.ElapsedEventArgs e) {
            _timer.Stop();
            door.close();
            timerFinishedEvent = true;

        }
    }
}
