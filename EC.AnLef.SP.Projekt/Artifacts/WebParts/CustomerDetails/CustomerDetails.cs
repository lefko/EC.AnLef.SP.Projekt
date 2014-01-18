using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace EC.AnLef.SP.Projekt.Artifacts.WebParts.CustomerDetails
{
    [ToolboxItemAttribute(false)]
    public class CustomerDetails : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/EC.AnLef.SP.Projekt.Artifacts.WebParts/CustomerDetails/CustomerDetailsUserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }
    }
}
