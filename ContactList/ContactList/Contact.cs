using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList
{
    class Contact
    {
        public int ID { get; set; }
        public string First { get; set}
        public string Last { get; set; }
        public string Email { get; set; }

        public string URL { get; set; }

        public Contact()
        {
            ID = 0;
            First = string.Empty;
            Last = string.Empty;
            Email = string.Empty;
            URL = string.Empty;
             
        }


    }
}
