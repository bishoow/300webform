using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace _300webform
{
    public partial class databaes : System.Web.UI.Page
    {
        MySqlConnection conn;
        MySqlCommand command;

        protected void Submit_Click(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;PORT=4306;DATABASE=dotnet;UID=root;PASSWORD=;";
            conn = new MySqlConnection(connectionString);
            conn.Open();
            string Sql = "SELECT * FROM students WHERE RollNo = " + Name.Text;
            command = new MySqlCommand(Sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Response.Write("Name: " + dr["Name"] + "<br/>");
                    Response.Write("RegNo: " + dr["RegNo"] + "<br/>");
                    Response.Write("RollNo: " + dr["RollNo"] + "<br/>");
                    Response.Write("Result: " + dr["Result"] + "<br/>");
                    Response.Write("College: " + dr["College"] + "<br/>");
                    Response.Write("ExamHeld: " + dr["ExamHeld"] + "<br/>");
                }
            }
            conn.Close();
        }
    }
}