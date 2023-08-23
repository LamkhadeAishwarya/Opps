using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
   public class Laptop
    {
        int noOfUSBPort;
        int processorSpeed;
             
        public int NumberOfUSB
        {
            set { noOfUSBPort = value; }
            get { return noOfUSBPort; }
        }
        public int ProcessorSpeed
        {
            set { processorSpeed = value; }
            get { return processorSpeed; }
        }
    }
}
