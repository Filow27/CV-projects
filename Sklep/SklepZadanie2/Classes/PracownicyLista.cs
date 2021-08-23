using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SklepZadanie2.Classes
{
    public static class PracownicyLista
    {
        public static List<Pracownicy> pracownicy = new List<Pracownicy>();
        public static void DodajPracownika(Pracownicy p)
        {
            pracownicy.Add(p);
        }
        public static int Count
        {
            get => pracownicy.Count();
        }
        public static Pracownicy GetPracownik(int i)
        {
            return pracownicy[i];
        }
        public static void SetPracownik(int i, Pracownicy p)
        {
            pracownicy[i] = p;
        }
        public static void usuńPracownika(int i)
        {
            pracownicy.RemoveAt(i);
        }
        public static void Save()
        {
            XmlSerializer serializer = new XmlSerializer(pracownicy.GetType());
            using (TextWriter filestream = new StreamWriter("Pracownicy.xml"))
            {
                serializer.Serialize(filestream, pracownicy);
            }
        }
        public static void Load()
        {
            XmlSerializer deserialize = new XmlSerializer(pracownicy.GetType());
            if (File.Exists("Pracownicy.xml"))
            {
                using (TextReader filestream = new StreamReader("Pracownicy.xml"))
                {
                    pracownicy = (BList<Pracownicy>)deserialize.Deserialize(filestream);
                }
            }
        }

        
        //public static void ObliczWypłate()
        //{
        //    for (int i = 0; i < Count; i++)
        //    {
        //        decimal tmp = 0;
        //        for (int j = 0; j < DzieńPlanowanyLista.Count; j++)
        //        {
        //            if (DzieńPlanowanyLista.GetDzieńPlanowany(i).Data >= DateTime.Today.AddDays(-30).Date && Convert.ToInt32(DzieńPlanowanyLista.GetDzieńPlanowany(j).Data) < Convert.ToInt32(DateTime.Today.Date) && Convert.ToInt32(DzieńPlanowanyLista.GetDzieńPlanowany(j).Pracownik) == i)
        //            {
        //                tmp = (DzieńPlanowanyLista.GetDzieńPlanowany(j).RoboczoGodziny - DzieńPlanowanyLista.GetDzieńPlanowany(j).PalnowaneGodziny) * 3;
        //                tmp += DzieńPlanowanyLista.GetDzieńPlanowany(j).RoboczoGodziny;
        //                tmp *= pracownicy[i].StawkaGodzinowa;
        //            }
        //        }
        //        pracownicy[i].Wynagrodzenie = tmp;
        //    }
        //}

    }
}
