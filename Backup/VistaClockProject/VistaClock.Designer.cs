//##########################################################################
//★★★★★★★           http://www.cnpopsoft.com           ★★★★★★★
//★★          VB & C# source code and articles for free !!!           ★★
//★★★★★★★                Davidwu                       ★★★★★★★
//##########################################################################

namespace CNPOPSOFT.Controls
{
    partial class VistaClock
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuSkin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSilver = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRed = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFlower = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShowSecond = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShowSpring = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSkin,
            this.toolStripMenuItem1,
            this.mnuShowSecond,
            this.mnuShowSpring});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 98);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mnuSkin
            // 
            this.mnuSkin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSilver,
            this.mnuBlack,
            this.mnuRed,
            this.mnuFlower});
            this.mnuSkin.Name = "mnuSkin";
            this.mnuSkin.Size = new System.Drawing.Size(152, 22);
            this.mnuSkin.Text = "&Skin";
            // 
            // mnuSilver
            // 
            this.mnuSilver.Name = "mnuSilver";
            this.mnuSilver.Size = new System.Drawing.Size(111, 22);
            this.mnuSilver.Text = "&Silver";
            this.mnuSilver.Click += new System.EventHandler(this.mnuSilver_Click);
            // 
            // mnuBlack
            // 
            this.mnuBlack.Name = "mnuBlack";
            this.mnuBlack.Size = new System.Drawing.Size(111, 22);
            this.mnuBlack.Text = "&Black";
            this.mnuBlack.Click += new System.EventHandler(this.mnuBlack_Click);
            // 
            // mnuRed
            // 
            this.mnuRed.Name = "mnuRed";
            this.mnuRed.Size = new System.Drawing.Size(111, 22);
            this.mnuRed.Text = "&Red";
            this.mnuRed.Click += new System.EventHandler(this.mnuRed_Click);
            // 
            // mnuFlower
            // 
            this.mnuFlower.Name = "mnuFlower";
            this.mnuFlower.Size = new System.Drawing.Size(111, 22);
            this.mnuFlower.Text = "&Flower";
            this.mnuFlower.Click += new System.EventHandler(this.mnuFlower_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuShowSecond
            // 
            this.mnuShowSecond.Name = "mnuShowSecond";
            this.mnuShowSecond.Size = new System.Drawing.Size(152, 22);
            this.mnuShowSecond.Text = "ShowSe&cond";
            this.mnuShowSecond.Click += new System.EventHandler(this.mnuShowSecond_Click);
            // 
            // mnuShowSpring
            // 
            this.mnuShowSpring.Name = "mnuShowSpring";
            this.mnuShowSpring.Size = new System.Drawing.Size(152, 22);
            this.mnuShowSpring.Text = "S&pringEffect";
            this.mnuShowSpring.Click += new System.EventHandler(this.mnuShowSpring_Click);
            // 
            // VistaClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "VistaClock";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSkin;
        private System.Windows.Forms.ToolStripMenuItem mnuSilver;
        private System.Windows.Forms.ToolStripMenuItem mnuBlack;
        private System.Windows.Forms.ToolStripMenuItem mnuRed;
        private System.Windows.Forms.ToolStripMenuItem mnuFlower;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuShowSecond;
        private System.Windows.Forms.ToolStripMenuItem mnuShowSpring;
    }
}
