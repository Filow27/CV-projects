using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZadanie2.Classes
{
    public class DzieńPlanowany
    {
        private DateTime data;
        private decimal palnowaneGodziny;
        private string pracownik;
        private decimal roboczoGodziny = 0;
        private Pracownicy praconik;

        public DzieńPlanowany(DateTime data, string pracownik,decimal palnowaneGodziny, decimal roboczoGodziny)
        {
            this.data = data;
            this.palnowaneGodziny = palnowaneGodziny;
            this.roboczoGodziny = roboczoGodziny;
            this.pracownik = pracownik;
        }

        public DateTime Data { get => data; set => data = value; }
        public decimal PalnowaneGodziny { get => palnowaneGodziny; set => palnowaneGodziny = value; }
        public decimal RoboczoGodziny { get => roboczoGodziny; set => roboczoGodziny = value; }
        public string Pracownik { get => pracownik; set => pracownik = value; }
        public Pracownicy Praconik { get => praconik; set => praconik = value; }

        public Pracownicy getPracownik()
        {
            return this.praconik;
        }
        public DzieńPlanowany()
        {

        }

       
    }
}
