using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SklepZadanie2.Classes
{
    public static class DzieńPlanowanyLista
    {
        public static List<DzieńPlanowany> dniPlanowane = new List<DzieńPlanowany>();
        public static void DodajDzieńPlanowany(DzieńPlanowany d)
        {
            dniPlanowane.Add(d);
        }
        public static DzieńPlanowany GetDzieńPlanowany(int i)
        {
            return dniPlanowane[i];
        }
        public static int Count
        {
            get => dniPlanowane.Count();
        }
        public static void setDzieńPlanowany(int i,DzieńPlanowany d )
        {
            dniPlanowane[i] = d;
        }
        public static void usuńPlanowanyDzień(int i)
        {
            dniPlanowane.RemoveAt(i);
        }
        public static void Save()
        {
            XmlSerializer serializer = new XmlSerializer(dniPlanowane.GetType());
            using (TextWriter filestream = new StreamWriter("Dni planowane.xml"))
            {
                serializer.Serialize(filestream, dniPlanowane);
            }
        }
        public static void Load()
        {
            XmlSerializer deserialize = new XmlSerializer(dniPlanowane.GetType());
            if (File.Exists("Dni planowane.xml"))
            {
                using (TextReader filestream = new StreamReader("Dni planowane.xml"))
                {
                    dniPlanowane = (List<DzieńPlanowany>)deserialize.Deserialize(filestream);
                }
            }
        }

    }
}
