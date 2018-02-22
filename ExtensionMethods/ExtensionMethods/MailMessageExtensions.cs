namespace Scorchio.ExtensionMethods
{
    using System.Net.Mail;

    /// <summary>
    /// MailMessage Extensions.
    /// </summary>
    public static class MailMessageExtensions
    {
        /// <summary>
        /// Sends the specified instance.
        /// </summary>
        /// <param name="this">The this.</param>
        public static void Send(this MailMessage @this)
        {
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.Send(@this);
            }
        }
    }
}
