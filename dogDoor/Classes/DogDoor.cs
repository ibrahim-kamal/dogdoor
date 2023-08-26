using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogDoor.Classes
{
    public class DogDoor
    {
        private Boolean open;

        public DogDoor() { 
            this.open = false;  
        }

        public void Open() {
            Console.WriteLine("The dog door Opens");
            open = true;
        }

        public void close(){
            Console.WriteLine("The dog door Closes");
            open=false;
        }


        public Boolean isOpen() {
            return open; 
        }



    }
}
