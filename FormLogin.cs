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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {

            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe_client_lourd";
            dbCon.UserName = "root";
            dbCon.Password = "";//Crypto.Decrypt("MGgAtv/61oXwMgJN47ilHg==");//Pour éviter d'afficher le mot de passe en clair dans le code
            if (dbCon.IsConnect())
            {
                string query = "SELECT login, mdp FROM user Where login = ?login and mdp = ?mdp";
                query = Tools.PrepareLigne(query, "?login", Tools.PrepareChamp(tbLogin.Text, "Chaine"));
                query = Tools.PrepareLigne(query, "?mdp", Tools.PrepareChamp(tbMdp.Text, "Chaine"));


                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur

                while (reader.Read())
                {
                    if (reader["login"].ToString() == tbLogin.Text && reader["mdp"].ToString() == tbMdp.Text)
                    {
                        if (reader["login"].ToString() == "abass")
                        {
                            FormUser2A monuser2 = new FormUser2A();
                            monuser2.Show();
                        }
                        else
                        {
                            MenuPrincipal monMenuPrincipal = new MenuPrincipal();
                            monMenuPrincipal.Show();

                        }    
                       

                    }
                    else
                    {
                        lblpopup.Text = "login ou mot de passe invalide !";
                        lblpopup.Visible = true;

                        
                    }


                }
            }


        }
    }
}
