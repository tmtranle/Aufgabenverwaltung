
namespace ReStartAufgabenverwaltung
{
    partial class Hauptfenster
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAufgaben = new System.Windows.Forms.ListBox();
            this.buttonOeffneHinzufuegenFormular = new System.Windows.Forms.Button();
            this.buttonBearbeiten = new System.Windows.Forms.Button();
            this.buttonEntfernen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAufgaben
            // 
            this.listBoxAufgaben.FormattingEnabled = true;
            this.listBoxAufgaben.ItemHeight = 15;
            this.listBoxAufgaben.Location = new System.Drawing.Point(13, 13);
            this.listBoxAufgaben.Name = "listBoxAufgaben";
            this.listBoxAufgaben.Size = new System.Drawing.Size(294, 424);
            this.listBoxAufgaben.TabIndex = 0;
            // 
            // buttonOeffneHinzufuegenFormular
            // 
            this.buttonOeffneHinzufuegenFormular.Location = new System.Drawing.Point(314, 13);
            this.buttonOeffneHinzufuegenFormular.Name = "buttonOeffneHinzufuegenFormular";
            this.buttonOeffneHinzufuegenFormular.Size = new System.Drawing.Size(138, 23);
            this.buttonOeffneHinzufuegenFormular.TabIndex = 1;
            this.buttonOeffneHinzufuegenFormular.Text = "Aufgabe hinzufügen";
            this.buttonOeffneHinzufuegenFormular.UseVisualStyleBackColor = true;
            this.buttonOeffneHinzufuegenFormular.Click += new System.EventHandler(this.buttonOeffneHinzufuegenFormular_Click);
            // 
            // buttonBearbeiten
            // 
            this.buttonBearbeiten.Location = new System.Drawing.Point(314, 43);
            this.buttonBearbeiten.Name = "buttonBearbeiten";
            this.buttonBearbeiten.Size = new System.Drawing.Size(138, 23);
            this.buttonBearbeiten.TabIndex = 2;
            this.buttonBearbeiten.Text = "Aufgabe bearbeiten";
            this.buttonBearbeiten.UseVisualStyleBackColor = true;
            this.buttonBearbeiten.Click += new System.EventHandler(this.buttonBearbeiten_Click);
            // 
            // buttonEntfernen
            // 
            this.buttonEntfernen.Location = new System.Drawing.Point(314, 73);
            this.buttonEntfernen.Name = "buttonEntfernen";
            this.buttonEntfernen.Size = new System.Drawing.Size(138, 23);
            this.buttonEntfernen.TabIndex = 3;
            this.buttonEntfernen.Text = "Aufgabe entfernen";
            this.buttonEntfernen.UseVisualStyleBackColor = true;
            this.buttonEntfernen.Click += new System.EventHandler(this.buttonEntfernen_Click);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 450);
            this.Controls.Add(this.buttonEntfernen);
            this.Controls.Add(this.buttonBearbeiten);
            this.Controls.Add(this.buttonOeffneHinzufuegenFormular);
            this.Controls.Add(this.listBoxAufgaben);
            this.Name = "Hauptfenster";
            this.Text = "Aufgabenverwaltung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAufgaben;
        private System.Windows.Forms.Button buttonOeffneHinzufuegenFormular;
        private System.Windows.Forms.Button buttonBearbeiten;
        private System.Windows.Forms.Button buttonEntfernen;
    }
}

