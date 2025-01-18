using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTech
{
    public partial class frmHome : Form
    {
        private bool see = false;
        public bool login = false;
        public ArrayList userList = new ArrayList(); // The array list that contains all current users
        public string logemail;   // Used to identify which acocunt is logged in currently
        public frmHome()
        {
            InitializeComponent();
           
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            ReadData();  //Acquires the user data from the respective file
            if (login)
            {
                
                new FoodCategory().Show();
                this.Close();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (validateUser())  // Credentials are correct 
            {
                if(cbxRemember.Checked)
                {
                   if(MessageBox.Show("As much as CreateIT adores our customers, Please be aware that using the Remember Me function will auto-log you in everytime you open the app on your device. This will leave your account vulnerable to unauthorised access if your device is not in your control. You can turn off this feature any time. Would you like to proceed?", "Sensitive Data Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        GetUser(txtemail.Text).Setsaved('Y');
                        this.Hide();
                        logemail = txtemail.Text;
                        MessageBox.Show($"Greetings {GetUser(txtemail.Text).Getaccountname()}, Please enjoy your browsing today😊.", "Welcome Message.");
                        txtemail.Clear();
                        txtpassword.Clear(); // ANNNND sensitive Data Gone 😀... well atleast here 
                        new FoodCategory().Show();
                        return;
                    }
                   else
                    {
                        cbxRemember.Checked = false;
                        MessageBox.Show("Revert complete. Do not worry, your data is our priority😎.", "Abort Confirmed");
                        return;
                    }
                 
                }
                new FoodCategory().Show();
                logemail = txtemail.Text;
                MessageBox.Show($"Greetings {GetUser(txtemail.Text).Getaccountname()}, Please enjoy your browsing today😊.","Welcome Message.");
                txtemail.Clear();
                txtpassword.Clear(); // ANNNND sensitive Data Gone 😀... well atleast here 
                this.Close();
            }
            else       // Credentials are incorrect
            {
                Console.Beep();
                MessageBox.Show("Invalid Login Credentials.Please Try Again.","Warning.",MessageBoxButtons.OKCancel);
            }
               
          
        }
        private bool validateUser() // User Authentication
        {
            bool password = false;
            bool email = false;
            here:
            if(txtemail.Text==null || txtpassword==null)
            {
                Console.Beep();
                MessageBox.Show("Error,Please fill in the required fields");
                goto here;
            }
            else
            {
                foreach( User user in userList)
                {
                    if(password&&email)
                    {
                        return true;
                    }
                    if(txtpassword.Text == user.Getpassword())
                    {
                        password = true;
                    }
                    if(txtemail.Text == user.Getemail())
                    {
                        email = true;
                    }
                }
                return false;
            }
        }
        public void ReadData()  // Acquiring data to be used by CreateIT
        {

            StreamReader sr = new StreamReader("CreateTech.txt");
            string line = sr.ReadLine();
            string[] lines;
            while (line != null)
            {
                lines = line.Split(',');
                string email = lines[0];
                string surname = lines[1];
                string name = lines[2];
                string accountname = lines[3];
                string password = lines[4];
                char saved = char.Parse(lines[5]);
                Object user = new User(email, surname, name, accountname, password,saved);
                userList.Add(user);
                if(saved=='Y') // This current user is logged in
                {
                    logemail = email;
                    login = true; // CreateIT will login with this email
                }
               line = sr.ReadLine();
            }
            sr.Close();
        }
        public User GetUser(string wanted)   // A method that is used to complete functionality related to the logged-in user
        {
            foreach(User user in userList)
            {
                if(wanted == user.Getemail())
                {
                    return user;
                }
            }
            return null;
        }

        private void eye_Click(object sender, EventArgs e)
        {
            if (!see) //enable view password feature 
            {
                txtpassword.UseSystemPasswordChar = false;
                eye.Image = Properties.Resources.closeeye;
                see = true;
            }
            else  // conceal the password 
            {
                txtpassword.UseSystemPasswordChar = true;
                eye.Image = Properties.Resources.eye;
                see = false;
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            new NewAccount().Show();
            this.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBackground_MouseMove(object sender, MouseEventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLocalTime().ToShortTimeString(); // Changes the time
        }
    }
    public class User  // Contains data about each current user
    {
        string email;
        string surname;
        string name;
        string accountname;
        string password;
        char saved;   // Used to check if the user needs to login next time or not
        public User(string email, string surname, string name, string accountname, string password, char saved)

        {
            this.email = email;
            this.surname = surname;
            this.name = name;
            this.accountname = accountname;
            this.password = password;
            this.saved = saved;
        }
        public string Getemail()
        {
            return email;
        }
        public string Getsurname()
        {
            return surname;
        }
        public string Getname()
        {
            return name;
        }
        public string Getaccountname()
        {
            return accountname;
        }
        public string Getpassword()
        {
            return password;
        }
        public char Getsaved()
        {
            return saved;
        }

        public void Setemail(string email)
        {
            this.email = email;
        }
        public void Setsurname(string surname)
        {
            this.surname = surname;
        }
        public void Setname(string name)
        {
            this.name = name;
        }
        public void Setaccountname(string accountname)
        {
            this.accountname = accountname;
        }
        public void Setpassword(string password) // sensitive method
        {
            this.password = password;
        }
        public void Setsaved(char saved) //sensitive method
        {
            this.saved = saved;
        }
        
    }
}
