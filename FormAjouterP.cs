using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTerfacePPE;
using MySql.Data.MySqlClient;
using QRCoder;

namespace InterfacePPE
{
    public partial class FormAjouterP : Form
    {

        Participant LeParticipant;
        public FormAjouterP(Participant UnParticipant)
        {
            InitializeComponent();
            LeParticipant = UnParticipant;
            tbNom.Text = UnParticipant.NomParticipant;
            tbPrenom.Text = UnParticipant.PrenomParticipant;
            tbEmail.Text = UnParticipant.EmailParticipant;
            tbVille.Text = UnParticipant.VilleParticipant;
        }




        private void btnAjouter_Click(object sender, EventArgs e)
        {


            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe_client_lourd";
            dbCon.UserName = "root";
            dbCon.Password = "";//Pour éviter d'afficher le mot de passe en clair dans le code

            if (dbCon.IsConnect())
            {
                //Parcours Classique d'un curseur, adressage des colonnes par leur position ordinale dans la requête
                string query = "select id, nom, prenom, mail, ville from participant;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                reader.Close();

                Participant UnParticipant = new Participant();
                String NomParticipant, PrenomParticipant, EmailParticipant, VilleParticipant;



                NomParticipant = tbNom.Text;
                PrenomParticipant = tbPrenom.Text;
                EmailParticipant = tbEmail.Text;
                VilleParticipant = tbVille.Text;
                
                try
                {

                    //Ici on effectue l'enregistrement dans la BDD
                    UnParticipant.Init(NomParticipant, PrenomParticipant, EmailParticipant,VilleParticipant);
                    UnParticipant.Save(dbCon, reader);
                    MessageBox.Show("le participant à été Ajouter!... cliquer sur OK");
                    tbNomPrenomEmail.Text = tbPrenom.Text + " " + tbNom.Text + " " + tbEmail.Text;
                    tbNom.Text = "";
                    tbPrenom.Text = "";
                    tbEmail.Text = "";
                    tbVille.Text = "";
                    
                }
                catch
                {
                    MessageBox.Show("Saisie  incorrect");
                }


            }



        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            DBConnection dbCon = new DBConnection();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "ppe_client_lourd";
            dbCon.UserName = "root";
            dbCon.Password = "";//Pour éviter d'afficher le mot de passe en clair dans le code

            if (dbCon.IsConnect())
            {
                //Parcours Classique d'un curseur, adressage des colonnes par leur position ordinale dans la requête
                string query = "select id, nom, prenom,mail, ville from participant;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();//Remplissage du curseur
                reader.Close();
                int ID; String Nom; String Prenom; String Email; String Ville;
                Prenom = tbPrenom.Text;
                String Query = "select id,nom,prenom,mail, ville from participant where Prenom=?Prenom";

                Query = Tools.PrepareLigne(Query, "?Prenom", Tools.PrepareChamp(Prenom, "Chaine"));

                var Cmd = new MySqlCommand(Query, dbCon.Connection);


                var Reader = Cmd.ExecuteReader();
                while (Reader.Read())
                {

                    ID = (int)Reader["id"];
                    Nom = (string)Reader["nom"];
                    Prenom = (string)Reader["prenom"];
                    Email = (string)Reader["mail"];
                    Ville = (string)Reader["ville"];


                    QRCodeGenerator qrGenerator = new QRCodeGenerator();
                    String QRBrut = Prenom + " " + Nom;
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRBrut, QRCodeGenerator.ECCLevel.Q);

                    Base64QRCode qrCode = new Base64QRCode(qrCodeData);
                    string qrCodeImageAsBase64 = qrCode.GetGraphic(20);

                    StreamWriter monStreamWriter = new StreamWriter(@"C:\Temp\BadgeSalon.html");//Necessite using System.IO;

                    String strImage = " <img id='qrcode' src = \"data:image/png;base64," + qrCodeImageAsBase64 + "\" alt = 'qrcode' width = '100' height = '100'>";
                    //CODE HTML
                    monStreamWriter.WriteLine("<html>");
                    monStreamWriter.WriteLine("<body>");
                    //CODE CSS
                    monStreamWriter.WriteLine("<style>");
                    monStreamWriter.WriteLine("body {font-family: Helvetica;}");
                    monStreamWriter.WriteLine("h1,h2,h3 {margin: 0; font-weight: normal;}");
                    monStreamWriter.WriteLine("h1{ font-size: 30px;}");
                    monStreamWriter.WriteLine("h2{ font-size: 20px;}");
                    monStreamWriter.WriteLine("#container {height: 240px; width: 375px; position: fixed;}");
                    monStreamWriter.WriteLine("#text {float: left;}");
                    monStreamWriter.WriteLine("#qrcode {float: right;}");
                    monStreamWriter.WriteLine("#text #qrcode {display: inline-block;}");
                    monStreamWriter.WriteLine("</style>");
                    //FIN CODE CSS
                    monStreamWriter.WriteLine("<div id = 'container'>");
                    monStreamWriter.WriteLine("<div id = 'card' class='bckgr'>");
                    string temptext = "<h1>" + "Visiteur" + "</h1>";
                    monStreamWriter.WriteLine(temptext);
                    monStreamWriter.WriteLine("<br><br>");
                    monStreamWriter.WriteLine("<div id='text'>");
                    temptext = "<h2>" + Nom + "</h2>";
                    monStreamWriter.WriteLine(temptext);
                    temptext = "<h2>" + Prenom + "</h2>";
                    monStreamWriter.WriteLine(temptext);
                    temptext = "<h2>" + Email + "</h2>";
                    monStreamWriter.WriteLine(temptext);
                    temptext = "<h2>" + Ville + "</h2>";
                    monStreamWriter.WriteLine(temptext);
                    monStreamWriter.WriteLine("</div>");    //Fermeture premier div
                    monStreamWriter.WriteLine(strImage);    //Ecriture de l'image base 64 dans le fichier
                    monStreamWriter.WriteLine("</div>");    //Fermeture deuxieme div
                    monStreamWriter.WriteLine("</div>");    //Fermeture troisieme div
                    monStreamWriter.WriteLine("</body>");
                    monStreamWriter.WriteLine("</html>");
                    //FIN CODE HTML


                    // Fermeture du StreamWriter (Très important) 
                    monStreamWriter.Close();
                    System.Diagnostics.Process.Start("Chrome", @"C:\Temp\BadgeSalon.html");
                    MessageBox.Show("Badge généré");




                }
                Reader.Close();
            }
        }

        

        
    }
}
