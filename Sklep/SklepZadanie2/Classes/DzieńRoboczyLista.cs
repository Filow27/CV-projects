using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SklepZadanie2.Classes
{
    public static class DzieńRoboczyLista

    {
        public static List<DzieńRoboczy> dniRobocze = new List<DzieńRoboczy>();
        public static void DodajDzieńRoboczy (DzieńRoboczy d)
        {
            dniRobocze.Add(d);
        }
        public static DzieńRoboczy GetDzieńRoboczy(int i)
        {
            return dniRobocze[i];
        }
        public static void usuńPlanowanyDzień(int i)
        {
            dniRobocze.RemoveAt(i);
        }
        public static int Count
        {
            get => dniRobocze.Count();
        }
        public static void setDzieńRoboczy(int i, DzieńRoboczy d)
        {
            dniRobocze[i] = d;
        }
        public static void Save()
        {
            XmlSerializer serializer = new XmlSerializer(dniRobocze.GetType());
            using (TextWriter filestream = new StreamWriter("Dni robocze.xml"))
            {
                serializer.Serialize(filestream, dniRobocze);
            }
        }
        public static void Load()
        {
            XmlSerializer deserialize = new XmlSerializer(dniRobocze.GetType());
            if (File.Exists("Dni robocze.xml"))
            {
                using (TextReader filestream = new StreamReader("Dni robocze.xml"))
                {
                    dniRobocze = (List<DzieńRoboczy>)deserialize.Deserialize(filestream);
                }
            }
        }

    }
}
