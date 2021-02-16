namespace GUI {
    partial class Blackjack_Form {
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
            this.btnHitPlayerHand1 = new System.Windows.Forms.Button();
            this.btnDoublePlayerHand1 = new System.Windows.Forms.Button();
            this.btnStandPlayerHand1 = new System.Windows.Forms.Button();
            this.btnSurrenderPlayerHand1 = new System.Windows.Forms.Button();
            this.btnSplitPlayerHand1 = new System.Windows.Forms.Button();
            this.btnHitPlayerHand2 = new System.Windows.Forms.Button();
            this.btnDoublePlayerHand2 = new System.Windows.Forms.Button();
            this.btnStandPlayerHand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.picDeck = new System.Windows.Forms.PictureBox();
            this.tblDealerHand = new System.Windows.Forms.TableLayoutPanel();
            this.tblPlayerHand1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPlayerHand2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDealerHand = new System.Windows.Forms.Label();
            this.lblPlayerHand = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblPlayerInfo1 = new System.Windows.Forms.Label();
            this.lblDealerInfo = new System.Windows.Forms.Label();
            this.lblPlayerInfo2 = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHitPlayerHand1
            // 
            this.btnHitPlayerHand1.BackColor = System.Drawing.Color.Yellow;
            this.btnHitPlayerHand1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHitPlayerHand1.FlatAppearance.BorderSize = 5;
            this.btnHitPlayerHand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitPlayerHand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitPlayerHand1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHitPlayerHand1.Location = new System.Drawing.Point(43, 743);
            this.btnHitPlayerHand1.Name = "btnHitPlayerHand1";
            this.btnHitPlayerHand1.Size = new System.Drawing.Size(113, 72);
            this.btnHitPlayerHand1.TabIndex = 0;
            this.btnHitPlayerHand1.Text = "Hit";
            this.btnHitPlayerHand1.UseVisualStyleBackColor = false;
            this.btnHitPlayerHand1.Click += new System.EventHandler(this.btnHitPlayerHand1_Click);
            // 
            // btnDoublePlayerHand1
            // 
            this.btnDoublePlayerHand1.BackColor = System.Drawing.Color.Yellow;
            this.btnDoublePlayerHand1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDoublePlayerHand1.FlatAppearance.BorderSize = 5;
            this.btnDoublePlayerHand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoublePlayerHand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoublePlayerHand1.Location = new System.Drawing.Point(179, 743);
            this.btnDoublePlayerHand1.Name = "btnDoublePlayerHand1";
            this.btnDoublePlayerHand1.Size = new System.Drawing.Size(113, 72);
            this.btnDoublePlayerHand1.TabIndex = 1;
            this.btnDoublePlayerHand1.Text = "Double";
            this.btnDoublePlayerHand1.UseVisualStyleBackColor = false;
            this.btnDoublePlayerHand1.Click += new System.EventHandler(this.btnDoublePlayerHand1_Click);
            // 
            // btnStandPlayerHand1
            // 
            this.btnStandPlayerHand1.BackColor = System.Drawing.Color.Yellow;
            this.btnStandPlayerHand1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStandPlayerHand1.FlatAppearance.BorderSize = 5;
            this.btnStandPlayerHand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandPlayerHand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandPlayerHand1.Location = new System.Drawing.Point(311, 743);
            this.btnStandPlayerHand1.Name = "btnStandPlayerHand1";
            this.btnStandPlayerHand1.Size = new System.Drawing.Size(113, 72);
            this.btnStandPlayerHand1.TabIndex = 2;
            this.btnStandPlayerHand1.Text = "Stand";
            this.btnStandPlayerHand1.UseVisualStyleBackColor = false;
            this.btnStandPlayerHand1.Click += new System.EventHandler(this.btnStandPlayerHand1_Click);
            // 
            // btnSurrenderPlayerHand1
            // 
            this.btnSurrenderPlayerHand1.BackColor = System.Drawing.Color.Yellow;
            this.btnSurrenderPlayerHand1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSurrenderPlayerHand1.FlatAppearance.BorderSize = 5;
            this.btnSurrenderPlayerHand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurrenderPlayerHand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurrenderPlayerHand1.Location = new System.Drawing.Point(445, 743);
            this.btnSurrenderPlayerHand1.Name = "btnSurrenderPlayerHand1";
            this.btnSurrenderPlayerHand1.Size = new System.Drawing.Size(143, 72);
            this.btnSurrenderPlayerHand1.TabIndex = 3;
            this.btnSurrenderPlayerHand1.Text = "Surrender";
            this.btnSurrenderPlayerHand1.UseVisualStyleBackColor = false;
            this.btnSurrenderPlayerHand1.Click += new System.EventHandler(this.btnSurrenderPlayerHand1_Click);
            // 
            // btnSplitPlayerHand1
            // 
            this.btnSplitPlayerHand1.BackColor = System.Drawing.Color.Yellow;
            this.btnSplitPlayerHand1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSplitPlayerHand1.FlatAppearance.BorderSize = 5;
            this.btnSplitPlayerHand1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSplitPlayerHand1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitPlayerHand1.Location = new System.Drawing.Point(606, 743);
            this.btnSplitPlayerHand1.Name = "btnSplitPlayerHand1";
            this.btnSplitPlayerHand1.Size = new System.Drawing.Size(116, 72);
            this.btnSplitPlayerHand1.TabIndex = 4;
            this.btnSplitPlayerHand1.Text = "Split";
            this.btnSplitPlayerHand1.UseVisualStyleBackColor = false;
            this.btnSplitPlayerHand1.Click += new System.EventHandler(this.btnSplitPlayerHand1_Click);
            // 
            // btnHitPlayerHand2
            // 
            this.btnHitPlayerHand2.BackColor = System.Drawing.Color.Yellow;
            this.btnHitPlayerHand2.Enabled = false;
            this.btnHitPlayerHand2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHitPlayerHand2.FlatAppearance.BorderSize = 5;
            this.btnHitPlayerHand2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitPlayerHand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitPlayerHand2.Location = new System.Drawing.Point(1016, 743);
            this.btnHitPlayerHand2.Name = "btnHitPlayerHand2";
            this.btnHitPlayerHand2.Size = new System.Drawing.Size(113, 72);
            this.btnHitPlayerHand2.TabIndex = 5;
            this.btnHitPlayerHand2.Text = "Hit ";
            this.btnHitPlayerHand2.UseVisualStyleBackColor = false;
            this.btnHitPlayerHand2.Click += new System.EventHandler(this.btnHitPlayerHand2_Click);
            // 
            // btnDoublePlayerHand2
            // 
            this.btnDoublePlayerHand2.BackColor = System.Drawing.Color.Yellow;
            this.btnDoublePlayerHand2.Enabled = false;
            this.btnDoublePlayerHand2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDoublePlayerHand2.FlatAppearance.BorderSize = 5;
            this.btnDoublePlayerHand2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoublePlayerHand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoublePlayerHand2.Location = new System.Drawing.Point(1152, 743);
            this.btnDoublePlayerHand2.Name = "btnDoublePlayerHand2";
            this.btnDoublePlayerHand2.Size = new System.Drawing.Size(113, 72);
            this.btnDoublePlayerHand2.TabIndex = 6;
            this.btnDoublePlayerHand2.Text = "Double";
            this.btnDoublePlayerHand2.UseVisualStyleBackColor = false;
            this.btnDoublePlayerHand2.Click += new System.EventHandler(this.btnDoublePlayerHand2_Click);
            // 
            // btnStandPlayerHand2
            // 
            this.btnStandPlayerHand2.BackColor = System.Drawing.Color.Yellow;
            this.btnStandPlayerHand2.Enabled = false;
            this.btnStandPlayerHand2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStandPlayerHand2.FlatAppearance.BorderSize = 5;
            this.btnStandPlayerHand2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStandPlayerHand2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStandPlayerHand2.Location = new System.Drawing.Point(1291, 743);
            this.btnStandPlayerHand2.Name = "btnStandPlayerHand2";
            this.btnStandPlayerHand2.Size = new System.Drawing.Size(113, 72);
            this.btnStandPlayerHand2.TabIndex = 7;
            this.btnStandPlayerHand2.Text = "Stand";
            this.btnStandPlayerHand2.UseVisualStyleBackColor = false;
            this.btnStandPlayerHand2.Click += new System.EventHandler(this.btnStandPlayerHand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReset.FlatAppearance.BorderSize = 4;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1696, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 47);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.Yellow;
            this.btnDeal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeal.FlatAppearance.BorderSize = 3;
            this.btnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(1039, 364);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(165, 47);
            this.btnDeal.TabIndex = 9;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // picDeck
            // 
            this.picDeck.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.picDeck.Location = new System.Drawing.Point(937, 316);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(72, 95);
            this.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeck.TabIndex = 10;
            this.picDeck.TabStop = false;
            // 
            // tblDealerHand
            // 
            this.tblDealerHand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDealerHand.ColumnCount = 10;
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblDealerHand.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblDealerHand.Location = new System.Drawing.Point(43, 27);
            this.tblDealerHand.Name = "tblDealerHand";
            this.tblDealerHand.RowCount = 1;
            this.tblDealerHand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDealerHand.Size = new System.Drawing.Size(800, 168);
            this.tblDealerHand.TabIndex = 11;
            // 
            // tblPlayerHand1
            // 
            this.tblPlayerHand1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPlayerHand1.ColumnCount = 11;
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPlayerHand1.Location = new System.Drawing.Point(42, 552);
            this.tblPlayerHand1.Name = "tblPlayerHand1";
            this.tblPlayerHand1.RowCount = 1;
            this.tblPlayerHand1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayerHand1.Size = new System.Drawing.Size(800, 168);
            this.tblPlayerHand1.TabIndex = 12;
            // 
            // tblPlayerHand2
            // 
            this.tblPlayerHand2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblPlayerHand2.ColumnCount = 11;
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tblPlayerHand2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblPlayerHand2.Location = new System.Drawing.Point(1016, 552);
            this.tblPlayerHand2.Name = "tblPlayerHand2";
            this.tblPlayerHand2.RowCount = 1;
            this.tblPlayerHand2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlayerHand2.Size = new System.Drawing.Size(800, 168);
            this.tblPlayerHand2.TabIndex = 13;
            // 
            // lblDealerHand
            // 
            this.lblDealerHand.AutoSize = true;
            this.lblDealerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerHand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDealerHand.Location = new System.Drawing.Point(38, 224);
            this.lblDealerHand.Name = "lblDealerHand";
            this.lblDealerHand.Size = new System.Drawing.Size(91, 29);
            this.lblDealerHand.TabIndex = 15;
            this.lblDealerHand.Text = "Dealer";
            // 
            // lblPlayerHand
            // 
            this.lblPlayerHand.AutoSize = true;
            this.lblPlayerHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHand.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerHand.Location = new System.Drawing.Point(38, 494);
            this.lblPlayerHand.Name = "lblPlayerHand";
            this.lblPlayerHand.Size = new System.Drawing.Size(87, 29);
            this.lblPlayerHand.TabIndex = 16;
            this.lblPlayerHand.Text = "Player";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBet.Location = new System.Drawing.Point(1034, 335);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(48, 26);
            this.lblBet.TabIndex = 19;
            this.lblBet.Text = "Bet";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInstructions.Location = new System.Drawing.Point(1210, 332);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(135, 26);
            this.lblInstructions.TabIndex = 20;
            this.lblInstructions.Text = "Instructions";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Yellow;
            this.lblMoney.Location = new System.Drawing.Point(1088, 303);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(91, 26);
            this.lblMoney.TabIndex = 21;
            this.lblMoney.Text = "$ 1,000";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Yellow;
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(1084, 332);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblPlayerInfo1
            // 
            this.lblPlayerInfo1.AutoSize = true;
            this.lblPlayerInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInfo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerInfo1.Location = new System.Drawing.Point(40, 523);
            this.lblPlayerInfo1.Name = "lblPlayerInfo1";
            this.lblPlayerInfo1.Size = new System.Drawing.Size(56, 29);
            this.lblPlayerInfo1.TabIndex = 34;
            this.lblPlayerInfo1.Text = "Info";
            // 
            // lblDealerInfo
            // 
            this.lblDealerInfo.AutoSize = true;
            this.lblDealerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDealerInfo.Location = new System.Drawing.Point(40, 195);
            this.lblDealerInfo.Name = "lblDealerInfo";
            this.lblDealerInfo.Size = new System.Drawing.Size(56, 29);
            this.lblDealerInfo.TabIndex = 35;
            this.lblDealerInfo.Text = "Info";
            // 
            // lblPlayerInfo2
            // 
            this.lblPlayerInfo2.AutoSize = true;
            this.lblPlayerInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerInfo2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayerInfo2.Location = new System.Drawing.Point(1011, 520);
            this.lblPlayerInfo2.Name = "lblPlayerInfo2";
            this.lblPlayerInfo2.Size = new System.Drawing.Size(56, 29);
            this.lblPlayerInfo2.TabIndex = 36;
            this.lblPlayerInfo2.Text = "Info";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInstructions2.Location = new System.Drawing.Point(1214, 364);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(0, 26);
            this.lblInstructions2.TabIndex = 37;
            // 
            // Blackjack_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1872, 837);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.lblPlayerInfo2);
            this.Controls.Add(this.lblDealerInfo);
            this.Controls.Add(this.lblPlayerInfo1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.lblPlayerHand);
            this.Controls.Add(this.lblDealerHand);
            this.Controls.Add(this.tblPlayerHand2);
            this.Controls.Add(this.tblPlayerHand1);
            this.Controls.Add(this.tblDealerHand);
            this.Controls.Add(this.picDeck);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStandPlayerHand2);
            this.Controls.Add(this.btnDoublePlayerHand2);
            this.Controls.Add(this.btnHitPlayerHand2);
            this.Controls.Add(this.btnSplitPlayerHand1);
            this.Controls.Add(this.btnSurrenderPlayerHand1);
            this.Controls.Add(this.btnStandPlayerHand1);
            this.Controls.Add(this.btnDoublePlayerHand1);
            this.Controls.Add(this.btnHitPlayerHand1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(2089, 893);
            this.MinimumSize = new System.Drawing.Size(1714, 893);
            this.Name = "Blackjack_Form";
            this.Text = "Blackjack";
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitPlayerHand1;
        private System.Windows.Forms.Button btnDoublePlayerHand1;
        private System.Windows.Forms.Button btnStandPlayerHand1;
        private System.Windows.Forms.Button btnSurrenderPlayerHand1;
        private System.Windows.Forms.Button btnSplitPlayerHand1;
        private System.Windows.Forms.Button btnHitPlayerHand2;
        private System.Windows.Forms.Button btnDoublePlayerHand2;
        private System.Windows.Forms.Button btnStandPlayerHand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.PictureBox picDeck;
        private System.Windows.Forms.TableLayoutPanel tblDealerHand;
        private System.Windows.Forms.TableLayoutPanel tblPlayerHand1;
        private System.Windows.Forms.TableLayoutPanel tblPlayerHand2;
        private System.Windows.Forms.Label lblDealerHand;
        private System.Windows.Forms.Label lblPlayerHand;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblPlayerInfo1;
        private System.Windows.Forms.Label lblDealerInfo;
        private System.Windows.Forms.Label lblPlayerInfo2;
        private System.Windows.Forms.Label lblInstructions2;
    }
}