namespace Optimum
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AboutBox = new System.Windows.Forms.TextBox();
            this.ByBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(464, 321);
            this.MainPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ByBox);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 281);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(464, 40);
            this.BottomPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.AboutBox);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(464, 281);
            this.TopPanel.TabIndex = 1;
            // 
            // AboutBox
            // 
            this.AboutBox.BackColor = System.Drawing.Color.White;
            this.AboutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutBox.Location = new System.Drawing.Point(0, 0);
            this.AboutBox.Multiline = true;
            this.AboutBox.Name = "AboutBox";
            this.AboutBox.ReadOnly = true;
            this.AboutBox.Size = new System.Drawing.Size(464, 281);
            this.AboutBox.TabIndex = 1;
            this.AboutBox.TabStop = false;
            this.AboutBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ByBox
            // 
            this.ByBox.BackColor = System.Drawing.Color.White;
            this.ByBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ByBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ByBox.Location = new System.Drawing.Point(0, 0);
            this.ByBox.Multiline = true;
            this.ByBox.Name = "ByBox";
            this.ByBox.ReadOnly = true;
            this.ByBox.Size = new System.Drawing.Size(464, 40);
            this.ByBox.TabIndex = 1;
            this.ByBox.TabStop = false;
            this.ByBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "About";
            this.Text = "About";
            this.MainPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox AboutBox;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox ByBox;
    }
}