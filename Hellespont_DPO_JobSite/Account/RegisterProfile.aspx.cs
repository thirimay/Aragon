using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hellespont_DPO_JobSite.Model;

namespace Hellespont_DPO_JobSite.Account
{
    public partial class RegisterProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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
    }
}