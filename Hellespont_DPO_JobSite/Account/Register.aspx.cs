using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using Hellespont_DPO_JobSite.Model;

namespace Hellespont_DPO_JobSite.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
            if (!IsPostBack)
            {
                ddlReligion.DataSource = Enum.GetValues(typeof(Religion));
                ddlReligion.DataTextField = "Value";
                ddlReligion.DataValueField = "Key";
                ddlReligion.DataBind();

                ddlMStatus.DataSource = Enum.GetValues(typeof(Marital_Status));
                ddlMStatus.DataTextField = "Value";
                ddlMStatus.DataValueField = "Key";
                ddlMStatus.DataBind();
            }
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie: false);

            //string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            //if (!OpenAuth.IsLocalUrl(continueUrl))
            //{
            //    continueUrl = "~/";
            //}
            //Response.Redirect("~/Account/RegisterProfile.aspx");
        }
        protected void RegisterUser_Continue(object sender,EventArgs e)
        {
            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (!OpenAuth.IsLocalUrl(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect("~/Account/RegisterProfile.aspx");
        }
        protected void RegisterUser_Finish(object sender, EventArgs e)
        {
            
        }
    }
}