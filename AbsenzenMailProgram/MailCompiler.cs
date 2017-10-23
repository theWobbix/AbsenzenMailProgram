using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Gmail.v1;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Net.Mail;
using Google.Apis.Gmail.v1.Data;

namespace AbsenzenMailProgram
{
    class MailCompiler
    {
        public static void CreateMail()
        {

            AE.Net.Mail.MailMessage msg = new AE.Net.Mail.MailMessage
                {
                    Subject = "Your Subject",
                    Body = "Hello, World, from Gmail API!",
                    From = new MailAddress("the.wobbix.@gmail.com")
                };
            msg.To.Add(new MailAddress("hannes.eybl@stud.gymhofwil.ch"));
            msg.ReplyTo.Add(msg.From); // Bounces without this!!
            StringWriter msgStr = new StringWriter();
            msg.Save(msgStr);

            GmailService gmail = new GmailService();
            gmail.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message
                {
                    Raw = Base64UrlEncode(msgStr.ToString())
                }, "client_secret").Execute();
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            // Special "url-safe" base64 encode.
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }
    }
}

