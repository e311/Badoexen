namespace LDT
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Button_laden = new System.Windows.Forms.Button();
            this.TXT_Name = new System.Windows.Forms.TextBox();
            this.label_Nachname = new System.Windows.Forms.Label();
            this.TXT_Vorname = new System.Windows.Forms.TextBox();
            this.TXT_Gebdat = new System.Windows.Forms.TextBox();
            this.TXT_Fallnummer = new System.Windows.Forms.TextBox();
            this.label_Vorname = new System.Windows.Forms.Label();
            this.label_geburtsdatum = new System.Windows.Forms.Label();
            this.label_fallnummer = new System.Windows.Forms.Label();
            this.button_Speichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "LDT|*.LDT";
            this.openFileDialog1.InitialDirectory = "L:\\";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Button_laden
            // 
            this.Button_laden.Location = new System.Drawing.Point(21, 17);
            this.Button_laden.Name = "Button_laden";
            this.Button_laden.Size = new System.Drawing.Size(75, 23);
            this.Button_laden.TabIndex = 0;
            this.Button_laden.Text = "LDT Laden";
            this.Button_laden.UseVisualStyleBackColor = true;
            this.Button_laden.Click += new System.EventHandler(this.button1_Click);
            // 
            // TXT_Name
            // 
            this.TXT_Name.Location = new System.Drawing.Point(101, 67);
            this.TXT_Name.Name = "TXT_Name";
            this.TXT_Name.Size = new System.Drawing.Size(100, 20);
            this.TXT_Name.TabIndex = 1;
            // 
            // label_Nachname
            // 
            this.label_Nachname.AutoSize = true;
            this.label_Nachname.Location = new System.Drawing.Point(18, 67);
            this.label_Nachname.Name = "label_Nachname";
            this.label_Nachname.Size = new System.Drawing.Size(59, 13);
            this.label_Nachname.TabIndex = 2;
            this.label_Nachname.Text = "Nachname";
            // 
            // TXT_Vorname
            // 
            this.TXT_Vorname.Location = new System.Drawing.Point(101, 93);
            this.TXT_Vorname.Name = "TXT_Vorname";
            this.TXT_Vorname.Size = new System.Drawing.Size(100, 20);
            this.TXT_Vorname.TabIndex = 3;
            // 
            // TXT_Gebdat
            // 
            this.TXT_Gebdat.Location = new System.Drawing.Point(101, 119);
            this.TXT_Gebdat.Name = "TXT_Gebdat";
            this.TXT_Gebdat.Size = new System.Drawing.Size(100, 20);
            this.TXT_Gebdat.TabIndex = 4;
            // 
            // TXT_Fallnummer
            // 
            this.TXT_Fallnummer.Location = new System.Drawing.Point(101, 145);
            this.TXT_Fallnummer.Name = "TXT_Fallnummer";
            this.TXT_Fallnummer.Size = new System.Drawing.Size(100, 20);
            this.TXT_Fallnummer.TabIndex = 5;
            // 
            // label_Vorname
            // 
            this.label_Vorname.AutoSize = true;
            this.label_Vorname.Location = new System.Drawing.Point(18, 93);
            this.label_Vorname.Name = "label_Vorname";
            this.label_Vorname.Size = new System.Drawing.Size(49, 13);
            this.label_Vorname.TabIndex = 6;
            this.label_Vorname.Text = "Vorname";
            // 
            // label_geburtsdatum
            // 
            this.label_geburtsdatum.AutoSize = true;
            this.label_geburtsdatum.Location = new System.Drawing.Point(18, 119);
            this.label_geburtsdatum.Name = "label_geburtsdatum";
            this.label_geburtsdatum.Size = new System.Drawing.Size(73, 13);
            this.label_geburtsdatum.TabIndex = 7;
            this.label_geburtsdatum.Text = "Geburtsdatum";
            // 
            // label_fallnummer
            // 
            this.label_fallnummer.AutoSize = true;
            this.label_fallnummer.Location = new System.Drawing.Point(18, 145);
            this.label_fallnummer.Name = "label_fallnummer";
            this.label_fallnummer.Size = new System.Drawing.Size(60, 13);
            this.label_fallnummer.TabIndex = 8;
            this.label_fallnummer.Text = "Fallnummer";
            // 
            // button_Speichern
            // 
            this.button_Speichern.Location = new System.Drawing.Point(103, 16);
            this.button_Speichern.Name = "button_Speichern";
            this.button_Speichern.Size = new System.Drawing.Size(75, 23);
            this.button_Speichern.TabIndex = 9;
            this.button_Speichern.Text = "Speichern";
            this.button_Speichern.UseVisualStyleBackColor = true;
            this.button_Speichern.Click += new System.EventHandler(this.button_Speichern_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 196);
            this.Controls.Add(this.button_Speichern);
            this.Controls.Add(this.label_fallnummer);
            this.Controls.Add(this.label_geburtsdatum);
            this.Controls.Add(this.label_Vorname);
            this.Controls.Add(this.TXT_Fallnummer);
            this.Controls.Add(this.TXT_Gebdat);
            this.Controls.Add(this.TXT_Vorname);
            this.Controls.Add(this.label_Nachname);
            this.Controls.Add(this.TXT_Name);
            this.Controls.Add(this.Button_laden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Button_laden;
        private System.Windows.Forms.TextBox TXT_Name;
        private System.Windows.Forms.Label label_Nachname;
        private System.Windows.Forms.TextBox TXT_Vorname;
        private System.Windows.Forms.TextBox TXT_Gebdat;
        private System.Windows.Forms.TextBox TXT_Fallnummer;
        private System.Windows.Forms.Label label_Vorname;
        private System.Windows.Forms.Label label_geburtsdatum;
        private System.Windows.Forms.Label label_fallnummer;
        private System.Windows.Forms.Button button_Speichern;
    }
}

