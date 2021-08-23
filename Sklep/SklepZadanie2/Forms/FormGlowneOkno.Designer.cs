
namespace SklepZadanie2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPracownicy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPracownicy
            // 
            this.buttonPracownicy.Location = new System.Drawing.Point(12, 91);
            this.buttonPracownicy.Name = "buttonPracownicy";
            this.buttonPracownicy.Size = new System.Drawing.Size(146, 75);
            this.buttonPracownicy.TabIndex = 1;
            this.buttonPracownicy.Text = "Pracownicy";
            this.buttonPracownicy.UseVisualStyleBackColor = true;
            this.buttonPracownicy.Click += new System.EventHandler(this.buttonPracownicy_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 75);
            this.button2.TabIndex = 2;
            this.button2.Text = "Raporty";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonRaporty_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dni robocze";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDniRobocze_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(171, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 75);
            this.button4.TabIndex = 4;
            this.button4.Text = "Dni planowane";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonGrafikPracownika_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 184);
            this.Controls.Add(this.buttonPracownicy);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonPracownicy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

