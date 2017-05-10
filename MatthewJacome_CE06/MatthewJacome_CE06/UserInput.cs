using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewJacome_CE06
{
    class UserInput
    {
       
        // Properties
        string mode;
        decimal miles;
        decimal hours;
        string direction;
        // Getters and setters
        public string Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }

        public decimal Miles
        {
            get
            {
                return miles;
            }

            set
            {
                miles = value;
            }
        }

        public decimal Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }

            set
            {
                direction = value;
            }
        }
    }
}
