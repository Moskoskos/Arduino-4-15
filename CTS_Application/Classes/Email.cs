using System;
using System.Net.Mail;
using System.Windows.Forms;


namespace CTS_Application
{
    class Email
    {
        private SmtpClient client;
        private MailMessage message;
        private string from;

        public Email()
        {
            from = "ardumailen@gmail.com"; //Vil være systemmailen til firmaet som leverer produktet. feks. alarm.ctms@<InsertCompanyName>.no
            client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential(from, "fluefiske");
            client.EnableSsl = true;
        }
        /// <summary>
        /// Sender mail med feilmelding til bruker.
        /// </summary>
        /// <param name="body1">Alarm-teksten</param>
        public void SendMessage(string body1)
        {
            DbRead dbRead = new DbRead();
            string body = body1;
            string subject1 = "Alarm fra CTS";
            //Then get the number of rows in the table to iterate IDs
            int numOfRows = Convert.ToInt32(dbRead.GetTotalRow());
            //For hver unike ID i databasen, send en mail.
            for (int i = 1; i <= numOfRows; i++)
            {
                string userId = dbRead.GetEmail(i);

                if (userId.Length > 0) //Kjør kun hvis det finnes innhold.
                {
                    try
                    {
                        message = new MailMessage(from, userId, subject1, body);
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }





}
