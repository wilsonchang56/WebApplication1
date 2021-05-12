using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test3 : System.Web.UI.Page
    {
        static int ct = 60;
        static string lines = "";
      
       
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }
        protected void Button_Click(object sender, ImageClickEventArgs e)
        {
            int user = 0;
            if (sender == ImageButton1)
            {
                user = 1;
                userResult.Text = "玩家出剪刀";
            }
            else if (sender == ImageButton2)
            {
                user = 2;
                userResult.Text = "玩家出石頭";
            }
            else if (sender == ImageButton3)
            {
                user = 3;
                userResult.Text = "玩家出布";
            }

            Random rnd = new Random();
            int computer = rnd.Next(1, 4);
            if (computer == 1)
            {
                computerResult.Text = "電腦出剪刀";
                computerImage.ImageUrl = "~/pic/scissors.png";
            }
            else if (computer == 2)
            {
                computerResult.Text = "電腦出石頭";
                computerImage.ImageUrl = "~/pic/stone.png";
            }
            else if (computer == 3)
            {
                computerResult.Text = "電腦出布";
                computerImage.ImageUrl = "~/pic/paper.png";
            }


            if ((user == 1 && computer == 3) ||
                (user == 2 && computer == 1) ||
                (user == 3 && computer == 2))
                final.Text = "玩家贏了";
            else if ((user == 1 && computer == 2)
                || (user == 2 && computer == 3)
                || (user == 3 && computer == 1))
                final.Text = "玩家輸了";
            else
                final.Text = "平手";
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("test2");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
        }
    

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            lines = TextBox1.Text;
           
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           
        }

        protected void Send_Click(object sender, EventArgs e)
        {
            Application["messageResult"] = Application["messageResult"] + Session["userN"].ToString()+":"+lines+"<br>";
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            ct--;
           /* Label1.Text = "倒數計時" + ct.ToString();
            */
            if (Application["messageResult"] != null)
            {
                Label2.Text = Application["messageResult"].ToString();
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}