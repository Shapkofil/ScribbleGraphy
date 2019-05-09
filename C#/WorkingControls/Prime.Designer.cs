namespace WorkingControls
{
    partial class Prime
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Free Writing");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Practice");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Template Writing");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Activities", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("All Characters");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("My Characters");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Gallery", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prime));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templaeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GalleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSidePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Tag = "tools";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.activitiesToolStripMenuItem,
            this.GalleryToolStripMenuItem,
            this.openAllToolStripMenuItem,
            this.toolStripMenuItem10,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Tag = "utils";
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Free Writing";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practiceToolStripMenuItem,
            this.templaeToolStripMenuItem});
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // practiceToolStripMenuItem
            // 
            this.practiceToolStripMenuItem.Name = "practiceToolStripMenuItem";
            this.practiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.practiceToolStripMenuItem.Text = "Practice";
            this.practiceToolStripMenuItem.Click += new System.EventHandler(this.practiceToolStripMenuItem_Click);
            // 
            // templaeToolStripMenuItem
            // 
            this.templaeToolStripMenuItem.Name = "templaeToolStripMenuItem";
            this.templaeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.templaeToolStripMenuItem.Text = "Template Writing";
            this.templaeToolStripMenuItem.Click += new System.EventHandler(this.templateToolStripMenuItem_Click);
            // 
            // GalleryToolStripMenuItem
            // 
            this.GalleryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCharactersToolStripMenuItem,
            this.myCharactersToolStripMenuItem});
            this.GalleryToolStripMenuItem.Name = "GalleryToolStripMenuItem";
            this.GalleryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GalleryToolStripMenuItem.Text = "Gallery";
            // 
            // allCharactersToolStripMenuItem
            // 
            this.allCharactersToolStripMenuItem.Name = "allCharactersToolStripMenuItem";
            this.allCharactersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allCharactersToolStripMenuItem.Text = "All Characters";
            this.allCharactersToolStripMenuItem.Click += new System.EventHandler(this.allCharactersToolStripMenuItem_Click);
            // 
            // myCharactersToolStripMenuItem
            // 
            this.myCharactersToolStripMenuItem.Name = "myCharactersToolStripMenuItem";
            this.myCharactersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myCharactersToolStripMenuItem.Text = "My Characters";
            this.myCharactersToolStripMenuItem.Click += new System.EventHandler(this.myCharactersToolStripMenuItem_Click);
            // 
            // openAllToolStripMenuItem
            // 
            this.openAllToolStripMenuItem.Name = "openAllToolStripMenuItem";
            this.openAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openAllToolStripMenuItem.Text = "Open All";
            this.openAllToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "--------------------";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSidePanelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Tag = "utils";
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // showSidePanelToolStripMenuItem
            // 
            this.showSidePanelToolStripMenuItem.Checked = true;
            this.showSidePanelToolStripMenuItem.CheckOnClick = true;
            this.showSidePanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSidePanelToolStripMenuItem.Name = "showSidePanelToolStripMenuItem";
            this.showSidePanelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.showSidePanelToolStripMenuItem.Text = "Show Side Panel";
            this.showSidePanelToolStripMenuItem.Click += new System.EventHandler(this.showSidePanelToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Tag = "utils";
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Free Writing";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Practice";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Template Writing";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Activities";
            treeNode5.Name = "Node4";
            treeNode5.Text = "All Characters";
            treeNode6.Name = "Node5";
            treeNode6.Text = "My Characters";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Gallery";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(167, 376);
            this.treeView1.TabIndex = 7;
            this.treeView1.Tag = "utils";
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // Prime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 400);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Prime";
            this.Text = "Border";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSidePanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GalleryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem templaeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCharactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
    }
}