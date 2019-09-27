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
        private string rue;
        private string ville;
        private string telephone;
        private string mail;
        private static SqlConnection Connection Instance;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public int Id { get => id; set => id = value; }
        public string NomEntreprise { get => nomEntreprise; set => nomEntreprise = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Mail { get => mail; set => mail = value; }


        public Client()
        { }

        public Client(int id)
        {
            command = new SqlCommand("SELECT nomEntreprise, rue, ville, telephone, mail from Client where id = @id", Connection.instance);
            command.Parameters.Add(new SqlParameter("@id", id));
            Connection.Instance.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                NomEntreprise = reader.GetString(0);
                Rue = reader.GetString(1);
                Ville = reader.GetString(2);
                Telephone = reader.GetString(3);
                Mail = reader.GetString(4);
                Id = id;
            }
            command.Dispose();
            Connection.Instance.Close();
        }

        public void AjouterClient()
        {
            command = new SqlCommand("INSERT INTO Client (nomEntreprise, rue, ville, telephone, mail) OUTPUT INSERTED.ID values(@nomEntreprise, @rue, @ville, @telephone, @mail) ", connections);
            command.Parameters.Add(new SqlParameter("@nomEntreprise", nomEntreprise));
            command.Parameters.Add(new SqlParameter("@rue", rue));
            command.Parameters.Add(new SqlParameter("@ville", ville));
            command.Parameters.Add(new SqlParameter("@telephone", telephone));
            command.Parameters.Add(new SqlParameter("@mail", mail));
            Connection.Instance.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            Connection.Instance.Close();
        }




    }
}
