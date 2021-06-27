using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://WebService1.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public bool Login(string userId, string emailAddress)
        {
            var user = new User(emailAddress, userId);
            return user.Login();
        }
    }

    internal class User
    {
        private string emailAddress;
        private string userId;

        public User(string emailAddress, string userId)
        {
            this.emailAddress = emailAddress;
            this.userId = userId;
        }

        internal bool Login()
        {
            throw new NotImplementedException();
        }

       
    }
}
