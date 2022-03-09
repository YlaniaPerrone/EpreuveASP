using HoliDayRental.Common.Repository;
using HoliDayRental.DAL.Entity;
using HoliDayRental.DAL.Handler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repository
{
    public class MembreService : ConnectionBase, IMembreRepository<Membre>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Membre] WHERE [idMembre] = @id";
                    SqlParameter p_id = new SqlParameter() { ParameterName = "id", Value = id };
                    command.Parameters.Add(p_id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public Membre Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre] WHERE [idMembre] = @id";
                    //Parameters...
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToMembre(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Membre> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] FROM [Membre]";
                    //Parameters...
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToMembre(reader);
                }
            }
        }

        public int Insert(Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Membre]([Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password]) OUTPUT [inserted].[idMembre] " +
                        " VALUES ( @Nom, @Prenom, @Email, @Pays, @Telephone, @Login, @Password)";
                    // SqlParameter p_id = new SqlParameter { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_Nom = new SqlParameter { ParameterName = "Nom", Value = entity.Nom };
                    SqlParameter p_Prenome = new SqlParameter { ParameterName = "Prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "Email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "Pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "Telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "Login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "Password", Value = entity.Password };

                    // command.Parameters.Add(p_id);
                    command.Parameters.Add(p_Nom);
                    command.Parameters.Add(p_Prenome);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, Membre entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE [Membre] SET [Nom] = @Nom, [Prenom] = @Prenom, [Email] = @Email, [Pays] = @Pays, [Telephone] = @Telephone, [Login] = @Login, [Password] = @Password WHERE [idMembre] = @id";
                    SqlParameter p_Nom = new SqlParameter { ParameterName = "Nom", Value = entity.Nom };
                    command.Parameters.Add(p_Nom);
                    SqlParameter p_Prenom = new SqlParameter { ParameterName = "Prenom", Value = entity.Prenom };
                    command.Parameters.Add(p_Prenom);
                    SqlParameter p_Email = new SqlParameter { ParameterName = "Email", Value = entity.Email };
                    command.Parameters.Add(p_Email);
                    SqlParameter p_Pays = new SqlParameter { ParameterName = "Pays", Value = entity.Pays };
                    command.Parameters.Add(p_Pays);
                    SqlParameter p_Telephone = new SqlParameter { ParameterName = "Telephone", Value = entity.Telephone };
                    command.Parameters.Add(p_Telephone);
                    SqlParameter p_Login = new SqlParameter { ParameterName = "Login", Value = entity.Login };
                    command.Parameters.Add(p_Login);
                    SqlParameter p_Password = new SqlParameter { ParameterName = "Password", Value = entity.Password };
                    command.Parameters.Add(p_Password);
                    SqlParameter p_id = new SqlParameter { ParameterName = "id", Value = entity.idMembre };
                    command.Parameters.Add(p_id);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
