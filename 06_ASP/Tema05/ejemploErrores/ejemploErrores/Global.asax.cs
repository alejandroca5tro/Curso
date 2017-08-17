using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ejemploErrores
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            string url = Request.Path;
            //Así sabemos dónde se ha producido el error
            Exception error = Server.GetLastError();

            StringBuilder text = new StringBuilder("Error que ha ocrrido:");
            text.Append(error.Message);
            text.Append(" en ");
            text.Append(url);

            EventLog log = new EventLog();
            log.Source = "TAJAMAR log";
            log.WriteEntry(text.ToString(), EventLogEntryType.Error);                
        }
    }
}