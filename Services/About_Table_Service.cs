using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using tablet_blazor.Models;

namespace tablet_blazor.Services
{
    public class About_Table_Service : IAbout_Table_Service
    {
        private readonly IConfiguration configuration;

        public About_Table_Service(IConfiguration Configuration)
        {
            configuration = Configuration;
        }

        public async Task<List<Table>> getTables()
        {
            List<Table> tables = new List<Table>();
            try
            {



                using (SqlConnection connection = new SqlConnection(
             configuration.GetConnectionString("myconnectionstring")
          ))
                {
                    SqlCommand cmd = new SqlCommand("sp_check_table_for_tablet", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader rs = await cmd.ExecuteReaderAsync();
                    int i = 0;
                    while (rs.Read())
                    {
                        tables.Add(new Table() {table_number = rs["tbl_no"].ToString(), have_bill = rs["have_bill"].ToString(), have_order = rs["have_order"].ToString() });
                        i++;







                    }
                }
                return tables;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
