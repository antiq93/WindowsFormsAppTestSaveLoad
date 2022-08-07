
namespace WindowsFormsAppTestSaveLoad
{
    partial class Form1
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
            this.lbl_pPath = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_sName = new System.Windows.Forms.Label();
            this.lbl_dbName = new System.Windows.Forms.Label();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.lbl_pword = new System.Windows.Forms.Label();
            this.lbl_parms = new System.Windows.Forms.Label();
            this.btn_saveAs = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txtB_sName = new System.Windows.Forms.TextBox();
            this.txtB_dbName = new System.Windows.Forms.TextBox();
            this.txtB_uname = new System.Windows.Forms.TextBox();
            this.txtB_pword = new System.Windows.Forms.TextBox();
            this.rtxtB_parms = new System.Windows.Forms.RichTextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.listB_recent = new System.Windows.Forms.ListBox();
            this.cmbB_recent = new System.Windows.Forms.ComboBox();
            this.btn_recent = new System.Windows.Forms.Button();
            this.btn_recentSave = new System.Windows.Forms.Button();
            this.lbl_recent = new System.Windows.Forms.Label();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_pPath
            // 
            this.lbl_pPath.AutoSize = true;
            this.lbl_pPath.Location = new System.Drawing.Point(9, 9);
            this.lbl_pPath.Name = "lbl_pPath";
            this.lbl_pPath.Size = new System.Drawing.Size(65, 13);
            this.lbl_pPath.TabIndex = 0;
            this.lbl_pPath.Text = "Project Path";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(153, 9);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(46, 13);
            this.lbl_path.TabIndex = 1;
            this.lbl_path.Text = "No Path";
            this.lbl_path.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 298);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_sName
            // 
            this.lbl_sName.AutoSize = true;
            this.lbl_sName.Location = new System.Drawing.Point(9, 55);
            this.lbl_sName.Name = "lbl_sName";
            this.lbl_sName.Size = new System.Drawing.Size(69, 13);
            this.lbl_sName.TabIndex = 3;
            this.lbl_sName.Text = "Server Name";
            // 
            // lbl_dbName
            // 
            this.lbl_dbName.AutoSize = true;
            this.lbl_dbName.Location = new System.Drawing.Point(9, 90);
            this.lbl_dbName.Name = "lbl_dbName";
            this.lbl_dbName.Size = new System.Drawing.Size(85, 13);
            this.lbl_dbName.TabIndex = 4;
            this.lbl_dbName.Text = "DataBase Name";
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Location = new System.Drawing.Point(9, 125);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(55, 13);
            this.lbl_uname.TabIndex = 5;
            this.lbl_uname.Text = "Username";
            // 
            // lbl_pword
            // 
            this.lbl_pword.AutoSize = true;
            this.lbl_pword.Location = new System.Drawing.Point(9, 160);
            this.lbl_pword.Name = "lbl_pword";
            this.lbl_pword.Size = new System.Drawing.Size(53, 13);
            this.lbl_pword.TabIndex = 6;
            this.lbl_pword.Text = "Password";
            // 
            // lbl_parms
            // 
            this.lbl_parms.AutoSize = true;
            this.lbl_parms.Location = new System.Drawing.Point(203, 26);
            this.lbl_parms.Name = "lbl_parms";
            this.lbl_parms.Size = new System.Drawing.Size(69, 13);
            this.lbl_parms.TabIndex = 7;
            this.lbl_parms.Text = "Parameters->";
            // 
            // btn_saveAs
            // 
            this.btn_saveAs.Location = new System.Drawing.Point(12, 327);
            this.btn_saveAs.Name = "btn_saveAs";
            this.btn_saveAs.Size = new System.Drawing.Size(75, 23);
            this.btn_saveAs.TabIndex = 8;
            this.btn_saveAs.Text = "Save As";
            this.btn_saveAs.UseVisualStyleBackColor = true;
            this.btn_saveAs.Click += new System.EventHandler(this.btn_saveAs_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 356);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 38);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear All Fields";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txtB_sName
            // 
            this.txtB_sName.Location = new System.Drawing.Point(156, 52);
            this.txtB_sName.Name = "txtB_sName";
            this.txtB_sName.Size = new System.Drawing.Size(100, 20);
            this.txtB_sName.TabIndex = 10;
            this.txtB_sName.TextChanged += new System.EventHandler(this.txtB_sName_TextChanged);
            // 
            // txtB_dbName
            // 
            this.txtB_dbName.Location = new System.Drawing.Point(156, 87);
            this.txtB_dbName.Name = "txtB_dbName";
            this.txtB_dbName.Size = new System.Drawing.Size(100, 20);
            this.txtB_dbName.TabIndex = 11;
            // 
            // txtB_uname
            // 
            this.txtB_uname.Location = new System.Drawing.Point(156, 122);
            this.txtB_uname.Name = "txtB_uname";
            this.txtB_uname.Size = new System.Drawing.Size(100, 20);
            this.txtB_uname.TabIndex = 12;
            // 
            // txtB_pword
            // 
            this.txtB_pword.Location = new System.Drawing.Point(156, 157);
            this.txtB_pword.Name = "txtB_pword";
            this.txtB_pword.PasswordChar = '●';
            this.txtB_pword.Size = new System.Drawing.Size(100, 20);
            this.txtB_pword.TabIndex = 13;
            // 
            // rtxtB_parms
            // 
            this.rtxtB_parms.Location = new System.Drawing.Point(278, 23);
            this.rtxtB_parms.Name = "rtxtB_parms";
            this.rtxtB_parms.Size = new System.Drawing.Size(496, 269);
            this.rtxtB_parms.TabIndex = 14;
            this.rtxtB_parms.Text = "";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 269);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 15;
            this.btn_load.Text = "Load Project";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 400);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 38);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Undo All Changes";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 240);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 17;
            this.btn_new.Text = "New Project";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // listB_recent
            // 
            this.listB_recent.FormattingEnabled = true;
            this.listB_recent.Location = new System.Drawing.Point(156, 304);
            this.listB_recent.Name = "listB_recent";
            this.listB_recent.Size = new System.Drawing.Size(618, 134);
            this.listB_recent.TabIndex = 18;
            // 
            // cmbB_recent
            // 
            this.cmbB_recent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbB_recent.FormattingEnabled = true;
            this.cmbB_recent.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbB_recent.Location = new System.Drawing.Point(156, 200);
            this.cmbB_recent.Name = "cmbB_recent";
            this.cmbB_recent.Size = new System.Drawing.Size(35, 21);
            this.cmbB_recent.TabIndex = 19;
            this.cmbB_recent.SelectedIndexChanged += new System.EventHandler(this.cmbB_recent_SelectedIndexChanged);
            // 
            // btn_recent
            // 
            this.btn_recent.Location = new System.Drawing.Point(88, 278);
            this.btn_recent.Name = "btn_recent";
            this.btn_recent.Size = new System.Drawing.Size(62, 75);
            this.btn_recent.TabIndex = 20;
            this.btn_recent.Text = "Load Selected Recent File";
            this.btn_recent.UseVisualStyleBackColor = true;
            this.btn_recent.Click += new System.EventHandler(this.btn_recent_Click);
            // 
            // btn_recentSave
            // 
            this.btn_recentSave.Location = new System.Drawing.Point(197, 183);
            this.btn_recentSave.Name = "btn_recentSave";
            this.btn_recentSave.Size = new System.Drawing.Size(75, 53);
            this.btn_recentSave.TabIndex = 21;
            this.btn_recentSave.Text = "Save <-Config Changes";
            this.btn_recentSave.UseVisualStyleBackColor = true;
            this.btn_recentSave.Click += new System.EventHandler(this.btn_recentSave_Click);
            // 
            // lbl_recent
            // 
            this.lbl_recent.AutoSize = true;
            this.lbl_recent.Location = new System.Drawing.Point(153, 289);
            this.lbl_recent.Name = "lbl_recent";
            this.lbl_recent.Size = new System.Drawing.Size(63, 13);
            this.lbl_recent.TabIndex = 22;
            this.lbl_recent.Text = "Recent files";
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(222, 289);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(522, 13);
            this.lbl_warning.TabIndex = 23;
            this.lbl_warning.Text = "Warning, save button is buggy. Everything else should be fine. Don\'t load recent " +
    "file if no file is selected in list.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.lbl_recent);
            this.Controls.Add(this.btn_recentSave);
            this.Controls.Add(this.btn_recent);
            this.Controls.Add(this.cmbB_recent);
            this.Controls.Add(this.listB_recent);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.rtxtB_parms);
            this.Controls.Add(this.txtB_pword);
            this.Controls.Add(this.txtB_uname);
            this.Controls.Add(this.txtB_dbName);
            this.Controls.Add(this.txtB_sName);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_saveAs);
            this.Controls.Add(this.lbl_parms);
            this.Controls.Add(this.lbl_pword);
            this.Controls.Add(this.lbl_uname);
            this.Controls.Add(this.lbl_dbName);
            this.Controls.Add(this.lbl_sName);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.lbl_pPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pPath;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_sName;
        private System.Windows.Forms.Label lbl_dbName;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label lbl_pword;
        private System.Windows.Forms.Label lbl_parms;
        private System.Windows.Forms.Button btn_saveAs;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txtB_sName;
        private System.Windows.Forms.TextBox txtB_dbName;
        private System.Windows.Forms.TextBox txtB_uname;
        private System.Windows.Forms.TextBox txtB_pword;
        private System.Windows.Forms.RichTextBox rtxtB_parms;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.ListBox listB_recent;
        private System.Windows.Forms.ComboBox cmbB_recent;
        private System.Windows.Forms.Button btn_recent;
        private System.Windows.Forms.Button btn_recentSave;
        private System.Windows.Forms.Label lbl_recent;
        private System.Windows.Forms.Label lbl_warning;
    }
}

