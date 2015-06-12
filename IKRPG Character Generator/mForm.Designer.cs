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
            this.archetypeTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.archetypeSelection = new System.Windows.Forms.ComboBox();
            this.archetypeText = new System.Windows.Forms.TextBox();
            this.archetypeSplitPanel = new System.Windows.Forms.SplitContainer();
            this.giftedFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.giftedAdditionalStudy = new System.Windows.Forms.CheckBox();
            this.giftedCombatCaster = new System.Windows.Forms.CheckBox();
            this.giftedFastCaster = new System.Windows.Forms.CheckBox();
            this.giftedFeatDominator = new System.Windows.Forms.CheckBox();
            this.giftedFeatPowerfulCaster = new System.Windows.Forms.CheckBox();
            this.giftedFeatQuickCast = new System.Windows.Forms.CheckBox();
            this.giftedFeatStrengthOfWill = new System.Windows.Forms.CheckBox();
            this.giftedMagicSensitivity = new System.Windows.Forms.CheckBox();
            this.giftedRuneReader = new System.Windows.Forms.CheckBox();
            this.giftedWardingCircle = new System.Windows.Forms.CheckBox();
            this.intellectualFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.intelBattlefieldCoordination = new System.Windows.Forms.CheckBox();
            this.intelFeatFlawlessTiming = new System.Windows.Forms.CheckBox();
            this.intelFeatPrescient = new System.Windows.Forms.CheckBox();
            this.intelFeatPerfectPlot = new System.Windows.Forms.CheckBox();
            this.intelFeatPlanOfAction = new System.Windows.Forms.CheckBox();
            this.intelFeatQuickThinking = new System.Windows.Forms.CheckBox();
            this.intelFeatUnconventionalWarfare = new System.Windows.Forms.CheckBox();
            this.intelGenius = new System.Windows.Forms.CheckBox();
            this.intelHyperPerception = new System.Windows.Forms.CheckBox();
            this.intelPhotographicMemory = new System.Windows.Forms.CheckBox();
            this.mightFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mightBeatBack = new System.Windows.Forms.CheckBox();
            this.mightFeatBackSwing = new System.Windows.Forms.CheckBox();
            this.mightFeatBoundingLeap = new System.Windows.Forms.CheckBox();
            this.mightFeatCounterCharge = new System.Windows.Forms.CheckBox();
            this.mightFeatInvulnerable = new System.Windows.Forms.CheckBox();
            this.mightFeatRevitalize = new System.Windows.Forms.CheckBox();
            this.mightFeatShieldBreaker = new System.Windows.Forms.CheckBox();
            this.mightFeatVendetta = new System.Windows.Forms.CheckBox();
            this.mightRighteousAnger = new System.Windows.Forms.CheckBox();
            this.mightTough = new System.Windows.Forms.CheckBox();
            this.skilledFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.skillAmbidextrous = new System.Windows.Forms.CheckBox();
            this.skillCagey = new System.Windows.Forms.CheckBox();
            this.skillDeft = new System.Windows.Forms.CheckBox();
            this.skillFeatDefensiveStrike = new System.Windows.Forms.CheckBox();
            this.skillFeatDisarm = new System.Windows.Forms.CheckBox();
            this.skillFeatSwashbuckler = new System.Windows.Forms.CheckBox();
            this.skillFeatUntouchable = new System.Windows.Forms.CheckBox();
            this.skillPreternaturaAwareness = new System.Windows.Forms.CheckBox();
            this.skillSidestep = new System.Windows.Forms.CheckBox();
            this.skillVirtuoso = new System.Windows.Forms.CheckBox();
            this.careerTab = new System.Windows.Forms.TabPage();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archetypeMinorText = new System.Windows.Forms.TextBox();
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
            this.archetypeTab.SuspendLayout();
            this.archetypeTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypeSplitPanel)).BeginInit();
            this.archetypeSplitPanel.Panel1.SuspendLayout();
            this.archetypeSplitPanel.Panel2.SuspendLayout();
            this.archetypeSplitPanel.SuspendLayout();
            this.giftedFlowPanel.SuspendLayout();
            this.intellectualFlowPanel.SuspendLayout();
            this.mightFlowPanel.SuspendLayout();
            this.skilledFlowPanel.SuspendLayout();
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
            this.exitToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "New";
            // 
            // tabContainer
            // 
            this.tabContainer.Controls.Add(this.racialTab);
            this.tabContainer.Controls.Add(this.archetypeTab);
            this.tabContainer.Controls.Add(this.careerTab);
            this.tabContainer.Location = new System.Drawing.Point(0, 27);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(585, 427);
            this.tabContainer.TabIndex = 3;
            // 
            // racialTab
            // 
            this.racialTab.Controls.Add(this.splitContainer1);
            this.racialTab.Location = new System.Drawing.Point(4, 22);
            this.racialTab.Name = "racialTab";
            this.racialTab.Padding = new System.Windows.Forms.Padding(3);
            this.racialTab.Size = new System.Drawing.Size(577, 401);
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
            this.splitContainer1.Size = new System.Drawing.Size(571, 395);
            this.splitContainer1.SplitterDistance = 44;
            this.splitContainer1.TabIndex = 4;
            // 
            // raceSelection
            // 
            this.raceSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raceSelection.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceSelection.FormattingEnabled = true;
            this.raceSelection.Items.AddRange(new object[] {
            "Human",
            "Dwarf",
            "Gobber",
            "Iosan",
            "Nyss",
            "Orgun",
            "Trollkin"});
            this.raceSelection.Location = new System.Drawing.Point(0, 0);
            this.raceSelection.Name = "raceSelection";
            this.raceSelection.Size = new System.Drawing.Size(571, 40);
            this.raceSelection.TabIndex = 0;
            this.raceSelection.SelectedIndexChanged += new System.EventHandler(this.raceSelectionChanged);
            this.raceSelection.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.disableMouseWheel);
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
            this.splitContainer2.Size = new System.Drawing.Size(571, 347);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 0;
            // 
            // attributeTablePanel
            // 
            this.attributeTablePanel.ColumnCount = 5;
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.attributeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
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
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.attributeTablePanel.Size = new System.Drawing.Size(245, 347);
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
            this.prowessLabel.Size = new System.Drawing.Size(39, 34);
            this.prowessLabel.TabIndex = 5;
            this.prowessLabel.Text = "PRW";
            this.prowessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intellectLabel
            // 
            this.intellectLabel.AutoSize = true;
            this.intellectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intellectLabel.Location = new System.Drawing.Point(3, 238);
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
            this.arcaneLabel.Location = new System.Drawing.Point(3, 272);
            this.arcaneLabel.Name = "arcaneLabel";
            this.arcaneLabel.Size = new System.Drawing.Size(39, 34);
            this.arcaneLabel.TabIndex = 7;
            this.arcaneLabel.Text = "ARC";
            this.arcaneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // perceptionLabel
            // 
            this.perceptionLabel.AutoSize = true;
            this.perceptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perceptionLabel.Location = new System.Drawing.Point(3, 306);
            this.perceptionLabel.Name = "perceptionLabel";
            this.perceptionLabel.Size = new System.Drawing.Size(39, 41);
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
            this.startingValueLabel.Size = new System.Drawing.Size(55, 34);
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
            this.startingPHY.Size = new System.Drawing.Size(59, 32);
            this.startingPHY.TabIndex = 10;
            this.startingPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingSPD
            // 
            this.startingSPD.AutoSize = true;
            this.startingSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingSPD.Location = new System.Drawing.Point(48, 68);
            this.startingSPD.Name = "startingSPD";
            this.startingSPD.Size = new System.Drawing.Size(55, 34);
            this.startingSPD.TabIndex = 11;
            this.startingSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingSTR
            // 
            this.startingSTR.AutoSize = true;
            this.startingSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingSTR.Location = new System.Drawing.Point(48, 102);
            this.startingSTR.Name = "startingSTR";
            this.startingSTR.Size = new System.Drawing.Size(55, 34);
            this.startingSTR.TabIndex = 12;
            this.startingSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingAGL
            // 
            this.startingAGL.AutoSize = true;
            this.startingAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingAGL.Location = new System.Drawing.Point(48, 136);
            this.startingAGL.Name = "startingAGL";
            this.startingAGL.Size = new System.Drawing.Size(55, 34);
            this.startingAGL.TabIndex = 13;
            this.startingAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPRW
            // 
            this.startingPRW.AutoSize = true;
            this.startingPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPRW.Location = new System.Drawing.Point(48, 170);
            this.startingPRW.Name = "startingPRW";
            this.startingPRW.Size = new System.Drawing.Size(55, 34);
            this.startingPRW.TabIndex = 14;
            this.startingPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPOI
            // 
            this.startingPOI.AutoSize = true;
            this.startingPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPOI.Location = new System.Drawing.Point(48, 204);
            this.startingPOI.Name = "startingPOI";
            this.startingPOI.Size = new System.Drawing.Size(55, 34);
            this.startingPOI.TabIndex = 15;
            this.startingPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingINT
            // 
            this.startingINT.AutoSize = true;
            this.startingINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingINT.Location = new System.Drawing.Point(48, 238);
            this.startingINT.Name = "startingINT";
            this.startingINT.Size = new System.Drawing.Size(55, 34);
            this.startingINT.TabIndex = 16;
            this.startingINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingARC
            // 
            this.startingARC.AutoSize = true;
            this.startingARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingARC.Location = new System.Drawing.Point(48, 272);
            this.startingARC.Name = "startingARC";
            this.startingARC.Size = new System.Drawing.Size(55, 34);
            this.startingARC.TabIndex = 17;
            this.startingARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startingPER
            // 
            this.startingPER.AutoSize = true;
            this.startingPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPER.Location = new System.Drawing.Point(48, 306);
            this.startingPER.Name = "startingPER";
            this.startingPER.Size = new System.Drawing.Size(55, 41);
            this.startingPER.TabIndex = 18;
            this.startingPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroLimitLabel
            // 
            this.heroLimitLabel.AutoSize = true;
            this.heroLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroLimitLabel.Location = new System.Drawing.Point(109, 0);
            this.heroLimitLabel.Name = "heroLimitLabel";
            this.heroLimitLabel.Size = new System.Drawing.Size(39, 34);
            this.heroLimitLabel.TabIndex = 19;
            this.heroLimitLabel.Text = "Hero Limit";
            this.heroLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPHY
            // 
            this.heroPHY.AutoSize = true;
            this.heroPHY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPHY.Location = new System.Drawing.Point(109, 34);
            this.heroPHY.Name = "heroPHY";
            this.heroPHY.Size = new System.Drawing.Size(39, 34);
            this.heroPHY.TabIndex = 20;
            this.heroPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroSPD
            // 
            this.heroSPD.AutoSize = true;
            this.heroSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroSPD.Location = new System.Drawing.Point(109, 68);
            this.heroSPD.Name = "heroSPD";
            this.heroSPD.Size = new System.Drawing.Size(39, 34);
            this.heroSPD.TabIndex = 21;
            this.heroSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroSTR
            // 
            this.heroSTR.AutoSize = true;
            this.heroSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroSTR.Location = new System.Drawing.Point(109, 102);
            this.heroSTR.Name = "heroSTR";
            this.heroSTR.Size = new System.Drawing.Size(39, 34);
            this.heroSTR.TabIndex = 22;
            this.heroSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroAGL
            // 
            this.heroAGL.AutoSize = true;
            this.heroAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroAGL.Location = new System.Drawing.Point(109, 136);
            this.heroAGL.Name = "heroAGL";
            this.heroAGL.Size = new System.Drawing.Size(39, 34);
            this.heroAGL.TabIndex = 23;
            this.heroAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPRW
            // 
            this.heroPRW.AutoSize = true;
            this.heroPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPRW.Location = new System.Drawing.Point(109, 170);
            this.heroPRW.Name = "heroPRW";
            this.heroPRW.Size = new System.Drawing.Size(39, 34);
            this.heroPRW.TabIndex = 24;
            this.heroPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPOI
            // 
            this.heroPOI.AutoSize = true;
            this.heroPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPOI.Location = new System.Drawing.Point(109, 204);
            this.heroPOI.Name = "heroPOI";
            this.heroPOI.Size = new System.Drawing.Size(39, 34);
            this.heroPOI.TabIndex = 25;
            this.heroPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroINT
            // 
            this.heroINT.AutoSize = true;
            this.heroINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroINT.Location = new System.Drawing.Point(109, 238);
            this.heroINT.Name = "heroINT";
            this.heroINT.Size = new System.Drawing.Size(39, 34);
            this.heroINT.TabIndex = 26;
            this.heroINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroARC
            // 
            this.heroARC.AutoSize = true;
            this.heroARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroARC.Location = new System.Drawing.Point(109, 272);
            this.heroARC.Name = "heroARC";
            this.heroARC.Size = new System.Drawing.Size(39, 34);
            this.heroARC.TabIndex = 27;
            this.heroARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heroPER
            // 
            this.heroPER.AutoSize = true;
            this.heroPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroPER.Location = new System.Drawing.Point(109, 306);
            this.heroPER.Name = "heroPER";
            this.heroPER.Size = new System.Drawing.Size(39, 41);
            this.heroPER.TabIndex = 28;
            this.heroPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetLimitLabel
            // 
            this.vetLimitLabel.AutoSize = true;
            this.vetLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetLimitLabel.Location = new System.Drawing.Point(154, 0);
            this.vetLimitLabel.Name = "vetLimitLabel";
            this.vetLimitLabel.Size = new System.Drawing.Size(39, 34);
            this.vetLimitLabel.TabIndex = 29;
            this.vetLimitLabel.Text = "Vet Limit";
            this.vetLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPHY
            // 
            this.vetPHY.AutoSize = true;
            this.vetPHY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPHY.Location = new System.Drawing.Point(154, 34);
            this.vetPHY.Name = "vetPHY";
            this.vetPHY.Size = new System.Drawing.Size(39, 34);
            this.vetPHY.TabIndex = 30;
            this.vetPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetSPD
            // 
            this.vetSPD.AutoSize = true;
            this.vetSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetSPD.Location = new System.Drawing.Point(154, 68);
            this.vetSPD.Name = "vetSPD";
            this.vetSPD.Size = new System.Drawing.Size(39, 34);
            this.vetSPD.TabIndex = 31;
            this.vetSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetSTR
            // 
            this.vetSTR.AutoSize = true;
            this.vetSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetSTR.Location = new System.Drawing.Point(154, 102);
            this.vetSTR.Name = "vetSTR";
            this.vetSTR.Size = new System.Drawing.Size(39, 34);
            this.vetSTR.TabIndex = 32;
            this.vetSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetAGL
            // 
            this.vetAGL.AutoSize = true;
            this.vetAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetAGL.Location = new System.Drawing.Point(154, 136);
            this.vetAGL.Name = "vetAGL";
            this.vetAGL.Size = new System.Drawing.Size(39, 34);
            this.vetAGL.TabIndex = 33;
            this.vetAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPOI
            // 
            this.vetPOI.AutoSize = true;
            this.vetPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPOI.Location = new System.Drawing.Point(154, 170);
            this.vetPOI.Name = "vetPOI";
            this.vetPOI.Size = new System.Drawing.Size(39, 34);
            this.vetPOI.TabIndex = 34;
            this.vetPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPRW
            // 
            this.vetPRW.AutoSize = true;
            this.vetPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPRW.Location = new System.Drawing.Point(154, 204);
            this.vetPRW.Name = "vetPRW";
            this.vetPRW.Size = new System.Drawing.Size(39, 34);
            this.vetPRW.TabIndex = 35;
            this.vetPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetINT
            // 
            this.vetINT.AutoSize = true;
            this.vetINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetINT.Location = new System.Drawing.Point(154, 238);
            this.vetINT.Name = "vetINT";
            this.vetINT.Size = new System.Drawing.Size(39, 34);
            this.vetINT.TabIndex = 36;
            this.vetINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetARC
            // 
            this.vetARC.AutoSize = true;
            this.vetARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetARC.Location = new System.Drawing.Point(154, 272);
            this.vetARC.Name = "vetARC";
            this.vetARC.Size = new System.Drawing.Size(39, 34);
            this.vetARC.TabIndex = 37;
            this.vetARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vetPER
            // 
            this.vetPER.AutoSize = true;
            this.vetPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vetPER.Location = new System.Drawing.Point(154, 306);
            this.vetPER.Name = "vetPER";
            this.vetPER.Size = new System.Drawing.Size(39, 41);
            this.vetPER.TabIndex = 38;
            this.vetPER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicLimitLabel
            // 
            this.epicLimitLabel.AutoSize = true;
            this.epicLimitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicLimitLabel.Location = new System.Drawing.Point(199, 0);
            this.epicLimitLabel.Name = "epicLimitLabel";
            this.epicLimitLabel.Size = new System.Drawing.Size(43, 34);
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
            this.epicPHY.Size = new System.Drawing.Size(43, 34);
            this.epicPHY.TabIndex = 40;
            this.epicPHY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicSPD
            // 
            this.epicSPD.AutoSize = true;
            this.epicSPD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicSPD.Location = new System.Drawing.Point(199, 68);
            this.epicSPD.Name = "epicSPD";
            this.epicSPD.Size = new System.Drawing.Size(43, 34);
            this.epicSPD.TabIndex = 41;
            this.epicSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicSTR
            // 
            this.epicSTR.AutoSize = true;
            this.epicSTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicSTR.Location = new System.Drawing.Point(199, 102);
            this.epicSTR.Name = "epicSTR";
            this.epicSTR.Size = new System.Drawing.Size(43, 34);
            this.epicSTR.TabIndex = 42;
            this.epicSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicAGL
            // 
            this.epicAGL.AutoSize = true;
            this.epicAGL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicAGL.Location = new System.Drawing.Point(199, 136);
            this.epicAGL.Name = "epicAGL";
            this.epicAGL.Size = new System.Drawing.Size(43, 34);
            this.epicAGL.TabIndex = 43;
            this.epicAGL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPOI
            // 
            this.epicPOI.AutoSize = true;
            this.epicPOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPOI.Location = new System.Drawing.Point(199, 170);
            this.epicPOI.Name = "epicPOI";
            this.epicPOI.Size = new System.Drawing.Size(43, 34);
            this.epicPOI.TabIndex = 44;
            this.epicPOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPRW
            // 
            this.epicPRW.AutoSize = true;
            this.epicPRW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPRW.Location = new System.Drawing.Point(199, 204);
            this.epicPRW.Name = "epicPRW";
            this.epicPRW.Size = new System.Drawing.Size(43, 34);
            this.epicPRW.TabIndex = 45;
            this.epicPRW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicINT
            // 
            this.epicINT.AutoSize = true;
            this.epicINT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicINT.Location = new System.Drawing.Point(199, 238);
            this.epicINT.Name = "epicINT";
            this.epicINT.Size = new System.Drawing.Size(43, 34);
            this.epicINT.TabIndex = 46;
            this.epicINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicARC
            // 
            this.epicARC.AutoSize = true;
            this.epicARC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicARC.Location = new System.Drawing.Point(199, 272);
            this.epicARC.Name = "epicARC";
            this.epicARC.Size = new System.Drawing.Size(43, 34);
            this.epicARC.TabIndex = 47;
            this.epicARC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // epicPER
            // 
            this.epicPER.AutoSize = true;
            this.epicPER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.epicPER.Location = new System.Drawing.Point(199, 306);
            this.epicPER.Name = "epicPER";
            this.epicPER.Size = new System.Drawing.Size(43, 41);
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
            this.racialText.Size = new System.Drawing.Size(322, 347);
            this.racialText.TabIndex = 2;
            // 
            // archetypeTab
            // 
            this.archetypeTab.Controls.Add(this.archetypeTablePanel);
            this.archetypeTab.Location = new System.Drawing.Point(4, 22);
            this.archetypeTab.Name = "archetypeTab";
            this.archetypeTab.Padding = new System.Windows.Forms.Padding(3);
            this.archetypeTab.Size = new System.Drawing.Size(577, 401);
            this.archetypeTab.TabIndex = 1;
            this.archetypeTab.Text = "Archetypes";
            this.archetypeTab.UseVisualStyleBackColor = true;
            // 
            // archetypeTablePanel
            // 
            this.archetypeTablePanel.ColumnCount = 2;
            this.archetypeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48862F));
            this.archetypeTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51138F));
            this.archetypeTablePanel.Controls.Add(this.archetypeSelection, 0, 0);
            this.archetypeTablePanel.Controls.Add(this.archetypeText, 0, 1);
            this.archetypeTablePanel.Controls.Add(this.archetypeSplitPanel, 1, 1);
            this.archetypeTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archetypeTablePanel.Location = new System.Drawing.Point(3, 3);
            this.archetypeTablePanel.Name = "archetypeTablePanel";
            this.archetypeTablePanel.RowCount = 2;
            this.archetypeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.64557F));
            this.archetypeTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.35443F));
            this.archetypeTablePanel.Size = new System.Drawing.Size(571, 395);
            this.archetypeTablePanel.TabIndex = 0;
            // 
            // archetypeSelection
            // 
            this.archetypeTablePanel.SetColumnSpan(this.archetypeSelection, 2);
            this.archetypeSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archetypeSelection.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.archetypeSelection.FormattingEnabled = true;
            this.archetypeSelection.Items.AddRange(new object[] {
            "Gifted",
            "Intellectual",
            "Mighty",
            "Skilled"});
            this.archetypeSelection.Location = new System.Drawing.Point(3, 3);
            this.archetypeSelection.Name = "archetypeSelection";
            this.archetypeSelection.Size = new System.Drawing.Size(565, 40);
            this.archetypeSelection.TabIndex = 0;
            this.archetypeSelection.SelectedIndexChanged += new System.EventHandler(this.archSelectionChanged);
            this.archetypeSelection.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.disableMouseWheel);
            // 
            // archetypeText
            // 
            this.archetypeText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archetypeText.Location = new System.Drawing.Point(3, 49);
            this.archetypeText.Multiline = true;
            this.archetypeText.Name = "archetypeText";
            this.archetypeText.ReadOnly = true;
            this.archetypeText.Size = new System.Drawing.Size(288, 343);
            this.archetypeText.TabIndex = 1;
            // 
            // archetypeSplitPanel
            // 
            this.archetypeSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archetypeSplitPanel.Location = new System.Drawing.Point(297, 49);
            this.archetypeSplitPanel.Name = "archetypeSplitPanel";
            this.archetypeSplitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // archetypeSplitPanel.Panel1
            // 
            this.archetypeSplitPanel.Panel1.Controls.Add(this.giftedFlowPanel);
            this.archetypeSplitPanel.Panel1.Controls.Add(this.intellectualFlowPanel);
            this.archetypeSplitPanel.Panel1.Controls.Add(this.mightFlowPanel);
            this.archetypeSplitPanel.Panel1.Controls.Add(this.skilledFlowPanel);
            // 
            // archetypeSplitPanel.Panel2
            // 
            this.archetypeSplitPanel.Panel2.Controls.Add(this.archetypeMinorText);
            this.archetypeSplitPanel.Size = new System.Drawing.Size(271, 343);
            this.archetypeSplitPanel.SplitterDistance = 139;
            this.archetypeSplitPanel.TabIndex = 2;
            // 
            // giftedFlowPanel
            // 
            this.giftedFlowPanel.AutoScroll = true;
            this.giftedFlowPanel.Controls.Add(this.giftedAdditionalStudy);
            this.giftedFlowPanel.Controls.Add(this.giftedCombatCaster);
            this.giftedFlowPanel.Controls.Add(this.giftedFastCaster);
            this.giftedFlowPanel.Controls.Add(this.giftedFeatDominator);
            this.giftedFlowPanel.Controls.Add(this.giftedFeatPowerfulCaster);
            this.giftedFlowPanel.Controls.Add(this.giftedFeatQuickCast);
            this.giftedFlowPanel.Controls.Add(this.giftedFeatStrengthOfWill);
            this.giftedFlowPanel.Controls.Add(this.giftedMagicSensitivity);
            this.giftedFlowPanel.Controls.Add(this.giftedRuneReader);
            this.giftedFlowPanel.Controls.Add(this.giftedWardingCircle);
            this.giftedFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giftedFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.giftedFlowPanel.Name = "giftedFlowPanel";
            this.giftedFlowPanel.Size = new System.Drawing.Size(271, 139);
            this.giftedFlowPanel.TabIndex = 0;
            this.giftedFlowPanel.Visible = false;
            // 
            // giftedAdditionalStudy
            // 
            this.giftedAdditionalStudy.AutoSize = true;
            this.giftedAdditionalStudy.Location = new System.Drawing.Point(3, 3);
            this.giftedAdditionalStudy.Name = "giftedAdditionalStudy";
            this.giftedAdditionalStudy.Size = new System.Drawing.Size(102, 17);
            this.giftedAdditionalStudy.TabIndex = 0;
            this.giftedAdditionalStudy.Text = "Additional Study";
            this.giftedAdditionalStudy.UseVisualStyleBackColor = true;
            // 
            // giftedCombatCaster
            // 
            this.giftedCombatCaster.AutoSize = true;
            this.giftedCombatCaster.Location = new System.Drawing.Point(111, 3);
            this.giftedCombatCaster.Name = "giftedCombatCaster";
            this.giftedCombatCaster.Size = new System.Drawing.Size(95, 17);
            this.giftedCombatCaster.TabIndex = 1;
            this.giftedCombatCaster.Text = "Combat Caster";
            this.giftedCombatCaster.UseVisualStyleBackColor = true;
            // 
            // giftedFastCaster
            // 
            this.giftedFastCaster.AutoSize = true;
            this.giftedFastCaster.Location = new System.Drawing.Point(3, 26);
            this.giftedFastCaster.Name = "giftedFastCaster";
            this.giftedFastCaster.Size = new System.Drawing.Size(79, 17);
            this.giftedFastCaster.TabIndex = 2;
            this.giftedFastCaster.Text = "Fast Caster";
            this.giftedFastCaster.UseVisualStyleBackColor = true;
            // 
            // giftedFeatDominator
            // 
            this.giftedFeatDominator.AutoSize = true;
            this.giftedFeatDominator.Location = new System.Drawing.Point(88, 26);
            this.giftedFeatDominator.Name = "giftedFeatDominator";
            this.giftedFeatDominator.Size = new System.Drawing.Size(101, 17);
            this.giftedFeatDominator.TabIndex = 3;
            this.giftedFeatDominator.Text = "Feat: Dominator";
            this.giftedFeatDominator.UseVisualStyleBackColor = true;
            // 
            // giftedFeatPowerfulCaster
            // 
            this.giftedFeatPowerfulCaster.AutoSize = true;
            this.giftedFeatPowerfulCaster.Location = new System.Drawing.Point(3, 49);
            this.giftedFeatPowerfulCaster.Name = "giftedFeatPowerfulCaster";
            this.giftedFeatPowerfulCaster.Size = new System.Drawing.Size(127, 17);
            this.giftedFeatPowerfulCaster.TabIndex = 4;
            this.giftedFeatPowerfulCaster.Text = "Feat: Powerful Caster";
            this.giftedFeatPowerfulCaster.UseVisualStyleBackColor = true;
            // 
            // giftedFeatQuickCast
            // 
            this.giftedFeatQuickCast.AutoSize = true;
            this.giftedFeatQuickCast.Location = new System.Drawing.Point(136, 49);
            this.giftedFeatQuickCast.Name = "giftedFeatQuickCast";
            this.giftedFeatQuickCast.Size = new System.Drawing.Size(105, 17);
            this.giftedFeatQuickCast.TabIndex = 5;
            this.giftedFeatQuickCast.Text = "Feat: Quick Cast";
            this.giftedFeatQuickCast.UseVisualStyleBackColor = true;
            // 
            // giftedFeatStrengthOfWill
            // 
            this.giftedFeatStrengthOfWill.AutoSize = true;
            this.giftedFeatStrengthOfWill.Location = new System.Drawing.Point(3, 72);
            this.giftedFeatStrengthOfWill.Name = "giftedFeatStrengthOfWill";
            this.giftedFeatStrengthOfWill.Size = new System.Drawing.Size(125, 17);
            this.giftedFeatStrengthOfWill.TabIndex = 6;
            this.giftedFeatStrengthOfWill.Text = "Feat: Strength of Will";
            this.giftedFeatStrengthOfWill.UseVisualStyleBackColor = true;
            // 
            // giftedMagicSensitivity
            // 
            this.giftedMagicSensitivity.AutoSize = true;
            this.giftedMagicSensitivity.Location = new System.Drawing.Point(134, 72);
            this.giftedMagicSensitivity.Name = "giftedMagicSensitivity";
            this.giftedMagicSensitivity.Size = new System.Drawing.Size(105, 17);
            this.giftedMagicSensitivity.TabIndex = 7;
            this.giftedMagicSensitivity.Text = "Magic Sensitivity";
            this.giftedMagicSensitivity.UseVisualStyleBackColor = true;
            // 
            // giftedRuneReader
            // 
            this.giftedRuneReader.AutoSize = true;
            this.giftedRuneReader.Location = new System.Drawing.Point(3, 95);
            this.giftedRuneReader.Name = "giftedRuneReader";
            this.giftedRuneReader.Size = new System.Drawing.Size(90, 17);
            this.giftedRuneReader.TabIndex = 8;
            this.giftedRuneReader.Text = "Rune Reader";
            this.giftedRuneReader.UseVisualStyleBackColor = true;
            // 
            // giftedWardingCircle
            // 
            this.giftedWardingCircle.AutoSize = true;
            this.giftedWardingCircle.Location = new System.Drawing.Point(99, 95);
            this.giftedWardingCircle.Name = "giftedWardingCircle";
            this.giftedWardingCircle.Size = new System.Drawing.Size(95, 17);
            this.giftedWardingCircle.TabIndex = 9;
            this.giftedWardingCircle.Text = "Warding Circle";
            this.giftedWardingCircle.UseVisualStyleBackColor = true;
            // 
            // intellectualFlowPanel
            // 
            this.intellectualFlowPanel.AutoScroll = true;
            this.intellectualFlowPanel.Controls.Add(this.intelBattlefieldCoordination);
            this.intellectualFlowPanel.Controls.Add(this.intelFeatFlawlessTiming);
            this.intellectualFlowPanel.Controls.Add(this.intelFeatPrescient);
            this.intellectualFlowPanel.Controls.Add(this.intelFeatPerfectPlot);
            this.intellectualFlowPanel.Controls.Add(this.intelFeatPlanOfAction);
            this.intellectualFlowPanel.Controls.Add(this.intelFeatQuickThinking);
            this.intellectualFlowPanel.Controls.Add(this.intelFeatUnconventionalWarfare);
            this.intellectualFlowPanel.Controls.Add(this.intelGenius);
            this.intellectualFlowPanel.Controls.Add(this.intelHyperPerception);
            this.intellectualFlowPanel.Controls.Add(this.intelPhotographicMemory);
            this.intellectualFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intellectualFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.intellectualFlowPanel.Name = "intellectualFlowPanel";
            this.intellectualFlowPanel.Size = new System.Drawing.Size(271, 139);
            this.intellectualFlowPanel.TabIndex = 1;
            this.intellectualFlowPanel.Visible = false;
            // 
            // intelBattlefieldCoordination
            // 
            this.intelBattlefieldCoordination.AutoSize = true;
            this.intelBattlefieldCoordination.Location = new System.Drawing.Point(3, 3);
            this.intelBattlefieldCoordination.Name = "intelBattlefieldCoordination";
            this.intelBattlefieldCoordination.Size = new System.Drawing.Size(134, 17);
            this.intelBattlefieldCoordination.TabIndex = 0;
            this.intelBattlefieldCoordination.Text = "Battlefield Coordination";
            this.intelBattlefieldCoordination.UseVisualStyleBackColor = true;
            // 
            // intelFeatFlawlessTiming
            // 
            this.intelFeatFlawlessTiming.AutoSize = true;
            this.intelFeatFlawlessTiming.Location = new System.Drawing.Point(3, 26);
            this.intelFeatFlawlessTiming.Name = "intelFeatFlawlessTiming";
            this.intelFeatFlawlessTiming.Size = new System.Drawing.Size(127, 17);
            this.intelFeatFlawlessTiming.TabIndex = 1;
            this.intelFeatFlawlessTiming.Text = "Feat: Flawless Timing";
            this.intelFeatFlawlessTiming.UseVisualStyleBackColor = true;
            // 
            // intelFeatPrescient
            // 
            this.intelFeatPrescient.AutoSize = true;
            this.intelFeatPrescient.Location = new System.Drawing.Point(136, 26);
            this.intelFeatPrescient.Name = "intelFeatPrescient";
            this.intelFeatPrescient.Size = new System.Drawing.Size(97, 17);
            this.intelFeatPrescient.TabIndex = 2;
            this.intelFeatPrescient.Text = "Feat: Prescient";
            this.intelFeatPrescient.UseVisualStyleBackColor = true;
            // 
            // intelFeatPerfectPlot
            // 
            this.intelFeatPerfectPlot.AutoSize = true;
            this.intelFeatPerfectPlot.Location = new System.Drawing.Point(3, 49);
            this.intelFeatPerfectPlot.Name = "intelFeatPerfectPlot";
            this.intelFeatPerfectPlot.Size = new System.Drawing.Size(108, 17);
            this.intelFeatPerfectPlot.TabIndex = 3;
            this.intelFeatPerfectPlot.Text = "Feat: Perfect Plot";
            this.intelFeatPerfectPlot.UseVisualStyleBackColor = true;
            // 
            // intelFeatPlanOfAction
            // 
            this.intelFeatPlanOfAction.AutoSize = true;
            this.intelFeatPlanOfAction.Location = new System.Drawing.Point(117, 49);
            this.intelFeatPlanOfAction.Name = "intelFeatPlanOfAction";
            this.intelFeatPlanOfAction.Size = new System.Drawing.Size(119, 17);
            this.intelFeatPlanOfAction.TabIndex = 4;
            this.intelFeatPlanOfAction.Text = "Feat: Plan of Action";
            this.intelFeatPlanOfAction.UseVisualStyleBackColor = true;
            // 
            // intelFeatQuickThinking
            // 
            this.intelFeatQuickThinking.AutoSize = true;
            this.intelFeatQuickThinking.Location = new System.Drawing.Point(3, 72);
            this.intelFeatQuickThinking.Name = "intelFeatQuickThinking";
            this.intelFeatQuickThinking.Size = new System.Drawing.Size(125, 17);
            this.intelFeatQuickThinking.TabIndex = 5;
            this.intelFeatQuickThinking.Text = "Feat: Quick Thinking";
            this.intelFeatQuickThinking.UseVisualStyleBackColor = true;
            // 
            // intelFeatUnconventionalWarfare
            // 
            this.intelFeatUnconventionalWarfare.AutoSize = true;
            this.intelFeatUnconventionalWarfare.Location = new System.Drawing.Point(3, 95);
            this.intelFeatUnconventionalWarfare.Name = "intelFeatUnconventionalWarfare";
            this.intelFeatUnconventionalWarfare.Size = new System.Drawing.Size(169, 17);
            this.intelFeatUnconventionalWarfare.TabIndex = 6;
            this.intelFeatUnconventionalWarfare.Text = "Feat: Unconventional Warfare";
            this.intelFeatUnconventionalWarfare.UseVisualStyleBackColor = true;
            // 
            // intelGenius
            // 
            this.intelGenius.AutoSize = true;
            this.intelGenius.Location = new System.Drawing.Point(178, 95);
            this.intelGenius.Name = "intelGenius";
            this.intelGenius.Size = new System.Drawing.Size(59, 17);
            this.intelGenius.TabIndex = 7;
            this.intelGenius.Text = "Genius";
            this.intelGenius.UseVisualStyleBackColor = true;
            // 
            // intelHyperPerception
            // 
            this.intelHyperPerception.AutoSize = true;
            this.intelHyperPerception.Location = new System.Drawing.Point(3, 118);
            this.intelHyperPerception.Name = "intelHyperPerception";
            this.intelHyperPerception.Size = new System.Drawing.Size(108, 17);
            this.intelHyperPerception.TabIndex = 8;
            this.intelHyperPerception.Text = "Hyper Perception";
            this.intelHyperPerception.UseVisualStyleBackColor = true;
            // 
            // intelPhotographicMemory
            // 
            this.intelPhotographicMemory.AutoSize = true;
            this.intelPhotographicMemory.Location = new System.Drawing.Point(117, 118);
            this.intelPhotographicMemory.Name = "intelPhotographicMemory";
            this.intelPhotographicMemory.Size = new System.Drawing.Size(129, 17);
            this.intelPhotographicMemory.TabIndex = 9;
            this.intelPhotographicMemory.Text = "Photographic Memory";
            this.intelPhotographicMemory.UseVisualStyleBackColor = true;
            // 
            // mightFlowPanel
            // 
            this.mightFlowPanel.AutoScroll = true;
            this.mightFlowPanel.Controls.Add(this.mightBeatBack);
            this.mightFlowPanel.Controls.Add(this.mightFeatBackSwing);
            this.mightFlowPanel.Controls.Add(this.mightFeatBoundingLeap);
            this.mightFlowPanel.Controls.Add(this.mightFeatCounterCharge);
            this.mightFlowPanel.Controls.Add(this.mightFeatInvulnerable);
            this.mightFlowPanel.Controls.Add(this.mightFeatRevitalize);
            this.mightFlowPanel.Controls.Add(this.mightFeatShieldBreaker);
            this.mightFlowPanel.Controls.Add(this.mightFeatVendetta);
            this.mightFlowPanel.Controls.Add(this.mightRighteousAnger);
            this.mightFlowPanel.Controls.Add(this.mightTough);
            this.mightFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mightFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.mightFlowPanel.Name = "mightFlowPanel";
            this.mightFlowPanel.Size = new System.Drawing.Size(271, 139);
            this.mightFlowPanel.TabIndex = 2;
            this.mightFlowPanel.Visible = false;
            // 
            // mightBeatBack
            // 
            this.mightBeatBack.AutoSize = true;
            this.mightBeatBack.Location = new System.Drawing.Point(3, 3);
            this.mightBeatBack.Name = "mightBeatBack";
            this.mightBeatBack.Size = new System.Drawing.Size(76, 17);
            this.mightBeatBack.TabIndex = 1;
            this.mightBeatBack.Text = "Beat Back";
            this.mightBeatBack.UseVisualStyleBackColor = true;
            // 
            // mightFeatBackSwing
            // 
            this.mightFeatBackSwing.AutoSize = true;
            this.mightFeatBackSwing.Location = new System.Drawing.Point(85, 3);
            this.mightFeatBackSwing.Name = "mightFeatBackSwing";
            this.mightFeatBackSwing.Size = new System.Drawing.Size(110, 17);
            this.mightFeatBackSwing.TabIndex = 2;
            this.mightFeatBackSwing.Text = "Feat: Back Swing";
            this.mightFeatBackSwing.UseVisualStyleBackColor = true;
            // 
            // mightFeatBoundingLeap
            // 
            this.mightFeatBoundingLeap.AutoSize = true;
            this.mightFeatBoundingLeap.Location = new System.Drawing.Point(3, 26);
            this.mightFeatBoundingLeap.Name = "mightFeatBoundingLeap";
            this.mightFeatBoundingLeap.Size = new System.Drawing.Size(125, 17);
            this.mightFeatBoundingLeap.TabIndex = 3;
            this.mightFeatBoundingLeap.Text = "Feat: Bounding Leap";
            this.mightFeatBoundingLeap.UseVisualStyleBackColor = true;
            // 
            // mightFeatCounterCharge
            // 
            this.mightFeatCounterCharge.AutoSize = true;
            this.mightFeatCounterCharge.Location = new System.Drawing.Point(134, 26);
            this.mightFeatCounterCharge.Name = "mightFeatCounterCharge";
            this.mightFeatCounterCharge.Size = new System.Drawing.Size(127, 17);
            this.mightFeatCounterCharge.TabIndex = 4;
            this.mightFeatCounterCharge.Text = "Feat: Counter Charge";
            this.mightFeatCounterCharge.UseVisualStyleBackColor = true;
            // 
            // mightFeatInvulnerable
            // 
            this.mightFeatInvulnerable.AutoSize = true;
            this.mightFeatInvulnerable.Location = new System.Drawing.Point(3, 49);
            this.mightFeatInvulnerable.Name = "mightFeatInvulnerable";
            this.mightFeatInvulnerable.Size = new System.Drawing.Size(111, 17);
            this.mightFeatInvulnerable.TabIndex = 5;
            this.mightFeatInvulnerable.Text = "Feat: Invulnerable";
            this.mightFeatInvulnerable.UseVisualStyleBackColor = true;
            // 
            // mightFeatRevitalize
            // 
            this.mightFeatRevitalize.AutoSize = true;
            this.mightFeatRevitalize.Location = new System.Drawing.Point(120, 49);
            this.mightFeatRevitalize.Name = "mightFeatRevitalize";
            this.mightFeatRevitalize.Size = new System.Drawing.Size(99, 17);
            this.mightFeatRevitalize.TabIndex = 6;
            this.mightFeatRevitalize.Text = "Feat: Revitalize";
            this.mightFeatRevitalize.UseVisualStyleBackColor = true;
            // 
            // mightFeatShieldBreaker
            // 
            this.mightFeatShieldBreaker.AutoSize = true;
            this.mightFeatShieldBreaker.Location = new System.Drawing.Point(3, 72);
            this.mightFeatShieldBreaker.Name = "mightFeatShieldBreaker";
            this.mightFeatShieldBreaker.Size = new System.Drawing.Size(122, 17);
            this.mightFeatShieldBreaker.TabIndex = 7;
            this.mightFeatShieldBreaker.Text = "Feat: Shield Breaker";
            this.mightFeatShieldBreaker.UseVisualStyleBackColor = true;
            // 
            // mightFeatVendetta
            // 
            this.mightFeatVendetta.AutoSize = true;
            this.mightFeatVendetta.Location = new System.Drawing.Point(131, 72);
            this.mightFeatVendetta.Name = "mightFeatVendetta";
            this.mightFeatVendetta.Size = new System.Drawing.Size(96, 17);
            this.mightFeatVendetta.TabIndex = 8;
            this.mightFeatVendetta.Text = "Feat: Vendetta";
            this.mightFeatVendetta.UseVisualStyleBackColor = true;
            // 
            // mightRighteousAnger
            // 
            this.mightRighteousAnger.AutoSize = true;
            this.mightRighteousAnger.Location = new System.Drawing.Point(3, 95);
            this.mightRighteousAnger.Name = "mightRighteousAnger";
            this.mightRighteousAnger.Size = new System.Drawing.Size(105, 17);
            this.mightRighteousAnger.TabIndex = 9;
            this.mightRighteousAnger.Text = "Righteous Anger";
            this.mightRighteousAnger.UseVisualStyleBackColor = true;
            // 
            // mightTough
            // 
            this.mightTough.AutoSize = true;
            this.mightTough.Location = new System.Drawing.Point(114, 95);
            this.mightTough.Name = "mightTough";
            this.mightTough.Size = new System.Drawing.Size(57, 17);
            this.mightTough.TabIndex = 10;
            this.mightTough.Text = "Tough";
            this.mightTough.UseVisualStyleBackColor = true;
            // 
            // skilledFlowPanel
            // 
            this.skilledFlowPanel.AutoScroll = true;
            this.skilledFlowPanel.Controls.Add(this.skillAmbidextrous);
            this.skilledFlowPanel.Controls.Add(this.skillCagey);
            this.skilledFlowPanel.Controls.Add(this.skillDeft);
            this.skilledFlowPanel.Controls.Add(this.skillFeatDefensiveStrike);
            this.skilledFlowPanel.Controls.Add(this.skillFeatDisarm);
            this.skilledFlowPanel.Controls.Add(this.skillFeatSwashbuckler);
            this.skilledFlowPanel.Controls.Add(this.skillFeatUntouchable);
            this.skilledFlowPanel.Controls.Add(this.skillPreternaturaAwareness);
            this.skilledFlowPanel.Controls.Add(this.skillSidestep);
            this.skilledFlowPanel.Controls.Add(this.skillVirtuoso);
            this.skilledFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skilledFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.skilledFlowPanel.Name = "skilledFlowPanel";
            this.skilledFlowPanel.Size = new System.Drawing.Size(271, 139);
            this.skilledFlowPanel.TabIndex = 3;
            this.skilledFlowPanel.Visible = false;
            // 
            // skillAmbidextrous
            // 
            this.skillAmbidextrous.AutoSize = true;
            this.skillAmbidextrous.Location = new System.Drawing.Point(3, 3);
            this.skillAmbidextrous.Name = "skillAmbidextrous";
            this.skillAmbidextrous.Size = new System.Drawing.Size(89, 17);
            this.skillAmbidextrous.TabIndex = 1;
            this.skillAmbidextrous.Text = "Ambidextrous";
            this.skillAmbidextrous.UseVisualStyleBackColor = true;
            // 
            // skillCagey
            // 
            this.skillCagey.AutoSize = true;
            this.skillCagey.Location = new System.Drawing.Point(98, 3);
            this.skillCagey.Name = "skillCagey";
            this.skillCagey.Size = new System.Drawing.Size(56, 17);
            this.skillCagey.TabIndex = 2;
            this.skillCagey.Text = "Cagey";
            this.skillCagey.UseVisualStyleBackColor = true;
            // 
            // skillDeft
            // 
            this.skillDeft.AutoSize = true;
            this.skillDeft.Location = new System.Drawing.Point(160, 3);
            this.skillDeft.Name = "skillDeft";
            this.skillDeft.Size = new System.Drawing.Size(46, 17);
            this.skillDeft.TabIndex = 3;
            this.skillDeft.Text = "Deft";
            this.skillDeft.UseVisualStyleBackColor = true;
            // 
            // skillFeatDefensiveStrike
            // 
            this.skillFeatDefensiveStrike.AutoSize = true;
            this.skillFeatDefensiveStrike.Location = new System.Drawing.Point(3, 26);
            this.skillFeatDefensiveStrike.Name = "skillFeatDefensiveStrike";
            this.skillFeatDefensiveStrike.Size = new System.Drawing.Size(131, 17);
            this.skillFeatDefensiveStrike.TabIndex = 4;
            this.skillFeatDefensiveStrike.Text = "Feat: Defensive Strike";
            this.skillFeatDefensiveStrike.UseVisualStyleBackColor = true;
            // 
            // skillFeatDisarm
            // 
            this.skillFeatDisarm.AutoSize = true;
            this.skillFeatDisarm.Location = new System.Drawing.Point(140, 26);
            this.skillFeatDisarm.Name = "skillFeatDisarm";
            this.skillFeatDisarm.Size = new System.Drawing.Size(85, 17);
            this.skillFeatDisarm.TabIndex = 5;
            this.skillFeatDisarm.Text = "Feat: Disarm";
            this.skillFeatDisarm.UseVisualStyleBackColor = true;
            // 
            // skillFeatSwashbuckler
            // 
            this.skillFeatSwashbuckler.AutoSize = true;
            this.skillFeatSwashbuckler.Location = new System.Drawing.Point(3, 49);
            this.skillFeatSwashbuckler.Name = "skillFeatSwashbuckler";
            this.skillFeatSwashbuckler.Size = new System.Drawing.Size(120, 17);
            this.skillFeatSwashbuckler.TabIndex = 6;
            this.skillFeatSwashbuckler.Text = "Feat: Swashbuckler";
            this.skillFeatSwashbuckler.UseVisualStyleBackColor = true;
            // 
            // skillFeatUntouchable
            // 
            this.skillFeatUntouchable.AutoSize = true;
            this.skillFeatUntouchable.Location = new System.Drawing.Point(129, 49);
            this.skillFeatUntouchable.Name = "skillFeatUntouchable";
            this.skillFeatUntouchable.Size = new System.Drawing.Size(114, 17);
            this.skillFeatUntouchable.TabIndex = 7;
            this.skillFeatUntouchable.Text = "Feat: Untouchable";
            this.skillFeatUntouchable.UseVisualStyleBackColor = true;
            // 
            // skillPreternaturaAwareness
            // 
            this.skillPreternaturaAwareness.AutoSize = true;
            this.skillPreternaturaAwareness.Location = new System.Drawing.Point(3, 72);
            this.skillPreternaturaAwareness.Name = "skillPreternaturaAwareness";
            this.skillPreternaturaAwareness.Size = new System.Drawing.Size(141, 17);
            this.skillPreternaturaAwareness.TabIndex = 8;
            this.skillPreternaturaAwareness.Text = "Preternatural Awareness";
            this.skillPreternaturaAwareness.UseVisualStyleBackColor = true;
            // 
            // skillSidestep
            // 
            this.skillSidestep.AutoSize = true;
            this.skillSidestep.Location = new System.Drawing.Point(150, 72);
            this.skillSidestep.Name = "skillSidestep";
            this.skillSidestep.Size = new System.Drawing.Size(67, 17);
            this.skillSidestep.TabIndex = 9;
            this.skillSidestep.Text = "Sidestep";
            this.skillSidestep.UseVisualStyleBackColor = true;
            // 
            // skillVirtuoso
            // 
            this.skillVirtuoso.AutoSize = true;
            this.skillVirtuoso.Location = new System.Drawing.Point(3, 95);
            this.skillVirtuoso.Name = "skillVirtuoso";
            this.skillVirtuoso.Size = new System.Drawing.Size(64, 17);
            this.skillVirtuoso.TabIndex = 10;
            this.skillVirtuoso.Text = "Virtuoso";
            this.skillVirtuoso.UseVisualStyleBackColor = true;
            // 
            // careerTab
            // 
            this.careerTab.Location = new System.Drawing.Point(4, 22);
            this.careerTab.Name = "careerTab";
            this.careerTab.Padding = new System.Windows.Forms.Padding(3);
            this.careerTab.Size = new System.Drawing.Size(577, 401);
            this.careerTab.TabIndex = 2;
            this.careerTab.Text = "Careers";
            this.careerTab.UseVisualStyleBackColor = true;
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // archetypeMinorText
            // 
            this.archetypeMinorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archetypeMinorText.Location = new System.Drawing.Point(0, 0);
            this.archetypeMinorText.Multiline = true;
            this.archetypeMinorText.Name = "archetypeMinorText";
            this.archetypeMinorText.ReadOnly = true;
            this.archetypeMinorText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.archetypeMinorText.Size = new System.Drawing.Size(271, 200);
            this.archetypeMinorText.TabIndex = 0;
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
            this.archetypeTab.ResumeLayout(false);
            this.archetypeTablePanel.ResumeLayout(false);
            this.archetypeTablePanel.PerformLayout();
            this.archetypeSplitPanel.Panel1.ResumeLayout(false);
            this.archetypeSplitPanel.Panel2.ResumeLayout(false);
            this.archetypeSplitPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archetypeSplitPanel)).EndInit();
            this.archetypeSplitPanel.ResumeLayout(false);
            this.giftedFlowPanel.ResumeLayout(false);
            this.giftedFlowPanel.PerformLayout();
            this.intellectualFlowPanel.ResumeLayout(false);
            this.intellectualFlowPanel.PerformLayout();
            this.mightFlowPanel.ResumeLayout(false);
            this.mightFlowPanel.PerformLayout();
            this.skilledFlowPanel.ResumeLayout(false);
            this.skilledFlowPanel.PerformLayout();
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
        private TableLayoutPanel archetypeTablePanel;
        private ComboBox archetypeSelection;
        private TextBox archetypeText;
        private SplitContainer archetypeSplitPanel;
        private FlowLayoutPanel giftedFlowPanel;
        private FlowLayoutPanel intellectualFlowPanel;
        private FlowLayoutPanel mightFlowPanel;
        private FlowLayoutPanel skilledFlowPanel;
        private CheckBox giftedAdditionalStudy;
        private CheckBox giftedCombatCaster;
        private CheckBox giftedFastCaster;
        private CheckBox giftedFeatDominator;
        private CheckBox giftedFeatPowerfulCaster;
        private CheckBox giftedFeatQuickCast;
        private CheckBox giftedFeatStrengthOfWill;
        private CheckBox giftedMagicSensitivity;
        private CheckBox giftedRuneReader;
        private CheckBox giftedWardingCircle;
        private CheckBox intelBattlefieldCoordination;
        private CheckBox intelFeatFlawlessTiming;
        private CheckBox intelFeatPrescient;
        private CheckBox intelFeatPerfectPlot;
        private CheckBox intelFeatPlanOfAction;
        private CheckBox intelFeatQuickThinking;
        private CheckBox intelFeatUnconventionalWarfare;
        private CheckBox intelGenius;
        private CheckBox intelHyperPerception;
        private CheckBox intelPhotographicMemory;
        private CheckBox mightBeatBack;
        private CheckBox mightFeatBackSwing;
        private CheckBox mightFeatBoundingLeap;
        private CheckBox mightFeatCounterCharge;
        private CheckBox mightFeatInvulnerable;
        private CheckBox mightFeatRevitalize;
        private CheckBox mightFeatShieldBreaker;
        private CheckBox mightFeatVendetta;
        private CheckBox mightRighteousAnger;
        private CheckBox mightTough;
        private CheckBox skillAmbidextrous;
        private CheckBox skillCagey;
        private CheckBox skillDeft;
        private CheckBox skillFeatDefensiveStrike;
        private CheckBox skillFeatDisarm;
        private CheckBox skillFeatSwashbuckler;
        private CheckBox skillFeatUntouchable;
        private CheckBox skillPreternaturaAwareness;
        private CheckBox skillSidestep;
        private CheckBox skillVirtuoso;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private TextBox archetypeMinorText;

    }
}

