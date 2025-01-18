using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateTech
{
    public partial class NewAccount : Form
    {
        private bool enabled = false;
        private bool see = false;
        public NewAccount()
        {
            InitializeComponent();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            if (enabled == false)    // Enables the calender
            {
                calender.Visible = true;
                calender.Enabled = true;
                btnCalender.Text = "Disable Calender";
                enabled = true;
            }
            else                     // Disables the calender
            {
                calender.Visible = false;
                calender.Enabled = false;
                btnCalender.Text = "Enable Calender";
                enabled = false;
            }
        }

        private void calender_ValueChanged(object sender, EventArgs e)
        {
            txtBirthDate.Text = calender.Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to return without completing the sign-up process?", "Warning Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new frmHome().Show();
            }
            else
            {
                MessageBox.Show("Your account application details are still pending.", "Abort Confirmed");
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(!IsAllLetters(txtName.Text))
            {
                MessageBox.Show("Error, Your Name cannot consist of numbers or other characters.Please include letters only in the name field", "Data Notification");
                txtName.Focus();
                return;
            }
            if (!IsAllLetters(txtSurname.Text))
            {
                MessageBox.Show("Error, Your Surname cannot consist of numbers or other characters.Please include letters only in the name field", "Data Notification");
                txtSurname.Focus();
                return;
            }
            if (!IsEmailValid(txtemail.Text)) // checks if the email is valid
            {
                MessageBox.Show("Error, Your email address is invalid. Please retype a correct email address.", "Data Notification");
                txtSurname.Focus();
                return;
            }
            if (!IsEmailVerified(txtemail.Text))   // The email is not verified.
                return;

            if (txtName.Text == "" || txtSurname.Text == "" || txtpassword.Text == "" || txtemail.Text == "" || txtBirthDate.Text == "")
            {
                MessageBox.Show("Error, Please complete all fields before submitting your account application.", "Warning");
            }
            else // Password Validation begins here so brace yourself, it's a mess 
            {
                if (txtpassword.TextLength < 8)  // 8 character password
                {
                    MessageBox.Show("Error, Your password is too short.Please have an 8 or more character password.", "Data Notification");
                    txtpassword.Focus();
                    return;
                }

                bool letters = IsAllLetters(txtpassword.Text);
                bool numbers = IsAllNumbers(txtpassword.Text); 
                bool specialchar = IsOnlyLettersAndNumbers(txtpassword.Text);
         
                if (letters)
                {
                    txtpassword.Focus(); // Sets the password text box to being highlighted/ focused on 
                    MessageBox.Show("Error, Your password does not contain numbers. Please include letters,numbers and special characters(@,#,$,%) within your password.", "Data Notification");
                    return;
                }
                else
                    if (numbers)
                {
                    MessageBox.Show("Error, Your password does not contain letters. Please use a password with numbers, special characters(@,#,$,%) as well as letters.", "Data Notification");
                    txtpassword.Focus();
                    return;
                }
                else
                if (specialchar)
                {
                    MessageBox.Show("Error, Your password does not contain special characters. Please use a password with numbers,special characters(@,#,$,%) as well as letters.", "Data Notification");
                    txtpassword.Focus();
                    return;
                }
                

            }
        }
        public static bool IsAllLetters(string password)
        {
            foreach(char c in password)   // Checks if the password is only letters 
            {
                if (!Char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsAllNumbers(string password)  // Checks if the password is only numbers
        {
            foreach(char c in password)
            {
                if(!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsOnlyLettersAndNumbers(string password)  // Checks if the password has only letters and numbers, no special characters (@,#,$,%)
        {
            foreach (char c in password)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsEmailValid(string email)  // Checks if the email has only letters and numbers, as well as @ or .
        {
            foreach (char c in email)
            {
                if (!Char.IsLetterOrDigit(c) && c!='@'&&c!='.')
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsEmailVerified(string email)  // Checks if the email has only letters and numbers, as well as @ or .
        {
            int letters = 0;
            int at = 0;
            int period = 0;
            int numbers = 0;
            foreach (char c in email)
            {
                if (Char.IsLetter(c))
                {
                    ++letters;
                }
                if(c =='@')
                {
                    ++at;
                }
                if (c == '.')
                {
                    ++period;
                }
                else
                    ++numbers;
            }
            if(letters==0) // No letters in email
            {
                MessageBox.Show("Error, Your email does not contain letters.Please retype your email correctly.", "Data Notification");
                return false;
            }
            if (at!=1||period!=1)  // No period or at, email standards conflict
            {
                MessageBox.Show("Error, Your email is not valid.Please retype your email correctly.", "Data Notification");
                return false;
            }
            return true;
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

        private void NewAccount_MouseMove(object sender, MouseEventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLocalTime().ToShortTimeString(); // Changes the time
        }
    }
}
