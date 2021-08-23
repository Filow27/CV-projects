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
    public partial class FormZaplanowaneDni : Form
    {
        public FormZaplanowaneDni()
        {
            InitializeComponent();
            odswieżTabele();
        }

        private void FormZaplanowaneDni_Load(object sender, EventArgs e)
        {  foreach (Pracownicy p in PracownicyLista.pracownicy)
                comboBox1.Items.Add(p);
           
        }
        
        
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DzieńPlanowanyLista.dniPlanowane.Add(new DzieńPlanowany(dateTimePicker1.Value.Date, comboBox1.SelectedItem.ToString(), numericUpDown1.Value, numericUpDown2.Value)) ;

            odswieżTabele();

        }
        private void odswieżTabele()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < DzieńPlanowanyLista.Count; i++)
            {
                DzieńPlanowany p = DzieńPlanowanyLista.GetDzieńPlanowany(i);
                int r = dataGridView1.Rows.Add(p.Data,p.Pracownik,p.PalnowaneGodziny,p.RoboczoGodziny);
                dataGridView1.Rows[r].Tag = i;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //decimal godziny = 0m;
            //if(DzieńPlanowany
            //{
            //    hours = 
            //}
        }

        private void labelGodzinyDoWykonania_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
                DzieńPlanowanyLista.usuńPlanowanyDzień(Math.Abs(row.Index) - 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
           
        }
    }
}
