using SEN371_Project.FunctionalAreas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371_Project
{
    public partial class frmLogin : Form
    {
      //  private Employee emp;
        public frmLogin()
        {
            InitializeComponent();
        /*    emp = new Employee
            {
                Username = "sampleUser",
                Salt = GenerateSalt(), // Generate a random salt for the user
                HashedPassword = HashPassword("samplePassword", GenerateSalt()) // Hash the password with the salt
            };*/
        }

        // Helper method to generate a random salt
        private static string GenerateSalt()
        {
            byte[] saltBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }
 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            clientMange obj = new clientMange();
            List<string> check = new List<string>();
            check.Add("CEO,Susan,Susanson,+278150523");
            check.Add("Driver,Bob,Susanson,+278130523");

            obj.BusinessClient("Premier", 2, "255 This street", "Gotham", "3333", check);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            /*bool isValid = emp.ValidateCredentials(username, password);

            if (isValid)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmApplication a = new frmApplication();
                a.Show();
                }
            else
            {
                MessageBox.Show("Invalid username or password. Login failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            this.Hide();
            frmApplication a = new frmApplication();
            a.Show();
            
        }
    }
  }
