using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logout"] != null && Convert.ToString(Session["logout"]) == "1")
            {
                Response.Redirect("test3");
            }
            if (!IsPostBack)
            {
                name.Text = "小";
                
                passwd.Text = "123456";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            /*userLabel.Text = Request.Form["user2"].ToString();

            string passcc = "";
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ordersConnectionString2"].ConnectionString;

            //new一個SqlConnection物件，是與資料庫連結的通道(其名為Connection)，以s_data內的連接字串連接所對應的資料庫。
            SqlConnection connection = new SqlConnection(s_data);

            string sqlcmd = "select * from account where account = "+"'"+Request.Form["user2"]+"'";

            //new一個SqlCommand告訴這個物件準備要執行什麼SQL指令
            SqlCommand Command = new SqlCommand(sqlcmd, connection);

            //與資料庫連接的通道開啟
            connection.Open();

            //new一個DataReader接取Execute所回傳的資料。
            SqlDataReader Reader = Command.ExecuteReader();

            //檢查是否有資料列
            if (Reader.HasRows)
            {
                //使用Read方法把資料讀進Reader，讓Reader一筆一筆順向指向資料列，並回傳是否成功。
                if (Reader.Read())
                {
                    //DataReader讀出欄位內資料的方式，通常也可寫Reader[0]、[1]...[N]代表第一個欄位到N個欄位。
                    passcc = Reader["password"].ToString();
                }
            }

            //關閉與資料庫連接的通道
            connection.Close();

            if (passwd.Text == passcc)
            {
               
                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                
                passwdLabel.Text = "密碼輸入錯誤";
            }

            */
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ordersConnectionString2"].ConnectionString;

           

            SqlConnection connection = new SqlConnection(s_data);

            connection.Open();

            string insertsql = $"insert into [account] (account,password) values(@account,@passwd)";

            SqlCommand Command = new SqlCommand(insertsql, connection);

            Command.Parameters.Add("@account", SqlDbType.NVarChar);
            Command.Parameters["@account"].Value = "acc";
            Command.Parameters.Add("@passwd", SqlDbType.NVarChar);
            Command.Parameters["@passwd"].Value = "123456";

            Command.ExecuteNonQuery();
            
            connection.Close();

            /*
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command);//從Command取得資料存入dataAdapter

            DataSet dataset = new DataSet();//創一個dataset的記憶體資料集

            dataAdapter.Fill(dataset);//將dataAdapter資料存入dataset

            foreach (DataRow datarow in dataset.Tables["選擇的資料表名稱"].Rows)
            {
                //每個資料列的內容
            }

            //新增一筆資料
            DataRow newRow = dataset.Tables["資料表名稱"].NewRow();
            newRow["id"] = 999;
            newRow["header"] = 111;
            dataset.Tables["資料表名稱"].Rows.Add(newRow);

            //移除一筆資料
            dataset.Tables["資料表名稱"].Rows.Remove(dataset.Tables["資料表名稱"].Rows[1]);

            //修改一筆資料
            DataRow[] rows = dataset.Tables["資料表名稱"].Select("id=1");
            if (rows.Length > 0)
            {
                rows[0]["id"] = 2;
            }
            */

        }
    }
}