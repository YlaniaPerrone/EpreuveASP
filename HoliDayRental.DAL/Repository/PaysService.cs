
using HoliDayRental.Common.Repository;
using HoliDayRental.DAL.Entity;
using HoliDayRental.DAL.Handler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HoliDayRental.DAL.Repository
{
    public class PaysService : ConnectionBase, IPaysRepository<HoliDayRental.DAL.Entity.Pays> //IGetRepository<HoliDayRental.DAL.Entity.Pays, int> // IPaysRepository<Pays>
    {
        public Pays Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idPays], [Libelle] FROM [Pays] WHERE [idPays] = @id";
                    //Parameters...
                    SqlParameter p_id = new SqlParameter("id", id);
                    command.Parameters.Add(p_id);
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) return Mapper.ToGetPays(reader);
                    return null;
                }
            }
        }

        public IEnumerable<Pays> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [idPays], [Libelle] FROM [Pays]";
                    //Parameters...
                    //SqlParameter p_id = new SqlParameter("id", id);
                    //command.Parameters.Add(p_id);
                    connection.Open();
                    //Choose Execution method
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) yield return Mapper.ToGetPays(reader);
                }
            
            }
        }
    }
}
