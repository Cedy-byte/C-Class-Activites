namespace TipCalculator
{
    partial class fvTipCalculator
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbServive = new System.Windows.Forms.ComboBox();
            this.tbarNum = new System.Windows.Forms.TrackBar();
            this.radSplitYes = new System.Windows.Forms.RadioButton();
            this.radSplitNo = new System.Windows.Forms.RadioButton();
            this.groupBoxSplit = new System.Windows.Forms.GroupBox();
            this.txtPeople = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbarNum)).BeginInit();
            this.groupBoxSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(69, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(216, 26);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Tip Calculator";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAmount.Location = new System.Drawing.Point(32, 108);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(88, 15);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Bill Amount :";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTip.Location = new System.Drawing.Point(32, 148);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(51, 15);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Tip % :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNum.Location = new System.Drawing.Point(32, 321);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(97, 15);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "No of people :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(146, 103);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(155, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(146, 143);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(155, 20);
            this.txtTip.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(210, 381);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 34);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(54, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.SystemColors.Control;
            this.lblService.Location = new System.Drawing.Point(32, 190);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(108, 15);
            this.lblService.TabIndex = 9;
            this.lblService.Text = "Service Rating :";
            // 
            // cmbServive
            // 
            this.cmbServive.FormattingEnabled = true;
            this.cmbServive.Items.AddRange(new object[] {
            "Poor",
            "Moderate",
            "Excellent"});
            this.cmbServive.Location = new System.Drawing.Point(146, 190);
            this.cmbServive.Name = "cmbServive";
            this.cmbServive.Size = new System.Drawing.Size(155, 21);
            this.cmbServive.TabIndex = 10;
            this.cmbServive.Text = "Poor";
            // 
            // tbarNum
            // 
            this.tbarNum.Location = new System.Drawing.Point(140, 321);
            this.tbarNum.Name = "tbarNum";
            this.tbarNum.Size = new System.Drawing.Size(118, 45);
            this.tbarNum.TabIndex = 11;
            this.tbarNum.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // radSplitYes
            // 
            this.radSplitYes.AutoSize = true;
            this.radSplitYes.Location = new System.Drawing.Point(91, 19);
            this.radSplitYes.Name = "radSplitYes";
            this.radSplitYes.Size = new System.Drawing.Size(51, 19);
            this.radSplitYes.TabIndex = 13;
            this.radSplitYes.TabStop = true;
            this.radSplitYes.Text = "YES";
            this.radSplitYes.UseVisualStyleBackColor = true;
            // 
            // radSplitNo
            // 
            this.radSplitNo.AutoSize = true;
            this.radSplitNo.Location = new System.Drawing.Point(91, 42);
            this.radSplitNo.Name = "radSplitNo";
            this.radSplitNo.Size = new System.Drawing.Size(45, 19);
            this.radSplitNo.TabIndex = 14;
            this.radSplitNo.TabStop = true;
            this.radSplitNo.Text = "NO";
            this.radSplitNo.UseVisualStyleBackColor = true;
            // 
            // groupBoxSplit
            // 
            this.groupBoxSplit.Controls.Add(this.radSplitNo);
            this.groupBoxSplit.Controls.Add(this.radSplitYes);
            this.groupBoxSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSplit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSplit.Location = new System.Drawing.Point(55, 227);
            this.groupBoxSplit.Name = "groupBoxSplit";
            this.groupBoxSplit.Size = new System.Drawing.Size(246, 73);
            this.groupBoxSplit.TabIndex = 15;
            this.groupBoxSplit.TabStop = false;
            this.groupBoxSplit.Text = "Split Bill :";
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(271, 330);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(30, 20);
            this.txtPeople.TabIndex = 16;
            // 
            // fvTipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = global::TipCalculator.Properties.Resources.kfc_background_1;
            this.ClientSize = new System.Drawing.Size(349, 449);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.groupBoxSplit);
            this.Controls.Add(this.tbarNum);
            this.Controls.Add(this.cmbServive);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblHeading);
            this.Name = "fvTipCalculator";
            this.Text = "Tip Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.tbarNum)).EndInit();
            this.groupBoxSplit.ResumeLayout(false);
            this.groupBoxSplit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbServive;
        private System.Windows.Forms.TrackBar tbarNum;
        private System.Windows.Forms.RadioButton radSplitYes;
        private System.Windows.Forms.RadioButton radSplitNo;
        private System.Windows.Forms.GroupBox groupBoxSplit;
        private System.Windows.Forms.TextBox txtPeople;
    }
}

