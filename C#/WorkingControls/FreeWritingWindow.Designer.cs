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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.PredictionDisplay = new System.Windows.Forms.PictureBox();
            this.DrawableContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).BeginInit();
            this.DrawableContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            resources.ApplyResources(this.ClearButton, "ClearButton");
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Tag = "focus";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // simbolLabel
            // 
            resources.ApplyResources(this.simbolLabel, "simbolLabel");
            this.simbolLabel.Name = "simbolLabel";
            this.simbolLabel.Tag = "focus";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Tag = "focus";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // drawable
            // 
            resources.ApplyResources(this.drawable, "drawable");
            this.drawable.BackColor = System.Drawing.Color.Black;
            this.drawable.Name = "drawable";
            this.drawable.Paint += new System.Windows.Forms.PaintEventHandler(this.drawable_Paint);
            this.drawable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawable_MouseDown);
            this.drawable.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawable_MouseMove);
            this.drawable.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawable_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mainLabel);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ExitButton
            // 
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Tag = "focus";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // mainLabel
            // 
            resources.ApplyResources(this.mainLabel, "mainLabel");
            this.mainLabel.Name = "mainLabel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NextButton);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.simbolLabel);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.PredictionDisplay);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // NextButton
            // 
            resources.ApplyResources(this.NextButton, "NextButton");
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.Name = "NextButton";
            this.NextButton.Tag = "focus";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PredictionDisplay
            // 
            resources.ApplyResources(this.PredictionDisplay, "PredictionDisplay");
            this.PredictionDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PredictionDisplay.Name = "PredictionDisplay";
            this.PredictionDisplay.TabStop = false;
            this.PredictionDisplay.Click += new System.EventHandler(this.PredictionDisplay_Click);
            // 
            // DrawableContainer
            // 
            this.DrawableContainer.BackColor = System.Drawing.Color.DarkGray;
            this.DrawableContainer.Controls.Add(this.drawable);
            resources.ApplyResources(this.DrawableContainer, "DrawableContainer");
            this.DrawableContainer.Name = "DrawableContainer";
            // 
            // FreeWritingWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.DrawableContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FreeWritingWindow";
            this.Tag = "focus";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.DrawableContainer, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PredictionDisplay)).EndInit();
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
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel DrawableContainer;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

