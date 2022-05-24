using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using tablet_blazor.Models;

namespace tablet_blazor.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;

        public OrdersService(IConfiguration Configuration, HttpClient HttpClient)
        {
            configuration = Configuration;
            httpClient = HttpClient;
        }

        public async Task AddNote(long rid, string note)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
            configuration.GetConnectionString("myconnectionstring")
         ))
                {

                    SqlCommand cmd1 = new SqlCommand("update tbl_froshtn_wasl set note=@note where rid=@rid", connection);
                    cmd1.Parameters.AddWithValue("@note", note);
                    cmd1.Parameters.AddWithValue("@rid", rid);
                    connection.Open();
                    await cmd1.ExecuteNonQueryAsync();


                }
            }
            catch (Exception ex) { }
        }

        public async Task AddQty(long rid, decimal qty)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
             configuration.GetConnectionString("myconnectionstring")
          ))
                {


                    SqlCommand cmd1 = new SqlCommand("update tbl_froshtn_wasl set qty=qty+@qty where rid=@rid and print_order=0 and print_bill=0 and (qty+@qty)>=0 ", connection);
                    cmd1.Parameters.AddWithValue("@qty", qty);
                    cmd1.Parameters.AddWithValue("@rid", rid);
                    connection.Open();
                    await cmd1.ExecuteNonQueryAsync();

                }
            }
            catch (Exception ex) { }
        }

        public async Task ChangeTable(string old_table, string new_table)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(
        configuration.GetConnectionString("myconnectionstring")
     ))
                {
                    SqlCommand cmd = new SqlCommand("update [dbo].[tbl_froshtn_wasl] set [mez]=@new_table where [mez]=@old_table", connection);
                    cmd.Parameters.AddWithValue("@old_table", old_table);
                    cmd.Parameters.AddWithValue("@new_table", new_table);
                    connection.Open();
                    await cmd.ExecuteNonQueryAsync();

                }

            }
            catch (Exception ex) { }
        }

        public async Task DeleteRecord(Item item)
        {

            try
            {
                await httpClient.PostAsJsonAsync("api/DeleteOrder", item);
            }
            catch (Exception ex) { }

        }


        public async Task<List<Item>> GetItems(string menu)
        {
            try
            {
                List<Item> items = new List<Item>();
                using (SqlConnection connection = new SqlConnection(
               configuration.GetConnectionString("myconnectionstring")
            ))
                {
                    SqlCommand cmd = new SqlCommand("select [item_id],[item_type],[item_name],[price],[item_location] from [dbo].[tbl_xwardnakan] where item_id not in(0,1,-1) and status=1 and item_type = @item_type", connection);
                    cmd.Parameters.AddWithValue("@item_type", menu);
                    cmd.Connection.Open();
                    SqlDataReader rs = await cmd.ExecuteReaderAsync();
                    int i = 0;
                    while (rs.Read())
                    {
                        items.Add(new Item { id = Convert.ToInt32(rs.GetValue(0).ToString()), name = rs.GetValue(2).ToString() });


                        i++;

                    }
                }
                return items;


            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<string>> GetMenus()
        {
            List<string> menus = new List<string>();
            try
            {


                using (SqlConnection connection = new SqlConnection(
                  configuration.GetConnectionString("myconnectionstring")
               ))
                {
                    SqlCommand cmd = new SqlCommand("sp_tbl_xwardnakan_yes_menu", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection.Open();
                    SqlDataReader rs = await cmd.ExecuteReaderAsync();
                    int i = 0;
                    while (rs.Read())
                    {
                        menus.Add(rs.GetValue(0).ToString());
                        i++;







                    }
                }
                return menus;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<List<Item>> GetTable(string table_number)
        {
            List<Item> table_items = new List<Item>();
            try
            {
                using (SqlConnection connection = new SqlConnection(
                configuration.GetConnectionString("myconnectionstring")
             ))
                {

                    SqlCommand cmd = new SqlCommand("sp_tbl_froshtn_wasl_mez", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mez", table_number);
                    cmd.Connection.Open();
                    SqlDataReader rs = await cmd.ExecuteReaderAsync();
                    int i = 0;
                    while (rs.Read())
                    {
                        table_items.Add(new Item
                        {
                            rid = Convert.ToInt64(rs["rid"].ToString()),
                            id = Convert.ToInt32(rs["item_id"].ToString()),
                            name = rs["item_name"].ToString(),
                            qty = Convert.ToDecimal(rs["qty"].ToString()),
                            uname = rs["uname"].ToString(),
                            note = rs["note"].ToString(),
                            O = Convert.ToBoolean(rs["print_order"].ToString()),
                            P= Convert.ToBoolean(rs["print_bill"].ToString()),
                            person_id = rs["person_id"].ToString()
                        });
                      

                        i++;

                    }
                    return table_items;
                }



            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task Printhelp(Item item)
        {
            try
            {
                await httpClient.PostAsJsonAsync("api/PrintHelp", item);
            }
            catch (Exception ex) { }
        }

        public async Task PrintOrder(Item item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(
              configuration.GetConnectionString("myconnectionstring")
           ))
                {
                    string sql = "select item_location,count(*) from Q_froshtn_wasl where mez='" + item.table_number + "' and print_order=0 group by item_location";


                    SqlCommand cmd = new SqlCommand(sql, connection);
                    connection.Open();
                    SqlDataReader rs = await cmd.ExecuteReaderAsync();
                    int x = 0;
                    while (rs.Read())
                    {
                        if (int.Parse(rs.GetValue(1).ToString()) > 0)
                        {
                            if (rs.GetValue(0).ToString() == "Bar") { await httpClient.PostAsJsonAsync("api/PrintOrder", new Item() { table_number = item.table_number, location = "Bar" }); }
                            else if (rs.GetValue(0).ToString() == "FastFood") { await httpClient.PostAsJsonAsync("api/PrintOrder", new Item() { table_number = item.table_number, location = "FastFood" }); }
                            else if (rs.GetValue(0).ToString() == "Nergala") { await httpClient.PostAsJsonAsync("api/PrintOrder", new Item() { table_number = item.table_number, location = "Nergala" }); }
                            else if (rs.GetValue(0).ToString() == "Barbque") { await httpClient.PostAsJsonAsync("api/PrintOrder", new Item() { table_number = item.table_number, location = "Barbque" }); }
                            else if (rs.GetValue(0).ToString() == "Pizza") { await httpClient.PostAsJsonAsync("api/PrintOrder", new Item() { table_number = item.table_number, location = "Pizza" }); }
                            else if (rs.GetValue(0).ToString() == "Salad") { await httpClient.PostAsJsonAsync("api/PrintOrder", new Item() { table_number = item.table_number, location = "Salad" }); }
                            x = 1;
                        }
                    }
                    rs.Close();
                    if (x == 1)
                    {

                        SqlCommand cmd1 = new SqlCommand("sp_tbl_froshtn_wasl_mez_after_print_order", connection);
                        cmd1.CommandType = CommandType.StoredProcedure;
                        cmd1.Parameters.AddWithValue("@mez", item.table_number);
                        await cmd1.ExecuteNonQueryAsync();


                    }
                }
            }

            catch (Exception ex) { }
        }

        public async Task PrintTotal(Item item)
        {
            try
            {
                await httpClient.PostAsJsonAsync("api/PrintTotal", item);
            }
            catch (Exception ex) { }


        }


        public async Task SaveItem(Item item)
        {
            try
            {


                using (SqlConnection connection = new SqlConnection(
                  configuration.GetConnectionString("myconnectionstring")
               ))
                {
                    SqlCommand cmd = new SqlCommand("sp_insert_item", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@item_id", item.id);
                    cmd.Parameters.AddWithValue("@mez", item.table_number);
                    cmd.Parameters.AddWithValue("@qty", item.qty);
                    cmd.Parameters.AddWithValue("@insert_by", item.uid);
                    cmd.Parameters.AddWithValue("@note", item.note);
                    cmd.Parameters.AddWithValue("@person_id", item.person_id);
                    cmd.Connection.Open();
                    await cmd.ExecuteNonQueryAsync();



                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
