using System;
using System.Drawing;
using System.Windows.Forms;




namespace CTS_Application
{
    public partial class Subscribers : Form
    {
        public Subscribers()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Skriver informasjon fra tekstboksene i frmSub til databasen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSubmit_Click(object sender, EventArgs e)
        {
            string username;
            string firstname;
            string lastname;
            int number;
            string email;
            try
            {
                username = txtUsername.Text;
                firstname = txtFirstName.Text;
                lastname = txtLastName.Text;
                number = Convert.ToInt32(txtNumber.Text);
                email = txtMail.Text;

                DbWrite dbWrite = new DbWrite();
                dbWrite.InsertIntoUsers(username, firstname, lastname, email, number); //Sender informasjonen fra variablene til metoden dbWrite.InsertIntoUsers.
                usersTableAdapter.Fill(ctsDataSetUsers.users); //Oppdaterer GridView.
                lblMessage.Text = "Transfer Succesful"; //Informasjon til brukeren at spørringen var en suksess.
                lblMessage.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Failure in doing operation";
                lblMessage.ForeColor = Color.Red;
                MessageBox.Show("There is a missmatch in your input\r\r\nCheck that your input is correct (telephonenumbers only consisting of digits)\r\r\n" + ex.Message);
            }
        }

        //Oppdaterer GridView ved å oppdatere DataSetUsers.Users og fylle dette inn i usersTableAdapter.
        private void frmSub_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'ctsDataSetUsers.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ctsDataSetUsers.users);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Fill(ctsDataSetUsers.users);
            lblMessage.Text = "Table Updated";
            lblMessage.ForeColor = Color.Green;
        }

        /// <summary>
        /// Sletter all inofrmasjon i tekstboksene i frmSub
        /// </summary>
        /// <param name="conConCol"></param>
        private void ClearTextBoxes(Control.ControlCollection conConCol)
        {
            //Source:
            //http://www.codeproject.com/Questions/567848/ClearplusallplustextboxplusinplusC
            //Checks all textboxes for text and deletes it.
            foreach (Control ctrl in conConCol)
            {
                TextBox txtBox = ctrl as TextBox;
                if (txtBox != null)
                    txtBox.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }
        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }




    }
}
