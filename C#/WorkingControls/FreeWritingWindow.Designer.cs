namespace WorkingControls
{
    partial class FreeWritingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeWritingWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.simbolLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.drawable = new System.Windows.Forms.Panel();
            this.PredictionDisplay = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DrawableContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DrawableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(38, 307);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 71);
            this.button1.TabIndex = 2;
            this.button1.Tag = "focus";
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(38, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 82);
            this.button2.TabIndex = 6;
            this.button2.Tag = "focus";
            this.button2.Text = "Save to Gallery";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drawable
            // 
            this.drawable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawable.BackColor = System.Drawing.Color.Black;
            this.drawable.Location = new System.Drawing.Point(33, 8);
            this.drawable.Margin = new System.Windows.Forms.Padding(4);
            this.drawable.Name = "drawable";
            this.drawable.Size = new System.Drawing.Size(512, 512);
            this.drawable.TabIndex = 0;
            this.drawable.Paint += new System.Windows.Forms.PaintEventHandler(this.drawable_Paint);
            this.drawable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawable_MouseDown);
            this.drawable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawable_MouseMove);
            this.drawable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawable_MouseUp);
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
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(205, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 58);
            this.panel1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(561, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Writing system:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Free Writing";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.simbolLabel);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.PredictionDisplay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(785, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 528);
            this.panel2.TabIndex = 15;
            // 
            // DrawableContainer
            // 
            this.DrawableContainer.BackColor = System.Drawing.Color.DarkGray;
            this.DrawableContainer.Controls.Add(this.drawable);
            this.DrawableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawableContainer.Location = new System.Drawing.Point(205, 86);
            this.DrawableContainer.Name = "DrawableContainer";
            this.DrawableContainer.Size = new System.Drawing.Size(580, 528);
            this.DrawableContainer.TabIndex = 16;
            // 
            // FreeWritingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 614);
            this.Controls.Add(this.DrawableContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1078, 661);
            this.Name = "FreeWritingWindow";
            this.Tag = "focus";
            this.Text = "ScribbleGraphy";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.DrawableContainer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DrawableContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PredictionDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label simbolLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel drawable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DrawableContainer;
    }
}

