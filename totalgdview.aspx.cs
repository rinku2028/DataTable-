using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace totalgrid
{
    public partial class totalgdview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(!IsPostBack)
            {
                DataLoad();
    }
}

    public void DataLoad()
    {
        DataTable dt = new DataTable();
        dt.Clear();
        dt.Columns.AddRange(new DataColumn[4] { new DataColumn("ID", typeof(int)), new DataColumn("Name", typeof(string)), new DataColumn("Branch", typeof(string)), new DataColumn("Salary", typeof(int)) });
        dt.Rows.Add("001", "Sharron Sharma", "Delhi", "50000");
        dt.Rows.Add("002", "Prakirti Rahul", "Chennai", "60000");
        dt.Rows.Add("003", "Nikh Sharma", "Delhi", "50000");
        dt.Rows.Add("004", "Sweta Tiwari", "Goa", "70000");
        dt.Rows.Add("005", "Suman Burma", "Delhi", "40000");
        dt.Rows.Add("006", "Ankit Niraula", "Delhi", "40000");
        dt.Rows.Add("007", "Suresh Devgan", "Goa", "55000");
        dt.Rows.Add("008", "Ajay Sharma", "Rajasthan", "70000");
        dt.Rows.Add("009", "Pooja Patel", "Delhi", "80000");
        dt.Rows.Add("010", "Pooja Vedi", "Delhi", "90000");
        gdview1.DataSource = dt;
        gdview1.DataBind();
        gdview1.FooterRow.Cells[2].Text = "TOTAL";
        gdview1.FooterRow.Cells[2].Font.Bold = true;
        int total = dt.AsEnumerable().Sum(row => row.Field<Int32>(dt.Columns[3].ToString()));
        gdview1.FooterRow.Cells[3].Text = total.ToString();


    }

    protected void gdview1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (Convert.ToInt32(e.Row.Cells[3].Text) > 50000)
            {
                    e.Row.BackColor = Color.DarkBlue;
            }
        }
    }


    }
}