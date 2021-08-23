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
    public partial class FormRaporty : Form
    {
        public FormRaporty()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder(); 
        StringBuilder z = new StringBuilder();
        decimal godzinyRobocze = 0;
        
        private void FormRaporty_Load(object sender, EventArgs e)
        {
            sb.Clear();
            foreach (Pracownicy p in PracownicyLista.pracownicy)
                comboBoxPracownik.Items.Add(p);
            foreach(DzieńRoboczy r in DzieńRoboczyLista.dniRobocze)
            {
                if (r.RoboczoGodziny == 1)
                {
                    sb.AppendLine(r.Data.ToString("dd -MM-yyyy") + " | \t" + r.RoboczoGodziny + "  roboczogodzina");
                    
                }
                else if (r.RoboczoGodziny >= 2 && r.RoboczoGodziny <= 4)
                {
                    sb.AppendLine(r.Data.ToString("dd-MM-yyyy") + " | \t" + r.RoboczoGodziny + "  roboczogodziny");
                     
                }
                else
                {
                    sb.AppendLine(r.Data.ToString("dd-MM-yyyy") + " | \t" + r.RoboczoGodziny + "  roboczogodzin");
                    
                }
                godzinyRobocze += r.RoboczoGodziny;

            }
            textBoxDniRobocze.Text = sb.ToString();
            labelGodzinyRobocze.Text = "Godziny robocze: " + godzinyRobocze.ToString();

            decimal godzinyZaplanowane=0, godzinyPrzepracowane = 0;
            foreach (DzieńPlanowany dp in DzieńPlanowanyLista.dniPlanowane)
            {
                if (dp.PalnowaneGodziny == 1)
                {
                    sb.AppendLine(dp.Data.ToString("dd-MM-yyyy") + " | \t" + dp.PalnowaneGodziny + "  roboczogodzina" + " | " + dp.Pracownik.ToString());
             
                }
                else if (dp.PalnowaneGodziny >= 2 && dp.PalnowaneGodziny <= 4)
                {
                    sb.AppendLine(dp.Data.ToString("dd-MM-yyyy") + " | \t" + dp.PalnowaneGodziny + "  roboczogodziny" + " | " + dp.Pracownik.ToString());
                   
                }
                else
                {
                    sb.AppendLine(dp.Data.ToString("dd-MM-yyyy") + " | \t" + dp.PalnowaneGodziny + "  roboczogodzin" + " | " + dp.Pracownik.ToString());
                    
                }
                godzinyZaplanowane += dp.PalnowaneGodziny;
                godzinyPrzepracowane += dp.RoboczoGodziny;
            }

            textBoxDniZaplanowane.Text = sb.ToString();
            labelGodzinyZaplanowane.Text = "Godzin zaplanowanych: " + godzinyZaplanowane.ToString();
            labelGodzinyPrzepracowane.Text = "Godzin przepracowanych: " + godzinyPrzepracowane.ToString();

            decimal roznicaGodzin = godzinyPrzepracowane - godzinyZaplanowane;
            labelRoznicaGodzin.Text = "Różnica godzin: " + roznicaGodzin.ToString();

            if (roznicaGodzin == 0)
            {
                textBoxRaport.Text = "Godziny poprawnie zaplanowane.";
            }
            else if (roznicaGodzin > 0)
            {
                textBoxRaport.Text = "Za mało zaplanowanych godzin";
            }
            else if (roznicaGodzin < 0)
            {
                textBoxRaport.Text = "Za dużo zaplanowanych godzin";
            }

            

        }

        private void labelGodzinyRobocze_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPracownik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            z.Clear();
          
            decimal godzinyZaplanowane = 0;
            decimal godzinyPrzepracowane = 0;
            decimal naleznoscZaplanowana = 0m;decimal naleznoscFaktyczna = 0;
            
            foreach (DzieńPlanowany dp in DzieńPlanowanyLista.dniPlanowane)
            {
                if (dp.Pracownik == comboBoxPracownik.SelectedItem.ToString())
                {
                    z.AppendLine(dp.Data.ToString("dd-MM-yyyy") + " | " + dp.RoboczoGodziny + "/" + dp.PalnowaneGodziny + " godz." ) ;

                    godzinyPrzepracowane += dp.RoboczoGodziny;
                    naleznoscFaktyczna += dp.RoboczoGodziny;
                    godzinyZaplanowane += dp.PalnowaneGodziny;
                    naleznoscZaplanowana += dp.PalnowaneGodziny;
                }
            }
            decimal roznicaGodzinowa = godzinyZaplanowane - godzinyPrzepracowane;
            foreach (Pracownicy p in PracownicyLista.pracownicy)
            {    if (p.Imie +" "+ p.Naziwsko == comboBoxPracownik.SelectedItem.ToString())
                {
                    if (godzinyPrzepracowane == godzinyZaplanowane)
                    {
                        naleznoscZaplanowana = naleznoscZaplanowana * p.StawkaGodzinowa;
                         naleznoscFaktyczna = naleznoscFaktyczna * p.StawkaGodzinowa;

                        textBoxRaport.Text = "Godziny poprawnie zaplanowane.";
                        labelNaleznoscFaktyczna.Text = "Faktyczna należność: " + naleznoscFaktyczna *p.StawkaGodzinowa + " zł";
                    }
                    else if (godzinyPrzepracowane > godzinyZaplanowane)
                    {
                        naleznoscZaplanowana = naleznoscZaplanowana * p.StawkaGodzinowa;
                        naleznoscFaktyczna = naleznoscFaktyczna * p.StawkaGodzinowa;
                        textBoxRaport.Text = "Pracownik pracuje za dużo. Zmniejsz liczbę godzin lub zwiększ należność za nadgodziny.";
                        labelNaleznoscFaktyczna.Text = "Faktyczna należność: " + (naleznoscZaplanowana + ((Math.Abs(roznicaGodzinowa) * p.StawkaGodzinowa * 3))).ToString() + "zł";

                    }
                    else if (godzinyPrzepracowane < godzinyZaplanowane)
                    {
                        naleznoscFaktyczna = naleznoscFaktyczna * p.StawkaGodzinowa;
                        naleznoscZaplanowana = naleznoscZaplanowana * p.StawkaGodzinowa;
                        textBoxRaport.Text = "Pracownik pracuje za mało. Zwiększ liczbę godzin, lub zmniejsz należność z wypłaty.";
                        labelNaleznoscFaktyczna.Text = "Faktyczna należność: " + (naleznoscZaplanowana - (Math.Abs(roznicaGodzinowa) * p.StawkaGodzinowa * 3)).ToString() + "zł";

                    }
                }
                



                textBox2.Text = z.ToString();
                label6.Text = "Godziny zaplanowane: " + godzinyZaplanowane.ToString();
                labelNaleznoscZaplanowana.Text = "Oczekiwana należność: " + naleznoscZaplanowana.ToString() + "zł";
                //labelNaleznoscFaktyczna.Text = "Faktyczna należność: " + naleznoscFaktyczna.ToString() + "zł";
                label5.Text = "Godziny przepracowane: " + godzinyPrzepracowane.ToString();

            }   
        }

        private void labelGodzinyZaplanowane_Click(object sender, EventArgs e)
        {

        }
    }
}
