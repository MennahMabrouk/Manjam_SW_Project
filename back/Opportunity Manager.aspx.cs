using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace manjam_backend
{
    public partial class OpportunityManager : System.Web.UI.Page
    {
        

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            // Validate input
            


        }
        /*protected void CreateButton_Click(object sender, EventArgs e)
        {
            // Get the values for the new opportunity
            string title = TitleTextBox.Text;
            byte[] image = GetImageBytes(ImageFileUpload.PostedFile);
            string details = DetailsTextBox.Text;

            // Insert the new opportunity into the database
            sqlDataSource.InsertParameters["title"].DefaultValue = title;
            sqlDataSource.InsertParameters["image"].DefaultValue = image;
            sqlDataSource.InsertParameters["details"].DefaultValue = details;
            sqlDataSource.Insert();

            // Refresh the grid view to show the new opportunity
            gridView.DataBind();
        }
        
        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            // Get the values for the updated opportunity
            int opportunityId = (int)gridView.SelectedDataKey.Value;
            string title = TitleTextBox.Text;
            byte[] image = GetImageBytes(ImageFileUpload.PostedFile);
            string details = DetailsTextBox.Text;

            // Update the opportunity in the database
            sqlDataSource.UpdateParameters["title"].DefaultValue = title;
            sqlDataSource.UpdateParameters["image"].DefaultValue = image;
            sqlDataSource.UpdateParameters["details"].DefaultValue = details;
            sqlDataSource.UpdateParameters["opportunity_id"].DefaultValue = opportunityId;
            sqlDataSource.Update();

            // Refresh the grid view to show the updated opportunity
            gridView.DataBind();
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get the ID of the opportunity to delete
            int opportunityId = (int)gridView.SelectedDataKey.Value;

            // Delete the opportunity from the database
            sqlDataSource.DeleteParameters["opportunity_id"].DefaultValue = opportunityId;
            sqlDataSource.Delete();

            // Refresh the grid view to remove the deleted opportunity
            gridView.DataBind();
        }*/
    }
}