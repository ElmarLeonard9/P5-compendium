using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace TA_SBD_Persona5
{
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=LAPTOP-36SFCLPQ\\SQLEXPRESS;Initial Catalog=TA_SBD; Integrated Security=True";
            con.Open();
        }

        public string ToSHA256(string value)
        {
            SHA256 sha256 = SHA256.Create();

            byte[] hashData = sha256.ComputeHash(Encoding.Default.GetBytes(value));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            return returnValue.ToString();
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Select * from UserLogin where Username=@username and Passwd=@password";
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", ToSHA256(txtPassword.Text));
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
    
                if (dt.Rows[0]["Id_UserRole"].ToString() == "1")
                {
                    Session["id"] = txtUsername.Text;
                    Response.Redirect("AdminPage.aspx");
                    Session.RemoveAll();
                }
                else if (dt.Rows[0]["Id_UserRole"].ToString() == "2")
                {
                    Session["id"] = txtUsername.Text;
                    Response.Redirect("HomePage.aspx");
                    Session.RemoveAll();
                }
            }
            else
            {
                Label1.Text = "Your username and Password is incorrect";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}