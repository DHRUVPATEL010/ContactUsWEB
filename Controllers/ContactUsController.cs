
using Microsoft.AspNetCore.Mvc;
using Web1.Models;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Web1.Controllers
{
    public class ContactUsController : Controller
    {
        private IConfiguration _configuration;

        public ContactUsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult AddData(ContactUs model)
            {

            var myHttpClient = new HttpClient();
            myHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var apiURL = _configuration.GetValue<string>("apiURL");
            var response = myHttpClient.PostAsJsonAsync(apiURL, model).Result;

            return View("ContactUs");

            //if (ModelState.IsValid)
            //{
            //    using (SqlConnection _conn = new SqlConnection())
            //    {
            //        _conn.ConnectionString = "server=acceptagreement.com;Database=testDB_Jigar;User Id=sa;Password=Fall1130836!";
            //        _conn.Open();

            //        SqlCommand command = _conn.CreateCommand();
            //        command.CommandText = "INSERT INTO ContactUs (FirstName, LastName, Phone, Mobile, ReasonForContact, CompanyName, Email, Comment, Inactive, Status) " +
            //                              "VALUES (@FirstName, @LastName, @Phone, @Mobile, @ReasonForContact, @CompanyName, @Email, @Comment, @Inactive, @Status)";

            //        command.Parameters.AddWithValue("@FirstName", model.FirstName);
            //        command.Parameters.AddWithValue("@LastName", model.LastName);
            //        command.Parameters.AddWithValue("@Phone", model.Phone);
            //        command.Parameters.AddWithValue("@Mobile", model.Mobile);
            //        command.Parameters.AddWithValue("@ReasonForContact", model.ReasonForContact);
            //        command.Parameters.AddWithValue("@CompanyName", model.CompanyName);
            //        command.Parameters.AddWithValue("@Email", model.Email);
            //        command.Parameters.AddWithValue("@Comment", model.Comment);
            //        command.Parameters.AddWithValue("@Inactive", false);
            //        command.Parameters.AddWithValue("@Status", 'O' );

            //        Int32 rowsAdded = command.ExecuteNonQuery();
            //        Console.WriteLine(rowsAdded + " rows added!");

            //        _conn.Close();
            //    }

            //    return View();
            //}
            //else
            //{
            //    return View(model);
            //}

        }
            //public IActionResult AddData(ContactUs contacts)
            //{
            //    var name = contacts;

            //    var AppName = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("appsettings")["apiURL"];

            //    return View("ContactUs");
            //}



            public IActionResult Dhruv()
            {
                return View("ContactUs");
            }

            public IActionResult Index()
            {
                return View("ContactUs");
            }

        }
    }
