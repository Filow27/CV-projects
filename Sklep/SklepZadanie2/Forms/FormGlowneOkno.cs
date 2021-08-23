using SklepZadanie2.Forms;
using System;
using System.Windows.Forms;
using SklepZadanie2.Classes;

namespace SklepZadanie2
{

    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
            try
            {
               Wczytaj();
            }
            catch
            {
                MessageBox.Show("Wystąpił Problem z wczytywaniem danych! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Zapisz();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void odswiezTabele()
        //{
        //    dataGridView1.Rows.Clear();
        //    for (int i = 0; i< PracownicyLista.Count;i++)
        //    {
        //        dataGridView1.Rows.Add(PracownicyLista.GetPracownik(i).Imie);
        //    }
        //}

        private void buttonPracownicy_Click(object sender, EventArgs e)
        {
            FormPracownicy formPracownicy = new FormPracownicy();
            this.Hide();
            formPracownicy.ShowDialog();
            this.Show();
            Zapisz();
        }

        private void buttonRaporty_Click(object sender, EventArgs e)
        {
            FormRaporty formRaporty = new FormRaporty();
            this.Hide();
            formRaporty.ShowDialog();
            this.Show();
            Zapisz();
        }

        private void buttonDniRobocze_Click(object sender, EventArgs e)
        {
            FormDzieńRoboczy formDzieńRoboczy = new FormDzieńRoboczy();
            this.Hide();
            formDzieńRoboczy.ShowDialog();
            this.Show();
            Zapisz();
        }

        private void buttonGrafikPracownika_Click(object sender, EventArgs e)
        {
            FormZaplanowaneDni formZaplanowaneDni = new FormZaplanowaneDni();
            this.Hide();
            formZaplanowaneDni.ShowDialog();
            this.Show();
            Zapisz();
        }
        private void Zapisz()
        {
            PracownicyLista.Save();
            DzieńPlanowanyLista.Save();
            DzieńRoboczyLista.Save();
            //odswiezTabele();
        }
        private void Wczytaj()
        {
            PracownicyLista.Load();
            DzieńPlanowanyLista.Load();
            DzieńRoboczyLista.Load();
            //odswiezTabele();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
