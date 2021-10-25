using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
   public class Author
    {
        public Author(string au_id, string au_lname, string au_fname, string phone, string address, string city, string state, string zip, bool contract)
        {
            Au_id = au_id;
            Au_lname = au_lname;
            Au_fname = au_fname;
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Contract = contract;
        }

        public string Au_id { get; set; }
        public string Au_lname { get; set; }
        public string Au_fname { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public bool Contract { get; set; }
    }
}
