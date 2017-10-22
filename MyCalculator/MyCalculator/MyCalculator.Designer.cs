namespace MyCalculator
{
    partial class MyCalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.displayTextField = new System.Windows.Forms.TextBox();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.multipleBtn = new System.Windows.Forms.Button();
            this.dividBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayTextField
            // 
            this.displayTextField.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.displayTextField.Location = new System.Drawing.Point(12, 12);
            this.displayTextField.Name = "displayTextField";
            this.displayTextField.ReadOnly = true;
            this.displayTextField.Size = new System.Drawing.Size(378, 65);
            this.displayTextField.TabIndex = 0;
            this.displayTextField.Text = "0";
            this.displayTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sevenBtn
            // 
            this.sevenBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sevenBtn.Location = new System.Drawing.Point(12, 135);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(90, 48);
            this.sevenBtn.TabIndex = 1;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eightBtn.Location = new System.Drawing.Point(108, 135);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(90, 48);
            this.eightBtn.TabIndex = 2;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nineBtn.Location = new System.Drawing.Point(204, 135);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(90, 48);
            this.nineBtn.TabIndex = 3;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fourBtn.Location = new System.Drawing.Point(12, 189);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(90, 48);
            this.fourBtn.TabIndex = 4;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fiveBtn.Location = new System.Drawing.Point(108, 189);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(90, 48);
            this.fiveBtn.TabIndex = 5;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sixBtn.Location = new System.Drawing.Point(204, 189);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(90, 48);
            this.sixBtn.TabIndex = 6;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oneBtn.Location = new System.Drawing.Point(12, 243);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(90, 48);
            this.oneBtn.TabIndex = 7;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.twoBtn.Location = new System.Drawing.Point(108, 243);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(90, 48);
            this.twoBtn.TabIndex = 8;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.threeBtn.Location = new System.Drawing.Point(204, 243);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(90, 48);
            this.threeBtn.TabIndex = 9;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zeroBtn.Location = new System.Drawing.Point(12, 297);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(186, 48);
            this.zeroBtn.TabIndex = 10;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalBtn.Location = new System.Drawing.Point(204, 297);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(90, 48);
            this.equalBtn.TabIndex = 11;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.minusBtn.Location = new System.Drawing.Point(300, 135);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(90, 48);
            this.minusBtn.TabIndex = 12;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plusBtn.Location = new System.Drawing.Point(300, 189);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(90, 48);
            this.plusBtn.TabIndex = 13;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            // 
            // multipleBtn
            // 
            this.multipleBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.multipleBtn.Location = new System.Drawing.Point(300, 243);
            this.multipleBtn.Name = "multipleBtn";
            this.multipleBtn.Size = new System.Drawing.Size(90, 48);
            this.multipleBtn.TabIndex = 14;
            this.multipleBtn.Text = "*";
            this.multipleBtn.UseVisualStyleBackColor = true;
            // 
            // dividBtn
            // 
            this.dividBtn.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dividBtn.Location = new System.Drawing.Point(300, 297);
            this.dividBtn.Name = "dividBtn";
            this.dividBtn.Size = new System.Drawing.Size(90, 48);
            this.dividBtn.TabIndex = 15;
            this.dividBtn.Text = "/";
            this.dividBtn.UseVisualStyleBackColor = true;
            // 
            // historyBtn
            // 
            this.historyBtn.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.historyBtn.Location = new System.Drawing.Point(12, 81);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(378, 48);
            this.historyBtn.TabIndex = 16;
            this.historyBtn.Text = "歷史紀錄";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // MyCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 363);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.dividBtn);
            this.Controls.Add(this.multipleBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.displayTextField);
            this.Name = "MyCalculator";
            this.Text = "MyCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextField;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button multipleBtn;
        private System.Windows.Forms.Button dividBtn;
        private System.Windows.Forms.Button historyBtn;
    }
}

