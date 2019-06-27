using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace MusicStore.UI.MVC.Tools
{
    public class MailHelper
    {
        public static bool SendConfirmationMail(string username, string password, string mail, int id)
        {
            bool result = false;
            MailMessage msg = new MailMessage();
            msg.To.Add(mail);
            msg.Subject = "Welcome";
            msg.IsBodyHtml = true;
            msg.Body = "Thank you for signing in";
            msg.From = new MailAddress("bilgeinsan1530@gmail.com");
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            NetworkCredential credential = new NetworkCredential("2009girisli@gmail.com", "Asdf1989");
            smtpClient.Credentials = credential;
            try
            {
                smtpClient.Send(msg);
                result = true;
            }
            catch (Exception)
            {
                result = false;

            }
            return result;
        }
    }
}