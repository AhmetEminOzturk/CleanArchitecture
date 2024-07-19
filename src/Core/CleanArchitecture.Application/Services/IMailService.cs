using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public interface IMailService
    {
        Task SendMailAsync(List<string> emails, string subject, string body, List<Attachment> attachments = null);
    }
}