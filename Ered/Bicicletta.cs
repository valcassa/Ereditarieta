using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicolo
{
    class Bicicletta : Veicolo {

        public bool Electric { get; set; }


        public Bicicletta(int code, string brand, string model, bool electric)  
            : base(brand, model, code){
            Electric = electric;
        }
    }
    }
    
    

