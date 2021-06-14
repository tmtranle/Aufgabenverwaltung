using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReStartAufgabenverwaltung
{
    public partial class Eingabefenster : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=AufgabenverwaltungDB");

        public Hauptfenster hauptfenster;
        public Aufgabe zuBearbeiten;

        public Eingabefenster(Hauptfenster hauptfenster, Aufgabe zuBearbeiten)
        {
            this.hauptfenster = hauptfenster;
            this.zuBearbeiten = zuBearbeiten;
            InitializeComponent();
            if (zuBearbeiten != null)
            {
                textBoxBezeichnung.Text = zuBearbeiten.Bezeichnung;
                dateTimePickerAbgabedatum.Value = zuBearbeiten.Abgabedatum;
                textBoxMitarbeiter.Text = zuBearbeiten.Mitarbeiter;
                numericUpDownErledigungsgrad.Value = zuBearbeiten.Erledigungsgrad;
                buttonHinzufuegen.Text = "Änderung speichern";
            }
            DialogResult = DialogResult.Cancel;
            
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            if (zuBearbeiten == null)
            {
                AufgabeHinzufuegen();
            }
            else
            {
                AufgabeBearbeiten();
            }
        }
        
        private void AufgabeHinzufuegen()
        { 
        // Nutzereingaben erhalten
            string bezeichnung = textBoxBezeichnung.Text;
            if (bezeichnung.Length == 0)
            {
                MessageBox.Show("Bezeichnung eingeben");
                return;
            }
            DateTime abgabedatum = dateTimePickerAbgabedatum.Value;
            string mitarbeiter = textBoxMitarbeiter.Text;
            if (mitarbeiter.Length == 0)
            {
                mitarbeiter = "nicht vergeben";
                return;
            }
            int erledigungsgrad = (int) numericUpDownErledigungsgrad.Value;

            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Aufgabe (Bezeichnung, Abgabedatum, Mitarbeiter, Erledigungsgrad)"
                + " VALUES(@bezeichnung, @abgabedatum, @mitarbeiter, @erledigungsgrad)";
            cmd.Parameters.AddWithValue("Bezeichnung", bezeichnung);
            cmd.Parameters.AddWithValue("Abgabedatum", abgabedatum);
            cmd.Parameters.AddWithValue("Mitarbeiter", mitarbeiter);
            cmd.Parameters.AddWithValue("Erledigungsgrad", erledigungsgrad);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            long Id = cmd.LastInsertedId;
            conn.Close();

            // zur Liste hinzufügen 
            Aufgabe hinzuzufuegen = new Aufgabe(Id, bezeichnung, abgabedatum, mitarbeiter, erledigungsgrad);
            // Listbox aktualisieren
            hauptfenster.AddAufgabe(hinzuzufuegen);
            DialogResult = DialogResult.OK;
            this.Close();
            conn.Close();
        }

        private void AufgabeBearbeiten()
        {
            string bezeichnung = textBoxBezeichnung.Text;
            if (bezeichnung.Length == 0)
            {
                return;
            }
            DateTime abgabedatum = dateTimePickerAbgabedatum.Value;
            string mitarbeiter = textBoxMitarbeiter.Text;
            int erledigungsgrad = (int) numericUpDownErledigungsgrad.Value;

            zuBearbeiten.Bezeichnung = bezeichnung;
            zuBearbeiten.Abgabedatum = abgabedatum;
            zuBearbeiten.Mitarbeiter = mitarbeiter;
            zuBearbeiten.Erledigungsgrad = erledigungsgrad;

            DialogResult = DialogResult.OK;

            Close();

        }
    }
}
