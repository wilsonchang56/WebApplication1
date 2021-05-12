using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要描述
    /// </summary>
    public class Handler1 : IHttpHandler,IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Session["Myfilee"] !=null)
            {
                HttpPostedFile myfile = (HttpPostedFile)context.Session["myfile"];
                int myfile_Lenth = myfile.ContentLength;
                byte[] mydata = new byte[myfile_Lenth];
                myfile.InputStream.Read(mydata, 0, myfile_Lenth);
                context.Response.Clear();
                context.Response.ContentType = "image/jpeg";
                context.Response.BinaryWrite(mydata);


            }
            context.Response.ContentType = "text/plain";
            context.Response.Write(context.Session["userN"].ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}