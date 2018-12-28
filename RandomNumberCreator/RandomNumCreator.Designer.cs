namespace RandomNumberCreator
{
    partial class RandomNumCreator
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFoot = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbSplit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRepeatable = new System.Windows.Forms.CheckBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.pnlFoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "随机数范围";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "随机数个数";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(109, 31);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(57, 25);
            this.txtNum.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(401, 31);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(101, 25);
            this.txtMin.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(109, 105);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(521, 140);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "生成结果";
            // 
            // pnlFoot
            // 
            this.pnlFoot.Controls.Add(this.chkCheck);
            this.pnlFoot.Controls.Add(this.label7);
            this.pnlFoot.Controls.Add(this.btnClear);
            this.pnlFoot.Controls.Add(this.cmbSplit);
            this.pnlFoot.Controls.Add(this.label6);
            this.pnlFoot.Controls.Add(this.txtAverage);
            this.pnlFoot.Controls.Add(this.label5);
            this.pnlFoot.Controls.Add(this.chkRepeatable);
            this.pnlFoot.Controls.Add(this.btnCreate);
            this.pnlFoot.Controls.Add(this.txtMax);
            this.pnlFoot.Controls.Add(this.label4);
            this.pnlFoot.Controls.Add(this.txtNum);
            this.pnlFoot.Controls.Add(this.label3);
            this.pnlFoot.Controls.Add(this.label1);
            this.pnlFoot.Controls.Add(this.txtResult);
            this.pnlFoot.Controls.Add(this.label2);
            this.pnlFoot.Controls.Add(this.txtMin);
            this.pnlFoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoot.Location = new System.Drawing.Point(0, 0);
            this.pnlFoot.Name = "pnlFoot";
            this.pnlFoot.Size = new System.Drawing.Size(767, 293);
            this.pnlFoot.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(632, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "版权所有@wangrd";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClear.Location = new System.Drawing.Point(647, 62);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "清空[&D]";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbSplit
            // 
            this.cmbSplit.FormattingEnabled = true;
            this.cmbSplit.Items.AddRange(new object[] {
            "逗号",
            "Tab",
            "换行"});
            this.cmbSplit.Location = new System.Drawing.Point(401, 67);
            this.cmbSplit.Name = "cmbSplit";
            this.cmbSplit.Size = new System.Drawing.Size(101, 23);
            this.cmbSplit.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "分隔符";
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(237, 31);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(57, 25);
            this.txtAverage.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "均值";
            // 
            // chkRepeatable
            // 
            this.chkRepeatable.AutoSize = true;
            this.chkRepeatable.Location = new System.Drawing.Point(109, 69);
            this.chkRepeatable.Name = "chkRepeatable";
            this.chkRepeatable.Size = new System.Drawing.Size(89, 19);
            this.chkRepeatable.TabIndex = 9;
            this.chkRepeatable.Text = "允许重复";
            this.chkRepeatable.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreate.Location = new System.Drawing.Point(647, 28);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(87, 30);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "生成[&C]";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(529, 31);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(101, 25);
            this.txtMax.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(205, 69);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(89, 19);
            this.chkCheck.TabIndex = 16;
            this.chkCheck.Text = "校验结果";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // RandomNumCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 293);
            this.Controls.Add(this.pnlFoot);
            this.Name = "RandomNumCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机数生成";
            this.Load += new System.EventHandler(this.RandomNumCreator_Load);
            this.pnlFoot.ResumeLayout(false);
            this.pnlFoot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFoot;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRepeatable;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSplit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkCheck;
    }
}

