using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReStartAufgabenverwaltung
{
    public partial class Hauptfenster : Form
    {
        private List<Aufgabe> alleAufgaben = new List<Aufgabe>();
        
        public void AddAufgabe(Aufgabe a)
        {
            alleAufgaben.Add(a);
            listBoxAufgaben.Items.Add(a.ToString());
        }
        
        public Hauptfenster()
        {
            InitializeComponent();
            // Testdaten
            // AddAufgabe(new Aufgabe(1, "Waschen", DateTime.Now, "Mai", 90));
            DatenLaden();
        }

        MySqlConnection conn = new MySqlConnection("Server=localhost;UID=root;PWD=;DATABASE=AufgabenverwaltungDB");
        public void DatenLaden()
        {
            // Server kontaktieren
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT ID, Bezeichnung, Abgabedatum, Mitarbeiter, Erledigungsgrad FROM Aufgabe";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                long Id = reader.GetInt64(0);
                string Bezeichnung = reader.GetString(1);
                DateTime Abgabedatum = reader.GetDateTime(2);
                string Mitarbeiter = reader.GetString(3);
                int Erledigungsgrad = reader.GetInt32(4);
                AddAufgabe(new Aufgabe(Id, Bezeichnung, Abgabedatum, Mitarbeiter, Erledigungsgrad));
            }
            reader.Close();
            conn.Close();
        }

        private void buttonOeffneHinzufuegenFormular_Click(object sender, EventArgs e)
        {
            Eingabefenster eingabefenster = new Eingabefenster(this, null);
            eingabefenster.ShowDialog();
        }

        private void buttonEntfernen_Click(object sender, EventArgs e)
        {
            // Index für ausgewählte Aufgabe definieren
            int entfernenIndex = listBoxAufgaben.SelectedIndex;
            if (entfernenIndex < 0 || entfernenIndex >= alleAufgaben.Count)
            {
                MessageBox.Show("Aufgabe zum Entfernen auswählen!");
                return;
            }
            Aufgabe zuEntfernen = alleAufgaben[entfernenIndex];
            
            // Server kontaktieren
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Aufgabe WHERE Id =" + zuEntfernen.Id;
            cmd.ExecuteNonQuery();
            conn.Close();

            // aus der Liste entfernen
            alleAufgaben.RemoveAt(entfernenIndex);
            // Listbox anzeige aktualisieren
            listBoxAufgaben.Items.RemoveAt(entfernenIndex);
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            int bearbeitenIndex = listBoxAufgaben.SelectedIndex;
            if (bearbeitenIndex < 0 || bearbeitenIndex > alleAufgaben.Count)
            {
                MessageBox.Show("Aufgabe zum Bearbeiten auswählen!");
                return;
            }
            else
            {
                Aufgabe zuBearbeiten = alleAufgaben[bearbeitenIndex];
                Eingabefenster eingabefenster = new Eingabefenster(this, zuBearbeiten);
                eingabefenster.ShowDialog();
                if (eingabefenster.DialogResult == DialogResult.OK)
                {
                    listBoxAufgaben.Items[bearbeitenIndex] = zuBearbeiten.ToString();
                }
            }
        }
    }
}
