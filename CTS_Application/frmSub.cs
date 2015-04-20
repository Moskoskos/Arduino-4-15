using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Almost complete.
//Missing:
//Ability to delete entries in database
//Ability to modify entries in database
//
//
//
//
//YO YO YO!



namespace CTS_Application
{
    public partial class Subscribers : Form
    {
        public Subscribers()
        {
            InitializeComponent();
           // int num = dataGridView1.Rows.Count;
        
           
        }
        //Submits the input in the textboxes to the SQL database.
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
             
                //When using dbConnect.OpenConnection and dbConnect.CloseConnection it did not write to database. Wh?
                DbConnect dbConnect = new DbConnect();
                //Inserts the desierd input into the DbConnect method
                dbConnect.InsertIntoUsers(username, firstname, lastname, email, number);
                //After the query is ran and the connection is closed, retrieve rows and update the table.
                usersTableAdapter.Fill(ctsDataSetUsers.users);
                lblMessage.Text = "Transfer Succesful";
                lblMessage.ForeColor = Color.Green;
                
                
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Failure in doing operation";
                lblMessage.ForeColor = Color.Red;
                MessageBox.Show("There is a missmatch in your input\r\r\nCheck that your input is correct (telephonenumbers only consisting of digits)\r\r\n" + ex.Message);
            }
        }
        private void frmSub_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ctsDataSetUsers.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.ctsDataSetUsers.users);
            // TODO: This line of code loads data into the 'ctsDataSet.users' table. You can move, or remove it, as needed.
            // The data comes from the connection created to the MySql Server.
            //this.Location = new Point(1287, 0);
            this.usersTableAdapter.Fill(this.ctsDataSetUsers.users);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Fill(ctsDataSetUsers.users);
            lblMessage.Text = "Table Updated";
            lblMessage.ForeColor = Color.Green;
        }
        //THIS U NEED TO LEARN
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
