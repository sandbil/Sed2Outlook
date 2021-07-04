namespace Sed2Outlook
{
    partial class Sed2OutlookFrm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sed2OutlookFrm));
            this.startOnWindows = new System.Windows.Forms.CheckBox();
            this.startMinimized = new System.Windows.Forms.CheckBox();
            this.startServing = new System.Windows.Forms.CheckBox();
            this.Browse = new System.Windows.Forms.Button();
            this.LHTTP_PORT = new System.Windows.Forms.Label();
            this.LATTACH_FOLDER = new System.Windows.Forms.Label();
            this.ATTACH_FOLDER = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.HTTP_PORT = new System.Windows.Forms.TextBox();
            this.lblActions = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.OpenItem1 = new System.Windows.Forms.MenuItem();
            this.HideItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.StartItem4 = new System.Windows.Forms.MenuItem();
            this.StopItem5 = new System.Windows.Forms.MenuItem();
            this.ExitItem8 = new System.Windows.Forms.MenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.frmCaption = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // startOnWindows
            // 
            this.startOnWindows.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.startOnWindows, "startOnWindows");
            this.startOnWindows.Name = "startOnWindows";
            this.startOnWindows.UseVisualStyleBackColor = false;
            // 
            // startMinimized
            // 
            this.startMinimized.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.startMinimized, "startMinimized");
            this.startMinimized.Name = "startMinimized";
            this.startMinimized.UseVisualStyleBackColor = false;
            // 
            // startServing
            // 
            this.startServing.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.startServing, "startServing");
            this.startServing.Name = "startServing";
            this.startServing.UseVisualStyleBackColor = false;
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Browse, "Browse");
            this.Browse.Name = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // LHTTP_PORT
            // 
            this.LHTTP_PORT.BackColor = System.Drawing.Color.Transparent;
            this.LHTTP_PORT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.LHTTP_PORT, "LHTTP_PORT");
            this.LHTTP_PORT.Name = "LHTTP_PORT";
            // 
            // LATTACH_FOLDER
            // 
            this.LATTACH_FOLDER.BackColor = System.Drawing.Color.Transparent;
            this.LATTACH_FOLDER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.LATTACH_FOLDER, "LATTACH_FOLDER");
            this.LATTACH_FOLDER.Name = "LATTACH_FOLDER";
            // 
            // ATTACH_FOLDER
            // 
            resources.ApplyResources(this.ATTACH_FOLDER, "ATTACH_FOLDER");
            this.ATTACH_FOLDER.Name = "ATTACH_FOLDER";
            this.ATTACH_FOLDER.Validating += new System.ComponentModel.CancelEventHandler(this.ATTACH_FOLDER_Validating);
            this.ATTACH_FOLDER.Validated += new System.EventHandler(this.ATTACH_FOLDER_Validated);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Start, "Start");
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // HTTP_PORT
            // 
            resources.ApplyResources(this.HTTP_PORT, "HTTP_PORT");
            this.HTTP_PORT.Name = "HTTP_PORT";
            this.HTTP_PORT.Validating += new System.ComponentModel.CancelEventHandler(this.HTTP_PORT_Validating);
            this.HTTP_PORT.Validated += new System.EventHandler(this.HTTP_PORT_Validated);
            // 
            // lblActions
            // 
            this.lblActions.BackColor = System.Drawing.Color.Transparent;
            this.lblActions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.lblActions, "lblActions");
            this.lblActions.Name = "lblActions";
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OpenItem1,
            this.HideItem2,
            this.menuItem3,
            this.StartItem4,
            this.StopItem5,
            this.ExitItem8});
            // 
            // OpenItem1
            // 
            this.OpenItem1.Index = 0;
            resources.ApplyResources(this.OpenItem1, "OpenItem1");
            this.OpenItem1.Click += new System.EventHandler(this.OpenItem1_Click);
            // 
            // HideItem2
            // 
            this.HideItem2.Index = 1;
            resources.ApplyResources(this.HideItem2, "HideItem2");
            this.HideItem2.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            resources.ApplyResources(this.menuItem3, "menuItem3");
            // 
            // StartItem4
            // 
            this.StartItem4.Index = 3;
            resources.ApplyResources(this.StartItem4, "StartItem4");
            this.StartItem4.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopItem5
            // 
            this.StopItem5.Index = 4;
            resources.ApplyResources(this.StopItem5, "StopItem5");
            this.StopItem5.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ExitItem8
            // 
            this.ExitItem8.Index = 5;
            resources.ApplyResources(this.ExitItem8, "ExitItem8");
            this.ExitItem8.Click += new System.EventHandler(this.btClose_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenu = this.contextMenu;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btMinimize, "btMinimize");
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // frmCaption
            // 
            this.frmCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.frmCaption, "frmCaption");
            this.frmCaption.Name = "frmCaption";
            // 
            // Sed2OutlookFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.frmCaption);
            this.Controls.Add(this.startOnWindows);
            this.Controls.Add(this.startMinimized);
            this.Controls.Add(this.startServing);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.LHTTP_PORT);
            this.Controls.Add(this.LATTACH_FOLDER);
            this.Controls.Add(this.ATTACH_FOLDER);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.HTTP_PORT);
            this.Controls.Add(this.lblActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Sed2OutlookFrm";
            this.Load += new System.EventHandler(this.Sed2OutlookFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Sed2OutlookFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sed2OutlookFrm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox startOnWindows;
        private System.Windows.Forms.CheckBox startMinimized;
        private System.Windows.Forms.CheckBox startServing;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label LHTTP_PORT;
        private System.Windows.Forms.Label LATTACH_FOLDER;
        private System.Windows.Forms.TextBox ATTACH_FOLDER;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox HTTP_PORT;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem OpenItem1;
        private System.Windows.Forms.MenuItem HideItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem StartItem4;
        private System.Windows.Forms.MenuItem StopItem5;
        private System.Windows.Forms.MenuItem ExitItem8;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Label frmCaption;
    }
}

