using System; 

namespace Veicolo
{
   

    class Veicolo{ 
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Code { get; set; }
            // Creare una classe Veicolo con le seguenti proprietà(brand, modello, codice)
            // e poi le seguenti classi derivate Automobile(con proprietà targa e carburante)
            // e bicicletta(con proprietà Elettrica/Non Elettrica).
         public Veicolo(string brand, string model, int code){   
            Brand = brand;
            Model = model;
            Code = code;

        
        }
    }
}
