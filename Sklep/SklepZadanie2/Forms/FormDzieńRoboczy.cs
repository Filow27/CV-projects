using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SklepZadanie2.Classes;

namespace SklepZadanie2.Forms
{
    public partial class FormDzieńRoboczy : Form
    {
        public FormDzieńRoboczy()
        {
            InitializeComponent();
            odswieżTabele();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DzieńRoboczyLista.dniRobocze.Add(new DzieńRoboczy(dateTimePicker1.Value.Date, numericUpDown1.Value));
            odswieżTabele();
        }
        private void odswieżTabele()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < DzieńRoboczyLista.Count; i++)
            {
                DzieńRoboczy p = DzieńRoboczyLista.GetDzieńRoboczy(i);
                int r = dataGridView1.Rows.Add(p.Data,p.RoboczoGodziny);
                dataGridView1.Rows[r].Tag = i;

            }
        }

        private void FormDzieńRoboczy_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //PracownicyLista.ObliczWypłate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
                DzieńRoboczyLista.usuńPlanowanyDzień(Math.Abs(row.Index) - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
