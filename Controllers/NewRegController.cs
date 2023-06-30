using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVC_reg_Application.Models;
using System.Configuration;
using System.IO;

namespace MVC_reg_Application.Controllers
{
    public class NewRegController : Controller
    {
        // GET: NewReg
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserClass uc,HttpPostedFileBase file)
        {
            string conn = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);
            string sqlquery = "insert into [dbo].[MVCregUser](Fname,Lname,Dob,Gender,Phonenumber,Email,Address,State,City,Username,Password,Cpassword,Uimg) values (@Fname,@Lname,@Dob,@Gender,@Phonenumber,@Email,@Address,@State,@City,@Usemame,@Password,@Cpassword,@Uimg)";
            SqlCommand cmd = new SqlCommand(sqlquery,sqlconn);
            
            sqlconn.Open();
            cmd.Parameters.AddWithValue("@Fname",uc.Fname);
            cmd.Parameters.AddWithValue("@Lname", uc.Lname);
            cmd.Parameters.AddWithValue("@Dob", uc.Dob);
            cmd.Parameters.AddWithValue("@Gender", uc.Gender);
            cmd.Parameters.AddWithValue("@Phonenumber", uc.Phonenumber);
            cmd.Parameters.AddWithValue("@Email", uc.Email);
            cmd.Parameters.AddWithValue("@Address", uc.Address);
            cmd.Parameters.AddWithValue("@State", uc.State);
            cmd.Parameters.AddWithValue("@City", uc.City);
            cmd.Parameters.AddWithValue("@Username", uc.Username);
            cmd.Parameters.AddWithValue("@Password", uc.Password);
            cmd.Parameters.AddWithValue("@Cpassword", uc.Cpassword);
            if(file!=null && file.ContentLength>0)
            {
                string filename = Path.GetFileName(file.FileName);
                string imgpath = Path.Combine(Server.MapPath("~/User-Image/"), filename);
                file.SaveAs(imgpath);
            }
            cmd.Parameters.AddWithValue("@Uimg", "~/User-Image/"+file.FileName);
            cmd.ExecuteNonQuery();
            sqlconn.Close();
            ViewData["Message"] = "User Record" + uc.Fname + "is saved successfully";
            return View();
        }
    }
}