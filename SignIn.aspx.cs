using System;
using System.Data.SqlClient;
using HotelBooking;
namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected virtual void Submit_Clicked(object sender, EventArgs e)
        {
            User user = new User(userId.Text, password.Text);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = KOWSALYA\SQLSERVER; Initial Catalog = master; User ID = sa; Password = gowtham");
            LogInController logInController = new LogInController();
            int retRows = logInController.LogIn(user, sqlConnection);
            if (retRows == 0)
            {
                Response.Write("Incorrect Username or Password");
            }
            else
            {
                string message = "Logged in successfully.";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
            }
        }
    }
}