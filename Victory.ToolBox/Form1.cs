using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Victory.ToolBox.Helper;

namespace Victory.ToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
        }
        #region 数据库连接字符串加密

        private void btn_conn_encode_Click(object sender, EventArgs e)
        {
            string key = MachineHelper.GetCpuId();
            this.tb_conn_miwen.Text = EncryptHelper.AesEncrypt(this.tb_conn_mingwen.Text, key);
        }

        private void btn_conn_decode_Click(object sender, EventArgs e)
        {
            string key = MachineHelper.GetCpuId();
            this.tb_conn_mingwen.Text = EncryptHelper.AesDecrypt(this.tb_conn_miwen.Text, key);
        }


        #endregion



        #region Md5 加密

        private void tb_md5_mingwen_TextChanged(object sender, EventArgs e)
        {
            this.tb_md5_16.Text = EncryptHelper.Md5Encode16(this.tb_md5_mingwen.Text);
            this.tb_md5_32.Text = EncryptHelper.Md5Encode32(this.tb_md5_mingwen.Text);
        }



        #endregion

        #region 时间戳

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lb_datenow.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            this.tb_date_timesapn.Text = DateTime.Now.ToTimestamp().ToString();
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
         
            this.timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.timer1.Enabled = true;
        }
    }
}
