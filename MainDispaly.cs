using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_ABBP
{

    public partial class MainDispaly : Form
    {
        DateTime dt = DateTime.Now;
        int BetweenMonth = 0;

        public MainDispaly()
        {
            InitializeComponent();
        }

        private void Main_Dispaly_Load(object sender, EventArgs e)
        {
            this.monthly.Text = dt.ToString("yyyy.MM");
        }

        // 終了メニュー
        private void Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthly_Click(object sender, EventArgs e)
        {
            
        }

        private void prev_month_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth--;
            DateTime prev_month = dt.AddMonths(BetweenMonth);
            this.monthly.Text = prev_month.ToString("yyyy.MM");
        }

        private void next_month_btn_Click(object sender, EventArgs e)
        {
            BetweenMonth++;
            DateTime next_month = dt.AddMonths(BetweenMonth);
            this.monthly.Text = next_month.ToString("yyyy.MM");
        }
    }
}
