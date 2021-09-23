using System;
using System.Collections.Generic;
using System.Text;

namespace Adressbok
{
    public class Person
    { 
        public string Namn { get; set; }
        public string Gatuadress { get; set; }
        public string Postnummer { get; set; }
        public string Postort { get; set; }
        public string Telefon { get; set; }
        public string Epost { get; set; }


        public Person(string namn = "", string gatuadress = "", string postnummer ="", 
            string postort ="", string telefon ="", string epost ="")
        {
            this.Namn = namn;
            this.Gatuadress = gatuadress;
            this.Postnummer = postnummer;
            this.Postort = postort;
            this.Telefon = telefon;
            this.Epost = epost;
        }

        //Metoden override:ar till stängvärde
        public override string ToString()
        {
            string nyKontakt = Namn + " " + Gatuadress + " " + Postnummer + " " + Postort + " " + Telefon + " " + Epost +
                Environment.NewLine;
            return nyKontakt;
        }
    }
}