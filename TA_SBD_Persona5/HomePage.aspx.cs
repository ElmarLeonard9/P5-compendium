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
    public partial class HomePage : System.Web.UI.Page
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
            cmd.CommandText = "SELECT c.Race, c.Lvl, c.Name, b.St, b.Ma, b.En, b.Ag, b.Lu, a.Phys, a.Gun, a.Fire, a.Ice, a.Elec, a.Wind, a.Psy, a.Nuclear, a.Bless, a.Curse " +
                "FROM Demon c INNER JOIN Stat b ON c.Id_Stat = b.Id_Stat INNER JOIN Resistance a on c.Id_Resistance = a.Id_Resistance WHERE c.Is_Delete = 0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = ds;
            GridViewJoin.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT c.Race, c.Lvl, c.Name, b.St, b.Ma, b.En, b.Ag, b.Lu, a.Phys, a.Gun, a.Fire, a.Ice, a.Elec, a.Wind, a.Psy, a.Nuclear, a.Bless, a.Curse " +
                "FROM Demon c INNER JOIN Stat b ON c.Id_Stat = b.id_Stat INNER JOIN Resistance a on c.Id_Resistance = a.Id_Resistance WHERE c.Is_Delete = 0 AND c.Name LIKE '%" + txtMomon.Text.ToString() + "%'";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = dt;
            GridViewJoin.DataBind();
        }

        protected void btnSortRace_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT c.Race, c.Lvl, c.Name, b.St, b.Ma, b.En, b.Ag, b.Lu, a.Phys, a.Gun, a.Fire, a.Ice, a.Elec, a.Wind, a.Psy, a.Nuclear, a.Bless, a.Curse " +
               "FROM Demon c INNER JOIN Stat b ON c.Id_Stat = b.id_Stat INNER JOIN Resistance a on c.Id_Resistance = a.Id_Resistance WHERE c.Is_Delete = 0 ORDER BY c.Race";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = dt;
            GridViewJoin.DataBind();
        }

        protected void btnSortLevel_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT c.Race, c.Lvl, c.Name, b.St, b.Ma, b.En, b.Ag, b.Lu, a.Phys, a.Gun, a.Fire, a.Ice, a.Elec, a.Wind, a.Psy, a.Nuclear, a.Bless, a.Curse " +
               "FROM Demon c INNER JOIN Stat b ON c.Id_Stat = b.id_Stat INNER JOIN Resistance a on c.Id_Resistance = a.Id_Resistance WHERE c.Is_Delete = 0 ORDER BY c.Lvl";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = dt;
            GridViewJoin.DataBind();
        }

        protected void btnSortName_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "SELECT c.Race, c.Lvl, c.Name, b.St, b.Ma, b.En, b.Ag, b.Lu, a.Phys, a.Gun, a.Fire, a.Ice, a.Elec, a.Wind, a.Psy, a.Nuclear, a.Bless, a.Curse " +
               "FROM Demon c INNER JOIN Stat b ON c.Id_Stat = b.id_Stat INNER JOIN Resistance a on c.Id_Resistance = a.Id_Resistance WHERE c.Is_Delete = 0 ORDER BY c.Name";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            GridViewJoin.DataSource = dt;
            GridViewJoin.DataBind();
        }

        protected void btnSortReset_Click(object sender, EventArgs e)
        {
            DataShow();
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("LoginPage.aspx");
        }
    }
}