using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace Blanchisserie
{
    class Client
    {
        private int id;
        private string nomEntreprise;
        private string rueEntreprise;
        private string villeEntreprise;
        private string telephoneEntreprise;
        private string mailEntreprise;
        //private static SqlConnection Connection Instance;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public int Id { get => id; set => id = value; }
        public string NomEntreprise { get => nomEntreprise; set => nomEntreprise = value; }
        public string RueEntreprise { get => rueEntreprise; set => rueEntreprise = value; }
        public string VilleEntreprise { get => villeEntreprise; set => villeEntreprise = value; }
        public string TelephoneEntreprise { get => telephoneEntreprise; set => telephoneEntreprise = value; }
        public string MailEntreprise { get => mailEntreprise; set => mailEntreprise = value; }

        public Client()
        { }

        public Client(int id)
        {
            command = new SqlCommand("SELECT nomEntreprise, rueEntreprise, villeEntreprise, telephoneEntreprise, mailEntreprise from Client where id = @id", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@id", id));
            Connection.Instance.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                NomEntreprise = reader.GetString(0);
                RueEntreprise = reader.GetString(1);
                VilleEntreprise = reader.GetString(2);
                TelephoneEntreprise = reader.GetString(3);
                MailEntreprise = reader.GetString(4);
                Id = id;
            }
            command.Dispose();
            Connection.Instance.Close();
        }

        public void AjouterClient()
        {
            command = new SqlCommand("INSERT INTO Client (nomEntreprise, rueEntreprise, villeEntreprise, telephoneEntreprise, mailEntreprise) OUTPUT INSERTED.ID values(@nomEntreprise, @rueEntreprise, @villeEntreprise, @telephoneEntreprise, @mailEntreprise) ", Connection.Instance);
            command.Parameters.Add(new SqlParameter("@nomEntreprise", nomEntreprise));
            command.Parameters.Add(new SqlParameter("@rueEntreprise", RueEntreprise));
            command.Parameters.Add(new SqlParameter("@villeEntreprise", VilleEntreprise));
            command.Parameters.Add(new SqlParameter("@telephoneEntreprise", TelephoneEntreprise));
            command.Parameters.Add(new SqlParameter("@mailEntreprise", MailEntreprise));
            Connection.Instance.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
        }




    }
}
