using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Import_Images__Students_
{
    public partial class Form1 : Form
    {
        string clientID = null; 
        string clientSecret = null; 
        string resource = null; 
        string entityname = String.Empty;
        string fieldname = String.Empty;
        IOrganizationService service = null;
        string[] jpgFiles = null;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           clientID = Properties.Settings.Default.ClientID;
           clientSecret = Properties.Settings.Default.ClientSecret;
           resource = Properties.Settings.Default.EnvURL;
           entityname = Properties.Settings.Default.EntityName;
            fieldname = Properties.Settings.Default.FieldName;

            txtbox_envUrl.Text = resource;
            txtbox_secretid.Text = clientSecret;
            txtbox_clientid.Text = clientID;
            txtbox_entityname.Text = entityname;
            txtbox_fieldname.Text = fieldname;

            if (clientID != "" && clientSecret != "" && resource != "")
            {
                try
                {
                    service = GetOrganizationServiceClientSecret(clientID, clientSecret, resource);
                    if (service != null)
                    {
                        lbl_conection.Text = "Connected";
                        lbl_conection.ForeColor = Color.Green;
                    }
                    else
                    {
                        lbl_conection.Text = "Not Connected";
                        lbl_conection.ForeColor = Color.Red;
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {

                folderBrowserDialog.Description = "Select a folder containing JPG files";
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;

                    //  MessageBox.Show(selectedFolderPath);
                    if (selectedFolderPath.Length > 45)
                    {
                        label1.Text = selectedFolderPath.Substring(0, 45) + "...";
                    }
                    else
                    {
                        label1.Text = selectedFolderPath;
                    }
                    jpgFiles = Directory.GetFiles(selectedFolderPath, "*.jpg");
                  //  ResizeImagesToPassportSize(jpgFiles);
                }
            }
        }
        private void btn_importtocrm_Click(object sender, EventArgs e)
        {
           
            if (entityname != "" && fieldname != "" )
            {
                if (jpgFiles != null)
                {
                    importimages();
                }
                else
                {
                    MessageBox.Show("Please Select Folder!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Entity Name or Field Name is missing!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private async void importimages()
        {
            await Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();

                }));
                if (service != null)
                {
                   
                    if (jpgFiles.Any())
                    {
                        // Process the JPG files
                        foreach (string jpgFilePath in jpgFiles)
                        {
                            string pictureNameWithoutExtension = Path.GetFileNameWithoutExtension(jpgFilePath);
                            QueryExpression query = new QueryExpression(entityname);
                            query.ColumnSet.AddColumns(fieldname,"entityimage");
                            query.Criteria.AddCondition(fieldname, ConditionOperator.Equal, pictureNameWithoutExtension);
                            //  query.Criteria.AddCondition("mc_class", ConditionOperator.Equal, classid);
                            // query.Criteria.AddCondition("mc_section", ConditionOperator.Equal, sectionnnid);


                            EntityCollection results = service.RetrieveMultiple(query);
                            if (results.Entities.Count > 0)
                            {
                                Entity accounts = results.Entities[0];
                                //  byte[] imagebytes = accounts.GetAttributeValue<byte[]>("entityimage");
                                // MessageBox.Show();
                                byte[] jpgBytes;
                                using (System.Drawing.Image img = System.Drawing.Image.FromFile(jpgFilePath))
                                {
                                    System.Drawing.Image resizedImage = Resize(img, 300, 300);


                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        // Save the resized image to the MemoryStream in JPEG format
                                        resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                                        // Return the byte array
                                        jpgBytes = ms.ToArray();
                                    }
                                }

                                // Your resized image is now in pictureBox1, and jpgBytes contains the byte array.
                                //byte[] jpgBytes = File.ReadAllBytes(jpgFilePath);
                                accounts["entityimage"] = jpgBytes;
                                service.Update(accounts);
                                Invoke((Action)(() =>
                                {
                                    listBox1.Items.Add(pictureNameWithoutExtension);
                                }));

                            }
                            else
                            {
                                Invoke((Action)(() =>
                                {
                                    listBox2.Items.Add(pictureNameWithoutExtension);
                                }));

                            }
                        }
                        MessageBox.Show("Data Imported Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No JPG files found in the selected folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No Connection found with CRM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            });

        }
       
        private Image Resize(Image img, int iWidth, int iHeight)
        {
            Bitmap bmp = new Bitmap(iWidth, iHeight);
            Graphics graphic = Graphics.FromImage((Image)bmp); graphic.DrawImage(img, 0, 0, iWidth, iHeight);

            return (Image)bmp;
        }

        public static IOrganizationService GetOrganizationServiceClientSecret(string clientId, string clientSecret, string organizationUri)
        {
            try
            {
                var conn = new CrmServiceClient($@"AuthType=ClientSecret; url={organizationUri}; ClientId={clientId}; ClientSecret={clientSecret}");
                return conn.OrganizationWebProxyClient != null ? conn.OrganizationWebProxyClient : (IOrganizationService)conn.OrganizationServiceProxy;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnvURL = txtbox_envUrl.Text;
            Properties.Settings.Default.ClientSecret = txtbox_secretid.Text;
            Properties.Settings.Default.ClientID = txtbox_clientid.Text;
            Properties.Settings.Default.EntityName = txtbox_entityname.Text;
            Properties.Settings.Default.FieldName = txtbox_fieldname.Text;
            Properties.Settings.Default.Save();
            Form1_Load(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete all saved Data?";
            string title = "Confirmation";

            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                txtbox_envUrl.Text = "";
                txtbox_secretid.Text = "";
                txtbox_clientid.Text = "";
                txtbox_entityname.Text = "";
                txtbox_fieldname.Text = "";
                Properties.Settings.Default.Reset();
                service = null;
                lbl_conection.Text = "Not Connected";
                lbl_conection.ForeColor = Color.Red;

            }
            else if (result == DialogResult.No)
            {
            }
          
        }


    }
}
