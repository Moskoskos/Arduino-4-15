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
           from = "arduino.ia2.4.15@gmail.com";
            client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential(from, "Arduino4.15");
            client.EnableSsl = true;
    }
        public Email()
        { }

        public void SendMessage(string to1, string subject1, string body1)
        {
            message = new MailMessage(from, to1, subject1, body1);


            try
            {
                client.Send(message);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }             
    }
       


        
    
}
