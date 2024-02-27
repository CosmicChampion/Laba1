using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class AddressVM
    {

        public AddressVM(string new_adres, int new_num) { this.Street = new_adres; this.Number = new_num; }

        public string Street {  get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return this.Street + " " + this.Number;
        }

    }
}
