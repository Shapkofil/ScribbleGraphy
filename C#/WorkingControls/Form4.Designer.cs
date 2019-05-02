namespace WorkingControls
{
    partial class Form4
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
            this.DrawableContainer = new System.Windows.Forms.Panel();
            this.drawable = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simbolLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PredictionDisplay = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawableContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawableContainer
            // 
            this.DrawableContainer.BackColor = System.Drawing.Color.DarkGray;
            this.DrawableContainer.Controls.Add(this.drawable);
            this.DrawableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawableContainer.Location = new System.Drawing.Point(205, 86);
            this.DrawableContainer.Name = "DrawableContainer";
            this.DrawableContainer.Size = new System.Drawing.Size(489, 432);
            this.DrawableContainer.TabIndex = 19;
            // 
            // drawable
            // 
            this.drawable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawable.BackColor = System.Drawing.Color.Black;
            this.drawable.Location = new System.Drawing.Point(-13, -40);
            this.drawable.Margin = new System.Windows.Forms.Padding(4);
            this.drawable.Name = "drawable";
            this.drawable.Size = new System.Drawing.Size(512, 512);
            this.drawable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.simbolLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.PredictionDisplay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(694, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 432);
            this.panel2.TabIndex = 18;
            // 
            // simbolLabel
            // 
            this.simbolLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simbolLabel.AutoSize = true;
            this.simbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simbolLabel.Location = new System.Drawing.Point(69, 245);
            this.simbolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.simbolLabel.Name = "simbolLabel";
            this.simbolLabel.Size = new System.Drawing.Size(142, 32);
            this.simbolLabel.TabIndex = 3;
            this.simbolLabel.Tag = "focus";
            this.simbolLabel.Text = "Loading...";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(38, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 71);
            this.button1.TabIndex = 2;
            this.button1.Tag = "focus";
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PredictionDisplay
            // 
            this.PredictionDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PredictionDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PredictionDisplay.Location = new System.Drawing.Point(38, 45);
            this.PredictionDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.PredictionDisplay.Name = "PredictionDisplay";
            this.PredictionDisplay.Size = new System.Drawing.Size(199, 184);
            this.PredictionDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PredictionDisplay.TabIndex = 1;
            this.PredictionDisplay.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(205, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 58);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(969, 518);
            this.Controls.Add(this.DrawableContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.DrawableContainer, 0);
            this.DrawableContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DrawableContainer;
        private System.Windows.Forms.Panel drawable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label simbolLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PredictionDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
