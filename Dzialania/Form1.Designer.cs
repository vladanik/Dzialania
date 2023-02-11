namespace Dzialania
{
    partial class Form1
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
            this.tbPierwsza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDruga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lWynik = new System.Windows.Forms.Label();
            this.rbDodaj = new System.Windows.Forms.RadioButton();
            this.rbOdejmij = new System.Windows.Forms.RadioButton();
            this.rbPomnoz = new System.Windows.Forms.RadioButton();
            this.rbPodziel = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.btnZakoncz = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPierwsza
            // 
            this.tbPierwsza.Location = new System.Drawing.Point(82, 55);
            this.tbPierwsza.Name = "tbPierwsza";
            this.tbPierwsza.Size = new System.Drawing.Size(100, 20);
            this.tbPierwsza.TabIndex = 0;
            this.tbPierwsza.UseWaitCursor = true;
            this.tbPierwsza.TextChanged += new System.EventHandler(this.liczWszystko);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbDruga
            // 
            this.tbDruga.Location = new System.Drawing.Point(82, 82);
            this.tbDruga.Name = "tbDruga";
            this.tbDruga.Size = new System.Drawing.Size(100, 20);
            this.tbDruga.TabIndex = 2;
            this.tbDruga.UseWaitCursor = true;
            this.tbDruga.TextChanged += new System.EventHandler(this.liczWszystko);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "b";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lWynik
            // 
            this.lWynik.AutoSize = true;
            this.lWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lWynik.Location = new System.Drawing.Point(78, 126);
            this.lWynik.Name = "lWynik";
            this.lWynik.Size = new System.Drawing.Size(64, 20);
            this.lWynik.TabIndex = 4;
            this.lWynik.Text = "wynik: ?";
            this.lWynik.UseWaitCursor = true;
            // 
            // rbDodaj
            // 
            this.rbDodaj.AutoSize = true;
            this.rbDodaj.Checked = true;
            this.rbDodaj.Location = new System.Drawing.Point(32, 30);
            this.rbDodaj.Name = "rbDodaj";
            this.rbDodaj.Size = new System.Drawing.Size(31, 17);
            this.rbDodaj.TabIndex = 5;
            this.rbDodaj.TabStop = true;
            this.rbDodaj.Text = "+";
            this.rbDodaj.UseVisualStyleBackColor = true;
            this.rbDodaj.UseWaitCursor = true;
            this.rbDodaj.CheckedChanged += new System.EventHandler(this.liczWszystko);
            // 
            // rbOdejmij
            // 
            this.rbOdejmij.AutoSize = true;
            this.rbOdejmij.Location = new System.Drawing.Point(32, 53);
            this.rbOdejmij.Name = "rbOdejmij";
            this.rbOdejmij.Size = new System.Drawing.Size(28, 17);
            this.rbOdejmij.TabIndex = 6;
            this.rbOdejmij.Text = "-";
            this.rbOdejmij.UseVisualStyleBackColor = true;
            this.rbOdejmij.UseWaitCursor = true;
            this.rbOdejmij.CheckedChanged += new System.EventHandler(this.liczWszystko);
            // 
            // rbPomnoz
            // 
            this.rbPomnoz.AutoSize = true;
            this.rbPomnoz.Location = new System.Drawing.Point(32, 76);
            this.rbPomnoz.Name = "rbPomnoz";
            this.rbPomnoz.Size = new System.Drawing.Size(29, 17);
            this.rbPomnoz.TabIndex = 7;
            this.rbPomnoz.Text = "*";
            this.rbPomnoz.UseVisualStyleBackColor = true;
            this.rbPomnoz.UseWaitCursor = true;
            this.rbPomnoz.CheckedChanged += new System.EventHandler(this.liczWszystko);
            // 
            // rbPodziel
            // 
            this.rbPodziel.AutoSize = true;
            this.rbPodziel.Location = new System.Drawing.Point(32, 99);
            this.rbPodziel.Name = "rbPodziel";
            this.rbPodziel.Size = new System.Drawing.Size(30, 17);
            this.rbPodziel.TabIndex = 8;
            this.rbPodziel.Text = "/";
            this.rbPodziel.UseVisualStyleBackColor = true;
            this.rbPodziel.UseWaitCursor = true;
            this.rbPodziel.CheckedChanged += new System.EventHandler(this.liczWszystko);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDodaj);
            this.groupBox1.Controls.Add(this.rbPodziel);
            this.groupBox1.Controls.Add(this.rbOdejmij);
            this.groupBox1.Controls.Add(this.rbPomnoz);
            this.groupBox1.Location = new System.Drawing.Point(188, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wybierz działanie";
            this.groupBox1.UseWaitCursor = true;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(426, 336);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(75, 23);
            this.btnOblicz.TabIndex = 10;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.UseWaitCursor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // btnZakoncz
            // 
            this.btnZakoncz.Location = new System.Drawing.Point(507, 336);
            this.btnZakoncz.Name = "btnZakoncz";
            this.btnZakoncz.Size = new System.Drawing.Size(75, 23);
            this.btnZakoncz.TabIndex = 11;
            this.btnZakoncz.Text = "Zakończ";
            this.btnZakoncz.UseVisualStyleBackColor = true;
            this.btnZakoncz.UseWaitCursor = true;
            this.btnZakoncz.Click += new System.EventHandler(this.btnZakoncz_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(345, 336);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(75, 23);
            this.btnWyczysc.TabIndex = 12;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.UseWaitCursor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 371);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnZakoncz);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lWynik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDruga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPierwsza);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.MaximumSize = new System.Drawing.Size(616, 410);
            this.MinimumSize = new System.Drawing.Size(616, 410);
            this.Name = "Form1";
            this.Text = "Działania";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPierwsza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDruga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lWynik;
        private System.Windows.Forms.RadioButton rbDodaj;
        private System.Windows.Forms.RadioButton rbOdejmij;
        private System.Windows.Forms.RadioButton rbPomnoz;
        private System.Windows.Forms.RadioButton rbPodziel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Button btnZakoncz;
        private System.Windows.Forms.Button btnWyczysc;
    }
}

