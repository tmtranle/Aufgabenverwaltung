
namespace ReStartAufgabenverwaltung
{
    partial class Eingabefenster
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
            this.labelBezeichnung = new System.Windows.Forms.Label();
            this.textBoxBezeichnung = new System.Windows.Forms.TextBox();
            this.labelAbgabedatum = new System.Windows.Forms.Label();
            this.dateTimePickerAbgabedatum = new System.Windows.Forms.DateTimePicker();
            this.labelMitarbeiter = new System.Windows.Forms.Label();
            this.textBoxMitarbeiter = new System.Windows.Forms.TextBox();
            this.labelErledigungsgrad = new System.Windows.Forms.Label();
            this.numericUpDownErledigungsgrad = new System.Windows.Forms.NumericUpDown();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErledigungsgrad)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBezeichnung
            // 
            this.labelBezeichnung.AutoSize = true;
            this.labelBezeichnung.Location = new System.Drawing.Point(13, 13);
            this.labelBezeichnung.Name = "labelBezeichnung";
            this.labelBezeichnung.Size = new System.Drawing.Size(75, 15);
            this.labelBezeichnung.TabIndex = 0;
            this.labelBezeichnung.Text = "Bezeichnung";
            // 
            // textBoxBezeichnung
            // 
            this.textBoxBezeichnung.Location = new System.Drawing.Point(13, 32);
            this.textBoxBezeichnung.Name = "textBoxBezeichnung";
            this.textBoxBezeichnung.Size = new System.Drawing.Size(279, 23);
            this.textBoxBezeichnung.TabIndex = 1;
            // 
            // labelAbgabedatum
            // 
            this.labelAbgabedatum.AutoSize = true;
            this.labelAbgabedatum.Location = new System.Drawing.Point(13, 62);
            this.labelAbgabedatum.Name = "labelAbgabedatum";
            this.labelAbgabedatum.Size = new System.Drawing.Size(83, 15);
            this.labelAbgabedatum.TabIndex = 2;
            this.labelAbgabedatum.Text = "Abgabedatum";
            // 
            // dateTimePickerAbgabedatum
            // 
            this.dateTimePickerAbgabedatum.Location = new System.Drawing.Point(13, 81);
            this.dateTimePickerAbgabedatum.Name = "dateTimePickerAbgabedatum";
            this.dateTimePickerAbgabedatum.Size = new System.Drawing.Size(279, 23);
            this.dateTimePickerAbgabedatum.TabIndex = 3;
            // 
            // labelMitarbeiter
            // 
            this.labelMitarbeiter.AutoSize = true;
            this.labelMitarbeiter.Location = new System.Drawing.Point(13, 111);
            this.labelMitarbeiter.Name = "labelMitarbeiter";
            this.labelMitarbeiter.Size = new System.Drawing.Size(65, 15);
            this.labelMitarbeiter.TabIndex = 4;
            this.labelMitarbeiter.Text = "Mitarbeiter";
            // 
            // textBoxMitarbeiter
            // 
            this.textBoxMitarbeiter.Location = new System.Drawing.Point(13, 130);
            this.textBoxMitarbeiter.Name = "textBoxMitarbeiter";
            this.textBoxMitarbeiter.Size = new System.Drawing.Size(279, 23);
            this.textBoxMitarbeiter.TabIndex = 5;
            // 
            // labelErledigungsgrad
            // 
            this.labelErledigungsgrad.AutoSize = true;
            this.labelErledigungsgrad.Location = new System.Drawing.Point(13, 160);
            this.labelErledigungsgrad.Name = "labelErledigungsgrad";
            this.labelErledigungsgrad.Size = new System.Drawing.Size(93, 15);
            this.labelErledigungsgrad.TabIndex = 6;
            this.labelErledigungsgrad.Text = "Erledigungsgrad";
            // 
            // numericUpDownErledigungsgrad
            // 
            this.numericUpDownErledigungsgrad.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownErledigungsgrad.Location = new System.Drawing.Point(13, 179);
            this.numericUpDownErledigungsgrad.Name = "numericUpDownErledigungsgrad";
            this.numericUpDownErledigungsgrad.Size = new System.Drawing.Size(93, 23);
            this.numericUpDownErledigungsgrad.TabIndex = 7;
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.Location = new System.Drawing.Point(112, 177);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(180, 23);
            this.buttonHinzufuegen.TabIndex = 8;
            this.buttonHinzufuegen.Text = "Aufgabe hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = true;
            this.buttonHinzufuegen.Click += new System.EventHandler(this.buttonHinzufuegen_Click);
            // 
            // Eingabefenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 225);
            this.Controls.Add(this.buttonHinzufuegen);
            this.Controls.Add(this.numericUpDownErledigungsgrad);
            this.Controls.Add(this.labelErledigungsgrad);
            this.Controls.Add(this.textBoxMitarbeiter);
            this.Controls.Add(this.labelMitarbeiter);
            this.Controls.Add(this.dateTimePickerAbgabedatum);
            this.Controls.Add(this.labelAbgabedatum);
            this.Controls.Add(this.textBoxBezeichnung);
            this.Controls.Add(this.labelBezeichnung);
            this.Name = "Eingabefenster";
            this.Text = "Eingabefenster";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownErledigungsgrad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBezeichnung;
        private System.Windows.Forms.TextBox textBoxBezeichnung;
        private System.Windows.Forms.Label labelAbgabedatum;
        private System.Windows.Forms.DateTimePicker dateTimePickerAbgabedatum;
        private System.Windows.Forms.Label labelMitarbeiter;
        private System.Windows.Forms.TextBox textBoxMitarbeiter;
        private System.Windows.Forms.Label labelErledigungsgrad;
        private System.Windows.Forms.NumericUpDown numericUpDownErledigungsgrad;
        private System.Windows.Forms.Button buttonHinzufuegen;
    }
}