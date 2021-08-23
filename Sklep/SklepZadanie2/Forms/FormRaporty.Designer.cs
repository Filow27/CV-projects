
namespace SklepZadanie2.Forms
{
    partial class FormRaporty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGodzinyRobocze = new System.Windows.Forms.Label();
            this.labelGodzinyZaplanowane = new System.Windows.Forms.Label();
            this.labelGodzinyPrzepracowane = new System.Windows.Forms.Label();
            this.textBoxRaport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRoznicaGodzin = new System.Windows.Forms.Label();
            this.textBoxDniZaplanowane = new System.Windows.Forms.TextBox();
            this.textBoxDniRobocze = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxPracownik = new System.Windows.Forms.ComboBox();
            this.labelNaleznoscFaktyczna = new System.Windows.Forms.Label();
            this.labelNaleznoscZaplanowana = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dni robocze";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dni zaplanowane";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGodzinyRobocze);
            this.groupBox1.Controls.Add(this.labelGodzinyZaplanowane);
            this.groupBox1.Controls.Add(this.labelGodzinyPrzepracowane);
            this.groupBox1.Location = new System.Drawing.Point(629, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statystyki";
            // 
            // labelGodzinyRobocze
            // 
            this.labelGodzinyRobocze.AutoSize = true;
            this.labelGodzinyRobocze.Location = new System.Drawing.Point(42, 25);
            this.labelGodzinyRobocze.Name = "labelGodzinyRobocze";
            this.labelGodzinyRobocze.Size = new System.Drawing.Size(95, 13);
            this.labelGodzinyRobocze.TabIndex = 5;
            this.labelGodzinyRobocze.Text = "Godzin roboczych:";
            this.labelGodzinyRobocze.Click += new System.EventHandler(this.labelGodzinyRobocze_Click);
            // 
            // labelGodzinyZaplanowane
            // 
            this.labelGodzinyZaplanowane.AutoSize = true;
            this.labelGodzinyZaplanowane.Location = new System.Drawing.Point(17, 50);
            this.labelGodzinyZaplanowane.Name = "labelGodzinyZaplanowane";
            this.labelGodzinyZaplanowane.Size = new System.Drawing.Size(120, 13);
            this.labelGodzinyZaplanowane.TabIndex = 6;
            this.labelGodzinyZaplanowane.Text = "Godzin zaplanowanych:";
            this.labelGodzinyZaplanowane.Click += new System.EventHandler(this.labelGodzinyZaplanowane_Click);
            // 
            // labelGodzinyPrzepracowane
            // 
            this.labelGodzinyPrzepracowane.AutoSize = true;
            this.labelGodzinyPrzepracowane.Location = new System.Drawing.Point(7, 75);
            this.labelGodzinyPrzepracowane.Name = "labelGodzinyPrzepracowane";
            this.labelGodzinyPrzepracowane.Size = new System.Drawing.Size(130, 13);
            this.labelGodzinyPrzepracowane.TabIndex = 7;
            this.labelGodzinyPrzepracowane.Text = "Godzin przepracowanych:";
            // 
            // textBoxRaport
            // 
            this.textBoxRaport.Enabled = false;
            this.textBoxRaport.Location = new System.Drawing.Point(629, 221);
            this.textBoxRaport.Multiline = true;
            this.textBoxRaport.Name = "textBoxRaport";
            this.textBoxRaport.Size = new System.Drawing.Size(188, 50);
            this.textBoxRaport.TabIndex = 18;
            this.textBoxRaport.Text = "Dni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Raport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "(porównanie roboczych z zaplanowanymi)";
            // 
            // labelRoznicaGodzin
            // 
            this.labelRoznicaGodzin.AutoSize = true;
            this.labelRoznicaGodzin.Location = new System.Drawing.Point(683, 154);
            this.labelRoznicaGodzin.Name = "labelRoznicaGodzin";
            this.labelRoznicaGodzin.Size = new System.Drawing.Size(83, 13);
            this.labelRoznicaGodzin.TabIndex = 15;
            this.labelRoznicaGodzin.Text = "Różnica godzin:";
            // 
            // textBoxDniZaplanowane
            // 
            this.textBoxDniZaplanowane.Enabled = false;
            this.textBoxDniZaplanowane.Location = new System.Drawing.Point(319, 60);
            this.textBoxDniZaplanowane.Multiline = true;
            this.textBoxDniZaplanowane.Name = "textBoxDniZaplanowane";
            this.textBoxDniZaplanowane.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDniZaplanowane.Size = new System.Drawing.Size(304, 349);
            this.textBoxDniZaplanowane.TabIndex = 19;
            this.textBoxDniZaplanowane.WordWrap = false;
            // 
            // textBoxDniRobocze
            // 
            this.textBoxDniRobocze.Location = new System.Drawing.Point(12, 60);
            this.textBoxDniRobocze.Multiline = true;
            this.textBoxDniRobocze.Name = "textBoxDniRobocze";
            this.textBoxDniRobocze.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDniRobocze.Size = new System.Drawing.Size(301, 349);
            this.textBoxDniRobocze.TabIndex = 20;
            this.textBoxDniRobocze.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1040, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Godziny przepracowane: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1043, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Godziny zaplanowane: ";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(843, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(191, 393);
            this.textBox2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pracownik:";
            // 
            // comboBoxPracownik
            // 
            this.comboBoxPracownik.FormattingEnabled = true;
            this.comboBoxPracownik.Location = new System.Drawing.Point(906, 7);
            this.comboBoxPracownik.Name = "comboBoxPracownik";
            this.comboBoxPracownik.Size = new System.Drawing.Size(188, 21);
            this.comboBoxPracownik.TabIndex = 21;
            this.comboBoxPracownik.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPracownik_SelectionChangeCommitted);
            // 
            // labelNaleznoscFaktyczna
            // 
            this.labelNaleznoscFaktyczna.AutoSize = true;
            this.labelNaleznoscFaktyczna.Location = new System.Drawing.Point(1043, 110);
            this.labelNaleznoscFaktyczna.Name = "labelNaleznoscFaktyczna";
            this.labelNaleznoscFaktyczna.Size = new System.Drawing.Size(110, 13);
            this.labelNaleznoscFaktyczna.TabIndex = 28;
            this.labelNaleznoscFaktyczna.Text = "Faktyczna należność:";
            // 
            // labelNaleznoscZaplanowana
            // 
            this.labelNaleznoscZaplanowana.AutoSize = true;
            this.labelNaleznoscZaplanowana.Location = new System.Drawing.Point(1040, 87);
            this.labelNaleznoscZaplanowana.Name = "labelNaleznoscZaplanowana";
            this.labelNaleznoscZaplanowana.Size = new System.Drawing.Size(120, 13);
            this.labelNaleznoscZaplanowana.TabIndex = 29;
            this.labelNaleznoscZaplanowana.Text = "Oczekiwana należność:";
            // 
            // FormRaporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 454);
            this.Controls.Add(this.labelNaleznoscZaplanowana);
            this.Controls.Add(this.labelNaleznoscFaktyczna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxPracownik);
            this.Controls.Add(this.textBoxDniRobocze);
            this.Controls.Add(this.textBoxDniZaplanowane);
            this.Controls.Add(this.textBoxRaport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRoznicaGodzin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRaporty";
            this.Text = "FormRaporty";
            this.Load += new System.EventHandler(this.FormRaporty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelGodzinyRobocze;
        private System.Windows.Forms.Label labelGodzinyZaplanowane;
        private System.Windows.Forms.Label labelGodzinyPrzepracowane;
        private System.Windows.Forms.TextBox textBoxRaport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRoznicaGodzin;
        private System.Windows.Forms.TextBox textBoxDniZaplanowane;
        private System.Windows.Forms.TextBox textBoxDniRobocze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxPracownik;
        private System.Windows.Forms.Label labelNaleznoscFaktyczna;
        private System.Windows.Forms.Label labelNaleznoscZaplanowana;
    }
}