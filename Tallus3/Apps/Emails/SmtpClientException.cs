using System;
using System.Collections.Generic;
using System.Text;

namespace Tallus3.Apps.Emails
{
    public class SmtpClientException : Exception
    {
        private string errorMessage = "";

        public SmtpClientException(string error_message)
        {
            this.errorMessage = error_message;
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }
        }
    }
}
