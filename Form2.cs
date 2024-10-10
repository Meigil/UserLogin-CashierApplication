using System;
using System.Windows.Forms;
using CashierApplication;

namespace CashierApplication
{
    public partial class Form2 : Form
    {
        Cashier cashier = new Cashier("Meigilverzy Basa", "meiyo", "lamiglods", "Finance");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (cashier.ValidateLogin(inputUsername, inputPassword))
            {
                MessageBox.Show($"Welcome {cashier.GetFullName()} of {cashier.GetDepartment()}");
                Form1 purchaseForm = new Form1();
                purchaseForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
    public abstract class UserAccount
    {
        
        private string fullName;
        private string userName;
        private string password;

        
        public UserAccount(string fullName, string userName, string password)
        {
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
        }

  
        public bool ValidateLogin(string inputUserName, string inputPassword)
        {
            return (this.userName == inputUserName && this.password == inputPassword);
        }

        
        public string GetFullName()
        {
            return this.fullName;
        }
    }
    public class Cashier : UserAccount
    {
        
        private string department;

        public Cashier(string fullName, string userName, string password, string department)
            : base(fullName, userName, password)
        {
            this.department = department;
        }

       
        public string GetDepartment()
        {
            return this.department;
        }
    }

}
