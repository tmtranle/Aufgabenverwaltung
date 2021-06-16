using System;
using System.Collections.Generic;
using System.Text;

namespace ReStartAufgabenverwaltung
{
    public class Aufgabe
    {
        public long Id { get; }
        public string Bezeichnung { get; set; }
        public DateTime Abgabedatum { get; set; }
        public string Mitarbeiter { get; set; }
        public int Erledigungsgrad { get; set; }

        public Aufgabe(long Id, string Bezeichnung, DateTime Abgabedatum, string Mitarbeiter, int Erledigungsgrad)
        {
            this.Id = Id;
            this.Bezeichnung = Bezeichnung;
            this.Abgabedatum = Abgabedatum;
            this.Mitarbeiter = Mitarbeiter;
            this.Erledigungsgrad = Erledigungsgrad;
        }

        public override string ToString()
        {
            return Bezeichnung + " bis zum " + Abgabedatum.ToShortDateString() + " von " + Mitarbeiter + " (" + Erledigungsgrad + ")";
        }
    }
}
