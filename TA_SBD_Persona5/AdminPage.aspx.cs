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
    public partial class AdminPage : System.Web.UI.Page
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
            cmd.CommandText = "Select * from Demon where Is_Delete = 0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewDemon.DataSource = ds;
            GridViewDemon.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select * from Stat where Is_Delete = 0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewStat.DataSource = ds;
            GridViewStat.DataBind();
            ds = new DataSet();
            cmd.CommandText = "Select * from Resistance where Is_Delete = 0";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridViewRes.DataSource = ds;
            GridViewRes.DataBind();
            con.Close();
        }

        protected void btnAddDemon_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Demon(Id_Demon, Race, Lvl, Name, Id_Stat, Id_Resistance, Is_Delete)values('" + txtIdDemon.Text + "', '" + txtRace.Text.ToString() + "', '" + txtLvl.Text + "', '" + txtNama.Text.ToString() + "', '" + txtIdStat.Text + "', '" + txtIdRes.Text + "',0)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDeleteDemon_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Demon Set Is_Delete = 1 where Id_Demon='" + txtIdDemon.Text + "'";
            cmd.Connection = con; 
            cmd.ExecuteNonQuery(); 
            DataShow();
        }

        protected void btnUpdateDemon_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Demon set Race='" + txtRace.Text.ToString() + "', Lvl='" + txtLvl.Text + "', Name='" + txtNama.Text.ToString() + 
                "', Id_Stat = '" + txtIdStat.Text + "', Id_Resistance = '" + txtIdRes.Text + "' WHERE Id_Demon = '" + txtIdDemon.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnAddStat_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Stat(Id_Stat, St, Ma, En, Ag, Lu, Is_Delete)values('" + txtIdStats.Text + "', '" +
                txtSt.Text + "', '" + txtMa.Text + "', '" + txtEn.Text + "', '" + txtAg.Text + "', '" + txtLu.Text + "', 0)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDeleteStat_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Stat Set Is_Delete = 1 where Id_Stat='" + txtIdStats.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnUpdateStat_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Stat set St='" + txtSt.Text + "', Ma='" + txtMa.Text + "', En='" + txtEn.Text + "', Ag= '" + txtAg.Text 
                + "', Lu= '" + txtLu.Text + "' WHERE Id_Stat = '" + txtIdStats.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnAddRes_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert Into Resistance(Id_Resistance, Phys, Gun, Fire, Ice, Elec, Wind, Psy, Nuclear, Bless, Curse, Is_Delete)values('" + 
                txtIdResist.Text + "', '" + txtPhys.Text.ToString() + "', '" + txtGun.Text.ToString() + "', '" + txtFire.Text.ToString() + "', '" + 
                txtIce.Text.ToString() + "', '" + txtElec.Text.ToString() + "', '" + txtWind.Text.ToString() + "', '" + txtPsy.Text.ToString() + "', '" +
                txtNuclear.Text.ToString() + "', '" + txtBless.Text.ToString() + "', '" + txtCurse.Text.ToString() + "', 0)";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDeleteRes_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Resistance Set Is_Delete = 1 where Id_Resistance='" + txtIdResist.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnUpdateRes_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Update Resistance set Phys='" + txtPhys.Text.ToString() + "', Gun='" + txtGun.Text.ToString() + "', Fire='" + txtFire.Text.ToString() 
                + "', Ice= '" + txtIce.Text.ToString() + "', Elec= '" + txtElec.Text.ToString() + "', Wind= '" + txtWind.Text.ToString() + "', Psy= '" + txtPsy.Text.ToString()
                + "', Nuclear= '" + txtNuclear.Text.ToString() + "', Bless= '" + txtBless.Text.ToString() + "', Curse= '" + txtCurse.Text.ToString() + "' WHERE Id_Resistance = '" + txtIdResist.Text + "'";
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