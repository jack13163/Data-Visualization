namespace Drilling
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.plContainer = new System.Windows.Forms.Panel();
            this.msMainFrmMenu = new System.Windows.Forms.MenuStrip();
            this.stmiSort = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCaseFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiListManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainFrmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // plContainer
            // 
            this.plContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plContainer.BackgroundImage = global::Drilling.Properties.Resources._2ba239f50b2c73d635c6d3fa319d6706;
            this.plContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;//背景图片拉伸
            this.plContainer.Location = new System.Drawing.Point(0, 25);
            this.plContainer.Name = "plContainer";
            this.plContainer.Size = new System.Drawing.Size(884, 637);
            this.plContainer.TabIndex = 0;
            // 
            // msMainFrmMenu
            // 
            this.msMainFrmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmiSort,
            this.tsmiCaseFlow,
            this.tsmiListManagement,
            this.tsmiExit});
            this.msMainFrmMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainFrmMenu.Name = "msMainFrmMenu";
            this.msMainFrmMenu.Size = new System.Drawing.Size(884, 25);
            this.msMainFrmMenu.TabIndex = 1;
            this.msMainFrmMenu.Text = "menuStrip1";
            // 
            // stmiSort
            // 
            this.stmiSort.Name = "stmiSort";
            this.stmiSort.Size = new System.Drawing.Size(68, 21);
            this.stmiSort.Text = "分类预测";
            this.stmiSort.Click += new System.EventHandler(this.stmiSort_Click);
            // 
            // tsmiCaseFlow
            // 
            this.tsmiCaseFlow.Name = "tsmiCaseFlow";
            this.tsmiCaseFlow.Size = new System.Drawing.Size(92, 21);
            this.tsmiCaseFlow.Text = "事故处理流程";
            this.tsmiCaseFlow.Click += new System.EventHandler(this.tsmiCaseFlow_Click);
            // 
            // tsmiListManagement
            // 
            this.tsmiListManagement.Name = "tsmiListManagement";
            this.tsmiListManagement.Size = new System.Drawing.Size(92, 21);
            this.tsmiListManagement.Text = "诊断记录维护";
            this.tsmiListManagement.Click += new System.EventHandler(this.tsmiListManagement_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(44, 21);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.plContainer);
            this.Controls.Add(this.msMainFrmMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainFrmMenu;
            this.Name = "MainFrm";
            this.Text = "钻井复杂情况与事故预测";
            this.msMainFrmMenu.ResumeLayout(false);
            this.msMainFrmMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plContainer;
        private System.Windows.Forms.MenuStrip msMainFrmMenu;
        private System.Windows.Forms.ToolStripMenuItem stmiSort;
        private System.Windows.Forms.ToolStripMenuItem tsmiCaseFlow;
        private System.Windows.Forms.ToolStripMenuItem tsmiListManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

