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
            this.ClearButton = new System.Windows.Forms.Button();
            this.simbolLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.drawable = new System.Windows.Forms.Panel();
            this.PredictionDisplay = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.DrawableContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DrawableContainer.SuspendLayout();
            this.SuspendLayout();
            //
            // ClearButton
            //
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(28, 227);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(138, 50);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Tag = "focus";
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            //
            // simbolLabel
            //
            this.simbolLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simbolLabel.AutoSize = true;
            this.simbolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simbolLabel.Location = new System.Drawing.Point(46, 178);
            this.simbolLabel.Name = "simbolLabel";
            this.simbolLabel.Size = new System.Drawing.Size(107, 26);
            this.simbolLabel.TabIndex = 3;
            this.simbolLabel.Tag = "focus";
            this.simbolLabel.Text = "Loading...";
            //
            // SaveButton
            //
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(29, 283);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 50);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Tag = "focus";
            this.SaveButton.Text = "Save to Gallery";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            //
            // drawable
            //
            this.drawable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawable.BackColor = System.Drawing.Color.Black;
            this.drawable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawable.Location = new System.Drawing.Point(22, 22);
            this.drawable.Name = "drawable";
            this.drawable.Size = new System.Drawing.Size(390, 390);
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
            this.PredictionDisplay.Location = new System.Drawing.Point(22, 9);
            this.PredictionDisplay.Name = "PredictionDisplay";
            this.PredictionDisplay.Size = new System.Drawing.Size(150, 150);
            this.PredictionDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PredictionDisplay.TabIndex = 1;
            this.PredictionDisplay.TabStop = false;
            this.PredictionDisplay.Click += new System.EventHandler(this.PredictionDisplay_Click);
            //
            // panel1
            //
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(167, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 47);
            this.panel1.TabIndex = 14;
            //
            // ExitButton
            //
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.Location = new System.Drawing.Point(145, 16);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 25);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Tag = "focus";
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Visible = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            //
            // comboBox1
            //
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(408, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            //
            // label2
            //
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(286, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Writing system:";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Free Writing";
            //
            // panel2
            //
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.simbolLabel);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.PredictionDisplay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(601, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 434);
            this.panel2.TabIndex = 15;
            //
            // NextButton
            //
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButton.Location = new System.Drawing.Point(29, 339);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(138, 50);
            this.NextButton.TabIndex = 7;
            this.NextButton.Tag = "focus";
            this.NextButton.Text = "Next Character";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            //
            // DrawableContainer
            //
            this.DrawableContainer.BackColor = System.Drawing.Color.DarkGray;
            this.DrawableContainer.Controls.Add(this.drawable);
            this.DrawableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawableContainer.Location = new System.Drawing.Point(167, 71);
            this.DrawableContainer.Margin = new System.Windows.Forms.Padding(2);
            this.DrawableContainer.Name = "DrawableContainer";
            this.DrawableContainer.Size = new System.Drawing.Size(434, 434);
            this.DrawableContainer.TabIndex = 16;
            //
            // FreeWritingWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 505);
            this.Controls.Add(this.DrawableContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MinimumSize = new System.Drawing.Size(812, 544);
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
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label simbolLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel drawable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DrawableContainer;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
