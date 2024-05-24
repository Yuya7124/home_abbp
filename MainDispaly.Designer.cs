namespace Home_ABBP
{
    partial class MainDispaly
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
            this.new_amount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.property_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.user_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.yen_icon = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthly
            // 
            this.monthly.AutoSize = true;
            this.monthly.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthly.ForeColor = System.Drawing.Color.White;
            this.monthly.Location = new System.Drawing.Point(51, 29);
            this.monthly.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthly.Name = "monthly";
            this.monthly.Size = new System.Drawing.Size(97, 24);
            this.monthly.TabIndex = 0;
            this.monthly.Text = "yyyy.MM";
            this.monthly.Click += new System.EventHandler(this.monthly_Click);
            // 
            // prev_month_btn
            // 
            this.prev_month_btn.Location = new System.Drawing.Point(12, 27);
            this.prev_month_btn.Name = "prev_month_btn";
            this.prev_month_btn.Size = new System.Drawing.Size(28, 28);
            this.prev_month_btn.TabIndex = 1;
            this.prev_month_btn.Text = "◀";
            this.prev_month_btn.UseVisualStyleBackColor = true;
            this.prev_month_btn.Click += new System.EventHandler(this.prev_month_btn_Click);
            // 
            // next_month_btn
            // 
            this.next_month_btn.Location = new System.Drawing.Point(157, 27);
            this.next_month_btn.Name = "next_month_btn";
            this.next_month_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.next_month_btn.Size = new System.Drawing.Size(28, 28);
            this.next_month_btn.TabIndex = 2;
            this.next_month_btn.Text = "▶";
            this.next_month_btn.UseVisualStyleBackColor = true;
            this.next_month_btn.Click += new System.EventHandler(this.next_month_btn_Click);
            // 
            // amount_num
            // 
            this.amount_num.AutoSize = true;
            this.amount_num.BackColor = System.Drawing.Color.Transparent;
            this.amount_num.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_num.ForeColor = System.Drawing.Color.White;
            this.amount_num.Location = new System.Drawing.Point(45, 72);
            this.amount_num.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.amount_num.Name = "amount_num";
            this.amount_num.Size = new System.Drawing.Size(52, 58);
            this.amount_num.TabIndex = 3;
            this.amount_num.Text = "0";
            // 
            // new_amount
            // 
            this.new_amount.Location = new System.Drawing.Point(12, 149);
            this.new_amount.Name = "new_amount";
            this.new_amount.Size = new System.Drawing.Size(28, 28);
            this.new_amount.TabIndex = 4;
            this.new_amount.Text = "✏";
            this.new_amount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "新規登録";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.BackColor = System.Drawing.Color.Transparent;
            this.user_name.Location = new System.Drawing.Point(486, 24);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(86, 21);
            this.user_name.TabIndex = 6;
            this.user_name.Text = "👤 nanka";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // OptionMenuItem
            // 
            this.OptionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserProperty,
            this.Logout,
            this.Quit});
            this.OptionMenuItem.Name = "OptionMenuItem";
            this.OptionMenuItem.Size = new System.Drawing.Size(43, 20);
            this.OptionMenuItem.Text = "設定";
            // 
            // UserProperty
            // 
            this.UserProperty.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.property_menu,
            this.user_edit});
            this.UserProperty.Name = "UserProperty";
            this.UserProperty.Size = new System.Drawing.Size(126, 22);
            this.UserProperty.Text = "ユーザ情報";
            // 
            // property_menu
            // 
            this.property_menu.Name = "property_menu";
            this.property_menu.Size = new System.Drawing.Size(124, 22);
            this.property_menu.Text = "プロパティ";
            // 
            // user_edit
            // 
            this.user_edit.Name = "user_edit";
            this.user_edit.Size = new System.Drawing.Size(124, 22);
            this.user_edit.Text = "データ変更";
            // 
            // Logout
            // 
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(126, 22);
            this.Logout.Text = "ログアウト";
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(126, 22);
            this.Quit.Text = "終了";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "編集";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "📝";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // yen_icon
            // 
            this.yen_icon.AutoSize = true;
            this.yen_icon.BackColor = System.Drawing.Color.Transparent;
            this.yen_icon.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yen_icon.ForeColor = System.Drawing.Color.White;
            this.yen_icon.Location = new System.Drawing.Point(15, 87);
            this.yen_icon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yen_icon.Name = "yen_icon";
            this.yen_icon.Size = new System.Drawing.Size(35, 39);
            this.yen_icon.TabIndex = 12;
            this.yen_icon.Text = "¥";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(176, 149);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 200);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Main_Dispaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.yen_icon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_amount);
            this.Controls.Add(this.amount_num);
            this.Controls.Add(this.next_month_btn);
            this.Controls.Add(this.prev_month_btn);
            this.Controls.Add(this.monthly);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Dispaly";
            this.Text = "Home ABBP";
            this.Load += new System.EventHandler(this.Main_Dispaly_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label monthly;
        private System.Windows.Forms.Button prev_month_btn;
        private System.Windows.Forms.Button next_month_btn;
        private System.Windows.Forms.Label amount_num;
        private System.Windows.Forms.Button new_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OptionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserProperty;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem Logout;
        private System.Windows.Forms.ToolStripMenuItem property_menu;
        private System.Windows.Forms.ToolStripMenuItem user_edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label yen_icon;
        private System.Windows.Forms.ListView listView1;
    }
}

