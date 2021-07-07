using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;


using OutLook = Microsoft.Office.Interop.Outlook;


namespace OutlookIntegrationEx
{
    public partial class MainForm : Form
    {
         # region    MemberVariables
           
         #endregion
        public MainForm()
        {
            InitializeComponent();
            //LOADING THE FODLERS IN OUT LOOK.
            LoadContactFoldersCombo();
        }
        /// <summary>
        /// loading the contact folders from outlook application
        /// </summary>
        private void LoadContactFoldersCombo()
        {
            OutLook._Application outlookObj = new OutLook.Application();
            OutLook.MAPIFolder contactsFolder = (OutLook.MAPIFolder)
                           outlookObj.Session.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderContacts);
            
            if (!cbFolder.Items.Contains("Default"))
            {
                cbFolder.Items.Add("Default");
            }
            //VERIFYING THE CUSTOM FOLDER IN OUT LOOK .
            foreach (OutLook.MAPIFolder subFolder in contactsFolder.Folders)
            {
                if (!cbFolder.Items.Contains(subFolder.Name))
                {
                    cbFolder.Items.Add(subFolder.Name);
                }
            }

        }
        /// <summary>
        /// Adding a new contact outlook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewContact nc = new NewContact();
            nc.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            nc.StartPosition = FormStartPosition.CenterParent;
            nc.ShowDialog();
        }
        /// <summary>
        /// Getting the contacts by passing the folder name.
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        private List<MyContact> GetContactsFromFolder(string folderName)
        {
            List<MyContact> contacts = null;

            object missing = System.Reflection.Missing.Value;

            //create instance of Outlook application and Outlook Contacts folder.
            try
            {
                OutLook.MAPIFolder fldContacts = null;
                    contacts = new List<MyContact>();
                    OutLook._Application outlookObj = new OutLook.Application();
                    if (folderName == "Default")
                    {
                        fldContacts = (OutLook.MAPIFolder)outlookObj.Session.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderContacts);
                    }
                    else
                    {

                        OutLook.MAPIFolder contactsFolder = (OutLook.MAPIFolder)
                            outlookObj.Session.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderContacts);
                        //VERIFYING THE CUSTOM FOLDER IN OUT LOOK .
                        foreach (OutLook.MAPIFolder subFolder in contactsFolder.Folders)
                        {
                            if (subFolder.Name == folderName)
                            {
                                fldContacts = subFolder;
                                break;
                            }
                        }
                    }
                    //LOOPIN G THROUGH CONTACTS IN THAT FOLDER.
                    foreach (Microsoft.Office.Interop.Outlook._ContactItem contactItem in fldContacts.Items)
                    {
                        {
                            MyContact contact = new MyContact();
                            contact.FirstName = (contactItem.FirstName == null) ? string.Empty : contactItem.FirstName;
                            contact.LastName = (contactItem.LastName == null) ? string.Empty : contactItem.LastName;
                            contact.EmailAddress = contactItem.Email1Address;
                            contact.Phone = contactItem.Business2TelephoneNumber;
                            contact.Address = contactItem.BusinessAddress;
                            //contact.
                            contacts.Add(contact);
                        }
                    }
                }
           
            catch (System.Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            return contacts;
        }
        /// <summary>
        /// REFESHING THE CONTACTS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string cntctFldrName = string.Empty;
            if (cbFolder.SelectedItem == null)
            {
                cntctFldrName = "Default";
                cbFolder.SelectedItem = "Default";
            }
            else
            {
                cntctFldrName = cbFolder.SelectedItem.ToString();
            }
            dgvContacts.Visible = false;
            
            if (GetContactsFromFolder(cntctFldrName).Count > 0)
            {
                dgvContacts.Visible = true;
                dgvContacts.DataSource = GetContactsFromFolder(cntctFldrName);
            }
            else
            {
                MessageBox.Show("No Contacts found in this folder");
            }
        }
        /// <summary>
        /// REFRESHING THE FOLDERS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefFolder_Click(object sender, EventArgs e)
        {
            LoadContactFoldersCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutLook._Application outlookObj = new OutLook.Application();
            OutLook.MAPIFolder root = outlookObj.Session.DefaultStore.GetRootFolder();
            OutLook._MailItem mailItem = outlookObj.CreateItem(OutLook.OlItemType.olMailItem) as OutLook.MailItem;
            //mailItem.Display(false);

            mailItem.To = "sandbil@ya.ru";
            mailItem.Subject = "123This is the subject OutlookIntegrationEx 123";
            mailItem.Body = "This is the body без предупр OutlookIntegrationEx123";

            //mailItem.Display(false);
            mailItem.Send();

        }
    }
}