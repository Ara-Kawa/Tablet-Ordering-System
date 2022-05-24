using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

using System.Web;
using System.Web.UI;
using ReportService.Models;
using System.Data.SqlClient;
using System.Data;

namespace ReportService.Controllers
{
    public class ValuesController : ApiController
    {
        
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        [Route ("api/PrintTotal")]// GET api/values/5
        [HttpPost]
        public string PrintTotal([FromBody] Item item)
        {
            try
            {
                LocalReport localReport = new LocalReport();
                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[] {
                new Microsoft.Reporting.WinForms.ReportParameter("table", item.table_number.ToString())
               

        };
                ReportParameter[] p1 = p;


                Task.Run(() =>
                {
                    localReport.ReportPath = System.Web.Hosting.HostingEnvironment.MapPath("~/total.rdlc");
                    localReport.SetParameters(p1);
                    localReport.PrintToPrinter("POS80");
                });
               
            }
            catch (Exception ex)
            {

            }
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Route("api/PrintHelp")]
        public void PrintHelp([FromBody]Item item)
        {
            try
            {
                LocalReport localReport = new LocalReport();

                Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[] {
                new Microsoft.Reporting.WinForms.ReportParameter("table", item.table_number.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("note",item.note)

        };
                ReportParameter[] p1 = p;

                Task.Run(() =>
                {
                    localReport.ReportPath = System.Web.Hosting.HostingEnvironment.MapPath("~/help.rdlc");
                    localReport.SetParameters(p1);
                    localReport.PrintToPrinter("POS80");
                });
              
            }
            catch (Exception ex)
            {

            }
        }

        [HttpPost]
        [Route("api/PrintOrder")]
        public void PrintOrder([FromBody]Item item)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection connection = new SqlConnection(
              System.Configuration.ConfigurationManager.
    ConnectionStrings["mycon"].ConnectionString)
         )
                {

                    SqlDataAdapter da = new SqlDataAdapter("sp_tbl_froshtn_wasl_mez_print_order", connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@mez", item.table_number);
                    da.SelectCommand.Parameters.AddWithValue("@item_location", item.location);
                   
                    da.Fill(dt);
                }
                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                LocalReport localReport = new LocalReport();

                localReport.ReportPath = System.Web.Hosting.HostingEnvironment.MapPath("~/print_order.rdlc");
                localReport.DataSources.Clear();
                localReport.DataSources.Add(rds);
                Task.Run(() =>
                {
                    localReport.PrintToPrinter(item.location);
                });
            }
            catch (Exception ex) { }
        }
        [HttpPost]
        [Route("api/DeleteOrder")]
        public void DeleteOrder([FromBody] Item item) {
            try
            {
                string rid = item.rid.ToString();
                string person = "";
                string item_name = "";
                string item_location = "";
                string qty = "";
                string note = " ";
                bool p = false;
                bool o = false;
                using (SqlConnection connection = new SqlConnection(
            System.Configuration.ConfigurationManager.
  ConnectionStrings["mycon"].ConnectionString)
       )
                {

                    SqlCommand cmd = new SqlCommand("select * from Q_froshtn_wasl where rid=@rid", connection);
                    cmd.Parameters.AddWithValue("@rid",rid);
                    connection.Open();
                    using (SqlDataReader rs = cmd.ExecuteReader())
                    {

                        while (rs.Read())
                        {
                            p = Convert.ToBoolean(rs["print_bill"].ToString());
                            o = Convert.ToBoolean(rs["print_order"].ToString());
                            item_location = rs["item_location"].ToString();
                            person = rs["person_id"].ToString();
                            item_name = rs["item_name"].ToString();
                            qty = rs["qty"].ToString();
                            if (rs["note"].ToString() == "") { }
                            else
                            {
                                note = rs["note"].ToString();
                            }


                        }
                    }
                } 
                string per = "";

                using (SqlConnection connection = new SqlConnection(
        System.Configuration.ConfigurationManager.
ConnectionStrings["mycon"].ConnectionString)
   )
                {
                 
                    SqlCommand cmd = new SqlCommand("select per from tbl_user where uname=@uname", connection);
                    cmd.Parameters.AddWithValue("@uname", item.uname);
                    connection.Open();
                    using (SqlDataReader rs = cmd.ExecuteReader())
                    {

                        while (rs.Read())
                        {
                            per = rs["per"].ToString();


                        }
                    }
                }
              


                Microsoft.Reporting.WinForms.ReportParameter[] rp = new Microsoft.Reporting.WinForms.ReportParameter[] {
                new Microsoft.Reporting.WinForms.ReportParameter("table",  item.table_number.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("user_name", item.uname),
                new Microsoft.Reporting.WinForms.ReportParameter("person", person),
                new Microsoft.Reporting.WinForms.ReportParameter("item_name", item_name),
                new Microsoft.Reporting.WinForms.ReportParameter("qty", qty),
                new Microsoft.Reporting.WinForms.ReportParameter("note", note)

        };
                ReportParameter[] p1 = rp;


                if (p == false && o == false) { delete_order(rid, o, item_location, p1, item.uid); }
                else if (per == "Administrator") { delete_order(rid, o, item_location, p1, item.uid); }
                else if (per == "Admin" && p == false) { delete_order(rid, o, item_location, p1, item.uid); }



            }
            catch (Exception ex) { }
        }
        void delete_order(string rid, bool print_order, string item_location, ReportParameter[] rp, int uid)
        {
            try
            {
                if (Convert.ToBoolean(print_order) == true)
                {
                    string p_name = "";
                    LocalReport localReport = new LocalReport();

                    if (item_location.ToLower() == "Bar".ToLower()) { p_name = "Bar"; }
                    else if (item_location.ToLower() == "FastFood".ToLower()) { p_name = "FastFood"; }
                    else if (item_location.ToLower() == "Nergala".ToLower()) { p_name = "Nergala"; }
                    else if (item_location.ToLower() == "Barbque".ToLower()) { p_name = "Barbque"; }
                    else if (item_location.ToLower() == "Pizza".ToLower()) { p_name = "Pizza"; }
                    else if (item_location.ToLower() == "Salad".ToLower()) { p_name = "Salad"; }


                    Task.Run(() =>
                    {
                        localReport.ReportPath = System.Web.Hosting.HostingEnvironment.MapPath("~/cancel_order.rdlc");
                        localReport.SetParameters(rp);
                        localReport.PrintToPrinter(p_name);
                    });

                }


                using (SqlConnection connection = new SqlConnection(
      System.Configuration.ConfigurationManager.
ConnectionStrings["mycon"].ConnectionString)
 )
                {
                    SqlCommand cmd = new SqlCommand("sp_delete_order_rid", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rid", rid);
                    cmd.Parameters.AddWithValue("@insert_by", uid.ToString());
                    cmd.Parameters.AddWithValue("@delete_date", Convert.ToDateTime(DateTime.Today.Date.ToString("dd/MM/yyyy")));
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
               
            }
            catch (Exception ex) { }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
