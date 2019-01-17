namespace Checkpoint2
{
    partial class Main
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblActors = new System.Windows.Forms.Label();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRead = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboActor = new System.Windows.Forms.ComboBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.opnTextFile = new System.Windows.Forms.OpenFileDialog();
            this.savTextFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "&Delete from Arraylist";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(280, 46);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(119, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "&Insert into Arraylist";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Actor &Name";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(12, 88);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "&Position";
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(12, 133);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(37, 13);
            this.lblActors.TabIndex = 4;
            this.lblActors.Text = "&Actors";
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(444, 24);
            this.mnuMain.TabIndex = 5;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRead,
            this.mnuWrite,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuRead
            // 
            this.mnuRead.Name = "mnuRead";
            this.mnuRead.Size = new System.Drawing.Size(154, 22);
            this.mnuRead.Text = "&Read Array List";
            this.mnuRead.Click += new System.EventHandler(this.mnuRead_Click);
            // 
            // mnuWrite
            // 
            this.mnuWrite.Name = "mnuWrite";
            this.mnuWrite.Size = new System.Drawing.Size(154, 22);
            this.mnuWrite.Text = "&Write Array List";
            this.mnuWrite.Click += new System.EventHandler(this.mnuWrite_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(154, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // cboActor
            // 
            this.cboActor.FormattingEnabled = true;
            this.cboActor.Location = new System.Drawing.Point(81, 130);
            this.cboActor.Name = "cboActor";
            this.cboActor.Size = new System.Drawing.Size(151, 21);
            this.cboActor.TabIndex = 6;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(81, 85);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(47, 20);
            this.txtPosition.TabIndex = 7;
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(81, 46);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(151, 20);
            this.txtActorName.TabIndex = 8;
            // 
            // opnTextFile
            // 
            this.opnTextFile.FileName = "extFile";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // Main
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 187);
            this.Controls.Add(this.txtActorName);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.cboActor);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "Main";
            this.Text = "Array Lists";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuRead;
        private System.Windows.Forms.ToolStripMenuItem mnuWrite;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox cboActor;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.OpenFileDialog opnTextFile;
        private System.Windows.Forms.SaveFileDialog savTextFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

