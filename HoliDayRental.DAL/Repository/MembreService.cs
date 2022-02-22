﻿using HoliDayRental.Common.Repository;
using HoliDayRental.DAL.Entite;
using HoliDayRental.DAL.Handler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repository
{
    public class MembreService : ConnectionBase, IMembreServiceRepository<Membre>
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
                    command.CommandText = "SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] " +
                        " FROM [Membre] WHERE [IdidMembre] = @id";
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
                    command.CommandText = "SELECT SELECT [idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password] " +
                        " FROM [Membre]";
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
                    command.CommandText = "INSERT INTO [Membre]([idMembre],[Nom],[Prenom],[Email],[Pays],[Telephone],[Login],[Password]) OUTPUT [inserted].[Id] " +
                        " VALUES (@idMembre @Nom, @Prenom, @Email, @Pays, @Telephone, @Login, @Password)";
                    SqlParameter p_id = new SqlParameter { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_nom = new SqlParameter { ParameterName = "Nom", Value = entity.Nom };
                    SqlParameter p_prenome = new SqlParameter { ParameterName = "Prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "Email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "Pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "Telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "Login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "Password", Value = entity.Password };

                    command.Parameters.Add(p_id);
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenome);
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
                    command.CommandText = "UPDATE [Membre] SET [idMembre] = @idMembre, [Nom] = @Nom,[Prenom] = @Prenom,[Email] = @Email, [Pays] = @Pays, [Telephone] = @Telephone, [Login] = @Login, [Password] = @Password WHERE [Id] = @id";
                    SqlParameter p_id = new SqlParameter { ParameterName = "idMembre", Value = entity.idMembre };
                    SqlParameter p_nom = new SqlParameter { ParameterName = "Nom", Value = entity.Nom };
                    SqlParameter p_prenome = new SqlParameter { ParameterName = "Prenom", Value = entity.Prenom };
                    SqlParameter p_email = new SqlParameter { ParameterName = "Email", Value = entity.Email };
                    SqlParameter p_pays = new SqlParameter { ParameterName = "Pays", Value = entity.Pays };
                    SqlParameter p_telephone = new SqlParameter { ParameterName = "Telephone", Value = entity.Telephone };
                    SqlParameter p_login = new SqlParameter { ParameterName = "Login", Value = entity.Login };
                    SqlParameter p_password = new SqlParameter { ParameterName = "Password", Value = entity.Password };

                    command.Parameters.Add(p_id);
                    command.Parameters.Add(p_nom);
                    command.Parameters.Add(p_prenome);
                    command.Parameters.Add(p_email);
                    command.Parameters.Add(p_pays);
                    command.Parameters.Add(p_telephone);
                    command.Parameters.Add(p_login);
                    command.Parameters.Add(p_password);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
