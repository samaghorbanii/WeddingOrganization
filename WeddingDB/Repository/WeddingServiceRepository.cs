using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDB.IRepository;

namespace WeddingDB.Repository
{
    public class WeddingServiceRepository : IWeddingServiceRepository
    {
        private const string ConnectionString = "data source=.; initial catalog=WeddingOrganization; integrated security=true;";

        public DataTable GetAll(int id)
        {
            var dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Usp_GetById_Service", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = null;

            sqlConnection.Open();

            reader = cmd.ExecuteReader();
            dt.Load(reader);
            sqlConnection.Close();

            return dt;

        }
    }
}
