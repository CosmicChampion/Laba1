using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ShopVM
    {
        public ShopVM(string new_name, int new_id, string new_street, int new_num) 
        { 
            this.Name = new_name; this.Id = new_id; address = new AddressVM(new_street, new_num); 
        }

        public string Name { get; set; }
        public int Id { get; set; }

        public AddressVM address;
    }
}
