using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird:Animal
    {
        // Create a class Bird - DONE
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public bool Fly { get; set; }
        public int Wings { get; set; }
        public bool Feathers { get; set; }
        public int Eyes { get; set; }

    }
}
