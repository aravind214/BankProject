
namespace BankManagement
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtCheckBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAmountWD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcNumWD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAmountDep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAcNumDep = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAmountTrnst = new System.Windows.Forms.TextBox();
            this.txtToTrnst = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFromTrnst = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTnsfrBlnce = new System.Windows.Forms.Label();
            this.ToSearch = new System.Windows.Forms.PictureBox();
            this.FromSearch = new System.Windows.Forms.PictureBox();
            this.btnTransfer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeposit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnWithdraw = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnReset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCheck = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BackPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(700, 31);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(190, 33);
            this.lblBalance.TabIndex = 40;
            this.lblBalance.Text = "Your Balance";
            // 
            // txtCheckBalance
            // 
            this.txtCheckBalance.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckBalance.Location = new System.Drawing.Point(111, 57);
            this.txtCheckBalance.Name = "txtCheckBalance";
            this.txtCheckBalance.Size = new System.Drawing.Size(276, 36);
            this.txtCheckBalance.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "Check Your Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 45);
            this.label1.TabIndex = 36;
            this.label1.Text = "Transactions";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 732);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtCheckBalance);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Location = new System.Drawing.Point(228, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 130);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Ivory;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtAmountWD);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtAcNumWD);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btnWithdraw);
            this.panel3.Location = new System.Drawing.Point(125, 239);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 176);
            this.panel3.TabIndex = 56;
            // 
            // txtAmountWD
            // 
            this.txtAmountWD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountWD.Location = new System.Drawing.Point(246, 120);
            this.txtAmountWD.Name = "txtAmountWD";
            this.txtAmountWD.Size = new System.Drawing.Size(193, 36);
            this.txtAmountWD.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 33);
            this.label11.TabIndex = 54;
            this.label11.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 38;
            this.label2.Text = "Withdraw";
            // 
            // txtAcNumWD
            // 
            this.txtAcNumWD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcNumWD.Location = new System.Drawing.Point(246, 63);
            this.txtAcNumWD.Name = "txtAcNumWD";
            this.txtAcNumWD.Size = new System.Drawing.Size(193, 36);
            this.txtAcNumWD.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(236, 33);
            this.label10.TabIndex = 40;
            this.label10.Text = "Account Number";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Ivory;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtAmountDep);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtAcNumDep);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnDeposit);
            this.panel4.Location = new System.Drawing.Point(754, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 176);
            this.panel4.TabIndex = 57;
            // 
            // txtAmountDep
            // 
            this.txtAmountDep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDep.Location = new System.Drawing.Point(254, 120);
            this.txtAmountDep.Name = "txtAmountDep";
            this.txtAmountDep.Size = new System.Drawing.Size(193, 36);
            this.txtAmountDep.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 33);
            this.label12.TabIndex = 54;
            this.label12.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Goldenrod;
            this.label13.Location = new System.Drawing.Point(5, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 33);
            this.label13.TabIndex = 38;
            this.label13.Text = "Deposit";
            // 
            // txtAcNumDep
            // 
            this.txtAcNumDep.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcNumDep.Location = new System.Drawing.Point(254, 63);
            this.txtAcNumDep.Name = "txtAcNumDep";
            this.txtAcNumDep.Size = new System.Drawing.Size(193, 36);
            this.txtAcNumDep.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 33);
            this.label14.TabIndex = 40;
            this.label14.Text = "Account Number";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Ivory;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblTnsfrBlnce);
            this.panel5.Controls.Add(this.ToSearch);
            this.panel5.Controls.Add(this.FromSearch);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtAmountTrnst);
            this.panel5.Controls.Add(this.txtToTrnst);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtFromTrnst);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnTransfer);
            this.panel5.Location = new System.Drawing.Point(125, 463);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1232, 176);
            this.panel5.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(622, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 33);
            this.label9.TabIndex = 55;
            this.label9.Text = "Amount";
            // 
            // txtAmountTrnst
            // 
            this.txtAmountTrnst.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountTrnst.Location = new System.Drawing.Point(787, 80);
            this.txtAmountTrnst.Name = "txtAmountTrnst";
            this.txtAmountTrnst.Size = new System.Drawing.Size(193, 36);
            this.txtAmountTrnst.TabIndex = 55;
            // 
            // txtToTrnst
            // 
            this.txtToTrnst.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToTrnst.Location = new System.Drawing.Point(246, 120);
            this.txtToTrnst.Name = "txtToTrnst";
            this.txtToTrnst.Size = new System.Drawing.Size(193, 36);
            this.txtToTrnst.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 33);
            this.label5.TabIndex = 54;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 33);
            this.label6.TabIndex = 38;
            this.label6.Text = "Transaction";
            // 
            // txtFromTrnst
            // 
            this.txtFromTrnst.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromTrnst.Location = new System.Drawing.Point(246, 63);
            this.txtFromTrnst.Name = "txtFromTrnst";
            this.txtFromTrnst.Size = new System.Drawing.Size(193, 36);
            this.txtFromTrnst.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 33);
            this.label7.TabIndex = 40;
            this.label7.Text = "From";
            // 
            // lblTnsfrBlnce
            // 
            this.lblTnsfrBlnce.AutoSize = true;
            this.lblTnsfrBlnce.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTnsfrBlnce.Location = new System.Drawing.Point(514, 63);
            this.lblTnsfrBlnce.Name = "lblTnsfrBlnce";
            this.lblTnsfrBlnce.Size = new System.Drawing.Size(84, 29);
            this.lblTnsfrBlnce.TabIndex = 57;
            this.lblTnsfrBlnce.Text = "Amount";
            // 
            // ToSearch
            // 
            this.ToSearch.BackColor = System.Drawing.Color.MistyRose;
            this.ToSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToSearch.Image = ((System.Drawing.Image)(resources.GetObject("ToSearch.Image")));
            this.ToSearch.Location = new System.Drawing.Point(459, 120);
            this.ToSearch.Name = "ToSearch";
            this.ToSearch.Size = new System.Drawing.Size(36, 36);
            this.ToSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ToSearch.TabIndex = 56;
            this.ToSearch.TabStop = false;
            this.ToSearch.Click += new System.EventHandler(this.ToSearch_Click);
            // 
            // FromSearch
            // 
            this.FromSearch.BackColor = System.Drawing.Color.MistyRose;
            this.FromSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FromSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FromSearch.Image = ((System.Drawing.Image)(resources.GetObject("FromSearch.Image")));
            this.FromSearch.Location = new System.Drawing.Point(459, 63);
            this.FromSearch.Name = "FromSearch";
            this.FromSearch.Size = new System.Drawing.Size(36, 36);
            this.FromSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FromSearch.TabIndex = 15;
            this.FromSearch.TabStop = false;
            this.FromSearch.Click += new System.EventHandler(this.FromSearch_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.ActiveBorderThickness = 1;
            this.btnTransfer.ActiveCornerRadius = 30;
            this.btnTransfer.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnTransfer.ActiveForecolor = System.Drawing.Color.Black;
            this.btnTransfer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTransfer.BackColor = System.Drawing.Color.Ivory;
            this.btnTransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransfer.BackgroundImage")));
            this.btnTransfer.ButtonText = "Transfer";
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Crimson;
            this.btnTransfer.IdleBorderThickness = 1;
            this.btnTransfer.IdleCornerRadius = 30;
            this.btnTransfer.IdleFillColor = System.Drawing.Color.MistyRose;
            this.btnTransfer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnTransfer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnTransfer.Location = new System.Drawing.Point(1082, 80);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(138, 43);
            this.btnTransfer.TabIndex = 52;
            this.btnTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.ActiveBorderThickness = 1;
            this.btnDeposit.ActiveCornerRadius = 30;
            this.btnDeposit.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnDeposit.ActiveForecolor = System.Drawing.Color.Black;
            this.btnDeposit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.BackColor = System.Drawing.Color.Ivory;
            this.btnDeposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeposit.BackgroundImage")));
            this.btnDeposit.ButtonText = "Deposit";
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeposit.IdleBorderThickness = 1;
            this.btnDeposit.IdleCornerRadius = 30;
            this.btnDeposit.IdleFillColor = System.Drawing.Color.MistyRose;
            this.btnDeposit.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeposit.Location = new System.Drawing.Point(461, 82);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(133, 43);
            this.btnDeposit.TabIndex = 52;
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.ActiveBorderThickness = 1;
            this.btnWithdraw.ActiveCornerRadius = 30;
            this.btnWithdraw.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnWithdraw.ActiveForecolor = System.Drawing.Color.Black;
            this.btnWithdraw.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnWithdraw.BackColor = System.Drawing.Color.Ivory;
            this.btnWithdraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWithdraw.BackgroundImage")));
            this.btnWithdraw.ButtonText = "Withdraw";
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Crimson;
            this.btnWithdraw.IdleBorderThickness = 1;
            this.btnWithdraw.IdleCornerRadius = 30;
            this.btnWithdraw.IdleFillColor = System.Drawing.Color.MistyRose;
            this.btnWithdraw.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnWithdraw.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnWithdraw.Location = new System.Drawing.Point(449, 82);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(138, 43);
            this.btnWithdraw.TabIndex = 52;
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.ActiveBorderThickness = 1;
            this.btnReset.ActiveCornerRadius = 30;
            this.btnReset.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnReset.ActiveForecolor = System.Drawing.Color.Black;
            this.btnReset.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset.BackColor = System.Drawing.Color.Ivory;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.ButtonText = "Reset";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Crimson;
            this.btnReset.IdleBorderThickness = 1;
            this.btnReset.IdleCornerRadius = 30;
            this.btnReset.IdleFillColor = System.Drawing.Color.MistyRose;
            this.btnReset.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReset.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Location = new System.Drawing.Point(723, 70);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 41);
            this.btnReset.TabIndex = 53;
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.ActiveBorderThickness = 1;
            this.btnCheck.ActiveCornerRadius = 30;
            this.btnCheck.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnCheck.ActiveForecolor = System.Drawing.Color.Black;
            this.btnCheck.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCheck.BackColor = System.Drawing.Color.Ivory;
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.ButtonText = "Check";
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Crimson;
            this.btnCheck.IdleBorderThickness = 1;
            this.btnCheck.IdleCornerRadius = 30;
            this.btnCheck.IdleFillColor = System.Drawing.Color.MistyRose;
            this.btnCheck.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCheck.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCheck.Location = new System.Drawing.Point(470, 50);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(126, 43);
            this.btnCheck.TabIndex = 52;
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1307, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 73);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // BackPic
            // 
            this.BackPic.BackColor = System.Drawing.Color.Transparent;
            this.BackPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackPic.Image = ((System.Drawing.Image)(resources.GetObject("BackPic.Image")));
            this.BackPic.Location = new System.Drawing.Point(1307, 667);
            this.BackPic.Name = "BackPic";
            this.BackPic.Size = new System.Drawing.Size(49, 44);
            this.BackPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackPic.TabIndex = 59;
            this.BackPic.TabStop = false;
            this.BackPic.Click += new System.EventHandler(this.BackPic_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1376, 732);
            this.Controls.Add(this.BackPic);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCheck;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtCheckBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmountWD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcNumWD;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuThinButton2 btnWithdraw;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAmountDep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAcNumDep;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeposit;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtToTrnst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFromTrnst;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTransfer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAmountTrnst;
        private System.Windows.Forms.PictureBox ToSearch;
        private System.Windows.Forms.PictureBox FromSearch;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReset;
        private System.Windows.Forms.Label lblTnsfrBlnce;
        private System.Windows.Forms.PictureBox BackPic;
    }
}