using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicolo

{
    class Auto : Veicolo{
        public string Ptarga { get; set; }
        public string Carb { get; set; }


        public Auto(string brand, string model, int code, string ptarga, string carb)  
                       : base(brand, model, code){ 

            Ptarga = ptarga;
            Carb = carb;
        
        }
    }
}
