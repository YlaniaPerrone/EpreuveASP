using HoliDayRental.Common.Repository;
using HoliDayRental.DAL.Entity;
using HoliDayRental.DAL.Handler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repository
{
    public class BienEchangeService : ConnectionBase, IBienEchangeRepository<HoliDayRental.DAL.Entity.BienEchange>
    {
        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [BienEchange] WHERE [idBien = @id";
                    //Parameters...
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    //Choose Execution method
                    command.ExecuteNonQuery();
                }
            }
        }

        public BienEchange Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchange] WHERE [idBien] = @id";
                    //Parameters...
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToBienEchange(reader);
                    return null;
                }
            }
        }

        public IEnumerable<BienEchange> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchange]  WHERE [isEnabled] = 'True'";
                    //Parameters...
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                }
            }
        }

        
        public IEnumerable<BienEchange> Ge(bool isEnabled)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation] FROM [BienEchange] WHERE [isEnabled] = True";
                    //Parameters...
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                }
            }
        }

        public int Insert(BienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [BienEchange]([titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation]) OUTPUT [inserted].[idBien] VALUES ( @titre, @DescCourte, @DescLong, @NombrePerson, @Pays, @Ville, @Rue, @Numero, @CodePostal, @Photo, @AssuranceObligatoire, @isEnabled, @DisabledDate, @Latitude, @Longitude, @idMembre, @DateCreation)";
                    // SqlParameter p_id = new SqlParameter("idBien", entity.idBien);
                    // command.Parameters.Add(p_id);
                    SqlParameter p_titre = new SqlParameter("titre", entity.titre);
                    command.Parameters.Add(p_titre);
                    SqlParameter p_descCourte = new SqlParameter("DescCourte", entity.DescCourte);
                    command.Parameters.Add(p_descCourte);
                    SqlParameter p_descLong = new SqlParameter("DescLong", entity.DescLong);
                    command.Parameters.Add(p_descLong);
                    SqlParameter p_nombrePerson = new SqlParameter("NombrePerson", entity.NombrePerson);
                    command.Parameters.Add(p_nombrePerson);
                    SqlParameter p_pays = new SqlParameter("Pays", entity.Pays);
                    command.Parameters.Add(p_pays);
                    SqlParameter p_ville = new SqlParameter("Ville", entity.Ville);
                    command.Parameters.Add(p_ville);
                    SqlParameter p_rue = new SqlParameter("Rue", entity.Rue);
                    command.Parameters.Add(p_rue);
                    SqlParameter p_numero = new SqlParameter("Numero", entity.Numero);
                    command.Parameters.Add(p_numero);
                    SqlParameter p_codePostal = new SqlParameter("CodePostal", entity.CodePostal);
                    command.Parameters.Add(p_codePostal);
                    SqlParameter p_photo = new SqlParameter("Photo", entity.Photo);
                    command.Parameters.Add(p_photo);
                    SqlParameter p_assuranceObligatoire = new SqlParameter("AssuranceObligatoire", entity.AssuranceObligatoire);
                    command.Parameters.Add(p_assuranceObligatoire);
                    SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.isEnabled);
                    command.Parameters.Add(p_isEnabled);
                    SqlParameter p_disabledDate = new SqlParameter { ParameterName = "DisabledDate", Value = (object)entity.DisabledDate ?? DBNull.Value };
                    command.Parameters.Add(p_disabledDate);
                    SqlParameter p_latitude = new SqlParameter("Latitude", entity.Latitude);
                    command.Parameters.Add(p_latitude);
                    SqlParameter p_longitude = new SqlParameter("Longitude", entity.Longitude);
                    command.Parameters.Add(p_longitude);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", entity.idMembre);
                    command.Parameters.Add(p_idMembre);
                    SqlParameter p_dateCreation = new SqlParameter("DateCreation", entity.DateCreation);
                    command.Parameters.Add(p_dateCreation);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public void Update(int id, BienEchange entity)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE SET  [titre] = @titre, [DescCourte]= @DescCourte, [DescLong] = @DescLong, [NombrePerson]= @NombrePerson, [Pays] = @Pays, [Ville] = @Ville , [Rue] = @Rue , [Numero] = @Numero , [CodePostal] = @CodePostal, [AssuranceObligatoire] = @AssuranceObligatoire , [isEnabled] = @isEnabled, [DisabledDate] = @DisabledDate, [Latitude] = @Latitude, [Longitude] = @Longitude, [idMembre] = @idMembre, [DateCreation] = @DateCreation  WHERE [idBien] = @id";
                    // SqlParameter p_id = new SqlParameter("idBien", entity.idBien);
                    // command.Parameters.Add(p_id);
                    SqlParameter p_titre = new SqlParameter("titre", entity.titre);
                    command.Parameters.Add(p_titre);
                    SqlParameter p_descCourte = new SqlParameter("DescCourte", entity.DescCourte);
                    command.Parameters.Add(p_descCourte);
                    SqlParameter p_descLong = new SqlParameter("DescLong", entity.DescLong);
                    command.Parameters.Add(p_descLong);
                    SqlParameter p_nombrePerson = new SqlParameter("NombrePerson", entity.NombrePerson);
                    command.Parameters.Add(p_nombrePerson);
                    SqlParameter p_pays = new SqlParameter("Pays", entity.Pays);
                    command.Parameters.Add(p_pays);
                    SqlParameter p_ville = new SqlParameter("Ville", entity.Ville);
                    command.Parameters.Add(p_ville);
                    SqlParameter p_rue = new SqlParameter("Rue", entity.Rue);
                    command.Parameters.Add(p_rue);
                    SqlParameter p_numero = new SqlParameter("Numero", entity.Numero);
                    command.Parameters.Add(p_numero);
                    SqlParameter p_codePostal = new SqlParameter("CodePostal", entity.CodePostal);
                    command.Parameters.Add(p_codePostal);
                    SqlParameter p_photo = new SqlParameter("Photo", entity.Photo);
                    command.Parameters.Add(p_photo);
                    SqlParameter p_assuranceObligatoire = new SqlParameter("AssuranceObligatoire", entity.AssuranceObligatoire);
                    command.Parameters.Add(p_assuranceObligatoire);
                    SqlParameter p_isEnabled = new SqlParameter("isEnabled", entity.isEnabled);
                    command.Parameters.Add(p_isEnabled);
                    SqlParameter p_disabledDate = new SqlParameter { ParameterName =  "DisabledDate", Value = (object)entity.DisabledDate ?? DBNull.Value };
                    command.Parameters.Add(p_disabledDate);
                    SqlParameter p_latitude = new SqlParameter("Latitude", entity.Latitude);
                    command.Parameters.Add(p_latitude);
                    SqlParameter p_longitude = new SqlParameter("Longitude", entity.Longitude);
                    command.Parameters.Add(p_longitude);
                    SqlParameter p_idMembre = new SqlParameter("idMembre", entity.idMembre);
                    command.Parameters.Add(p_idMembre);
                    SqlParameter p_dateCreation = new SqlParameter("DateCreation", entity.DateCreation);
                    command.Parameters.Add(p_dateCreation);


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<BienEchange> Get5LastPropretyAdded()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idBien], [titre], [DescCourte], [DescLong], [NombrePerson], [Pays], [Ville], [Rue], [Numero], [CodePostal], [Photo], [AssuranceObligatoire], [isEnabled], [DisabledDate], [Latitude], [Longitude], [idMembre], [DateCreation]  FROM [dbo].[Vue_BiensParPays]";

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToBienEchange(reader);
                }
            }
        }
    }
}
