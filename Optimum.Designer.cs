namespace Optimum
{
    partial class Optimum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optimum));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubmainPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.OutText = new System.Windows.Forms.TextBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ComputingButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.InformationPanel = new System.Windows.Forms.Panel();
            this.EpseelonBox = new System.Windows.Forms.TextBox();
            this.EpseelonLabel = new System.Windows.Forms.Label();
            this.InfoSLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.FunctionPanel = new System.Windows.Forms.Panel();
            this.FuncInput = new System.Windows.Forms.TextBox();
            this.FuncLabel = new System.Windows.Forms.Label();
            this.DelimiterPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.VarPanel = new System.Windows.Forms.Panel();
            this.BottomBorder = new System.Windows.Forms.Panel();
            this.TopBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileOfFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileOfResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileOfFunctionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileOfResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.SubmainPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.InformationPanel.SuspendLayout();
            this.FunctionPanel.SuspendLayout();
            this.DelimiterPanel.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SubmainPanel);
            this.MainPanel.Controls.Add(this.TopMenu);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(824, 381);
            this.MainPanel.TabIndex = 0;
            // 
            // SubmainPanel
            // 
            this.SubmainPanel.Controls.Add(this.RightPanel);
            this.SubmainPanel.Controls.Add(this.DelimiterPanel);
            this.SubmainPanel.Controls.Add(this.VarPanel);
            this.SubmainPanel.Controls.Add(this.BottomBorder);
            this.SubmainPanel.Controls.Add(this.TopBorder);
            this.SubmainPanel.Controls.Add(this.RightBorder);
            this.SubmainPanel.Controls.Add(this.LeftBorder);
            this.SubmainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmainPanel.Location = new System.Drawing.Point(0, 24);
            this.SubmainPanel.Name = "SubmainPanel";
            this.SubmainPanel.Size = new System.Drawing.Size(824, 357);
            this.SubmainPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.OutputPanel);
            this.RightPanel.Controls.Add(this.ButtonPanel);
            this.RightPanel.Controls.Add(this.InformationPanel);
            this.RightPanel.Controls.Add(this.FunctionPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPanel.Location = new System.Drawing.Point(325, 10);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(489, 337);
            this.RightPanel.TabIndex = 6;
            // 
            // OutputPanel
            // 
            this.OutputPanel.Controls.Add(this.OutText);
            this.OutputPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputPanel.Location = new System.Drawing.Point(0, 220);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(489, 117);
            this.OutputPanel.TabIndex = 3;
            // 
            // OutText
            // 
            this.OutText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutText.Location = new System.Drawing.Point(0, 0);
            this.OutText.Multiline = true;
            this.OutText.Name = "OutText";
            this.OutText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutText.Size = new System.Drawing.Size(489, 117);
            this.OutText.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.AbortButton);
            this.ButtonPanel.Controls.Add(this.ComputingButton);
            this.ButtonPanel.Controls.Add(this.CheckButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 150);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(489, 70);
            this.ButtonPanel.TabIndex = 2;
            // 
            // AbortButton
            // 
            this.AbortButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AbortButton.Location = new System.Drawing.Point(233, 0);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(128, 70);
            this.AbortButton.TabIndex = 2;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // ComputingButton
            // 
            this.ComputingButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComputingButton.Location = new System.Drawing.Point(361, 0);
            this.ComputingButton.Name = "ComputingButton";
            this.ComputingButton.Size = new System.Drawing.Size(128, 70);
            this.ComputingButton.TabIndex = 1;
            this.ComputingButton.Text = "Computing";
            this.ComputingButton.UseVisualStyleBackColor = true;
            this.ComputingButton.Click += new System.EventHandler(this.ComputingButton_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckButton.Location = new System.Drawing.Point(0, 0);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(128, 70);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // InformationPanel
            // 
            this.InformationPanel.Controls.Add(this.EpseelonBox);
            this.InformationPanel.Controls.Add(this.EpseelonLabel);
            this.InformationPanel.Controls.Add(this.InfoSLabel);
            this.InformationPanel.Controls.Add(this.InfoLabel);
            this.InformationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InformationPanel.Location = new System.Drawing.Point(0, 100);
            this.InformationPanel.Name = "InformationPanel";
            this.InformationPanel.Size = new System.Drawing.Size(489, 50);
            this.InformationPanel.TabIndex = 1;
            // 
            // EpseelonBox
            // 
            this.EpseelonBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EpseelonBox.Location = new System.Drawing.Point(407, 6);
            this.EpseelonBox.Name = "EpseelonBox";
            this.EpseelonBox.Size = new System.Drawing.Size(76, 31);
            this.EpseelonBox.TabIndex = 5;
            this.EpseelonBox.Text = "0,01";
            // 
            // EpseelonLabel
            // 
            this.EpseelonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EpseelonLabel.AutoSize = true;
            this.EpseelonLabel.Location = new System.Drawing.Point(351, 9);
            this.EpseelonLabel.Name = "EpseelonLabel";
            this.EpseelonLabel.Size = new System.Drawing.Size(50, 23);
            this.EpseelonLabel.TabIndex = 4;
            this.EpseelonLabel.Text = "ε = ";
            // 
            // InfoSLabel
            // 
            this.InfoSLabel.AutoSize = true;
            this.InfoSLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoSLabel.Location = new System.Drawing.Point(38, 0);
            this.InfoSLabel.Name = "InfoSLabel";
            this.InfoSLabel.Size = new System.Drawing.Size(22, 23);
            this.InfoSLabel.TabIndex = 3;
            this.InfoSLabel.Text = "2";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InfoLabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(0, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(38, 42);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "ℝ";
            // 
            // FunctionPanel
            // 
            this.FunctionPanel.Controls.Add(this.FuncInput);
            this.FunctionPanel.Controls.Add(this.FuncLabel);
            this.FunctionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FunctionPanel.Location = new System.Drawing.Point(0, 0);
            this.FunctionPanel.Name = "FunctionPanel";
            this.FunctionPanel.Size = new System.Drawing.Size(489, 100);
            this.FunctionPanel.TabIndex = 0;
            // 
            // FuncInput
            // 
            this.FuncInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FuncInput.Location = new System.Drawing.Point(100, 36);
            this.FuncInput.Name = "FuncInput";
            this.FuncInput.Size = new System.Drawing.Size(383, 31);
            this.FuncInput.TabIndex = 2;
            // 
            // FuncLabel
            // 
            this.FuncLabel.AutoSize = true;
            this.FuncLabel.Location = new System.Drawing.Point(23, 39);
            this.FuncLabel.Name = "FuncLabel";
            this.FuncLabel.Size = new System.Drawing.Size(76, 23);
            this.FuncLabel.TabIndex = 1;
            this.FuncLabel.Text = "f(x) = ";
            // 
            // DelimiterPanel
            // 
            this.DelimiterPanel.Controls.Add(this.RemoveButton);
            this.DelimiterPanel.Controls.Add(this.AddButton);
            this.DelimiterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.DelimiterPanel.Location = new System.Drawing.Point(280, 10);
            this.DelimiterPanel.Name = "DelimiterPanel";
            this.DelimiterPanel.Size = new System.Drawing.Size(45, 337);
            this.DelimiterPanel.TabIndex = 5;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(6, 64);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(32, 32);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "-";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(6, 18);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(32, 32);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // VarPanel
            // 
            this.VarPanel.AutoScroll = true;
            this.VarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.VarPanel.Location = new System.Drawing.Point(10, 10);
            this.VarPanel.Name = "VarPanel";
            this.VarPanel.Size = new System.Drawing.Size(270, 337);
            this.VarPanel.TabIndex = 4;
            // 
            // BottomBorder
            // 
            this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder.Location = new System.Drawing.Point(10, 347);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(804, 10);
            this.BottomBorder.TabIndex = 3;
            // 
            // TopBorder
            // 
            this.TopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBorder.Location = new System.Drawing.Point(10, 0);
            this.TopBorder.Name = "TopBorder";
            this.TopBorder.Size = new System.Drawing.Size(804, 10);
            this.TopBorder.TabIndex = 2;
            // 
            // RightBorder
            // 
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.Location = new System.Drawing.Point(814, 0);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(10, 357);
            this.RightBorder.TabIndex = 1;
            // 
            // LeftBorder
            // 
            this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder.Location = new System.Drawing.Point(0, 0);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(10, 357);
            this.LeftBorder.TabIndex = 0;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.SystemColors.Control;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(824, 24);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "TopMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileOfFunctionToolStripMenuItem,
            this.openFileOfResultToolStripMenuItem,
            this.saveFileOfFunctionToolStripMenuItem,
            this.saveFileOfResultToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileOfFunctionToolStripMenuItem
            // 
            this.openFileOfFunctionToolStripMenuItem.Name = "openFileOfFunctionToolStripMenuItem";
            this.openFileOfFunctionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openFileOfFunctionToolStripMenuItem.Text = "Open file of function";
            this.openFileOfFunctionToolStripMenuItem.Click += new System.EventHandler(this.openFileOfFunctionToolStripMenuItem_Click);
            // 
            // openFileOfResultToolStripMenuItem
            // 
            this.openFileOfResultToolStripMenuItem.Name = "openFileOfResultToolStripMenuItem";
            this.openFileOfResultToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openFileOfResultToolStripMenuItem.Text = "Open file of result";
            this.openFileOfResultToolStripMenuItem.Click += new System.EventHandler(this.openFileOfResultToolStripMenuItem_Click);
            // 
            // saveFileOfFunctionToolStripMenuItem
            // 
            this.saveFileOfFunctionToolStripMenuItem.Name = "saveFileOfFunctionToolStripMenuItem";
            this.saveFileOfFunctionToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveFileOfFunctionToolStripMenuItem.Text = "Save file of function";
            this.saveFileOfFunctionToolStripMenuItem.Click += new System.EventHandler(this.saveFileOfFunctionToolStripMenuItem_Click);
            // 
            // saveFileOfResultToolStripMenuItem
            // 
            this.saveFileOfResultToolStripMenuItem.Name = "saveFileOfResultToolStripMenuItem";
            this.saveFileOfResultToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveFileOfResultToolStripMenuItem.Text = "Save file of result";
            this.saveFileOfResultToolStripMenuItem.Click += new System.EventHandler(this.saveFileOfResultToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Optimum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 381);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(840, 420);
            this.Name = "Optimum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimum";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.SubmainPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            this.ButtonPanel.ResumeLayout(false);
            this.InformationPanel.ResumeLayout(false);
            this.InformationPanel.PerformLayout();
            this.FunctionPanel.ResumeLayout(false);
            this.FunctionPanel.PerformLayout();
            this.DelimiterPanel.ResumeLayout(false);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel SubmainPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.TextBox OutText;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.Button ComputingButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Panel InformationPanel;
        private System.Windows.Forms.Panel FunctionPanel;
        private System.Windows.Forms.Panel DelimiterPanel;
        private System.Windows.Forms.Panel VarPanel;
        private System.Windows.Forms.Panel BottomBorder;
        private System.Windows.Forms.Panel TopBorder;
        private System.Windows.Forms.Panel RightBorder;
        private System.Windows.Forms.Panel LeftBorder;
        private System.Windows.Forms.TextBox EpseelonBox;
        private System.Windows.Forms.Label EpseelonLabel;
        private System.Windows.Forms.Label InfoSLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox FuncInput;
        private System.Windows.Forms.Label FuncLabel;
        private System.Windows.Forms.ToolStripMenuItem openFileOfFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileOfResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileOfFunctionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileOfResultToolStripMenuItem;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
    }
}