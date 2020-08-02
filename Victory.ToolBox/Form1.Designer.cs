namespace Victory.ToolBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_conn_decode = new System.Windows.Forms.Button();
            this.btn_conn_encode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_conn_miwen = new System.Windows.Forms.TextBox();
            this.tb_conn_mingwen = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_md5_32 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_md5_16 = new System.Windows.Forms.TextBox();
            this.tb_md5_mingwen = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_datenow = new System.Windows.Forms.Label();
            this.tb_date_timesapn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_conn_decode);
            this.tabPage1.Controls.Add(this.btn_conn_encode);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_conn_miwen);
            this.tabPage1.Controls.Add(this.tb_conn_mingwen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(816, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "连接字符串加密";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_conn_decode
            // 
            this.btn_conn_decode.Location = new System.Drawing.Point(473, 267);
            this.btn_conn_decode.Name = "btn_conn_decode";
            this.btn_conn_decode.Size = new System.Drawing.Size(75, 23);
            this.btn_conn_decode.TabIndex = 5;
            this.btn_conn_decode.Text = "解密";
            this.btn_conn_decode.UseVisualStyleBackColor = true;
            this.btn_conn_decode.Click += new System.EventHandler(this.btn_conn_decode_Click);
            // 
            // btn_conn_encode
            // 
            this.btn_conn_encode.Location = new System.Drawing.Point(241, 267);
            this.btn_conn_encode.Name = "btn_conn_encode";
            this.btn_conn_encode.Size = new System.Drawing.Size(75, 23);
            this.btn_conn_encode.TabIndex = 4;
            this.btn_conn_encode.Text = "加密";
            this.btn_conn_encode.UseVisualStyleBackColor = true;
            this.btn_conn_encode.Click += new System.EventHandler(this.btn_conn_encode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密文：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "明文：";
            // 
            // tb_conn_miwen
            // 
            this.tb_conn_miwen.Location = new System.Drawing.Point(43, 309);
            this.tb_conn_miwen.Multiline = true;
            this.tb_conn_miwen.Name = "tb_conn_miwen";
            this.tb_conn_miwen.Size = new System.Drawing.Size(736, 213);
            this.tb_conn_miwen.TabIndex = 1;
            // 
            // tb_conn_mingwen
            // 
            this.tb_conn_mingwen.Location = new System.Drawing.Point(43, 42);
            this.tb_conn_mingwen.Multiline = true;
            this.tb_conn_mingwen.Name = "tb_conn_mingwen";
            this.tb_conn_mingwen.Size = new System.Drawing.Size(736, 208);
            this.tb_conn_mingwen.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_md5_32);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tb_md5_16);
            this.tabPage2.Controls.Add(this.tb_md5_mingwen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(816, 570);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " MD5";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "32位大写：";
            // 
            // tb_md5_32
            // 
            this.tb_md5_32.Location = new System.Drawing.Point(35, 373);
            this.tb_md5_32.Multiline = true;
            this.tb_md5_32.Name = "tb_md5_32";
            this.tb_md5_32.Size = new System.Drawing.Size(730, 94);
            this.tb_md5_32.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "16位大写：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "明文：";
            // 
            // tb_md5_16
            // 
            this.tb_md5_16.Location = new System.Drawing.Point(35, 201);
            this.tb_md5_16.Multiline = true;
            this.tb_md5_16.Name = "tb_md5_16";
            this.tb_md5_16.Size = new System.Drawing.Size(730, 100);
            this.tb_md5_16.TabIndex = 1;
            // 
            // tb_md5_mingwen
            // 
            this.tb_md5_mingwen.Location = new System.Drawing.Point(35, 38);
            this.tb_md5_mingwen.Multiline = true;
            this.tb_md5_mingwen.Name = "tb_md5_mingwen";
            this.tb_md5_mingwen.Size = new System.Drawing.Size(730, 96);
            this.tb_md5_mingwen.TabIndex = 0;
            this.tb_md5_mingwen.TextChanged += new System.EventHandler(this.tb_md5_mingwen_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.lb_datenow);
            this.tabPage3.Controls.Add(this.tb_date_timesapn);
            this.tabPage3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(816, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "时间戳";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_datenow
            // 
            this.lb_datenow.AutoSize = true;
            this.lb_datenow.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_datenow.Location = new System.Drawing.Point(132, 22);
            this.lb_datenow.Name = "lb_datenow";
            this.lb_datenow.Size = new System.Drawing.Size(88, 16);
            this.lb_datenow.TabIndex = 4;
            this.lb_datenow.Text = "当前时间：";
            // 
            // tb_date_timesapn
            // 
            this.tb_date_timesapn.Location = new System.Drawing.Point(134, 99);
            this.tb_date_timesapn.Name = "tb_date_timesapn";
            this.tb_date_timesapn.Size = new System.Drawing.Size(248, 26);
            this.tb_date_timesapn.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "当前时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "当前时间戳：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Victory工具箱";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_conn_miwen;
        private System.Windows.Forms.TextBox tb_conn_mingwen;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_conn_decode;
        private System.Windows.Forms.Button btn_conn_encode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_md5_16;
        private System.Windows.Forms.TextBox tb_md5_mingwen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_md5_32;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_datenow;
        private System.Windows.Forms.TextBox tb_date_timesapn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

