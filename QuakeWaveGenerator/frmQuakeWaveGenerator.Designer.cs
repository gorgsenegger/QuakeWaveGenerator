#pragma warning disable CS1591
namespace QuakeWaveGenerator
{
    partial class frmQuakeWaveGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuakeWaveGenerator));
            this.nudSizeInUnits = new System.Windows.Forms.NumericUpDown();
            this.lblSizeInUnits = new System.Windows.Forms.Label();
            this.lblTextureName = new System.Windows.Forms.Label();
            this.lblOffsetToRight = new System.Windows.Forms.Label();
            this.nudOffsetToRight = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetToFront = new System.Windows.Forms.Label();
            this.nudOffsetToFront = new System.Windows.Forms.NumericUpDown();
            this.lblOffsetToTop = new System.Windows.Forms.Label();
            this.nudOffsetToTop = new System.Windows.Forms.NumericUpDown();
            this.cmbTextureName = new System.Windows.Forms.ComboBox();
            this.lblNumberOfRows = new System.Windows.Forms.Label();
            this.nudNumRows = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfColumns = new System.Windows.Forms.Label();
            this.nudNumColumns = new System.Windows.Forms.NumericUpDown();
            this.txtSumBlocks = new System.Windows.Forms.TextBox();
            this.lblSumBlocks = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblBlockSpacing = new System.Windows.Forms.Label();
            this.nudSpacing = new System.Windows.Forms.NumericUpDown();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.nudDamage = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSound = new System.Windows.Forms.Label();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWaveHeightPerStep = new System.Windows.Forms.Label();
            this.nudWaveHeightPerStep = new System.Windows.Forms.NumericUpDown();
            this.lblNumSteps = new System.Windows.Forms.Label();
            this.nudNumSteps = new System.Windows.Forms.NumericUpDown();
            this.lblTotalWaveAmplitude = new System.Windows.Forms.Label();
            this.txtTotalAmplitude = new System.Windows.Forms.TextBox();
            this.tlpTextBoxes = new System.Windows.Forms.TableLayoutPanel();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnClearGeneratedText = new System.Windows.Forms.Button();
            this.btnCopyGeneratedCode = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStepHeights = new System.Windows.Forms.Label();
            this.txtStepHeights = new System.Windows.Forms.TextBox();
            this.lblDiagonalWave = new System.Windows.Forms.Label();
            this.chkDiagonalWave = new System.Windows.Forms.CheckBox();
            this.btnPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeInUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaveHeightPerStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSteps)).BeginInit();
            this.tlpTextBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudSizeInUnits
            // 
            this.nudSizeInUnits.Location = new System.Drawing.Point(348, 11);
            this.nudSizeInUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSizeInUnits.Name = "nudSizeInUnits";
            this.nudSizeInUnits.Size = new System.Drawing.Size(96, 26);
            this.nudSizeInUnits.TabIndex = 0;
            this.nudSizeInUnits.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // lblSizeInUnits
            // 
            this.lblSizeInUnits.AutoSize = true;
            this.lblSizeInUnits.Location = new System.Drawing.Point(208, 14);
            this.lblSizeInUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSizeInUnits.Name = "lblSizeInUnits";
            this.lblSizeInUnits.Size = new System.Drawing.Size(98, 20);
            this.lblSizeInUnits.TabIndex = 1;
            this.lblSizeInUnits.Text = "Size in units:";
            // 
            // lblTextureName
            // 
            this.lblTextureName.AutoSize = true;
            this.lblTextureName.Location = new System.Drawing.Point(718, 14);
            this.lblTextureName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextureName.Name = "lblTextureName";
            this.lblTextureName.Size = new System.Drawing.Size(110, 20);
            this.lblTextureName.TabIndex = 2;
            this.lblTextureName.Text = "Texture name:";
            // 
            // lblOffsetToRight
            // 
            this.lblOffsetToRight.AutoSize = true;
            this.lblOffsetToRight.Location = new System.Drawing.Point(208, 54);
            this.lblOffsetToRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffsetToRight.Name = "lblOffsetToRight";
            this.lblOffsetToRight.Size = new System.Drawing.Size(110, 20);
            this.lblOffsetToRight.TabIndex = 4;
            this.lblOffsetToRight.Text = "Offset to right:";
            // 
            // nudOffsetToRight
            // 
            this.nudOffsetToRight.Location = new System.Drawing.Point(348, 51);
            this.nudOffsetToRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOffsetToRight.Name = "nudOffsetToRight";
            this.nudOffsetToRight.Size = new System.Drawing.Size(96, 26);
            this.nudOffsetToRight.TabIndex = 3;
            // 
            // lblOffsetToFront
            // 
            this.lblOffsetToFront.AutoSize = true;
            this.lblOffsetToFront.Location = new System.Drawing.Point(453, 54);
            this.lblOffsetToFront.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffsetToFront.Name = "lblOffsetToFront";
            this.lblOffsetToFront.Size = new System.Drawing.Size(112, 20);
            this.lblOffsetToFront.TabIndex = 6;
            this.lblOffsetToFront.Text = "Offset to front:";
            // 
            // nudOffsetToFront
            // 
            this.nudOffsetToFront.Location = new System.Drawing.Point(614, 51);
            this.nudOffsetToFront.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOffsetToFront.Name = "nudOffsetToFront";
            this.nudOffsetToFront.Size = new System.Drawing.Size(96, 26);
            this.nudOffsetToFront.TabIndex = 4;
            // 
            // lblOffsetToTop
            // 
            this.lblOffsetToTop.AutoSize = true;
            this.lblOffsetToTop.Location = new System.Drawing.Point(718, 54);
            this.lblOffsetToTop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffsetToTop.Name = "lblOffsetToTop";
            this.lblOffsetToTop.Size = new System.Drawing.Size(102, 20);
            this.lblOffsetToTop.TabIndex = 8;
            this.lblOffsetToTop.Text = "Offset to top:";
            // 
            // nudOffsetToTop
            // 
            this.nudOffsetToTop.Location = new System.Drawing.Point(850, 51);
            this.nudOffsetToTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOffsetToTop.Name = "nudOffsetToTop";
            this.nudOffsetToTop.Size = new System.Drawing.Size(96, 26);
            this.nudOffsetToTop.TabIndex = 5;
            // 
            // cmbTextureName
            // 
            this.cmbTextureName.FormattingEnabled = true;
            this.cmbTextureName.Items.AddRange(new object[] {
            "#04awater1",
            "#04mwat1",
            "#04mwat2",
            "#04water1",
            "#04water2",
            "#lava1",
            "#lava1_luma",
            "#slime",
            "#slime0",
            "#slime0_luma",
            "#slime1",
            "#slime1_luma",
            "#slime_luma",
            "#teleport",
            "#water0",
            "#water1",
            "#water2",
            "+0basebtn",
            "+0basebtn_luma",
            "+0butn",
            "+0butn_luma",
            "+0butnn",
            "+0butnn_luma",
            "+0button",
            "+0button_luma",
            "+0floorsw",
            "+0floorsw_luma",
            "+0light01",
            "+0mtlsw",
            "+0planet",
            "+0planet_luma",
            "+0shoot",
            "+0shoot_luma",
            "+0slip",
            "+0slip_luma",
            "+0slipbot",
            "+0sliptop",
            "+1basebtn",
            "+1basebtn_luma",
            "+1butn",
            "+1butn_luma",
            "+1butnn",
            "+1butnn_luma",
            "+1button",
            "+1button_luma",
            "+1floorsw",
            "+1floorsw_luma",
            "+1light01",
            "+1mtlsw",
            "+1planet",
            "+1planet_luma",
            "+1shoot",
            "+1shoot_luma",
            "+1slip",
            "+1slip_luma",
            "+2butn",
            "+2butn_luma",
            "+2butnn",
            "+2butnn_luma",
            "+2button",
            "+2button_luma",
            "+2floorsw",
            "+2floorsw_luma",
            "+2light01",
            "+2mtlsw",
            "+2planet",
            "+2planet_luma",
            "+2shoot",
            "+2shoot_luma",
            "+2slip",
            "+2slip_luma",
            "+3butn",
            "+3butn_luma",
            "+3butnn",
            "+3butnn_luma",
            "+3button",
            "+3button_luma",
            "+3floorsw",
            "+3floorsw_luma",
            "+3mtlsw",
            "+3planet",
            "+3planet_luma",
            "+3shoot",
            "+3shoot_luma",
            "+3slip",
            "+3slip_luma",
            "+4slip",
            "+4slip_luma",
            "+5slip",
            "+5slip_luma",
            "+6slip",
            "+6slip_luma",
            "+abasebtn",
            "+abasebtn_luma",
            "+abutn",
            "+abutnn",
            "+abutton",
            "+afloorsw",
            "+amtlsw",
            "+ashoot",
            "README.md",
            "Update README",
            "adoor01_2",
            "adoor02_2",
            "adoor03_2",
            "adoor03_3",
            "adoor03_4",
            "adoor03_5",
            "adoor03_6",
            "adoor09_1",
            "adoor09_2",
            "afloor1_3",
            "afloor1_4",
            "afloor1_8",
            "afloor3_1",
            "altar1_1",
            "altar1_3",
            "altar1_4",
            "altar1_6",
            "altar1_7",
            "altar1_8",
            "altarb_1",
            "altarb_2",
            "altarc_1",
            "arch7",
            "arrow_m",
            "az1_6",
            "azfloor1_1",
            "azswitch3",
            "azswitch3_luma",
            "azwall1_5",
            "azwall3_1",
            "azwall3_2",
            "basebutn3",
            "basebutn3_luma",
            "bodiesa2_1",
            "bodiesa2_4",
            "bodiesa3_1",
            "bodiesa3_2",
            "bodiesa3_3",
            "bricka2_1",
            "bricka2_2",
            "bricka2_4",
            "bricka2_6",
            "carch02",
            "carch03",
            "carch03_luma",
            "carch04_1",
            "carch04_2",
            "ceil1_1",
            "ceil1_1_luma",
            "ceiling1_3",
            "ceiling4",
            "ceiling4_luma",
            "ceiling5",
            "church1_2",
            "church7",
            "city1_4",
            "city1_7",
            "city2_1",
            "city2_2",
            "city2_3",
            "city2_5",
            "city2_6",
            "city2_7",
            "city2_8",
            "city3_2",
            "city3_4",
            "city4_1",
            "city4_2",
            "city4_5",
            "city4_6",
            "city4_7",
            "city4_8",
            "city5_1",
            "city5_2",
            "city5_3",
            "city5_4",
            "city5_6",
            "city5_7",
            "city5_8",
            "city6_3",
            "city6_4",
            "city6_7",
            "city6_8",
            "city8_2",
            "citya1_1",
            "column01_3",
            "column01_4",
            "column1_2",
            "column1_4",
            "column1_5",
            "comp1_1",
            "comp1_1_luma",
            "comp1_2",
            "comp1_3",
            "comp1_4",
            "comp1_5",
            "comp1_6",
            "comp1_6_luma",
            "comp1_7",
            "comp1_8",
            "cop1_1",
            "cop1_2",
            "cop1_3",
            "cop1_4",
            "cop1_5",
            "cop1_6",
            "cop1_7",
            "cop1_8",
            "cop2_1",
            "cop2_2",
            "cop2_3",
            "cop2_4",
            "cop2_5",
            "cop2_6",
            "cop3_1",
            "cop3_2",
            "cop3_4",
            "cop4_3",
            "cop4_5",
            "crate0_side",
            "crate0_top",
            "crate1_side",
            "crate1_top",
            "dem4_1",
            "dem4_4",
            "dem5_3",
            "dem5_3_luma",
            "demc4_4",
            "door01_2",
            "door02_1",
            "door02_2",
            "door02_3",
            "door02_7",
            "door03_2",
            "door03_3",
            "door03_4",
            "door03_5",
            "door04_1",
            "door04_2",
            "door05_2",
            "door05_3",
            "dopeback",
            "dopefish",
            "dr01_1",
            "dr01_2",
            "dr02_1",
            "dr02_2",
            "dr03_1",
            "dr05_2",
            "dr07_1",
            "dung01_1",
            "dung01_2",
            "dung01_3",
            "dung01_4",
            "dung01_5",
            "dung02_1",
            "dung02_5",
            "ecop1_1",
            "ecop1_4",
            "ecop1_6",
            "ecop1_7",
            "ecop1_8",
            "edoor01_1",
            "elwall1_1",
            "elwall2_4",
            "emetal1_3",
            "enter01",
            "exit01",
            "exit02_2",
            "exit02_3",
            "floor01_5",
            "grave01_1",
            "grave01_3",
            "grave02_1",
            "grave02_2",
            "grave02_3",
            "grave02_4",
            "grave02_5",
            "grave02_6",
            "grave02_7",
            "grave03_1",
            "grave03_2",
            "grave03_3",
            "grave03_4",
            "grave03_5",
            "grave03_6",
            "grave03_7",
            "ground1_1",
            "ground1_2",
            "ground1_5",
            "ground1_6",
            "ground1_7",
            "ground1_8",
            "key01_1",
            "key01_1_luma",
            "key01_2",
            "key01_2_luma",
            "key01_3",
            "key02_1",
            "key02_1_luma",
            "key02_2",
            "key02_2_luma",
            "key03_1",
            "key03_1_luma",
            "key03_2",
            "key03_2_luma",
            "key03_3",
            "lgmetal",
            "lgmetal2",
            "lgmetal3",
            "lgmetal4",
            "light1_1",
            "light1_1_luma",
            "light1_2",
            "light1_2_luma",
            "light1_3",
            "light1_3_luma",
            "light1_4",
            "light1_4_luma",
            "light1_5",
            "light1_5_luma",
            "light1_7",
            "light1_7_luma",
            "light1_8",
            "light1_8_luma",
            "light3_3",
            "light3_3_luma",
            "light3_5",
            "light3_5_luma",
            "light3_6",
            "light3_6_luma",
            "light3_7",
            "light3_7_luma",
            "light3_8",
            "light3_8_luma",
            "m5_3",
            "m5_5",
            "m5_8",
            "med100",
            "med3_0",
            "med3_0_luma",
            "med3_1",
            "med3_1_luma",
            "met5_1",
            "met5_2",
            "met5_3",
            "met5_3_luma",
            "metal1_1",
            "metal1_2",
            "metal1_3",
            "metal1_4",
            "metal1_5",
            "metal1_6",
            "metal1_7",
            "metal2_1",
            "metal2_2",
            "metal2_3",
            "metal2_4",
            "metal2_5",
            "metal2_6",
            "metal2_7",
            "metal2_8",
            "metal3_2",
            "metal4_2",
            "metal4_3",
            "metal4_4",
            "metal4_5",
            "metal4_6",
            "metal4_7",
            "metal4_8",
            "metal5_1",
            "metal5_2",
            "metal5_3",
            "metal5_4",
            "metal5_5",
            "metal5_6",
            "metal5_8",
            "metal6_1",
            "metal6_2",
            "metal6_3",
            "metal6_3_luma",
            "metal6_4",
            "metalt1_1",
            "metalt1_2",
            "metalt1_2_luma",
            "metalt1_7",
            "metalt1_7_luma",
            "metalt2_1",
            "metalt2_2",
            "metalt2_3",
            "metalt2_4",
            "metalt2_5",
            "metalt2_6",
            "metalt2_7",
            "metalt2_8",
            "metflor2_1",
            "mmetal1_1",
            "mmetal1_2",
            "mmetal1_3",
            "mmetal1_5",
            "mmetal1_6",
            "mmetal1_7",
            "mmetal1_8",
            "mswtch_2",
            "mswtch_2_luma",
            "mswtch_3",
            "mswtch_3_luma",
            "mswtch_4",
            "mswtch_4_luma",
            "muh_bad",
            "muh_bad_luma",
            "nmetal2_1",
            "nmetal2_6",
            "plat_side1",
            "plat_side1_luma",
            "plat_stem",
            "plat_top1",
            "plat_top2",
            "quake",
            "raven",
            "rock1_2",
            "rock3_2",
            "rock3_7",
            "rock3_8",
            "rock4_1",
            "rock4_2",
            "rock5_2",
            "rune1_1",
            "rune1_4",
            "rune1_5",
            "rune1_6",
            "rune1_7",
            "rune2_1",
            "rune2_1_luma",
            "rune2_2",
            "rune2_2_luma",
            "rune2_3",
            "rune2_3_luma",
            "rune2_4",
            "rune2_4_luma",
            "rune2_5",
            "rune2_5_luma",
            "rune_a",
            "rune_a_luma",
            "sfloor1_2",
            "sfloor3_2",
            "sfloor4_1",
            "sfloor4_2",
            "sfloor4_4",
            "sfloor4_4_luma",
            "sfloor4_5",
            "sfloor4_6",
            "sfloor4_7",
            "sfloor4_8",
            "skill0",
            "skill1",
            "skill2",
            "skill3",
            "sky1",
            "sky1_alpha",
            "sky1_solid",
            "sky4",
            "sky4_alpha",
            "sky4_solid",
            "slip1",
            "slip1_luma",
            "slip2",
            "slip2_luma",
            "slipbotsd",
            "sliplite",
            "sliplite_luma",
            "slipside",
            "slipside_luma",
            "sliptopsd",
            "stone1_3",
            "stone1_5",
            "stone1_7",
            "switch_1",
            "switch_1_luma",
            "swtch1_1",
            "tech01_1",
            "tech01_2",
            "tech01_3",
            "tech01_5",
            "tech01_6",
            "tech01_7",
            "tech01_9",
            "tech02_1",
            "tech02_2",
            "tech02_3",
            "tech02_5",
            "tech02_6",
            "tech02_7",
            "tech03_1",
            "tech03_2",
            "tech03_2_luma",
            "tech04_1",
            "tech04_2",
            "tech04_3",
            "tech04_4",
            "tech04_5",
            "tech04_6",
            "tech04_7",
            "tech04_8",
            "tech05_1",
            "tech05_2",
            "tech06_1",
            "tech06_2",
            "tech06_2_luma",
            "tech07_1",
            "tech07_2",
            "tech08_1",
            "tech08_2",
            "tech09_3",
            "tech09_3_luma",
            "tech09_4",
            "tech09_4_luma",
            "tech10_1",
            "tech10_3",
            "tech11_1",
            "tech11_1_luma",
            "tech11_2",
            "tech11_2_luma",
            "tech12_1",
            "tech13_2",
            "tech14_1",
            "tech14_2",
            "tele_top",
            "tele_top_luma",
            "tlight01",
            "tlight01_2",
            "tlight01_luma",
            "tlight02",
            "tlight02_luma",
            "tlight03",
            "tlight03_luma",
            "tlight05",
            "tlight05_luma",
            "tlight07",
            "tlight07_luma",
            "tlight08",
            "tlight09",
            "tlight09_luma",
            "tlight10",
            "tlight10_luma",
            "tlight11",
            "tlight11_luma",
            "twall1_1",
            "twall1_2",
            "twall1_4",
            "twall2_1",
            "twall2_1_luma",
            "twall2_2",
            "twall2_2_luma",
            "twall2_3",
            "twall2_5",
            "twall2_6",
            "twall3_1",
            "twall3_1_luma",
            "twall5_1",
            "twall5_2",
            "twall5_3",
            "unwall1_8",
            "uwall1_2",
            "uwall1_3",
            "uwall1_4",
            "vine1_2",
            "wall11_2",
            "wall11_6",
            "wall14_5",
            "wall14_6",
            "wall16_7",
            "wall3_4",
            "wall5_4",
            "wall9_3",
            "wall9_8",
            "warch05",
            "wbrick1_4",
            "wbrick1_5",
            "wceiling4",
            "wceiling4_luma",
            "wceiling5",
            "wenter01",
            "wexit01",
            "wgrass1_1",
            "wgrnd1_5",
            "wgrnd1_6",
            "wgrnd1_8",
            "window01_1",
            "window01_2",
            "window01_3",
            "window01_4",
            "window02_1",
            "window03",
            "window03_luma",
            "window1_2",
            "window1_3",
            "window1_4",
            "wiz1_1",
            "wiz1_4",
            "wizmet1_1",
            "wizmet1_2",
            "wizmet1_3",
            "wizmet1_4",
            "wizmet1_5",
            "wizmet1_6",
            "wizmet1_7",
            "wizmet1_8",
            "wizwin1_2",
            "wizwin1_8",
            "wizwood1_2",
            "wizwood1_3",
            "wizwood1_4",
            "wizwood1_5",
            "wizwood1_6",
            "wizwood1_7",
            "wizwood1_8",
            "wkey02_1",
            "wkey02_1_luma",
            "wkey02_2",
            "wkey02_2_luma",
            "wkey02_3",
            "wmet1_1",
            "wmet2_1",
            "wmet2_2",
            "wmet2_3",
            "wmet2_4",
            "wmet2_6",
            "wmet3_1",
            "wmet3_3",
            "wmet3_4",
            "wmet4_2",
            "wmet4_3",
            "wmet4_4",
            "wmet4_5",
            "wmet4_6",
            "wmet4_7",
            "wmet4_8",
            "wood1_1",
            "wood1_5",
            "wood1_7",
            "wood1_8",
            "woodflr1_2",
            "woodflr1_4",
            "woodflr1_5",
            "wswamp1_2",
            "wswamp1_4",
            "wswamp2_1",
            "wswamp2_2",
            "wswitch1",
            "wwall1_1",
            "wwood1_5",
            "wwood1_7",
            "z_exit",
            "z_exit_luma"});
            this.cmbTextureName.Location = new System.Drawing.Point(850, 9);
            this.cmbTextureName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTextureName.Name = "cmbTextureName";
            this.cmbTextureName.Size = new System.Drawing.Size(206, 28);
            this.cmbTextureName.TabIndex = 2;
            // 
            // lblNumberOfRows
            // 
            this.lblNumberOfRows.AutoSize = true;
            this.lblNumberOfRows.Location = new System.Drawing.Point(208, 134);
            this.lblNumberOfRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfRows.Name = "lblNumberOfRows";
            this.lblNumberOfRows.Size = new System.Drawing.Size(124, 20);
            this.lblNumberOfRows.TabIndex = 11;
            this.lblNumberOfRows.Text = "Number of rows:";
            // 
            // nudNumRows
            // 
            this.nudNumRows.Location = new System.Drawing.Point(348, 131);
            this.nudNumRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNumRows.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudNumRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumRows.Name = "nudNumRows";
            this.nudNumRows.Size = new System.Drawing.Size(96, 26);
            this.nudNumRows.TabIndex = 9;
            this.nudNumRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumRows.ValueChanged += new System.EventHandler(this.nudNumRows_ValueChanged);
            this.nudNumRows.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumRows_KeyUp);
            // 
            // lblNumberOfColumns
            // 
            this.lblNumberOfColumns.AutoSize = true;
            this.lblNumberOfColumns.Location = new System.Drawing.Point(453, 134);
            this.lblNumberOfColumns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfColumns.Name = "lblNumberOfColumns";
            this.lblNumberOfColumns.Size = new System.Drawing.Size(150, 20);
            this.lblNumberOfColumns.TabIndex = 13;
            this.lblNumberOfColumns.Text = "Number of columns:";
            // 
            // nudNumColumns
            // 
            this.nudNumColumns.Location = new System.Drawing.Point(614, 131);
            this.nudNumColumns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNumColumns.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudNumColumns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumColumns.Name = "nudNumColumns";
            this.nudNumColumns.Size = new System.Drawing.Size(96, 26);
            this.nudNumColumns.TabIndex = 10;
            this.nudNumColumns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumColumns.ValueChanged += new System.EventHandler(this.nudNumColumns_ValueChanged);
            this.nudNumColumns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumColumns_KeyUp);
            // 
            // txtSumBlocks
            // 
            this.txtSumBlocks.Location = new System.Drawing.Point(850, 131);
            this.txtSumBlocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSumBlocks.Name = "txtSumBlocks";
            this.txtSumBlocks.ReadOnly = true;
            this.txtSumBlocks.Size = new System.Drawing.Size(94, 26);
            this.txtSumBlocks.TabIndex = 15;
            this.txtSumBlocks.Text = "1";
            // 
            // lblSumBlocks
            // 
            this.lblSumBlocks.AutoSize = true;
            this.lblSumBlocks.Location = new System.Drawing.Point(718, 134);
            this.lblSumBlocks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumBlocks.Name = "lblSumBlocks";
            this.lblSumBlocks.Size = new System.Drawing.Size(113, 20);
            this.lblSumBlocks.TabIndex = 16;
            this.lblSumBlocks.Text = "Sum of blocks:";
            // 
            // txtOutput
            // 
            this.tlpTextBoxes.SetColumnSpan(this.txtOutput, 2);
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(4, 5);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1057, 218);
            this.txtOutput.TabIndex = 17;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(723, 245);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(96, 35);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblBlockSpacing
            // 
            this.lblBlockSpacing.AutoSize = true;
            this.lblBlockSpacing.Location = new System.Drawing.Point(453, 14);
            this.lblBlockSpacing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBlockSpacing.Name = "lblBlockSpacing";
            this.lblBlockSpacing.Size = new System.Drawing.Size(67, 20);
            this.lblBlockSpacing.TabIndex = 20;
            this.lblBlockSpacing.Text = "Spacing";
            // 
            // nudSpacing
            // 
            this.nudSpacing.Location = new System.Drawing.Point(614, 11);
            this.nudSpacing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSpacing.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudSpacing.Name = "nudSpacing";
            this.nudSpacing.Size = new System.Drawing.Size(96, 26);
            this.nudSpacing.TabIndex = 1;
            this.nudSpacing.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(208, 94);
            this.lblDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(74, 20);
            this.lblDamage.TabIndex = 22;
            this.lblDamage.Text = "Damage:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(453, 94);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(60, 20);
            this.lblSpeed.TabIndex = 23;
            this.lblSpeed.Text = "Speed:";
            // 
            // nudDamage
            // 
            this.nudDamage.Location = new System.Drawing.Point(348, 91);
            this.nudDamage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDamage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(96, 26);
            this.nudDamage.TabIndex = 6;
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(614, 91);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudSpeed.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(96, 26);
            this.nudSpeed.TabIndex = 7;
            this.nudSpeed.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Location = new System.Drawing.Point(718, 94);
            this.lblSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(100, 20);
            this.lblSound.TabIndex = 26;
            this.lblSound.Text = "Make sound:";
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(850, 94);
            this.chkSound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(22, 21);
            this.chkSound.TabIndex = 8;
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(18, 15);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(182, 186);
            this.picLogo.TabIndex = 28;
            this.picLogo.TabStop = false;
            // 
            // lblWaveHeightPerStep
            // 
            this.lblWaveHeightPerStep.AutoSize = true;
            this.lblWaveHeightPerStep.Location = new System.Drawing.Point(208, 174);
            this.lblWaveHeightPerStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWaveHeightPerStep.Name = "lblWaveHeightPerStep";
            this.lblWaveHeightPerStep.Size = new System.Drawing.Size(118, 20);
            this.lblWaveHeightPerStep.TabIndex = 30;
            this.lblWaveHeightPerStep.Text = "Height per step";
            // 
            // nudWaveHeightPerStep
            // 
            this.nudWaveHeightPerStep.Location = new System.Drawing.Point(348, 171);
            this.nudWaveHeightPerStep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudWaveHeightPerStep.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudWaveHeightPerStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWaveHeightPerStep.Name = "nudWaveHeightPerStep";
            this.nudWaveHeightPerStep.Size = new System.Drawing.Size(96, 26);
            this.nudWaveHeightPerStep.TabIndex = 11;
            this.nudWaveHeightPerStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWaveHeightPerStep.ValueChanged += new System.EventHandler(this.nudWaveHeightPerStep_ValueChanged);
            this.nudWaveHeightPerStep.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudWaveHeightPerStep_KeyUp);
            // 
            // lblNumSteps
            // 
            this.lblNumSteps.AutoSize = true;
            this.lblNumSteps.Location = new System.Drawing.Point(453, 174);
            this.lblNumSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumSteps.Name = "lblNumSteps";
            this.lblNumSteps.Size = new System.Drawing.Size(130, 20);
            this.lblNumSteps.TabIndex = 32;
            this.lblNumSteps.Text = "Number of steps:";
            // 
            // nudNumSteps
            // 
            this.nudNumSteps.Location = new System.Drawing.Point(614, 171);
            this.nudNumSteps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNumSteps.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nudNumSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumSteps.Name = "nudNumSteps";
            this.nudNumSteps.Size = new System.Drawing.Size(96, 26);
            this.nudNumSteps.TabIndex = 12;
            this.nudNumSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumSteps.ValueChanged += new System.EventHandler(this.nudNumSteps_ValueChanged);
            this.nudNumSteps.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudNumSteps_KeyUp);
            // 
            // lblTotalWaveAmplitude
            // 
            this.lblTotalWaveAmplitude.AutoSize = true;
            this.lblTotalWaveAmplitude.Location = new System.Drawing.Point(718, 174);
            this.lblTotalWaveAmplitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalWaveAmplitude.Name = "lblTotalWaveAmplitude";
            this.lblTotalWaveAmplitude.Size = new System.Drawing.Size(121, 20);
            this.lblTotalWaveAmplitude.TabIndex = 35;
            this.lblTotalWaveAmplitude.Text = "Total amplitude:";
            // 
            // txtTotalAmplitude
            // 
            this.txtTotalAmplitude.Location = new System.Drawing.Point(850, 169);
            this.txtTotalAmplitude.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalAmplitude.Name = "txtTotalAmplitude";
            this.txtTotalAmplitude.ReadOnly = true;
            this.txtTotalAmplitude.Size = new System.Drawing.Size(94, 26);
            this.txtTotalAmplitude.TabIndex = 34;
            this.txtTotalAmplitude.Text = "1";
            // 
            // tlpTextBoxes
            // 
            this.tlpTextBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpTextBoxes.ColumnCount = 2;
            this.tlpTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextBoxes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpTextBoxes.Controls.Add(this.txtMessages, 0, 2);
            this.tlpTextBoxes.Controls.Add(this.txtOutput, 0, 0);
            this.tlpTextBoxes.Controls.Add(this.btnClearGeneratedText, 1, 1);
            this.tlpTextBoxes.Controls.Add(this.btnCopyGeneratedCode, 0, 1);
            this.tlpTextBoxes.Location = new System.Drawing.Point(18, 289);
            this.tlpTextBoxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpTextBoxes.Name = "tlpTextBoxes";
            this.tlpTextBoxes.RowCount = 3;
            this.tlpTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpTextBoxes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tlpTextBoxes.Size = new System.Drawing.Size(1065, 402);
            this.tlpTextBoxes.TabIndex = 37;
            // 
            // txtMessages
            // 
            this.tlpTextBoxes.SetColumnSpan(this.txtMessages, 2);
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessages.Location = new System.Drawing.Point(4, 284);
            this.txtMessages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(1057, 113);
            this.txtMessages.TabIndex = 37;
            // 
            // btnClearGeneratedText
            // 
            this.btnClearGeneratedText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearGeneratedText.Location = new System.Drawing.Point(920, 239);
            this.btnClearGeneratedText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearGeneratedText.Name = "btnClearGeneratedText";
            this.btnClearGeneratedText.Size = new System.Drawing.Size(141, 35);
            this.btnClearGeneratedText.TabIndex = 39;
            this.btnClearGeneratedText.Text = "Clear";
            this.btnClearGeneratedText.UseVisualStyleBackColor = true;
            this.btnClearGeneratedText.Click += new System.EventHandler(this.btnClearGeneratedText_Click);
            // 
            // btnCopyGeneratedCode
            // 
            this.btnCopyGeneratedCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyGeneratedCode.Location = new System.Drawing.Point(761, 239);
            this.btnCopyGeneratedCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCopyGeneratedCode.Name = "btnCopyGeneratedCode";
            this.btnCopyGeneratedCode.Size = new System.Drawing.Size(150, 35);
            this.btnCopyGeneratedCode.TabIndex = 38;
            this.btnCopyGeneratedCode.Text = "Copy to Clipboard";
            this.btnCopyGeneratedCode.UseVisualStyleBackColor = true;
            this.btnCopyGeneratedCode.Click += new System.EventHandler(this.btnCopyGeneratedCode_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(963, 245);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 35);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStepHeights
            // 
            this.lblStepHeights.AutoSize = true;
            this.lblStepHeights.Location = new System.Drawing.Point(208, 215);
            this.lblStepHeights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepHeights.Name = "lblStepHeights";
            this.lblStepHeights.Size = new System.Drawing.Size(121, 20);
            this.lblStepHeights.TabIndex = 39;
            this.lblStepHeights.Text = "Step sequence:";
            // 
            // txtStepHeights
            // 
            this.txtStepHeights.Location = new System.Drawing.Point(348, 211);
            this.txtStepHeights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStepHeights.Name = "txtStepHeights";
            this.txtStepHeights.ReadOnly = true;
            this.txtStepHeights.Size = new System.Drawing.Size(360, 26);
            this.txtStepHeights.TabIndex = 40;
            this.txtStepHeights.Text = "1";
            // 
            // lblDiagonalWave
            // 
            this.lblDiagonalWave.AutoSize = true;
            this.lblDiagonalWave.Location = new System.Drawing.Point(718, 215);
            this.lblDiagonalWave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiagonalWave.Name = "lblDiagonalWave";
            this.lblDiagonalWave.Size = new System.Drawing.Size(116, 20);
            this.lblDiagonalWave.TabIndex = 41;
            this.lblDiagonalWave.Text = "Diagonal wave:";
            // 
            // chkDiagonalWave
            // 
            this.chkDiagonalWave.AutoSize = true;
            this.chkDiagonalWave.Location = new System.Drawing.Point(850, 214);
            this.chkDiagonalWave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDiagonalWave.Name = "chkDiagonalWave";
            this.chkDiagonalWave.Size = new System.Drawing.Size(22, 21);
            this.chkDiagonalWave.TabIndex = 42;
            this.chkDiagonalWave.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(850, 245);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(96, 35);
            this.btnPreview.TabIndex = 43;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmQuakeWaveGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 709);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.chkDiagonalWave);
            this.Controls.Add(this.lblDiagonalWave);
            this.Controls.Add(this.txtStepHeights);
            this.Controls.Add(this.lblStepHeights);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tlpTextBoxes);
            this.Controls.Add(this.lblTotalWaveAmplitude);
            this.Controls.Add(this.txtTotalAmplitude);
            this.Controls.Add(this.nudNumSteps);
            this.Controls.Add(this.lblNumSteps);
            this.Controls.Add(this.nudWaveHeightPerStep);
            this.Controls.Add(this.lblWaveHeightPerStep);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.chkSound);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.nudDamage);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.nudSpacing);
            this.Controls.Add(this.lblBlockSpacing);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblSumBlocks);
            this.Controls.Add(this.txtSumBlocks);
            this.Controls.Add(this.nudNumColumns);
            this.Controls.Add(this.lblNumberOfColumns);
            this.Controls.Add(this.nudNumRows);
            this.Controls.Add(this.lblNumberOfRows);
            this.Controls.Add(this.cmbTextureName);
            this.Controls.Add(this.nudOffsetToTop);
            this.Controls.Add(this.lblOffsetToTop);
            this.Controls.Add(this.nudOffsetToFront);
            this.Controls.Add(this.lblOffsetToFront);
            this.Controls.Add(this.nudOffsetToRight);
            this.Controls.Add(this.lblOffsetToRight);
            this.Controls.Add(this.lblTextureName);
            this.Controls.Add(this.lblSizeInUnits);
            this.Controls.Add(this.nudSizeInUnits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1114, 739);
            this.Name = "frmQuakeWaveGenerator";
            this.Text = "Quake Wave Generator";
            this.Load += new System.EventHandler(this.frmQuakeWaveGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSizeInUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOffsetToTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWaveHeightPerStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumSteps)).EndInit();
            this.tlpTextBoxes.ResumeLayout(false);
            this.tlpTextBoxes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSizeInUnits;
        private System.Windows.Forms.Label lblSizeInUnits;
        private System.Windows.Forms.Label lblTextureName;
        private System.Windows.Forms.Label lblOffsetToRight;
        private System.Windows.Forms.NumericUpDown nudOffsetToRight;
        private System.Windows.Forms.Label lblOffsetToFront;
        private System.Windows.Forms.NumericUpDown nudOffsetToFront;
        private System.Windows.Forms.Label lblOffsetToTop;
        private System.Windows.Forms.NumericUpDown nudOffsetToTop;
        private System.Windows.Forms.ComboBox cmbTextureName;
        private System.Windows.Forms.Label lblNumberOfRows;
        private System.Windows.Forms.NumericUpDown nudNumRows;
        private System.Windows.Forms.Label lblNumberOfColumns;
        private System.Windows.Forms.NumericUpDown nudNumColumns;
        private System.Windows.Forms.TextBox txtSumBlocks;
        private System.Windows.Forms.Label lblSumBlocks;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblBlockSpacing;
        private System.Windows.Forms.NumericUpDown nudSpacing;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.NumericUpDown nudDamage;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWaveHeightPerStep;
        private System.Windows.Forms.NumericUpDown nudWaveHeightPerStep;
        private System.Windows.Forms.Label lblNumSteps;
        private System.Windows.Forms.NumericUpDown nudNumSteps;
        private System.Windows.Forms.Label lblTotalWaveAmplitude;
        private System.Windows.Forms.TextBox txtTotalAmplitude;
        private System.Windows.Forms.TableLayoutPanel tlpTextBoxes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnCopyGeneratedCode;
        private System.Windows.Forms.Button btnClearGeneratedText;
        private System.Windows.Forms.Label lblStepHeights;
        private System.Windows.Forms.TextBox txtStepHeights;
        private System.Windows.Forms.Label lblDiagonalWave;
        private System.Windows.Forms.CheckBox chkDiagonalWave;
        private System.Windows.Forms.Button btnPreview;
    }
}

#pragma warning restore CS1591
