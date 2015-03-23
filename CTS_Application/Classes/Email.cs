using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace CTS_Application
{
    class Email
    {
        public Email()
        {

        }
        public void SendEmail()
       {
           //Source:
           //http://stackoverflow.com/questions/704636/sending-email-through-gmail-smtp-server-with-c-sharp
               SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
               {
                   Credentials = new NetworkCredential("ia.arduino.415@gmail.com", "lekemosKOS15"),
                   EnableSsl = true
               };
               DbConnect dbConnect = new DbConnect();
            // Amount of subs counted.
               int numOfSubs = dbConnect.NumOfRowsSubTable();
            //The selected email.
               for (int i = 0; i <= numOfSubs; i++)
               {
                   
                   client.Send("ia.arduino.415@gmail.com", "@recipient", "INSERT TOPIC", "INSERT ALARM INFO");
                   Console.WriteLine("Sent");
                   Console.ReadLine();
               }
              
            
       }


        
    }
}
