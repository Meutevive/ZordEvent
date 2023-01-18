using InTerfacePPE;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacePPE
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            FormLogin MonLogin = new FormLogin();
            MonLogin.Hide();
        }
        

        private void btnAjouterParticipant_Click_1(object sender, EventArgs e)
        {

            Participant UnParticipant = new Participant();
            FormAjouterP MonFormulaire = new FormAjouterP(UnParticipant);
            MonFormulaire.Show();

        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridView.SelectedRows)
            {
                Participant UnParticipant = row.DataBoundItem as Participant;
                FormAjouterP MonFormParticipant = new FormAjouterP(UnParticipant);
                MonFormParticipant.Show();

            }

        }

        private void btnRechercherParticipant_Click_1(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe_client_lourd";
            dbCon.UserName = "root";
            dbCon.Password = "";//Crypto.Decrypt("MGgAtv/61oXwMgJN47ilHg==");//Pour éviter d'afficher le mot de passe en clair dans le code
            if (dbCon.IsConnect())
            {
                string query = "SELECT id, nom, prenom, mail, ville FROM participant Where prenom = ?prenom";
                query = Tools.PrepareLigne(query, "?prenom", Tools.PrepareChamp(tbRechercheNom.Text, "Chaine"));

                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                List<Participant> contacts = new List<Participant>();
                while (reader.Read())
                {
                    Participant contact = new Participant
                    {
                        IDParticipant = (int)reader["id"],
                        NomParticipant = (string)reader["nom"],
                        PrenomParticipant = (string)reader["prenom"],
                        EmailParticipant = (string)reader["mail"],
                        VilleParticipant = (string)reader["ville"]


                    };
                    contacts.Add(contact);
                }

                GridView.DataSource = null;
                GridView.DataSource = contacts;
                FormaterListe();
                reader.Close();
                dbCon.Close();
                GridView.Visible = true;

            }
        }

        private void FormaterListe()
        {
            GridView.Columns["IDParticipant"].Visible = false;
            GridView.Columns["NomParticipant"].HeaderText = "Nom du participant";
            GridView.Columns["NomParticipant"].Width = 150;
            GridView.Columns["PrenomParticipant"].HeaderText = "Prenom du participant";
            GridView.Columns["PrenomParticipant"].Width = 150;
            GridView.Columns["EmailParticipant"].HeaderText = "Email du participant";
            GridView.Columns["EmailParticipant"].Width = 150;
            GridView.Columns["VilleParticipant"].HeaderText = "Ville du participant";
            GridView.Columns["VilleParticipant"].Width = 150;
            GridView.MultiSelect = false;
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.ReadOnly = true;

        }

        private void btnTouslesParticipants_Click_1(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe_client_lourd";
            dbCon.UserName = "root";
            dbCon.Password = "";//Crypto.Decrypt("MGgAtv/61oXwMgJN47ilHg==");//Pour éviter d'afficher le mot de passe en clair dans le code
            if (dbCon.IsConnect())
            {
                string query = "SELECT id, nom, prenom, mail, ville FROM participant ORDER BY nom";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                List<Participant> participants = new List<Participant>();
                while (reader.Read())
                {
                    Participant LesParticipants = new Participant
                    {
                        IDParticipant = (int)reader["id"],
                        NomParticipant = (string)reader["nom"],
                        PrenomParticipant = (string)reader["Prenom"],
                        EmailParticipant = (string)reader["mail"],
                        VilleParticipant = (string)reader["ville"]


                    };
                    participants.Add(LesParticipants);
                }

                GridView.DataSource = null;
                GridView.DataSource = participants;
                FormaterListe();
                reader.Close();
                dbCon.Close();
                GridView.Visible = true;
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in GridView.SelectedRows)
            {
                Participant UnParticipant = row.DataBoundItem as Participant;
                if (UnParticipant.Supprimer())
                    MessageBox.Show("Participant Supprimé !");
                // Ici on rafraîchit la liste....
                else
                    MessageBox.Show("Impossible de  Supprimer !");

            }
        }
    }
}
