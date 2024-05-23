namespace Home_ABBP
{
    partial class Main_Dispaly
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.monthly = new System.Windows.Forms.Label();
            this.prev_month_btn = new System.Windows.Forms.Button();
            this.next_month_btn = new System.Windows.Forms.Button();
            this.amount_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly.Location = new System.Drawing.Point(51, 14);
            this.monthly.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(97, 24);
            this.monthly.TabIndex = 0;
            this.monthly.Text = "yyyy.MM";
            this.monthly.Click += new System.EventHandler(this.label1_Click);
            // 
            // prev_month_btn
            // 
            this.prev_month_btn.Location = new System.Drawing.Point(12, 12);
            this.prev_month_btn.Name = "prev_month_btn";
            this.prev_month_btn.Size = new System.Drawing.Size(30, 30);
            this.prev_month_btn.TabIndex = 1;
            this.prev_month_btn.Text = "◀";
            this.prev_month_btn.UseVisualStyleBackColor = true;
            // 
            // next_month_btn
            // 
            this.next_month_btn.Location = new System.Drawing.Point(157, 12);
            this.next_month_btn.Name = "next_month_btn";
            this.next_month_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.next_month_btn.Size = new System.Drawing.Size(30, 30);
            this.next_month_btn.TabIndex = 2;
            this.next_month_btn.Text = "▶";
            this.next_month_btn.UseVisualStyleBackColor = true;
            this.next_month_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // amount_num
            // 
            this.amount_num.AutoSize = true;
            this.amount_num.BackColor = System.Drawing.Color.Transparent;
            this.amount_num.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_num.Location = new System.Drawing.Point(27, 45);
            this.amount_num.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amount_num.Name = "amount_num";
            this.amount_num.Size = new System.Drawing.Size(160, 58);
            this.amount_num.TabIndex = 3;
            this.amount_num.Text = "12345";
            this.amount_num.Click += new System.EventHandler(this.label2_Click);
            // 
            // Main_Dispaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.amount_num);
            this.Controls.Add(this.next_month_btn);
            this.Controls.Add(this.prev_month_btn);
            this.Controls.Add(this.monthly);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main_Dispaly";
            this.Text = "Home ABBP";
            this.Load += new System.EventHandler(this.Main_Dispaly_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthly;
        private System.Windows.Forms.Button prev_month_btn;
        private System.Windows.Forms.Button next_month_btn;
        private System.Windows.Forms.Label amount_num;
    }
}

