using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;

namespace mvc
{
    public class CustomActionFilter : ActionFilterAttribute
    {

        public HttpRequest UsrAgnt
        {
            get
            {
                return HttpContext.Current.ApplicationInstance.Request;
            }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            StringBuilder sbUserDetails = new StringBuilder();
            string agent = UsrAgnt.UserAgent;
            string loggedInDate = DateTime.Now.ToString();

            sbUserDetails.AppendLine("User details:");
            sbUserDetails.AppendLine("-------------");
            sbUserDetails.AppendLine(agent);
            sbUserDetails.AppendLine(loggedInDate);
            sbUserDetails.AppendLine("-------------");

            LogData(sbUserDetails.ToString());
        }

        public void LogData(string data)
        {
            // Overwrites the file if exists or Creates new file and write the data - Start
            string path = @"C:\Users\Vishnu Naruto\Documents\Visual Studio 2013\Projects\mvc\mvc\Data\Test.txt";
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(data);

            sw.Close();
            //sw.Flush();
            // Overwrites the file if exists or Creates new file and write the data - End

            // Appends user details to the log file - Start
            //File.AppendAllText(path, data);
            // Appends user details to the log file - End
        }
    }
}