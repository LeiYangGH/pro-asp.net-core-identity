using Microsoft.AspNetCore.Identity.UI.Services;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Web;

namespace IdentityApp.Services {
    public class ConsoleEmailSender : IEmailSender {

        public Task SendEmailAsync(string emailAddress,
                string subject, string htmlMessage) {
            Debug.WriteLine("---New Email----");
            Debug.WriteLine($"To: {emailAddress}");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine(HttpUtility.HtmlDecode(htmlMessage));
            Debug.WriteLine("-------");
            return Task.CompletedTask;
        }
    }
}
