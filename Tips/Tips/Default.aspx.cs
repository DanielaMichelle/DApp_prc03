using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tips
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(@"C:\Users\usuario123\proyects\DesApps\Práctica\Practica3\Tips\Tips\upload\"
                + FileUpload1.FileName);
                HyperLink1.Text = FileUpload1.FileName;
                HyperLink1.NavigateUrl = @"upload/" + FileUpload1.FileName;
            }
            if (FileUpload2.HasFile)
            {
                FileUpload2.SaveAs(@"C:\Users\usuario123\proyects\DesApps\Práctica\Practica3\Tips\Tips\upload\"
                + FileUpload2.FileName);
                HyperLink2.Text = FileUpload2.FileName;
                HyperLink2.NavigateUrl = @"upload/" + FileUpload2.FileName;
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender,EventArgs e)
        {
            MultiView1.ActiveViewIndex = Int32.Parse(RadioButtonList1.SelectedValue);
        }
    }
}