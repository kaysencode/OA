namespace OA
{
    partial class M_Form
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.基本信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.档案管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工档案ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.区域档案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 396);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel.Text = "状态";
            // 
            // 基本信息ToolStripMenuItem
            // 
            this.基本信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.档案管理ToolStripMenuItem});
            this.基本信息ToolStripMenuItem.Name = "基本信息ToolStripMenuItem";
            this.基本信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本信息ToolStripMenuItem.Text = "基本信息";
            // 
            // 档案管理ToolStripMenuItem
            // 
            this.档案管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工档案ToolStripMenuItem,
            this.员工档案ToolStripMenuItem1,
            this.区域档案ToolStripMenuItem});
            this.档案管理ToolStripMenuItem.Name = "档案管理ToolStripMenuItem";
            this.档案管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.档案管理ToolStripMenuItem.Text = "档案管理";
            // 
            // 员工档案ToolStripMenuItem
            // 
            this.员工档案ToolStripMenuItem.Name = "员工档案ToolStripMenuItem";
            this.员工档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工档案ToolStripMenuItem.Text = "部门档案";
            // 
            // 员工档案ToolStripMenuItem1
            // 
            this.员工档案ToolStripMenuItem1.Name = "员工档案ToolStripMenuItem1";
            this.员工档案ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.员工档案ToolStripMenuItem1.Text = "员工档案";
            // 
            // 区域档案ToolStripMenuItem
            // 
            this.区域档案ToolStripMenuItem.Name = "区域档案ToolStripMenuItem";
            this.区域档案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.区域档案ToolStripMenuItem.Text = "区域档案";
            // 
            // M_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 418);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "M_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贵州精算软件OA系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.M_Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.M_Form_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.M_Form_FormClosing);

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem 基本信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 档案管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工档案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工档案ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 区域档案ToolStripMenuItem;
    }
}



