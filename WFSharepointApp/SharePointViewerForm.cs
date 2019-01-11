using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;
using Form = System.Windows.Forms.Form;

namespace WFSharepointApp
{
    public partial class SharePointViewerForm : Form
    {
        public SharePointViewerForm()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            int numberOfItems = 100;
            string spUrl = txtSiteUrl.Text.Trim();
            string username = txtUsername.Text.Trim();
            string simplePassword = txtPassword.Text.Trim();
            // used to pass thru sharepoint creds
            SecureString password = new SecureString();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            foreach (char c in simplePassword)
            {
                password.AppendChar(c);
            }

            try
            {
                ClientContext clientContext = new ClientContext(spUrl);
                clientContext.Credentials = new SharePointOnlineCredentials(txtUsername.Text.Trim(), password);

                Web webObject = clientContext.Web;
                List listObject = webObject.Lists.GetByTitle(txtListTitle.Text.Trim());

                CamlQuery cqObject = CamlQuery.CreateAllItemsQuery(numberOfItems);
                ListItemCollection collectionObject = listObject.GetItems(cqObject);

                clientContext.Load(collectionObject);
                clientContext.ExecuteQuery();

                if ( collectionObject.Count != 0 )
                {
                    DataTable dt = new DataTable();
                    DataRow dRow;

                    DataColumn dcId = new DataColumn("Id");
                    dcId.DataType = Type.GetType("System.String");
                    DataColumn dcTitle = new DataColumn("Title");
                    dcTitle.DataType = Type.GetType("System.String");

                    dt.Columns.Add(dcId);
                    dt.Columns.Add(dcTitle);

                    foreach ( ListItem item in collectionObject )
                    {
                        dRow = dt.NewRow();
                        dRow["Id"] = item.Id;
                        dRow["Title"] = item["Title"];
                        dt.Rows.Add(dRow);
                    }
                    dgListResults.DataSource = dt;
                }
                else
                {
                    // write message to client no data present
                    Console.WriteLine("LIST HAD NO ITEMS");
                }
            }
            catch( Exception ex )
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
