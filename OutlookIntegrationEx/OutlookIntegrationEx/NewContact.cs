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
    public partial class NewContact : Form
    {
        Microsoft.Office.Interop.Outlook.MAPIFolder CustomFolder = null;
        public NewContact()
        {
            InitializeComponent();
        }
        /// <summary>
        /// SAVING THE NEW CONTACT TO OUTLOOK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rdoCustom.Checked)
            {
                //IF THE CUSTOM FOLDER OPTION IS SELECTED PROMPTING FOR THE NAME.
                if (string.IsNullOrEmpty(txFolder.Text.Trim().ToString()))
                {
                    MessageBox.Show("Please Give Your CustomFolder Name");
                    return;
                }
                //IF WE NEED A CUSTOM FOLDER FOR CREATING CONTACTS .HERE IT CHECKS FOR FOLDER OR OTHER 
                //WISE IT CREATES A NEW CUSTOMER FOLDER WITH GIVEN NAME .

                if (!CheckCustomFolderExisits())
                {
                    CreateCustomFolder();
                }
                if (chkVerify.Checked)
                {
                    OutLook._Application outlookObj = new OutLook.Application();
                    MyContact cntact = new MyContact();
                    cntact.CustomProperty = txtProp1.Text.Trim().ToString();

                    //CREATING CONTACT ITEM OBJECT AND FINDING THE CONTACT ITEM 
                    OutLook.ContactItem newContact = (OutLook.ContactItem)FindContactItem(cntact, CustomFolder);

                    //THE VALUES WE CAN GET FROM WEB SERVICES OR DATA BASE OR CLASS. WE HAVE TO ASSIGN THE VALUES 
                    //TO OUTLOOK CONTACT ITEM OBJECT .
                    if (newContact != null)
                    {
                        newContact.FirstName = txtFirstName.Text.Trim().ToString();
                        newContact.LastName = txtLastName.Text.Trim().ToString();
                        newContact.Email1Address = txtEmail.Text.Trim().ToString();
                        newContact.Business2TelephoneNumber = txtPhone.Text.Trim().ToString();
                        newContact.BusinessAddress = txtAddress.Text.Trim().ToString();
                        if (chkAdd.Checked)
                        {
                            //HERE WE CAN CREATE OUR OWN CUSTOM PROPERTY TO IDENTIFY OUR APPLICATION. 
                            if(string.IsNullOrEmpty(txtProp1.Text.Trim().ToString()))
                            {
                                MessageBox.Show("please add value to Your Custom Property");
                                return;
                            }
                            newContact.UserProperties.Add("myPetName", OutLook.OlUserPropertyType.olText, true, OutLook.OlUserPropertyType.olText);
                            newContact.UserProperties["myPetName"].Value = txtProp1.Text.Trim().ToString();
                        }
                        newContact.Save();
                        this.Close();
                    }
                    else
                    {
                        //IF THE CONTACT DOES NOT EXIST WITH SAME CUSTOM PROPERTY CREATES THE CONTACT.
                         newContact = (OutLook.ContactItem)CustomFolder.Items.Add(OutLook.OlItemType.olContactItem);
                        newContact.FirstName = txtFirstName.Text.Trim().ToString();
                        newContact.LastName = txtLastName.Text.Trim().ToString();
                        newContact.Email1Address = txtEmail.Text.Trim().ToString();
                        newContact.Business2TelephoneNumber = txtPhone.Text.Trim().ToString();
                        newContact.BusinessAddress = txtAddress.Text.Trim().ToString();
                        if (chkAdd.Checked)
                        {
                            //HERE WE CAN CREATE OUR OWN CUSTOM PROPERTY TO IDENTIFY OUR APPLICATION. 
                            if (string.IsNullOrEmpty(txtProp1.Text.Trim().ToString()))
                            {
                                MessageBox.Show("please add value to Your Custom Property");
                                return;
                            }
                            newContact.UserProperties.Add("myPetName", OutLook.OlUserPropertyType.olText, true, OutLook.OlUserPropertyType.olText);
                            newContact.UserProperties["myPetName"].Value = txtProp1.Text.Trim().ToString();
                        }
                        newContact.Save();
                        this.Close();

                    }
                }
                else
                {
                    OutLook._Application outlookObj = new OutLook.Application();
                    OutLook.ContactItem newContact = (OutLook.ContactItem)CustomFolder.Items.Add(OutLook.OlItemType.olContactItem);
                    newContact.FirstName = txtFirstName.Text.Trim().ToString();
                    newContact.LastName = txtLastName.Text.Trim().ToString();
                    newContact.Email1Address = txtEmail.Text.Trim().ToString();
                    newContact.Business2TelephoneNumber = txtPhone.Text.Trim().ToString();
                    newContact.BusinessAddress = txtAddress.Text.Trim().ToString();
                    if (chkAdd.Checked)
                    {
                        //HERE WE CAN CREATE OUR OWN CUSTOM PROPERTY TO IDENTIFY OUR APPLICATION. 
                        if (string.IsNullOrEmpty(txtProp1.Text.Trim().ToString()))
                        {
                            MessageBox.Show("please add value to Your Custom Property");
                            return;
                        }
                        newContact.UserProperties.Add("myPetName", OutLook.OlUserPropertyType.olText, true, OutLook.OlUserPropertyType.olText);
                        newContact.UserProperties["myPetName"].Value = txtProp1.Text.Trim().ToString();
                    }
                    newContact.Save();
                    this.Close();
                }

            }
            else
            {
                //CREATES THE OUTLOOK CONTACT IN DEFAULT CONTACTS FOLDER.
                OutLook._Application outlookObj = new OutLook.Application();
                OutLook.MAPIFolder fldContacts = (OutLook.MAPIFolder)outlookObj.Session.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderContacts);
                OutLook.ContactItem newContact = (OutLook.ContactItem)fldContacts.Items.Add(OutLook.OlItemType.olContactItem);
                //THE VALUES WE CAN GET FROM WEB SERVICES OR DATA BASE OR CLASS. WE HAVE TO ASSIGN THE VALUES 
                //TO OUTLOOK CONTACT ITEM OBJECT .
                newContact.FirstName = txtFirstName.Text.Trim().ToString();
                newContact.LastName = txtLastName.Text.Trim().ToString();
                newContact.Email1Address = txtEmail.Text.Trim().ToString();
                newContact.Business2TelephoneNumber = txtPhone.Text.Trim().ToString();
                newContact.BusinessAddress = txtAddress.Text.Trim().ToString();
                newContact.Save();
                this.Close();
            }

        }
        /// <summary>
        /// ENABLING AND DISABLING THE CUSTOM FOLDER AND PROPERY OPTIONS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCustom.Checked)
            {
                txFolder.Enabled = true;
                chkAdd.Enabled = true;
                chkVerify.Enabled = true;
                txtProp1.Enabled = true;
            }
            else
            {
                txFolder.Enabled = false;
                chkAdd.Enabled = false;
                chkVerify.Enabled = false;
                txtProp1.Enabled = false;
            }
        }
        /// <summary>
        /// FIND THE CONTACT WITH SAME USER PROPERTY VALUE.
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="folder"></param>
        /// <returns></returns>
        private OutLook._ContactItem FindContactItem(MyContact contact, OutLook.MAPIFolder folder)
        {

            object missing = System.Reflection.Missing.Value;
            foreach (OutLook._ContactItem contactItem in folder.Items)
            {
                OutLook.UserProperty userProperty = contactItem.UserProperties.Find("myPetName", missing);
                if (userProperty != null)
                {
                    if (userProperty.Value.Equals(txtProp1.Text.Trim().ToString()))
                       return contactItem;
                }
            }
            return null;
        }
       
        /// <summary>
        /// Check myconacts(custom folder) exists or not
        /// </summary>
        /// <returns></returns>
        public bool CheckCustomFolderExisits()
        {
            OutLook._Application outlookObj = new OutLook.Application();
            OutLook.MAPIFolder fldContacts = (OutLook.MAPIFolder)outlookObj.Session.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderContacts);
            //VERIFYING THE MYCONTACTS (CUSTOM) SUB FOLDER IN CONTACTS FOLDER IN OUT LOOK.
            foreach (OutLook.MAPIFolder subFolder in fldContacts.Folders)
            {
                if (subFolder.Name == txFolder.Text.Trim().ToString())
                {
                    CustomFolder = subFolder;
                    return true;
                }
                else
                    return false;
            }
            return false;
        }
        /// <summary>
        /// CREATES THE CUSTOM FOLDER IN OUTLOOK CONTACTS FOLDER
        /// </summary>
        public void CreateCustomFolder()
        {
            OutLook._Application outlookApplication = new OutLook.Application();
            OutLook.MAPIFolder contactsFolder = (OutLook.MAPIFolder)
                outlookApplication.Session.GetDefaultFolder(OutLook.OlDefaultFolders.olFolderContacts);
            //VERIFYING THE MYCONTACTS(CUSTOM) FOLDER IN OUT LOOK .
            foreach (OutLook.MAPIFolder subFolder in contactsFolder.Folders)
            {
                if (subFolder.Name == txFolder.Text.Trim().ToString())
                {
                    CustomFolder = subFolder;
                }
            }
            //IF MYCONTACTS FOLDER DOES NOT EXIST CREATE A NEW FOLDER WITH NAME MYCONTACTS.
            if (CustomFolder == null)
            {
                CustomFolder = contactsFolder.Folders.Add(txFolder.Text.Trim().ToString(), Microsoft.Office.Interop.Outlook.OlDefaultFolders.olFolderContacts);
            }
        }
        /// <summary>
        /// ENABLING AND DISABLING THE CUSTOM PROPERTY CONTROLS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdd.Checked)
            {
                txtProp1.Enabled = true;
                chkVerify.Enabled = true;
            }
            else
            {
                txtProp1.Enabled = false;
                chkVerify.Enabled = false;
            }

        }

        private void lblCutomProp1_Click(object sender, EventArgs e)
        {

        }  
        
    }
}