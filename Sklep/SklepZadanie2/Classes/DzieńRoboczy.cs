using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZadanie2.Classes
{
    public class DzieńRoboczy
    {
        private DateTime data;
        private decimal roboczoGodziny = 0;

        public DzieńRoboczy(DateTime data, decimal roboczoGodziny)
        {
            this.data = data;
            this.roboczoGodziny = roboczoGodziny;
        }

        public DateTime Data { get => data; set => data = value; }
        public decimal RoboczoGodziny { get => roboczoGodziny; set => roboczoGodziny = value; }
        public DzieńRoboczy()
        {

        }
        public override string ToString()
        {
            return this.data.ToString();

        }
    }
}
