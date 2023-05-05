using System.Drawing;
using System.Drawing.Imaging;
using MailKit.Net.Smtp;
using MimeKit;
using Windows.Media.Capture;
using Windows.Storage;


/*

var mailMessage = new MimeMessage();
mailMessage.From.Add(new MailboxAddress("from name", "schutow.kir@yandex.ru"));
mailMessage.To.Add(new MailboxAddress("to name", "schutow.kir@yandex.ru"));
mailMessage.Subject = "subject";
mailMessage.Body = new TextPart("plain")
{
    Text = "The computer is on. \n" +
           $"Time: {DateTime.Now}\n" 
           // "Place:  \n"
};

using (var smtpClient = new SmtpClient())  // Sending a message
{
    smtpClient.Connect("smtp.yandex.ru", 465, true);
    smtpClient.Authenticate("schutow.kir", "bfrkntpxhiymjipi");
    smtpClient.Send(mailMessage);
    smtpClient.Disconnect(true);
}

Environment.Exit(0); // program exit
*/

