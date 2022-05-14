using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TA_SBD_Persona5
{
    public partial class DeletePage : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["id"].ToString();
            con.ConnectionString = "Data Source=LAPTOP-36SFCLPQ\\SQLEXPRESS;Initial Catalog=TA_SBD; Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from Demon where Is_Delete = 1";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewDemon.DataSource = ds;
            GridViewDemon.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select * from Stat where Is_Delete = 1";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewStat.DataSource = ds;
            GridViewStat.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select * from Resistance where Is_Delete = 1";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewRes.DataSource = ds;
            GridViewRes.DataBind();
        }

        protected void btnRestoreData_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update " + txtTabel.Text.ToString() + " Set Is_Delete = 0 where Id_" + txtTabel.Text.ToString() + "=" + txtIdTabel.Text + ";";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDeleteData_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "delete from " + txtTabel.Text.ToString() + " where Id_" + txtTabel.Text.ToString() + "=" + txtIdTabel.Text + ";";
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