//##########################################################################
//★★★★★★★           http://www.cnpopsoft.com           ★★★★★★★
//★★          VB & C# source code and articles for free !!!           ★★
//★★★★★★★                Davidwu                       ★★★★★★★
//##########################################################################

namespace CNPOPSOFT.Controls
{
    partial class frmDemo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.vistaClock1 = new CNPOPSOFT.Controls.VistaClock();
            this.vistaClock2 = new CNPOPSOFT.Controls.VistaClock();
            this.vistaClock3 = new CNPOPSOFT.Controls.VistaClock();
            this.vistaClock4 = new CNPOPSOFT.Controls.VistaClock();
            this.SuspendLayout();
            // 
            // vistaClock1
            // 
            this.vistaClock1.BackColor = System.Drawing.Color.Transparent;
            this.vistaClock1.Location = new System.Drawing.Point(74, 14);
            this.vistaClock1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vistaClock1.Name = "vistaClock1";
            this.vistaClock1.SecondSpring = true;
            this.vistaClock1.ShowSecond = true;
            this.vistaClock1.Size = new System.Drawing.Size(163, 173);
            this.vistaClock1.Style = CNPOPSOFT.Controls.VistaClock.VistaClockStyle.Silver;
            this.vistaClock1.TabIndex = 0;
            // 
            // vistaClock2
            // 
            this.vistaClock2.BackColor = System.Drawing.Color.Transparent;
            this.vistaClock2.Location = new System.Drawing.Point(74, 196);
            this.vistaClock2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vistaClock2.Name = "vistaClock2";
            this.vistaClock2.SecondSpring = true;
            this.vistaClock2.ShowSecond = true;
            this.vistaClock2.Size = new System.Drawing.Size(163, 173);
            this.vistaClock2.Style = CNPOPSOFT.Controls.VistaClock.VistaClockStyle.Red;
            this.vistaClock2.TabIndex = 1;
            // 
            // vistaClock3
            // 
            this.vistaClock3.BackColor = System.Drawing.Color.Transparent;
            this.vistaClock3.Location = new System.Drawing.Point(293, 14);
            this.vistaClock3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vistaClock3.Name = "vistaClock3";
            this.vistaClock3.SecondSpring = true;
            this.vistaClock3.ShowSecond = true;
            this.vistaClock3.Size = new System.Drawing.Size(163, 173);
            this.vistaClock3.Style = CNPOPSOFT.Controls.VistaClock.VistaClockStyle.Black;
            this.vistaClock3.TabIndex = 2;
            // 
            // vistaClock4
            // 
            this.vistaClock4.BackColor = System.Drawing.Color.Transparent;
            this.vistaClock4.Location = new System.Drawing.Point(293, 196);
            this.vistaClock4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vistaClock4.Name = "vistaClock4";
            this.vistaClock4.SecondSpring = true;
            this.vistaClock4.ShowSecond = true;
            this.vistaClock4.Size = new System.Drawing.Size(163, 173);
            this.vistaClock4.Style = CNPOPSOFT.Controls.VistaClock.VistaClockStyle.Flower;
            this.vistaClock4.TabIndex = 3;
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(562, 385);
            this.Controls.Add(this.vistaClock4);
            this.Controls.Add(this.vistaClock3);
            this.Controls.Add(this.vistaClock2);
            this.Controls.Add(this.vistaClock1);
            this.Name = "frmDemo";
            this.Text = "VistaClock Demo AriooBarzan Team";
            this.ResumeLayout(false);

        }

        #endregion

        private VistaClock vistaClock1;
        private VistaClock vistaClock2;
        private VistaClock vistaClock3;
        private VistaClock vistaClock4;
    }
}

