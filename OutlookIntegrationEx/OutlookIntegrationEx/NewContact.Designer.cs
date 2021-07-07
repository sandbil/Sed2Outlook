namespace OutlookIntegrationEx
{
    partial class NewContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContact));
            this.tbcInformation = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.lblCustom = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txFolder = new System.Windows.Forms.TextBox();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.rdoDefault = new System.Windows.Forms.RadioButton();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tpDetails = new System.Windows.Forms.TabPage();
            this.tlpInsts = new System.Windows.Forms.TableLayoutPanel();
            this.lblInsts = new System.Windows.Forms.Label();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.chkVerify = new System.Windows.Forms.CheckBox();
            this.txtProp1 = new System.Windows.Forms.TextBox();
            this.lblCutomProp1 = new System.Windows.Forms.Label();
            this.tlpNewContact = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbcInformation.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpDetails.SuspendLayout();
            this.tlpInsts.SuspendLayout();
            this.tlpNewContact.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcInformation
            // 
            this.tbcInformation.Controls.Add(this.tpGeneral);
            this.tbcInformation.Controls.Add(this.tpDetails);
            this.tbcInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcInformation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcInformation.Location = new System.Drawing.Point(3, 39);
            this.tbcInformation.Name = "tbcInformation";
            this.tbcInformation.SelectedIndex = 0;
            this.tbcInformation.Size = new System.Drawing.Size(631, 338);
            this.tbcInformation.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.lblCustom);
            this.tpGeneral.Controls.Add(this.lblFolder);
            this.tpGeneral.Controls.Add(this.txFolder);
            this.tpGeneral.Controls.Add(this.rdoCustom);
            this.tpGeneral.Controls.Add(this.rdoDefault);
            this.tpGeneral.Controls.Add(this.txtLastName);
            this.tpGeneral.Controls.Add(this.txtEmail);
            this.tpGeneral.Controls.Add(this.txtPhone);
            this.tpGeneral.Controls.Add(this.txtAddress);
            this.tpGeneral.Controls.Add(this.textBox2);
            this.tpGeneral.Controls.Add(this.lblPhone);
            this.tpGeneral.Controls.Add(this.label4);
            this.tpGeneral.Controls.Add(this.lblEmail);
            this.tpGeneral.Controls.Add(this.lblLastName);
            this.tpGeneral.Controls.Add(this.txtFirstName);
            this.tpGeneral.Controls.Add(this.lblFirstName);
            this.tpGeneral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(623, 312);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.Location = new System.Drawing.Point(14, 226);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(116, 13);
            this.lblCustom.TabIndex = 15;
            this.lblCustom.Text = "Custom Property";
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(368, 65);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(90, 13);
            this.lblFolder.TabIndex = 6;
            this.lblFolder.Text = "Folder Name";
            // 
            // txFolder
            // 
            this.txFolder.Enabled = false;
            this.txFolder.Location = new System.Drawing.Point(470, 63);
            this.txFolder.Name = "txFolder";
            this.txFolder.Size = new System.Drawing.Size(85, 21);
            this.txFolder.TabIndex = 13;
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(470, 27);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(73, 17);
            this.rdoCustom.TabIndex = 12;
            this.rdoCustom.TabStop = true;
            this.rdoCustom.Text = "Custom";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.rdoCustom_CheckedChanged);
            // 
            // rdoDefault
            // 
            this.rdoDefault.AutoSize = true;
            this.rdoDefault.Location = new System.Drawing.Point(364, 27);
            this.rdoDefault.Name = "rdoDefault";
            this.rdoDefault.Size = new System.Drawing.Size(72, 17);
            this.rdoDefault.TabIndex = 5;
            this.rdoDefault.TabStop = true;
            this.rdoDefault.Text = "Default";
            this.rdoDefault.UseVisualStyleBackColor = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(167, 65);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(165, 21);
            this.txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(165, 21);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(167, 141);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 21);
            this.txtPhone.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 181);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(388, 21);
            this.txtAddress.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(167, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "myPetName";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(21, 141);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(18, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(18, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "LastName";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(167, 29);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(165, 21);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(18, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(74, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "FirstName";
            // 
            // tpDetails
            // 
            this.tpDetails.Controls.Add(this.tlpInsts);
            this.tpDetails.Controls.Add(this.chkAdd);
            this.tpDetails.Controls.Add(this.chkVerify);
            this.tpDetails.Controls.Add(this.txtProp1);
            this.tpDetails.Controls.Add(this.lblCutomProp1);
            this.tpDetails.Location = new System.Drawing.Point(4, 22);
            this.tpDetails.Name = "tpDetails";
            this.tpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetails.Size = new System.Drawing.Size(623, 312);
            this.tpDetails.TabIndex = 1;
            this.tpDetails.Text = "Details";
            this.tpDetails.UseVisualStyleBackColor = true;
            // 
            // tlpInsts
            // 
            this.tlpInsts.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tlpInsts.ColumnCount = 1;
            this.tlpInsts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInsts.Controls.Add(this.lblInsts, 0, 0);
            this.tlpInsts.Location = new System.Drawing.Point(6, 7);
            this.tlpInsts.Name = "tlpInsts";
            this.tlpInsts.RowCount = 1;
            this.tlpInsts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInsts.Size = new System.Drawing.Size(611, 75);
            this.tlpInsts.TabIndex = 4;
            // 
            // lblInsts
            // 
            this.lblInsts.AutoSize = true;
            this.lblInsts.Location = new System.Drawing.Point(6, 3);
            this.lblInsts.Name = "lblInsts";
            this.lblInsts.Size = new System.Drawing.Size(593, 52);
            this.lblInsts.TabIndex = 0;
            this.lblInsts.Text = resources.GetString("lblInsts.Text");
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Checked = true;
            this.chkAdd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdd.Enabled = false;
            this.chkAdd.Location = new System.Drawing.Point(12, 116);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(192, 17);
            this.chkAdd.TabIndex = 3;
            this.chkAdd.Text = "Add this Custom property";
            this.chkAdd.UseVisualStyleBackColor = true;
            this.chkAdd.CheckedChanged += new System.EventHandler(this.chkAdd_CheckedChanged);
            // 
            // chkVerify
            // 
            this.chkVerify.AutoSize = true;
            this.chkVerify.Enabled = false;
            this.chkVerify.Location = new System.Drawing.Point(16, 226);
            this.chkVerify.Name = "chkVerify";
            this.chkVerify.Size = new System.Drawing.Size(398, 17);
            this.chkVerify.TabIndex = 2;
            this.chkVerify.Text = "Verify this propery whether contact already exists or not";
            this.chkVerify.UseVisualStyleBackColor = true;
            // 
            // txtProp1
            // 
            this.txtProp1.Enabled = false;
            this.txtProp1.Location = new System.Drawing.Point(169, 160);
            this.txtProp1.Name = "txtProp1";
            this.txtProp1.Size = new System.Drawing.Size(100, 21);
            this.txtProp1.TabIndex = 1;
            // 
            // lblCutomProp1
            // 
            this.lblCutomProp1.AutoSize = true;
            this.lblCutomProp1.Location = new System.Drawing.Point(11, 163);
            this.lblCutomProp1.Name = "lblCutomProp1";
            this.lblCutomProp1.Size = new System.Drawing.Size(91, 13);
            this.lblCutomProp1.TabIndex = 0;
            this.lblCutomProp1.Text = "My Pet Name";
            this.lblCutomProp1.Click += new System.EventHandler(this.lblCutomProp1_Click);
            // 
            // tlpNewContact
            // 
            this.tlpNewContact.ColumnCount = 1;
            this.tlpNewContact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewContact.Controls.Add(this.tbcInformation, 0, 1);
            this.tlpNewContact.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpNewContact.Location = new System.Drawing.Point(1, 6);
            this.tlpNewContact.Name = "tlpNewContact";
            this.tlpNewContact.RowCount = 2;
            this.tlpNewContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.473684F));
            this.tlpNewContact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.52631F));
            this.tlpNewContact.Size = new System.Drawing.Size(637, 380);
            this.tlpNewContact.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.10628F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.89372F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save &&Close";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // NewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 389);
            this.Controls.Add(this.tlpNewContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewContact";
            this.Text = "NewContact";
            this.tbcInformation.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpDetails.ResumeLayout(false);
            this.tpDetails.PerformLayout();
            this.tlpInsts.ResumeLayout(false);
            this.tlpInsts.PerformLayout();
            this.tlpNewContact.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcInformation;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpDetails;
        private System.Windows.Forms.TableLayoutPanel tlpNewContact;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txFolder;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.RadioButton rdoDefault;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.TextBox txtProp1;
        private System.Windows.Forms.Label lblCutomProp1;
        private System.Windows.Forms.CheckBox chkVerify;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.TableLayoutPanel tlpInsts;
        private System.Windows.Forms.Label lblInsts;
    }
}