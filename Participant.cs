using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using InTerfacePPE;
using System.Windows;

namespace InterfacePPE
{
    public class Participant  
    {
        public int IDParticipant
        {
            get;
            set;
        }
        public string NomParticipant
        {
            get;
            set;
        }

        public string PrenomParticipant
        {
            get;
            set;
        }
        public string EmailParticipant
        {
            get;
            set;
        }
        public string VilleParticipant
        {
            get;
            set;
        }
            
        public void Init(string NomParticipant, string PrenomParticipant, string EmailParticipant, string VilleParticipant)
        {
            this.NomParticipant = NomParticipant;
            this.PrenomParticipant = PrenomParticipant;
            this.EmailParticipant = EmailParticipant;
            this.VilleParticipant = VilleParticipant;
     

        }

        public void Save(DBConnection DataBaseConnection,MySqlDataReader TheReader)

        {
            if (IDParticipant > 0)
                UpdateParticipant(DataBaseConnection, TheReader);
            else
                AddParticipant(DataBaseConnection, TheReader);
        }

        private void UpdateParticipant(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            try
            {
                String sqlString = "UPDATE participant SET nom = ?nom, prenom = ?prenom, mail = ?mail, ville=?ville,  WHERE id = ?id";
                sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDParticipant.ToString(), "Nombre"));
                sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(NomParticipant, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(PrenomParticipant, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?mail", Tools.PrepareChamp(EmailParticipant, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?ville", Tools.PrepareChamp(VilleParticipant, "Chaine"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
               MessageBox.Show("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }
        
        
        

        private void AddParticipant( DBConnection DataBaseConnection, MySqlDataReader TheReader )
        {
            try {
                IDParticipant = GiveNewID(DataBaseConnection, TheReader);
                String sqlString = "INSERT INTO participant(id,nom,prenom,mail, ville) VALUES(?id,?nom,?prenom,?mail,?ville)";
                sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDParticipant.ToString(), "Nombre"));
                sqlString = Tools.PrepareLigne(sqlString, "?nom", Tools.PrepareChamp(NomParticipant, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?prenom", Tools.PrepareChamp(PrenomParticipant, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?mail", Tools.PrepareChamp(EmailParticipant, "Chaine"));
                sqlString = Tools.PrepareLigne(sqlString, "?ville", Tools.PrepareChamp(VilleParticipant, "Chaine"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }
        public bool Supprimer()
        {
            try
            {
                DBConnection dbCon = new DBConnection();
                dbCon.Server = "localhost";
                dbCon.DatabaseName = "ppe_client_lourd";
                dbCon.UserName = "root";
                dbCon.Password = ""; //Crypto.Decrypt("MGgAtv/61oXwMgJN47ilHg==");//Pour éviter d'afficher le mot de passe en clair dans le code
                if (dbCon.IsConnect())
                {
                    String sqlString = "DELETE FROM participant  WHERE id = ?id";
                    sqlString = Tools.PrepareLigne(sqlString, "?id", Tools.PrepareChamp(IDParticipant.ToString(), "Nombre"));
                    var cmd = new MySqlCommand(sqlString, dbCon.Connection);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                return false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }

        }

        private int GiveNewID(DBConnection DataBaseConnection, MySqlDataReader TheReader)
        {
            int NewCode_c = 0;
            try
            {
                String sqlString = "SELECT MAX(id) FROM participant;";
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connection);
                TheReader = cmd.ExecuteReader();

                while (TheReader.Read())
                { NewCode_c = TheReader.GetInt32(0); }
                TheReader.Close();
                NewCode_c++;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
            return NewCode_c;
        }





    }
}
