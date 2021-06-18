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
            this.LHTTP_FOLDER = new System.Windows.Forms.Label();
            this.ATTACH_FOLDER = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.HTTP_PORT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // startOnWindows
            // 
            resources.ApplyResources(this.startOnWindows, "startOnWindows");
            this.startOnWindows.BackColor = System.Drawing.Color.Transparent;
            this.Error.SetError(this.startOnWindows, resources.GetString("startOnWindows.Error"));
            this.Error.SetIconAlignment(this.startOnWindows, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("startOnWindows.IconAlignment"))));
            this.Error.SetIconPadding(this.startOnWindows, ((int)(resources.GetObject("startOnWindows.IconPadding"))));
            this.startOnWindows.Name = "startOnWindows";
            this.startOnWindows.UseVisualStyleBackColor = false;
            // 
            // startMinimized
            // 
            resources.ApplyResources(this.startMinimized, "startMinimized");
            this.startMinimized.BackColor = System.Drawing.Color.Transparent;
            this.Error.SetError(this.startMinimized, resources.GetString("startMinimized.Error"));
            this.Error.SetIconAlignment(this.startMinimized, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("startMinimized.IconAlignment"))));
            this.Error.SetIconPadding(this.startMinimized, ((int)(resources.GetObject("startMinimized.IconPadding"))));
            this.startMinimized.Name = "startMinimized";
            this.startMinimized.UseVisualStyleBackColor = false;
            // 
            // startServing
            // 
            resources.ApplyResources(this.startServing, "startServing");
            this.startServing.BackColor = System.Drawing.Color.Transparent;
            this.Error.SetError(this.startServing, resources.GetString("startServing.Error"));
            this.Error.SetIconAlignment(this.startServing, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("startServing.IconAlignment"))));
            this.Error.SetIconPadding(this.startServing, ((int)(resources.GetObject("startServing.IconPadding"))));
            this.startServing.Name = "startServing";
            this.startServing.UseVisualStyleBackColor = false;
            // 
            // Browse
            // 
            resources.ApplyResources(this.Browse, "Browse");
            this.Browse.BackColor = System.Drawing.Color.Transparent;
            this.Error.SetError(this.Browse, resources.GetString("Browse.Error"));
            this.Error.SetIconAlignment(this.Browse, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Browse.IconAlignment"))));
            this.Error.SetIconPadding(this.Browse, ((int)(resources.GetObject("Browse.IconPadding"))));
            this.Browse.Name = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // LHTTP_PORT
            // 
            resources.ApplyResources(this.LHTTP_PORT, "LHTTP_PORT");
            this.LHTTP_PORT.BackColor = System.Drawing.Color.Transparent;
            this.LHTTP_PORT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Error.SetError(this.LHTTP_PORT, resources.GetString("LHTTP_PORT.Error"));
            this.Error.SetIconAlignment(this.LHTTP_PORT, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LHTTP_PORT.IconAlignment"))));
            this.Error.SetIconPadding(this.LHTTP_PORT, ((int)(resources.GetObject("LHTTP_PORT.IconPadding"))));
            this.LHTTP_PORT.Name = "LHTTP_PORT";
            // 
            // LHTTP_FOLDER
            // 
            resources.ApplyResources(this.LHTTP_FOLDER, "LHTTP_FOLDER");
            this.LHTTP_FOLDER.BackColor = System.Drawing.Color.Transparent;
            this.LHTTP_FOLDER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Error.SetError(this.LHTTP_FOLDER, resources.GetString("LHTTP_FOLDER.Error"));
            this.Error.SetIconAlignment(this.LHTTP_FOLDER, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("LHTTP_FOLDER.IconAlignment"))));
            this.Error.SetIconPadding(this.LHTTP_FOLDER, ((int)(resources.GetObject("LHTTP_FOLDER.IconPadding"))));
            this.LHTTP_FOLDER.Name = "LHTTP_FOLDER";
            // 
            // ATTACH_FOLDER
            // 
            resources.ApplyResources(this.ATTACH_FOLDER, "ATTACH_FOLDER");
            this.Error.SetError(this.ATTACH_FOLDER, resources.GetString("ATTACH_FOLDER.Error"));
            this.Error.SetIconAlignment(this.ATTACH_FOLDER, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("ATTACH_FOLDER.IconAlignment"))));
            this.Error.SetIconPadding(this.ATTACH_FOLDER, ((int)(resources.GetObject("ATTACH_FOLDER.IconPadding"))));
            this.ATTACH_FOLDER.Name = "ATTACH_FOLDER";
            this.ATTACH_FOLDER.Validating += new System.ComponentModel.CancelEventHandler(this.ATTACH_FOLDER_Validating);
            this.ATTACH_FOLDER.Validated += new System.EventHandler(this.ATTACH_FOLDER_Validated);
            // 
            // Stop
            // 
            resources.ApplyResources(this.Stop, "Stop");
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Error.SetError(this.Stop, resources.GetString("Stop.Error"));
            this.Error.SetIconAlignment(this.Stop, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Stop.IconAlignment"))));
            this.Error.SetIconPadding(this.Stop, ((int)(resources.GetObject("Stop.IconPadding"))));
            this.Stop.Name = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Start
            // 
            resources.ApplyResources(this.Start, "Start");
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Error.SetError(this.Start, resources.GetString("Start.Error"));
            this.Error.SetIconAlignment(this.Start, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Start.IconAlignment"))));
            this.Error.SetIconPadding(this.Start, ((int)(resources.GetObject("Start.IconPadding"))));
            this.Start.Name = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // HTTP_PORT
            // 
            resources.ApplyResources(this.HTTP_PORT, "HTTP_PORT");
            this.Error.SetError(this.HTTP_PORT, resources.GetString("HTTP_PORT.Error"));
            this.Error.SetIconAlignment(this.HTTP_PORT, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("HTTP_PORT.IconAlignment"))));
            this.Error.SetIconPadding(this.HTTP_PORT, ((int)(resources.GetObject("HTTP_PORT.IconPadding"))));
            this.HTTP_PORT.Name = "HTTP_PORT";
            this.HTTP_PORT.Validating += new System.ComponentModel.CancelEventHandler(this.HTTP_PORT_Validating);
            this.HTTP_PORT.Validated += new System.EventHandler(this.HTTP_PORT_Validated);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Error.SetError(this.label1, resources.GetString("label1.Error"));
            this.Error.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.Error.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // contextMenu
            // 
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem8});
            resources.ApplyResources(this.contextMenu, "contextMenu");
            // 
            // menuItem1
            // 
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Index = 0;
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Index = 1;
            this.menuItem2.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // menuItem3
            // 
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Index = 2;
            // 
            // menuItem4
            // 
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Index = 3;
            this.menuItem4.Click += new System.EventHandler(this.Start_Click);
            // 
            // menuItem5
            // 
            resources.ApplyResources(this.menuItem5, "menuItem5");
            this.menuItem5.Index = 4;
            this.menuItem5.Click += new System.EventHandler(this.Stop_Click);
            // 
            // menuItem8
            // 
            resources.ApplyResources(this.menuItem8, "menuItem8");
            this.menuItem8.Index = 5;
            this.menuItem8.Click += new System.EventHandler(this.btClose_Click);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenu = this.contextMenu;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            resources.ApplyResources(this.Error, "Error");
            // 
            // btClose
            // 
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Error.SetError(this.btClose, resources.GetString("btClose.Error"));
            this.Error.SetIconAlignment(this.btClose, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btClose.IconAlignment"))));
            this.Error.SetIconPadding(this.btClose, ((int)(resources.GetObject("btClose.IconPadding"))));
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimize
            // 
            resources.ApplyResources(this.btMinimize, "btMinimize");
            this.btMinimize.BackColor = System.Drawing.Color.Transparent;
            this.Error.SetError(this.btMinimize, resources.GetString("btMinimize.Error"));
            this.Error.SetIconAlignment(this.btMinimize, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btMinimize.IconAlignment"))));
            this.Error.SetIconPadding(this.btMinimize, ((int)(resources.GetObject("btMinimize.IconPadding"))));
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Error.SetError(this.label2, resources.GetString("label2.Error"));
            this.Error.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.Error.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // FolderBrowser
            // 
            resources.ApplyResources(this.FolderBrowser, "FolderBrowser");
            // 
            // Sed2OutlookFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ControlBox = false;
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startOnWindows);
            this.Controls.Add(this.startMinimized);
            this.Controls.Add(this.startServing);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.LHTTP_PORT);
            this.Controls.Add(this.LHTTP_FOLDER);
            this.Controls.Add(this.ATTACH_FOLDER);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.HTTP_PORT);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label LHTTP_FOLDER;
        private System.Windows.Forms.TextBox ATTACH_FOLDER;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox HTTP_PORT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider Error;
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Label label2;
    }
}

