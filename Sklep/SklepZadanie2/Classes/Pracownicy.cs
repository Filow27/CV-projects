using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SklepZadanie2.Classes
{
    public class Pracownicy
    {
        private string imie;
        private string naziwsko;
        private DateTime dataUrodzenia;
        private string adresZamieszkania;
        private string urzadSkarbowy;
        private DateTime dataRozpoczeciaPracy;
        private decimal stawkaGodzinowa;
        private string telefon;
        private decimal wynagrodzenie;
        public DzieńPlanowany dzieńPlanowany;
        public DzieńRoboczy dzieńRoboczy;

        public string Imie { get => imie; set => imie = value; }
        public string Naziwsko { get => naziwsko; set => naziwsko = value; }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }
        public string AdresZamieszkania { get => adresZamieszkania; set => adresZamieszkania = value; }
        public string UrzadSkarbowy { get => urzadSkarbowy; set => urzadSkarbowy = value; }
        public DateTime DataRozpoczeciaPracy { get => dataRozpoczeciaPracy; set => dataRozpoczeciaPracy = value; }
        public decimal StawkaGodzinowa { get => stawkaGodzinowa; set => stawkaGodzinowa = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public decimal Wynagrodzenie  { get => wynagrodzenie; set => wynagrodzenie = value; }

        public Pracownicy(string imie, string naziwsko, DateTime dataUrodzenia, string adresZamieszkania, string urzadSkarbowy, DateTime dataRozpoczeciaPracy, decimal stawkaGodzinowa, string telefon) //decimal wynagrodzenie)
        {
            this.imie = imie;
            this.naziwsko = naziwsko;
            this.dataUrodzenia = dataUrodzenia;
            this.adresZamieszkania = adresZamieszkania;
            this.urzadSkarbowy = urzadSkarbowy;
            this.dataRozpoczeciaPracy = dataRozpoczeciaPracy;
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.telefon = telefon;
            //this.wynagrodzenie = wynagrodzenie;
        }

        public Pracownicy()
        {
        }
        public override string ToString()
        {
            return this.imie+" "+this.naziwsko.ToString();
        }
        //public decimal Zarobek()
        //{
        //    if (dzieńPlanowany.PalnowaneGodziny == dzieńPlanowany.RoboczoGodziny)
        //    {
        //        wynagrodzenie = stawkaGodzinowa * dzieńPlanowany.RoboczoGodziny;
        //    }
        //    else if (dzieńPlanowany.RoboczoGodziny > dzieńPlanowany.PalnowaneGodziny)
        //    {

        //        wynagrodzenie = dzieńPlanowany.RoboczoGodziny + (Math.Abs(dzieńPlanowany.PalnowaneGodziny - dzieńPlanowany.RoboczoGodziny) * stawkaGodzinowa * 3);

        //    }
        //    else if (dzieńPlanowany.RoboczoGodziny < dzieńPlanowany.PalnowaneGodziny)
        //    {

        //        wynagrodzenie = dzieńPlanowany.RoboczoGodziny - (Math.Abs(dzieńPlanowany.PalnowaneGodziny - dzieńPlanowany.RoboczoGodziny) * stawkaGodzinowa * 3);

        //    }
        //    return wynagrodzenie;
        //}
    }
}
