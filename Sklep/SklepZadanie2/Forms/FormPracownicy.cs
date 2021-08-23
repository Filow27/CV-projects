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
    public partial class FormPracownicy : Form
    {

        public FormPracownicy()
        {
            InitializeComponent();
            odswieżTabele();

        }

        private void FormPracownicy_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodajPracownika_Click(object sender, EventArgs e)
        {
            FormDodajPracownika formDodajPracownika = new FormDodajPracownika();
            this.Hide();
            formDodajPracownika.ShowDialog();
            this.Show();
            odswieżTabele();
        }
        private void odswieżTabele()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < PracownicyLista.Count; i++)
            {
                Pracownicy p = PracownicyLista.GetPracownik(i);
                int r = dataGridView1.Rows.Add(p.Imie, p.Naziwsko, p.DataUrodzenia, p.AdresZamieszkania, p.UrzadSkarbowy, p.DataRozpoczeciaPracy, p.StawkaGodzinowa, p.Telefon);
                dataGridView1.Rows[r].Tag = i;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                    throw new Exception("Nie wybrano pracownika", "Uwaga!",);
                FormDodajPracownika formDodajPracownika = new FormDodajPracownika();
                formDodajPracownika.setData(PracownicyLista.GetPracownik((int)dataGridView1.SelectedRows[0].Tag));
                formDodajPracownika.ShowDialog();
                if (formDodajPracownika.Pracownicy != null)
                {
                    PracownicyLista.SetPracownik((int)dataGridView1.SelectedRows[0].Tag, formDodajPracownika.Pracownicy);
                    odswieżTabele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        pr  ivate void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
                PracownicyLista.usuńPracownika(Math.Abs(row.Index)-1);
            }
        }
    }
}
