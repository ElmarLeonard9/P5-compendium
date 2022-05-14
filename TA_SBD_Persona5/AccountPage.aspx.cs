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
    public partial class AccountPage : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                DataShow();
            }
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

        public void DataShow()
        {
            cmd.CommandText = "Select * from UserLogin where Is_Delete = 0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewUser.DataSource = ds;
            GridViewUser.DataBind();
            con.Close();
        }

        protected void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            string password = ToSHA256(txtpasswd.Text);
            dt = new DataTable();
            cmd.CommandText = "Update UserLogin set Passwd='" + password + "' WHERE Id_User = '" + txtUserLogin.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnAccountDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "delete from UserLogin where Id_User = " + txtUserLogin.Text + ";";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("LoginPage.aspx");
        }
    }
}