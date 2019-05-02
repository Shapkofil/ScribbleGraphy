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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tutorials");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Activities", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("All Characters");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("My Characters");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Gallery", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prime));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSidePanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFreeWritingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGalleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mGEXPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.helpToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.mGEXPOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(695, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Tag = "tools";
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Tag = "utils";
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSidePanelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Tag = "utils";
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // showSidePanelToolStripMenuItem
            // 
            this.showSidePanelToolStripMenuItem.Checked = true;
            this.showSidePanelToolStripMenuItem.CheckOnClick = true;
            this.showSidePanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showSidePanelToolStripMenuItem.Name = "showSidePanelToolStripMenuItem";
            this.showSidePanelToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.showSidePanelToolStripMenuItem.Text = "Show Side Panel";
            this.showSidePanelToolStripMenuItem.Click += new System.EventHandler(this.showSidePanelToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Tag = "utils";
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAllToolStripMenuItem,
            this.openFreeWritingToolStripMenuItem,
            this.openGalleryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.helpToolStripMenuItem.Tag = "utils";
            this.helpToolStripMenuItem.Text = "Windows";
            // 
            // openAllToolStripMenuItem
            // 
            this.openAllToolStripMenuItem.Name = "openAllToolStripMenuItem";
            this.openAllToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openAllToolStripMenuItem.Text = "Open All";
            this.openAllToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // openFreeWritingToolStripMenuItem
            // 
            this.openFreeWritingToolStripMenuItem.Name = "openFreeWritingToolStripMenuItem";
            this.openFreeWritingToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openFreeWritingToolStripMenuItem.Text = "Open Free Writing";
            // 
            // openGalleryToolStripMenuItem
            // 
            this.openGalleryToolStripMenuItem.Name = "openGalleryToolStripMenuItem";
            this.openGalleryToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.openGalleryToolStripMenuItem.Text = "Open Gallery";
            this.openGalleryToolStripMenuItem.Click += new System.EventHandler(this.openAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Control;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(0, 28);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Free Writing";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Tutorials";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Activities";
            treeNode4.Name = "Node4";
            treeNode4.Text = "All Characters";
            treeNode5.Name = "Node5";
            treeNode5.Text = "My Characters";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Gallery";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(205, 464);
            this.treeView1.TabIndex = 7;
            this.treeView1.Tag = "utils";
            // 
            // mGEXPOToolStripMenuItem
            // 
            this.mGEXPOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameDemoToolStripMenuItem});
            this.mGEXPOToolStripMenuItem.Name = "mGEXPOToolStripMenuItem";
            this.mGEXPOToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.mGEXPOToolStripMenuItem.Text = "MGEXPO";
            // 
            // gameDemoToolStripMenuItem
            // 
            this.gameDemoToolStripMenuItem.Name = "gameDemoToolStripMenuItem";
            this.gameDemoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gameDemoToolStripMenuItem.Text = "GameDemo";
            this.gameDemoToolStripMenuItem.Click += new System.EventHandler(this.GameDemoToolStripMenuItem_Click);
            // 
            // Prime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 492);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem openAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFreeWritingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openGalleryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mGEXPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameDemoToolStripMenuItem;
    }
}