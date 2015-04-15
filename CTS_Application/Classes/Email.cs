using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Media;
using System.Threading;

namespace CTS_Application
{
    class Email
    {
       private SmtpClient client;
       private MailMessage message;
       private string from;
        public Email()
        {
            //from = "arduino.ia2.4.15@gmail.com" PW=Arduino4.15;
            from = "prebenarduino@gmail.com";
            client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential(from, "arduino123");       
            client.EnableSsl = true;
         }

        public void SendMessage(string body1)
        {
            DbRead dbRead = new DbRead();
            string body = body1;
            string subject1 = "Alarm fra CTS";
            //Then get the number of rows in the table to iterate IDs
            int numOfRows = Convert.ToInt32(dbRead.GetTotalRow());
            //For each unique id in the table, send email.
            for (int i = 1; i <= numOfRows; i++)
            {
                try
                {
                    string userId = dbRead.GetEmail(i);
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
