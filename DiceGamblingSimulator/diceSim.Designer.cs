namespace DiceGamblingSimulator
{
    partial class diceSimForm
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
            this.amountLbl = new System.Windows.Forms.Label();
            this.diceTabControl = new System.Windows.Forms.TabControl();
            this.dicePage = new System.Windows.Forms.TabPage();
            this.rollBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chanceLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.payoutLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.smallSymbolLbl = new System.Windows.Forms.Label();
            this.underValueLbl = new System.Windows.Forms.Label();
            this.overValueLbl = new System.Windows.Forms.Label();
            this.biggerSymbolLbl = new System.Windows.Forms.Label();
            this.underWinLbl = new System.Windows.Forms.Label();
            this.overWinLbl = new System.Windows.Forms.Label();
            this.doubleAmountBtn = new System.Windows.Forms.Button();
            this.halfAmountBtn = new System.Windows.Forms.Button();
            this.amountTxtPanel = new System.Windows.Forms.Panel();
            this.amountTxt = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.automaticDicePage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.chanceValueLbl = new System.Windows.Forms.Label();
            this.chanceValueChangeTxt = new System.Windows.Forms.TextBox();
            this.diceTabControl.SuspendLayout();
            this.dicePage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.amountTxtPanel.SuspendLayout();
            this.automaticDicePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLbl.ForeColor = System.Drawing.Color.White;
            this.amountLbl.Location = new System.Drawing.Point(12, 35);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(76, 24);
            this.amountLbl.TabIndex = 0;
            this.amountLbl.Text = "Amount";
            // 
            // diceTabControl
            // 
            this.diceTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diceTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.diceTabControl.Controls.Add(this.dicePage);
            this.diceTabControl.Controls.Add(this.automaticDicePage);
            this.diceTabControl.Location = new System.Drawing.Point(0, 0);
            this.diceTabControl.Name = "diceTabControl";
            this.diceTabControl.Padding = new System.Drawing.Point(0, 0);
            this.diceTabControl.SelectedIndex = 0;
            this.diceTabControl.Size = new System.Drawing.Size(640, 280);
            this.diceTabControl.TabIndex = 1;
            // 
            // dicePage
            // 
            this.dicePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dicePage.Controls.Add(this.rollBtn);
            this.dicePage.Controls.Add(this.panel3);
            this.dicePage.Controls.Add(this.panel2);
            this.dicePage.Controls.Add(this.panel1);
            this.dicePage.Controls.Add(this.doubleAmountBtn);
            this.dicePage.Controls.Add(this.halfAmountBtn);
            this.dicePage.Controls.Add(this.amountTxtPanel);
            this.dicePage.Controls.Add(this.closeBtn);
            this.dicePage.Controls.Add(this.amountLbl);
            this.dicePage.Location = new System.Drawing.Point(4, 25);
            this.dicePage.Name = "dicePage";
            this.dicePage.Padding = new System.Windows.Forms.Padding(3);
            this.dicePage.Size = new System.Drawing.Size(632, 251);
            this.dicePage.TabIndex = 0;
            this.dicePage.Text = "Dice";
            // 
            // rollBtn
            // 
            this.rollBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.rollBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rollBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rollBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rollBtn.Location = new System.Drawing.Point(13, 203);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(612, 40);
            this.rollBtn.TabIndex = 8;
            this.rollBtn.Text = "Roll Dice";
            this.rollBtn.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.chanceValueChangeTxt);
            this.panel3.Controls.Add(this.chanceValueLbl);
            this.panel3.Controls.Add(this.chanceLbl);
            this.panel3.Location = new System.Drawing.Point(423, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // chanceLbl
            // 
            this.chanceLbl.AutoSize = true;
            this.chanceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceLbl.Location = new System.Drawing.Point(72, 13);
            this.chanceLbl.Name = "chanceLbl";
            this.chanceLbl.Size = new System.Drawing.Size(64, 20);
            this.chanceLbl.TabIndex = 1;
            this.chanceLbl.Text = "Chance";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.payoutLbl);
            this.panel2.Location = new System.Drawing.Point(219, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // payoutLbl
            // 
            this.payoutLbl.AutoSize = true;
            this.payoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payoutLbl.Location = new System.Drawing.Point(70, 13);
            this.payoutLbl.Name = "payoutLbl";
            this.payoutLbl.Size = new System.Drawing.Size(58, 20);
            this.payoutLbl.TabIndex = 0;
            this.payoutLbl.Text = "Payout";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.smallSymbolLbl);
            this.panel1.Controls.Add(this.underValueLbl);
            this.panel1.Controls.Add(this.overValueLbl);
            this.panel1.Controls.Add(this.biggerSymbolLbl);
            this.panel1.Controls.Add(this.underWinLbl);
            this.panel1.Controls.Add(this.overWinLbl);
            this.panel1.Location = new System.Drawing.Point(13, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // smallSymbolLbl
            // 
            this.smallSymbolLbl.AutoSize = true;
            this.smallSymbolLbl.BackColor = System.Drawing.Color.Transparent;
            this.smallSymbolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallSymbolLbl.Location = new System.Drawing.Point(31, 45);
            this.smallSymbolLbl.Name = "smallSymbolLbl";
            this.smallSymbolLbl.Size = new System.Drawing.Size(32, 36);
            this.smallSymbolLbl.TabIndex = 6;
            this.smallSymbolLbl.Text = ">";
            // 
            // underValueLbl
            // 
            this.underValueLbl.AutoSize = true;
            this.underValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underValueLbl.Location = new System.Drawing.Point(57, 45);
            this.underValueLbl.Name = "underValueLbl";
            this.underValueLbl.Size = new System.Drawing.Size(91, 36);
            this.underValueLbl.TabIndex = 5;
            this.underValueLbl.Text = "49.99";
            this.underValueLbl.Click += new System.EventHandler(this.underValueLbl_Click);
            // 
            // overValueLbl
            // 
            this.overValueLbl.AutoSize = true;
            this.overValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overValueLbl.Location = new System.Drawing.Point(56, 45);
            this.overValueLbl.Name = "overValueLbl";
            this.overValueLbl.Size = new System.Drawing.Size(91, 36);
            this.overValueLbl.TabIndex = 3;
            this.overValueLbl.Text = "50.00";
            this.overValueLbl.Click += new System.EventHandler(this.overValueLbl_Click);
            // 
            // biggerSymbolLbl
            // 
            this.biggerSymbolLbl.AutoSize = true;
            this.biggerSymbolLbl.BackColor = System.Drawing.Color.Transparent;
            this.biggerSymbolLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biggerSymbolLbl.Location = new System.Drawing.Point(34, 45);
            this.biggerSymbolLbl.Name = "biggerSymbolLbl";
            this.biggerSymbolLbl.Size = new System.Drawing.Size(32, 36);
            this.biggerSymbolLbl.TabIndex = 4;
            this.biggerSymbolLbl.Text = "<";
            // 
            // underWinLbl
            // 
            this.underWinLbl.AutoSize = true;
            this.underWinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underWinLbl.Location = new System.Drawing.Point(35, 13);
            this.underWinLbl.Name = "underWinLbl";
            this.underWinLbl.Size = new System.Drawing.Size(133, 20);
            this.underWinLbl.TabIndex = 2;
            this.underWinLbl.Text = "Roll Under to Win";
            // 
            // overWinLbl
            // 
            this.overWinLbl.AutoSize = true;
            this.overWinLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overWinLbl.Location = new System.Drawing.Point(42, 13);
            this.overWinLbl.Name = "overWinLbl";
            this.overWinLbl.Size = new System.Drawing.Size(122, 20);
            this.overWinLbl.TabIndex = 1;
            this.overWinLbl.Text = "Roll Over to Win";
            // 
            // doubleAmountBtn
            // 
            this.doubleAmountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.doubleAmountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.doubleAmountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleAmountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleAmountBtn.ForeColor = System.Drawing.Color.Gray;
            this.doubleAmountBtn.Location = new System.Drawing.Point(218, 62);
            this.doubleAmountBtn.Name = "doubleAmountBtn";
            this.doubleAmountBtn.Size = new System.Drawing.Size(38, 29);
            this.doubleAmountBtn.TabIndex = 6;
            this.doubleAmountBtn.Text = "x2";
            this.doubleAmountBtn.UseVisualStyleBackColor = false;
            this.doubleAmountBtn.Click += new System.EventHandler(this.doubleAmountBtn_Click);
            // 
            // halfAmountBtn
            // 
            this.halfAmountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.halfAmountBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.halfAmountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.halfAmountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfAmountBtn.ForeColor = System.Drawing.Color.Gray;
            this.halfAmountBtn.Location = new System.Drawing.Point(174, 62);
            this.halfAmountBtn.Name = "halfAmountBtn";
            this.halfAmountBtn.Size = new System.Drawing.Size(38, 29);
            this.halfAmountBtn.TabIndex = 5;
            this.halfAmountBtn.Text = "/2";
            this.halfAmountBtn.UseVisualStyleBackColor = false;
            this.halfAmountBtn.Click += new System.EventHandler(this.halfAmountBtn_Click);
            // 
            // amountTxtPanel
            // 
            this.amountTxtPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.amountTxtPanel.Controls.Add(this.amountTxt);
            this.amountTxtPanel.Location = new System.Drawing.Point(13, 62);
            this.amountTxtPanel.Name = "amountTxtPanel";
            this.amountTxtPanel.Size = new System.Drawing.Size(155, 29);
            this.amountTxtPanel.TabIndex = 4;
            // 
            // amountTxt
            // 
            this.amountTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.amountTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountTxt.ForeColor = System.Drawing.Color.Gray;
            this.amountTxt.Location = new System.Drawing.Point(3, 3);
            this.amountTxt.Name = "amountTxt";
            this.amountTxt.Size = new System.Drawing.Size(144, 22);
            this.amountTxt.TabIndex = 3;
            this.amountTxt.Text = "0.00000000";
            this.amountTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBtn.Location = new System.Drawing.Point(557, 8);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(68, 29);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // automaticDicePage
            // 
            this.automaticDicePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.automaticDicePage.Controls.Add(this.button2);
            this.automaticDicePage.Location = new System.Drawing.Point(4, 25);
            this.automaticDicePage.Name = "automaticDicePage";
            this.automaticDicePage.Padding = new System.Windows.Forms.Padding(3);
            this.automaticDicePage.Size = new System.Drawing.Size(632, 251);
            this.automaticDicePage.TabIndex = 1;
            this.automaticDicePage.Text = "Automatic Dice";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chanceValueLbl
            // 
            this.chanceValueLbl.AutoSize = true;
            this.chanceValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceValueLbl.Location = new System.Drawing.Point(58, 45);
            this.chanceValueLbl.Name = "chanceValueLbl";
            this.chanceValueLbl.Size = new System.Drawing.Size(91, 36);
            this.chanceValueLbl.TabIndex = 7;
            this.chanceValueLbl.Text = "50.00";
            this.chanceValueLbl.Click += new System.EventHandler(this.chanceValueLbl_Click);
            // 
            // chanceValueChangeTxt
            // 
            this.chanceValueChangeTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.chanceValueChangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chanceValueChangeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceValueChangeTxt.ForeColor = System.Drawing.Color.White;
            this.chanceValueChangeTxt.Location = new System.Drawing.Point(57, 42);
            this.chanceValueChangeTxt.Name = "chanceValueChangeTxt";
            this.chanceValueChangeTxt.Size = new System.Drawing.Size(100, 34);
            this.chanceValueChangeTxt.TabIndex = 8;
            // 
            // diceSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(639, 280);
            this.ControlBox = false;
            this.Controls.Add(this.diceTabControl);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "diceSimForm";
            this.Text = "Dice Simulator";
            this.diceTabControl.ResumeLayout(false);
            this.dicePage.ResumeLayout(false);
            this.dicePage.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.amountTxtPanel.ResumeLayout(false);
            this.amountTxtPanel.PerformLayout();
            this.automaticDicePage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.TabControl diceTabControl;
        private System.Windows.Forms.TabPage dicePage;
        private System.Windows.Forms.TabPage automaticDicePage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox amountTxt;
        private System.Windows.Forms.Panel amountTxtPanel;
        private System.Windows.Forms.Button halfAmountBtn;
        private System.Windows.Forms.Button doubleAmountBtn;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label payoutLbl;
        private System.Windows.Forms.Label chanceLbl;
        private System.Windows.Forms.Label underWinLbl;
        private System.Windows.Forms.Label overWinLbl;
        private System.Windows.Forms.Label overValueLbl;
        private System.Windows.Forms.Label biggerSymbolLbl;
        private System.Windows.Forms.Label smallSymbolLbl;
        private System.Windows.Forms.Label underValueLbl;
        private System.Windows.Forms.TextBox chanceValueChangeTxt;
        private System.Windows.Forms.Label chanceValueLbl;
    }
}

