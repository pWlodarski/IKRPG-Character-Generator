using System.Windows.Forms;
namespace IKRPG_Character_Generator {
    partial class mForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.racialTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.raceSelection = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.attributeTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.physiqueLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.agilityLabel = new System.Windows.Forms.Label();
            this.poiseLabel = new System.Windows.Forms.Label();
            this.prowessLabel = new System.Windows.Forms.Label();
            this.intellectLabel = new System.Windows.Forms.Label();
            this.arcaneLabel = new System.Windows.Forms.Label();
            this.perceptionLabel = new System.Windows.Forms.Label();
            this.startingValueLabel = new System.Windows.Forms.Label();
            this.startingPHY = new System.Windows.Forms.Label();
            this.startingSPD = new System.Windows.Forms.Label();
            this.startingSTR = new System.Windows.Forms.Label();
            this.startingAGL = new System.Windows.Forms.Label();
            this.startingPRW = new System.Windows.Forms.Label();
            this.startingPOI = new System.Windows.Forms.Label();
            this.startingINT = new System.Windows.Forms.Label();
            this.startingARC = new System.Windows.Forms.Label();
            this.startingPER = new System.Windows.Forms.Label();
            this.heroLimitLabel = new System.Windows.Forms.Label();
            this.heroPHY = new System.Windows.Forms.Label();
            this.heroSPD = new System.Windows.Forms.Label();
            this.heroSTR = new System.Windows.Forms.Label();
            this.heroAGL = new System.Windows.Forms.Label();
            this.heroPRW = new System.Windows.Forms.Label();
            this.heroPOI = new System.Windows.Forms.Label();
            this.heroINT = new System.Windows.Forms.Label();
            this.heroARC = new System.Windows.Forms.Label();
            this.heroPER = new System.Windows.Forms.Label();
            this.vetLimitLabel = new System.Windows.Forms.Label();
            this.vetPHY = new System.Windows.Forms.Label();
            this.vetSPD = new System.Windows.Forms.Label();
            this.vetSTR = new System.Windows.Forms.Label();
            this.vetAGL = new System.Windows.Forms.Label();
            this.vetPOI = new System.Windows.Forms.Label();
            this.vetPRW = new System.Windows.Forms.Label();
            this.vetINT = new System.Windows.Forms.Label();
            this.vetARC = new System.Windows.Forms.Label();
            this.vetPER = new System.Windows.Forms.Label();
            this.epicLimitLabel = new System.Windows.Forms.Label();
            this.epicPHY = new System.Windows.Forms.Label();
            this.epicSPD = new System.Windows.Forms.Label();
            this.epicSTR = new System.Windows.Forms.Label();
            this.epicAGL = new System.Windows.Forms.Label();
            this.epicPOI = new System.Windows.Forms.Label();
            this.epicPRW = new System.Windows.Forms.Label();
            this.epicINT = new System.Windows.Forms.Label();
            this.epicARC = new System.Windows.Forms.Label();
            this.epicPER = new System.Windows.Forms.Label();
            this.racialText = new System.Windows.Forms.TextBox();
            this.archetypeTab = new System.Windows.Forms.TabPage();
            this.careerTab = new System.Windows.Forms.TabPage();
            this.mMenuStrip.SuspendLayout();
            this.tabContainer.SuspendLayout();
            this.racialTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.attributeTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenuStrip
            // 
            this.mMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMenuStrip.Name = "mMenuStrip";
            this.mMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mMenuStrip.Size = new System.Drawing.Size(585, 24);
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.racialTab);
            this.tabContainer.Controls.Add(this.archetypeTab);
            this.tabContainer.Controls.Add(this.careerTab);
            this.tabContainer.Location = new System.Drawing.Point(0, 27);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(584, 419);
            this.tabContainer.TabIndex = 3;
            // 
            // racialTab
            // 
            this.racialTab.Controls.Add(this.splitContainer1);
            this.racialTab.Location = new System.Drawing.Point(4, 22);
            this.racialTab.Name = "racialTab";
            this.racialTab.Padding = new System.Windows.Forms.Padding(3);
            this.racialTab.Size = new System.Drawing.Size(576, 393);
            this.racialTab.TabIndex = 0;
            this.racialTab.Text = "Race Selection";
            this.racialTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.raceSelection);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(570, 387);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 4;
            // 
            // raceSelection
            // 
            this.raceSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raceSelection.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceSelection.FormattingEnabled = true;
            this.raceSelection.Items.AddRange(new object[] {
            "Dwarf",
            "Gobber",
            "Human",
            "Iosan",
            "Nyss",
            "Orgun",
            "Trollkin"});
            this.raceSelection.Location = new System.Drawing.Point(0, 0);
            this.raceSelection.Name = "raceSelection";
            this.raceSelection.Size = new System.Drawing.Size(570, 40);
            this.raceSelection.TabIndex = 0;
            this.raceSelection.SelectedIndexChanged += new System.EventHandler(this.raceSelectionChanged);
            this.raceSelection.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.raceSelection_MouseWheel);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.attributeTablePanel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.racialText);
            this.splitContainer2.Size = new System.Drawing.Size(570, 339);
            this.splitContainer2.SplitterDistance = 246;
            this.splitContainer2.TabIndex = 0;
            // 
            // attributeTablePanel
            // 
            this.attributeTablePanel.ColumnCount = 5;
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.29268F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.57724F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.88618F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.attributeTablePanel.Controls.Add(this.physiqueLabel, 0, 1);
            this.attributeTablePanel.Controls.Add(this.speedLabel, 0, 2);
            this.attributeTablePanel.Controls.Add(this.strengthLabel, 0, 3);
            this.attributeTablePanel.Controls.Add(this.agilityLabel, 0, 4);
            this.attributeTablePanel.Controls.Add(this.poiseLabel, 0, 5);
            this.attributeTablePanel.Controls.Add(this.prowessLabel, 0, 6);
            this.attributeTablePanel.Controls.Add(this.intellectLabel, 0, 7);
            this.attributeTablePanel.Controls.Add(this.arcaneLabel, 0, 8);
            this.attributeTablePanel.Controls.Add(this.perceptionLabel, 0, 9);
            this.attributeTablePanel.Controls.Add(this.startingValueLabel, 1, 0);
            this.attributeTablePanel.Controls.Add(this.startingPHY, 1, 1);
            this.attributeTablePanel.Controls.Add(this.startingSPD, 1, 2);
            this.attributeTablePanel.Controls.Add(this.startingSTR, 1, 3);
            this.attributeTablePanel.Controls.Add(this.startingAGL, 1, 4);
            this.attributeTablePanel.Controls.Add(this.startingPRW, 1, 5);
            this.attributeTablePanel.Controls.Add(this.startingPOI, 1, 6);
            this.attributeTablePanel.Controls.Add(this.startingINT, 1, 7);
            this.attributeTablePanel.Controls.Add(this.startingARC, 1, 8);
            this.attributeTablePanel.Controls.Add(this.startingPER, 1, 9);
            this.attributeTablePanel.Controls.Add(this.heroLimitLabel, 2, 0);
            this.attributeTablePanel.Controls.Add(this.heroPHY, 2, 1);
            this.attributeTablePanel.Controls.Add(this.heroSPD, 2, 2);
            this.attributeTablePanel.Controls.Add(this.heroSTR, 2, 3);
            this.attributeTablePanel.Controls.Add(this.heroAGL, 2, 4);
            this.attributeTablePanel.Controls.Add(this.heroPRW, 2, 5);
            this.attributeTablePanel.Controls.Add(this.heroPOI, 2, 6);
            this.attributeTablePanel.Controls.Add(this.heroINT, 2, 7);
            this.attributeTablePanel.Controls.Add(this.heroARC, 2, 8);
            this.attributeTablePanel.Controls.Add(this.heroPER, 2, 9);
            this.attributeTablePanel.Controls.Add(this.vetLimitLabel, 3, 0);
            this.attributeTablePanel.Controls.Add(this.vetPHY, 3, 1);
            this.attributeTablePanel.Controls.Add(this.vetSPD, 3, 2);
            this.attributeTablePanel.Controls.Add(this.vetSTR, 3, 3);
            this.attributeTablePanel.Controls.Add(this.vetAGL, 3, 4);
            this.attributeTablePanel.Controls.Add(this.vetPOI, 3, 5);
            this.attributeTablePanel.Controls.Add(this.vetPRW, 3, 6);
            this.attributeTablePanel.Controls.Add(this.vetINT, 3, 7);
            this.attributeTablePanel.Controls.Add(this.vetARC, 3, 8);
            this.attributeTablePanel.Controls.Add(this.vetPER, 3, 9);
            this.attributeTablePanel.Controls.Add(this.epicLimitLabel, 4, 0);
            this.attributeTablePanel.Controls.Add(this.epicPHY, 4, 1);
            this.attributeTablePanel.Controls.Add(this.epicSPD, 4, 2);
            this.attributeTablePanel.Controls.Add(this.epicSTR, 4, 3);
            this.attributeTablePanel.Controls.Add(this.epicAGL, 4, 4);
            this.attributeTablePanel.Controls.Add(this.epicPOI, 4, 5);
            this.attributeTablePanel.Controls.Add(this.epicPRW, 4, 6);
            this.attributeTablePanel.Controls.Add(this.epicINT, 4, 7);
            this.attributeTablePanel.Controls.Add(this.epicARC, 4, 8);
            this.attributeTablePanel.Controls.Add(this.epicPER, 4, 9);
            this.attributeTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributeTablePanel.Location = new System.Drawing.Point(0, 0);
            this.attributeTablePanel.Name = "attributeTablePanel";
            this.attributeTablePanel.RowCount = 10;
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.20944F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0295F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.439528F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.849558F));
            this.attributeTablePanel.Size = new System.Drawing.Size(246, 339);
            this.attributeTablePanel.TabIndex = 0;
            // 
            // physiqueLabel
            // 
            this.physiqueLabel.AutoSize = true;
            this.physiqueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.physiqueLabel.Location = new System.Drawing.Point(3, 34);
            this.physiqueLabel.Name = "physiqueLabel";
            this.physiqueLabel.Size = new System.Drawing.Size(39, 34);
            this.physiqueLabel.TabIndex = 0;
            this.physiqueLabel.Text = "PHY";
            this.physiqueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedLabel.Location = new System.Drawing.Point(3, 68);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(39, 34);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "SPD";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.strengthLabel.Location = new System.Drawing.Point(3, 102);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(39, 34);
            this.strengthLabel.TabIndex = 2;
            this.strengthLabel.Text = "STR";
            this.strengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // agilityLabel
            // 
            this.agilityLabel.AutoSize = true;
            this.agilityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agilityLabel.Location = new System.Drawing.Point(3, 136);
            this.agilityLabel.Name = "agilityLabel";
            this.agilityLabel.Size = new System.Drawing.Size(39, 34);
            this.agilityLabel.TabIndex = 3;
            this.agilityLabel.Text = "AGL";
            this.agilityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // poiseLabel
            // 
            this.poiseLabel.AutoSize = true;
            this.poiseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poiseLabel.Location = new System.Drawing.Point(3, 170);
            this.poiseLabel.Name = "poiseLabel";
            this.poiseLabel.Size = new System.Drawing.Size(39, 34);
            this.poiseLabel.TabIndex = 4;
            this.poiseLabel.Text = "POI";
            this.poiseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prowessLabel
            // 
            this.prowessLabel.AutoSize = true;
            this.prowessLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prowessLabel.Location = new System.Drawing.Point(3, 204);
            this.prowessLabel.Name = "prowessLabel";
            this.prowessLabel.Size = new System.Drawing.Size(39, 38);
            this.prowessLabel.TabIndex = 5;
            this.prowessLabel.Text = "PRW";
            this.prowessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intellectLabel
            // 
            this.intellectLabel.AutoSize = true;
            this.intellectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intellectLabel.Location = new System.Drawing.Point(3, 242);
            this.intellectLabel.Name = "intellectLabel";
            this.intellectLabel.Size = new System.Drawing.Size(39, 34);
            this.intellectLabel.TabIndex = 6;
            this.intellectLabel.Text = "INT";
            this.intellectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arcaneLabel
            // 
            this.arcaneLabel.AutoSize = true;
            this.arcaneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arcaneLabel.Location = new System.Drawing.Point(3, 276);
            this.arcaneLabel.Name = "arcaneLabel";
            this.arcaneLabel.Size = new System.Drawing.Size(39, 32);
            this.arcaneLabel.TabIndex = 7;
            this.arcaneLabel.Text = "ARC";
            this.arcaneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perceptionLabel
            // 
            this.perceptionLabel.AutoSize = true;
            this.perceptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perceptionLabel.Location = new System.Drawing.Point(3, 308);
            this.perceptionLabel.Name = "perceptionLabel";
            this.perceptionLabel.Size = new System.Drawing.Size(39, 31);
            this.perceptionLabel.TabIndex = 8;
            this.perceptionLabel.Text = "PER";
            this.perceptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingValueLabel
            // 
            this.startingValueLabel.AutoSize = true;
            this.startingValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingValueLabel.Location = new System.Drawing.Point(48, 0);
            this.startingValueLabel.Name = "startingValueLabel";
            this.startingValueLabel.Size = new System.Drawing.Size(52, 34);
            this.startingValueLabel.TabIndex = 9;
            this.startingValueLabel.Text = "Starting Value";
            this.startingValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPHY
            // 
            this.startingPHY.AutoSize = true;
            this.startingPHY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPHY.Location = new System.Drawing.Point(46, 35);
            this.startingPHY.Margin = new System.Windows.Forms.Padding(1);
            this.startingPHY.Name = "startingPHY";
            this.startingPHY.Size = new System.Drawing.Size(56, 32);
            this.startingPHY.TabIndex = 10;
            this.startingPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingSPD
            // 
            this.startingSPD.AutoSize = true;
            this.startingSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingSPD.Location = new System.Drawing.Point(48, 68);
            this.startingSPD.Name = "startingSPD";
            this.startingSPD.Size = new System.Drawing.Size(52, 34);
            this.startingSPD.TabIndex = 11;
            this.startingSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingSTR
            // 
            this.startingSTR.AutoSize = true;
            this.startingSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingSTR.Location = new System.Drawing.Point(48, 102);
            this.startingSTR.Name = "startingSTR";
            this.startingSTR.Size = new System.Drawing.Size(52, 34);
            this.startingSTR.TabIndex = 12;
            this.startingSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingAGL
            // 
            this.startingAGL.AutoSize = true;
            this.startingAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingAGL.Location = new System.Drawing.Point(48, 136);
            this.startingAGL.Name = "startingAGL";
            this.startingAGL.Size = new System.Drawing.Size(52, 34);
            this.startingAGL.TabIndex = 13;
            this.startingAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPRW
            // 
            this.startingPRW.AutoSize = true;
            this.startingPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPRW.Location = new System.Drawing.Point(48, 170);
            this.startingPRW.Name = "startingPRW";
            this.startingPRW.Size = new System.Drawing.Size(52, 34);
            this.startingPRW.TabIndex = 14;
            this.startingPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPOI
            // 
            this.startingPOI.AutoSize = true;
            this.startingPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPOI.Location = new System.Drawing.Point(48, 204);
            this.startingPOI.Name = "startingPOI";
            this.startingPOI.Size = new System.Drawing.Size(52, 38);
            this.startingPOI.TabIndex = 15;
            this.startingPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingINT
            // 
            this.startingINT.AutoSize = true;
            this.startingINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingINT.Location = new System.Drawing.Point(48, 242);
            this.startingINT.Name = "startingINT";
            this.startingINT.Size = new System.Drawing.Size(52, 34);
            this.startingINT.TabIndex = 16;
            this.startingINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingARC
            // 
            this.startingARC.AutoSize = true;
            this.startingARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingARC.Location = new System.Drawing.Point(48, 276);
            this.startingARC.Name = "startingARC";
            this.startingARC.Size = new System.Drawing.Size(52, 32);
            this.startingARC.TabIndex = 17;
            this.startingARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPER
            // 
            this.startingPER.AutoSize = true;
            this.startingPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPER.Location = new System.Drawing.Point(48, 308);
            this.startingPER.Name = "startingPER";
            this.startingPER.Size = new System.Drawing.Size(52, 31);
            this.startingPER.TabIndex = 18;
            this.startingPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroLimitLabel
            // 
            this.heroLimitLabel.AutoSize = true;
            this.heroLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroLimitLabel.Location = new System.Drawing.Point(106, 0);
            this.heroLimitLabel.Name = "heroLimitLabel";
            this.heroLimitLabel.Size = new System.Drawing.Size(38, 34);
            this.heroLimitLabel.TabIndex = 19;
            this.heroLimitLabel.Text = "Hero Limit";
            this.heroLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPHY
            // 
            this.heroPHY.AutoSize = true;
            this.heroPHY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPHY.Location = new System.Drawing.Point(106, 34);
            this.heroPHY.Name = "heroPHY";
            this.heroPHY.Size = new System.Drawing.Size(38, 34);
            this.heroPHY.TabIndex = 20;
            this.heroPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroSPD
            // 
            this.heroSPD.AutoSize = true;
            this.heroSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroSPD.Location = new System.Drawing.Point(106, 68);
            this.heroSPD.Name = "heroSPD";
            this.heroSPD.Size = new System.Drawing.Size(38, 34);
            this.heroSPD.TabIndex = 21;
            this.heroSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroSTR
            // 
            this.heroSTR.AutoSize = true;
            this.heroSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroSTR.Location = new System.Drawing.Point(106, 102);
            this.heroSTR.Name = "heroSTR";
            this.heroSTR.Size = new System.Drawing.Size(38, 34);
            this.heroSTR.TabIndex = 22;
            this.heroSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroAGL
            // 
            this.heroAGL.AutoSize = true;
            this.heroAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroAGL.Location = new System.Drawing.Point(106, 136);
            this.heroAGL.Name = "heroAGL";
            this.heroAGL.Size = new System.Drawing.Size(38, 34);
            this.heroAGL.TabIndex = 23;
            this.heroAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPRW
            // 
            this.heroPRW.AutoSize = true;
            this.heroPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPRW.Location = new System.Drawing.Point(106, 170);
            this.heroPRW.Name = "heroPRW";
            this.heroPRW.Size = new System.Drawing.Size(38, 34);
            this.heroPRW.TabIndex = 24;
            this.heroPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPOI
            // 
            this.heroPOI.AutoSize = true;
            this.heroPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPOI.Location = new System.Drawing.Point(106, 204);
            this.heroPOI.Name = "heroPOI";
            this.heroPOI.Size = new System.Drawing.Size(38, 38);
            this.heroPOI.TabIndex = 25;
            this.heroPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroINT
            // 
            this.heroINT.AutoSize = true;
            this.heroINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroINT.Location = new System.Drawing.Point(106, 242);
            this.heroINT.Name = "heroINT";
            this.heroINT.Size = new System.Drawing.Size(38, 34);
            this.heroINT.TabIndex = 26;
            this.heroINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroARC
            // 
            this.heroARC.AutoSize = true;
            this.heroARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroARC.Location = new System.Drawing.Point(106, 276);
            this.heroARC.Name = "heroARC";
            this.heroARC.Size = new System.Drawing.Size(38, 32);
            this.heroARC.TabIndex = 27;
            this.heroARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPER
            // 
            this.heroPER.AutoSize = true;
            this.heroPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPER.Location = new System.Drawing.Point(106, 308);
            this.heroPER.Name = "heroPER";
            this.heroPER.Size = new System.Drawing.Size(38, 31);
            this.heroPER.TabIndex = 28;
            this.heroPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetLimitLabel
            // 
            this.vetLimitLabel.AutoSize = true;
            this.vetLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetLimitLabel.Location = new System.Drawing.Point(150, 0);
            this.vetLimitLabel.Name = "vetLimitLabel";
            this.vetLimitLabel.Size = new System.Drawing.Size(43, 34);
            this.vetLimitLabel.TabIndex = 29;
            this.vetLimitLabel.Text = "Vet Limit";
            this.vetLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPHY
            // 
            this.vetPHY.AutoSize = true;
            this.vetPHY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPHY.Location = new System.Drawing.Point(150, 34);
            this.vetPHY.Name = "vetPHY";
            this.vetPHY.Size = new System.Drawing.Size(43, 34);
            this.vetPHY.TabIndex = 30;
            this.vetPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetSPD
            // 
            this.vetSPD.AutoSize = true;
            this.vetSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetSPD.Location = new System.Drawing.Point(150, 68);
            this.vetSPD.Name = "vetSPD";
            this.vetSPD.Size = new System.Drawing.Size(43, 34);
            this.vetSPD.TabIndex = 31;
            this.vetSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetSTR
            // 
            this.vetSTR.AutoSize = true;
            this.vetSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetSTR.Location = new System.Drawing.Point(150, 102);
            this.vetSTR.Name = "vetSTR";
            this.vetSTR.Size = new System.Drawing.Size(43, 34);
            this.vetSTR.TabIndex = 32;
            this.vetSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetAGL
            // 
            this.vetAGL.AutoSize = true;
            this.vetAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetAGL.Location = new System.Drawing.Point(150, 136);
            this.vetAGL.Name = "vetAGL";
            this.vetAGL.Size = new System.Drawing.Size(43, 34);
            this.vetAGL.TabIndex = 33;
            this.vetAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPOI
            // 
            this.vetPOI.AutoSize = true;
            this.vetPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPOI.Location = new System.Drawing.Point(150, 170);
            this.vetPOI.Name = "vetPOI";
            this.vetPOI.Size = new System.Drawing.Size(43, 34);
            this.vetPOI.TabIndex = 34;
            this.vetPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPRW
            // 
            this.vetPRW.AutoSize = true;
            this.vetPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPRW.Location = new System.Drawing.Point(150, 204);
            this.vetPRW.Name = "vetPRW";
            this.vetPRW.Size = new System.Drawing.Size(43, 38);
            this.vetPRW.TabIndex = 35;
            this.vetPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetINT
            // 
            this.vetINT.AutoSize = true;
            this.vetINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetINT.Location = new System.Drawing.Point(150, 242);
            this.vetINT.Name = "vetINT";
            this.vetINT.Size = new System.Drawing.Size(43, 34);
            this.vetINT.TabIndex = 36;
            this.vetINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetARC
            // 
            this.vetARC.AutoSize = true;
            this.vetARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetARC.Location = new System.Drawing.Point(150, 276);
            this.vetARC.Name = "vetARC";
            this.vetARC.Size = new System.Drawing.Size(43, 32);
            this.vetARC.TabIndex = 37;
            this.vetARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPER
            // 
            this.vetPER.AutoSize = true;
            this.vetPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPER.Location = new System.Drawing.Point(150, 308);
            this.vetPER.Name = "vetPER";
            this.vetPER.Size = new System.Drawing.Size(43, 31);
            this.vetPER.TabIndex = 38;
            this.vetPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicLimitLabel
            // 
            this.epicLimitLabel.AutoSize = true;
            this.epicLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicLimitLabel.Location = new System.Drawing.Point(199, 0);
            this.epicLimitLabel.Name = "epicLimitLabel";
            this.epicLimitLabel.Size = new System.Drawing.Size(44, 34);
            this.epicLimitLabel.TabIndex = 39;
            this.epicLimitLabel.Text = "Epic Limit";
            this.epicLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPHY
            // 
            this.epicPHY.AutoSize = true;
            this.epicPHY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPHY.Location = new System.Drawing.Point(199, 34);
            this.epicPHY.Name = "epicPHY";
            this.epicPHY.Size = new System.Drawing.Size(44, 34);
            this.epicPHY.TabIndex = 40;
            this.epicPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicSPD
            // 
            this.epicSPD.AutoSize = true;
            this.epicSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicSPD.Location = new System.Drawing.Point(199, 68);
            this.epicSPD.Name = "epicSPD";
            this.epicSPD.Size = new System.Drawing.Size(44, 34);
            this.epicSPD.TabIndex = 41;
            this.epicSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicSTR
            // 
            this.epicSTR.AutoSize = true;
            this.epicSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicSTR.Location = new System.Drawing.Point(199, 102);
            this.epicSTR.Name = "epicSTR";
            this.epicSTR.Size = new System.Drawing.Size(44, 34);
            this.epicSTR.TabIndex = 42;
            this.epicSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicAGL
            // 
            this.epicAGL.AutoSize = true;
            this.epicAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicAGL.Location = new System.Drawing.Point(199, 136);
            this.epicAGL.Name = "epicAGL";
            this.epicAGL.Size = new System.Drawing.Size(44, 34);
            this.epicAGL.TabIndex = 43;
            this.epicAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPOI
            // 
            this.epicPOI.AutoSize = true;
            this.epicPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPOI.Location = new System.Drawing.Point(199, 170);
            this.epicPOI.Name = "epicPOI";
            this.epicPOI.Size = new System.Drawing.Size(44, 34);
            this.epicPOI.TabIndex = 44;
            this.epicPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPRW
            // 
            this.epicPRW.AutoSize = true;
            this.epicPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPRW.Location = new System.Drawing.Point(199, 204);
            this.epicPRW.Name = "epicPRW";
            this.epicPRW.Size = new System.Drawing.Size(44, 38);
            this.epicPRW.TabIndex = 45;
            this.epicPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicINT
            // 
            this.epicINT.AutoSize = true;
            this.epicINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicINT.Location = new System.Drawing.Point(199, 242);
            this.epicINT.Name = "epicINT";
            this.epicINT.Size = new System.Drawing.Size(44, 34);
            this.epicINT.TabIndex = 46;
            this.epicINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicARC
            // 
            this.epicARC.AutoSize = true;
            this.epicARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicARC.Location = new System.Drawing.Point(199, 276);
            this.epicARC.Name = "epicARC";
            this.epicARC.Size = new System.Drawing.Size(44, 32);
            this.epicARC.TabIndex = 47;
            this.epicARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPER
            // 
            this.epicPER.AutoSize = true;
            this.epicPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPER.Location = new System.Drawing.Point(199, 308);
            this.epicPER.Name = "epicPER";
            this.epicPER.Size = new System.Drawing.Size(44, 31);
            this.epicPER.TabIndex = 48;
            this.epicPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // racialText
            // 
            this.racialText.Cursor = System.Windows.Forms.Cursors.Default;
            this.racialText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.racialText.Location = new System.Drawing.Point(0, 0);
            this.racialText.Multiline = true;
            this.racialText.Name = "racialText";
            this.racialText.ReadOnly = true;
            this.racialText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.racialText.Size = new System.Drawing.Size(320, 339);
            this.racialText.TabIndex = 2;
            // 
            // archetypeTab
            // 
            this.archetypeTab.Location = new System.Drawing.Point(4, 22);
            this.archetypeTab.Name = "archetypeTab";
            this.archetypeTab.Padding = new System.Windows.Forms.Padding(3);
            this.archetypeTab.Size = new System.Drawing.Size(576, 393);
            this.archetypeTab.TabIndex = 1;
            this.archetypeTab.Text = "Archetypes";
            this.archetypeTab.UseVisualStyleBackColor = true;
            // 
            // careerTab
            // 
            this.careerTab.Location = new System.Drawing.Point(4, 22);
            this.careerTab.Name = "careerTab";
            this.careerTab.Padding = new System.Windows.Forms.Padding(3);
            this.careerTab.Size = new System.Drawing.Size(576, 393);
            this.careerTab.TabIndex = 2;
            this.careerTab.Text = "Careers";
            this.careerTab.UseVisualStyleBackColor = true;
            // 
            // mForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(585, 451);
            this.Controls.Add(this.tabContainer);
            this.Controls.Add(this.mMenuStrip);
            this.MainMenuStrip = this.mMenuStrip;
            this.Name = "mForm";
            this.Text = "Iron Kingdom Character Generator";
            this.mMenuStrip.ResumeLayout(false);
            this.mMenuStrip.PerformLayout();
            this.tabContainer.ResumeLayout(false);
            this.racialTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.attributeTablePanel.ResumeLayout(false);
            this.attributeTablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage racialTab;
        private System.Windows.Forms.TabPage archetypeTab;
        private System.Windows.Forms.TabPage careerTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox raceSelection;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel attributeTablePanel;
        private System.Windows.Forms.TextBox racialText;
        private System.Windows.Forms.Label physiqueLabel, speedLabel, strengthLabel, agilityLabel, poiseLabel, prowessLabel, intellectLabel, arcaneLabel, perceptionLabel;
        private System.Windows.Forms.Label startingValueLabel, startingPHY, startingSPD, startingSTR, startingAGL, startingPRW, startingPOI, startingINT, startingARC, startingPER;
        private System.Windows.Forms.Label heroLimitLabel, heroPHY, heroSPD, heroSTR, heroAGL, heroPRW, heroPOI, heroINT, heroARC, heroPER;
        private System.Windows.Forms.Label vetLimitLabel, vetPHY, vetSPD, vetSTR, vetAGL, vetPOI, vetPRW, vetINT, vetARC, vetPER;
        private System.Windows.Forms.Label epicLimitLabel, epicPHY, epicSPD, epicSTR, epicAGL, epicPOI, epicPRW, epicINT, epicARC, epicPER;

    }
}

