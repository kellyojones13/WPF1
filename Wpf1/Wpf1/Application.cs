using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf1
{
    class Form
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int ZipCode { get; set; }

        public Form()

        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public Form(string Name, string Address, int zipCode)
        {
        }

    }

    
}
