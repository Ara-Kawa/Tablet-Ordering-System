using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using tablet_blazor.Models;

namespace tablet_blazor.Services
{
    public class UserLogin : IUserLogin
    {
      
        private readonly IConfiguration configration;

        public UserLogin(IConfiguration _configration)
        {
            configration = _configration;
        }

        public async  Task<IEnumerable<string>> GetUsers()
        {
            List<string> users = new List<string>();
            try
            {


                using (SqlConnection connection = new SqlConnection(
                  configration.GetConnectionString("myconnectionstring")
               ))
                {
                    SqlCommand command = new SqlCommand("select * from tbl_user where active_account = 1", connection);
                   
                    command.Connection.Open();
                    int x = Convert.ToInt32(await command.ExecuteScalarAsync());

                    if (x == 0)
                    {
                        return null;
                    }
                    else
                    {
                      
                        using (SqlDataReader rdr = await command.ExecuteReaderAsync())
                        {
                            while (rdr.Read())
                            {
                                users.Add(rdr["uname"].ToString());
                               

                            }
                        }




                        return users;


                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async  Task<LoginResult> Login(User user)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(
                  configration.GetConnectionString("myconnectionstring")
               ))
                {
                    SqlCommand command = new SqlCommand("select * from tbl_user where uname = @uname and pass = @password", connection);
                    command.Parameters.AddWithValue("@uname", user.uname);
                    command.Parameters.AddWithValue("@password", user.pass);
                    command.Connection.Open();
                    int x =  Convert.ToInt32(await command.ExecuteScalarAsync());

                    if (x == 0)
                    {
                        return null;
                    }
                    else
                    {
                        string per = "";
                        int uid = -1;
                        using (SqlDataReader rdr =await command.ExecuteReaderAsync())
                        {
                            while (rdr.Read())
                            {
                                per = rdr["per"].ToString();
                                uid = (int)rdr["uid"];

                            }
                        }




                        return new LoginResult() { per = per, uid = uid };



                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null ;
            }
        }
    }
}
