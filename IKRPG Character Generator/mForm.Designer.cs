namespace IKRPG_Character_Generator
{
    partial class mForm
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
            this.mMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.racialTab = new System.Windows.Forms.TabPage();
            this.racialText = new System.Windows.Forms.Panel();
            this.radioButtonTrollkin = new System.Windows.Forms.RadioButton();
            this.radioButtonOrgun = new System.Windows.Forms.RadioButton();
            this.radioButtonNyss = new System.Windows.Forms.RadioButton();
            this.radioButtonIosan = new System.Windows.Forms.RadioButton();
            this.radioButtonGobber = new System.Windows.Forms.RadioButton();
            this.radioButtonDwarf = new System.Windows.Forms.RadioButton();
            this.radioButtonHuman = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mMenuStrip.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.racialTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenuStrip
            // 
            this.mMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMenuStrip.Name = "mMenuStrip";
            this.mMenuStrip.Size = new System.Drawing.Size(630, 24);
            this.mMenuStrip.TabIndex = 0;
            this.mMenuStrip.Text = "mMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(486, 433);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.racialTab);
            this.tabContainer.Controls.Add(this.tabPage2);
            this.tabContainer.Location = new System.Drawing.Point(0, 27);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(561, 404);
            this.tabContainer.TabIndex = 3;
            // 
            // racialTab
            // 
            this.racialTab.Controls.Add(this.racialText);
            this.racialTab.Controls.Add(this.radioButtonTrollkin);
            this.racialTab.Controls.Add(this.radioButtonOrgun);
            this.racialTab.Controls.Add(this.radioButtonNyss);
            this.racialTab.Controls.Add(this.radioButtonIosan);
            this.racialTab.Controls.Add(this.radioButtonGobber);
            this.racialTab.Controls.Add(this.radioButtonDwarf);
            this.racialTab.Controls.Add(this.radioButtonHuman);
            this.racialTab.Location = new System.Drawing.Point(4, 22);
            this.racialTab.Name = "racialTab";
            this.racialTab.Padding = new System.Windows.Forms.Padding(3);
            this.racialTab.Size = new System.Drawing.Size(553, 378);
            this.racialTab.TabIndex = 0;
            this.racialTab.Text = "Race Selection";
            this.racialTab.UseVisualStyleBackColor = true;
            // 
            // racialText
            // 
            this.racialText.Location = new System.Drawing.Point(217, 0);
            this.racialText.Name = "racialText";
            this.racialText.Size = new System.Drawing.Size(333, 375);
            this.racialText.TabIndex = 7;
            this.racialText.Paint += new System.Windows.Forms.PaintEventHandler(this.racialText_Paint);
            // 
            // radioButtonTrollkin
            // 
            this.radioButtonTrollkin.AutoSize = true;
            this.radioButtonTrollkin.Location = new System.Drawing.Point(9, 145);
            this.radioButtonTrollkin.Name = "radioButtonTrollkin";
            this.radioButtonTrollkin.Size = new System.Drawing.Size(59, 17);
            this.radioButtonTrollkin.TabIndex = 6;
            this.radioButtonTrollkin.Text = "Trollkin";
            this.radioButtonTrollkin.UseVisualStyleBackColor = true;
            // 
            // radioButtonOrgun
            // 
            this.radioButtonOrgun.AutoSize = true;
            this.radioButtonOrgun.Location = new System.Drawing.Point(9, 122);
            this.radioButtonOrgun.Name = "radioButtonOrgun";
            this.radioButtonOrgun.Size = new System.Drawing.Size(54, 17);
            this.radioButtonOrgun.TabIndex = 5;
            this.radioButtonOrgun.Text = "Orgun";
            this.radioButtonOrgun.UseVisualStyleBackColor = true;
            // 
            // radioButtonNyss
            // 
            this.radioButtonNyss.AutoSize = true;
            this.radioButtonNyss.Location = new System.Drawing.Point(9, 99);
            this.radioButtonNyss.Name = "radioButtonNyss";
            this.radioButtonNyss.Size = new System.Drawing.Size(48, 17);
            this.radioButtonNyss.TabIndex = 4;
            this.radioButtonNyss.Text = "Nyss";
            this.radioButtonNyss.UseVisualStyleBackColor = true;
            // 
            // radioButtonIosan
            // 
            this.radioButtonIosan.AutoSize = true;
            this.radioButtonIosan.Location = new System.Drawing.Point(9, 76);
            this.radioButtonIosan.Name = "radioButtonIosan";
            this.radioButtonIosan.Size = new System.Drawing.Size(51, 17);
            this.radioButtonIosan.TabIndex = 3;
            this.radioButtonIosan.Text = "Iosan";
            this.radioButtonIosan.UseVisualStyleBackColor = true;
            // 
            // radioButtonGobber
            // 
            this.radioButtonGobber.AutoSize = true;
            this.radioButtonGobber.Location = new System.Drawing.Point(9, 53);
            this.radioButtonGobber.Name = "radioButtonGobber";
            this.radioButtonGobber.Size = new System.Drawing.Size(60, 17);
            this.radioButtonGobber.TabIndex = 2;
            this.radioButtonGobber.Text = "Gobber";
            this.radioButtonGobber.UseVisualStyleBackColor = true;
            this.radioButtonGobber.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButtonDwarf
            // 
            this.radioButtonDwarf.AutoSize = true;
            this.radioButtonDwarf.Location = new System.Drawing.Point(9, 30);
            this.radioButtonDwarf.Name = "radioButtonDwarf";
            this.radioButtonDwarf.Size = new System.Drawing.Size(53, 17);
            this.radioButtonDwarf.TabIndex = 1;
            this.radioButtonDwarf.Text = "Dwarf";
            this.radioButtonDwarf.UseVisualStyleBackColor = true;
            // 
            // radioButtonHuman
            // 
            this.radioButtonHuman.AutoSize = true;
            this.radioButtonHuman.Checked = true;
            this.radioButtonHuman.Location = new System.Drawing.Point(9, 7);
            this.radioButtonHuman.Name = "radioButtonHuman";
            this.radioButtonHuman.Size = new System.Drawing.Size(59, 17);
            this.radioButtonHuman.TabIndex = 0;
            this.radioButtonHuman.TabStop = true;
            this.radioButtonHuman.Text = "Human";
            this.radioButtonHuman.UseVisualStyleBackColor = true;
            this.radioButtonHuman.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(630, 487);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.mMenuStrip);
            this.MainMenuStrip = this.mMenuStrip;
            this.Name = "mForm";
            this.Text = "Iron Kingdom Character Generator";
            this.Load += new System.EventHandler(this.mForm_Load);
            this.mMenuStrip.ResumeLayout(false);
            this.mMenuStrip.PerformLayout();
            this.tabContainer.ResumeLayout(false);
            this.racialTab.ResumeLayout(false);
            this.racialTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage racialTab;
        private System.Windows.Forms.RadioButton radioButtonIosan;
        private System.Windows.Forms.RadioButton radioButtonGobber;
        private System.Windows.Forms.RadioButton radioButtonDwarf;
        private System.Windows.Forms.RadioButton radioButtonHuman;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButtonTrollkin;
        private System.Windows.Forms.RadioButton radioButtonOrgun;
        private System.Windows.Forms.RadioButton radioButtonNyss;
        private System.Windows.Forms.Panel racialText;

    }
}

