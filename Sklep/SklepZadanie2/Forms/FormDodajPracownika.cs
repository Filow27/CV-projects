using SklepZadanie2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepZadanie2.Forms
{
    public partial class FormDodajPracownika : Form
    {
        private Pracownicy pracownicy = null;
        public Pracownicy Pracownicy
        {
            get => pracownicy;
        }
        public void setData(Pracownicy w)
        {

            textBox1.Text = w.Imie;
            textBox2.Text = w.Naziwsko;
            textBox3.Text = w.AdresZamieszkania;
            textBox4.Text = w.UrzadSkarbowy;
            textBox5.Text = w.Telefon;
            dateTimePicker1.Value = w.DataUrodzenia;
            dateTimePicker2.Value = w.DataRozpoczeciaPracy;
            numericUpDown1.Value = w.StawkaGodzinowa;
            this.Name = "Edycja danych pracowników";


        }

        public FormDodajPracownika()
        {
            InitializeComponent();
        }

        private void FormDodajPracownika_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) && String.IsNullOrWhiteSpace(textBox3.Text) &&  String.IsNullOrWhiteSpace(textBox4.Text)&&  numericUpDown1.Value ==0 && String.IsNullOrWhiteSpace(textBox5.Text)) 
                MessageBox.Show("Uzupełnij dane!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                PracownicyLista.pracownicy.Add(new Pracownicy(textBox1.Text,textBox2.Text,dateTimePicker1.Value,textBox3.Text, textBox4.Text,dateTimePicker2.Value,numericUpDown1.Value,textBox5.Text));
                this.Close();
            }

        }
    }
}
