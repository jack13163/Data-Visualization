using System.Drawing;
namespace Drilling
{
    partial class DrawFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccident = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAccident2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbTop = new System.Windows.Forms.GroupBox();
            this.rbtnTime = new System.Windows.Forms.RadioButton();
            this.rbtnDepth = new System.Windows.Forms.RadioButton();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_Left_Buttom = new System.Windows.Forms.GroupBox();
            this.gb_Right_Buttom = new System.Windows.Forms.GroupBox();
            this.gb_Right_Top = new System.Windows.Forms.GroupBox();
            this.gb_Left_Top = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tContainer.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbTop.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Drilling.Properties.Resources._01;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStatus,
            this.tsmiAccident,
            this.tsmiAccident2,
            this.tsmiClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiStatus
            // 
            this.tsmiStatus.Name = "tsmiStatus";
            this.tsmiStatus.Size = new System.Drawing.Size(92, 21);
            this.tsmiStatus.Text = "井下复杂情况";
            // 
            // tsmiAccident
            // 
            this.tsmiAccident.Name = "tsmiAccident";
            this.tsmiAccident.Size = new System.Drawing.Size(68, 21);
            this.tsmiAccident.Text = "井下事故";
            // 
            // tsmiAccident2
            // 
            this.tsmiAccident2.Name = "tsmiAccident2";
            this.tsmiAccident2.Size = new System.Drawing.Size(68, 21);
            this.tsmiAccident2.Text = "卡钻事故";
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(44, 21);
            this.tsmiClose.Text = "关闭";
            // 
            // tContainer
            // 
            this.tContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tContainer.Controls.Add(this.tabPage1);
            this.tContainer.Controls.Add(this.tabPage2);
            this.tContainer.Controls.Add(this.tabPage3);
            this.tContainer.Controls.Add(this.tabPage4);
            this.tContainer.Location = new System.Drawing.Point(12, 10);
            this.tContainer.Name = "tContainer";
            this.tContainer.SelectedIndex = 0;
            this.tContainer.Size = new System.Drawing.Size(1013, 661);
            this.tContainer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1005, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "配置信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1005, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "实时模拟";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1005, 635);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "实时传输";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbTop);
            this.tabPage4.Controls.Add(this.toolStripContainer);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1005, 635);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "数据展示";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbTop
            // 
            this.gbTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTop.Controls.Add(this.rbtnTime);
            this.gbTop.Controls.Add(this.rbtnDepth);
            this.gbTop.Location = new System.Drawing.Point(3, 7);
            this.gbTop.Name = "gbTop";
            this.gbTop.Size = new System.Drawing.Size(994, 50);
            this.gbTop.TabIndex = 1;
            this.gbTop.TabStop = false;
            this.gbTop.Text = "监控方式";
            // 
            // rbtnTime
            // 
            this.rbtnTime.AutoSize = true;
            this.rbtnTime.Location = new System.Drawing.Point(121, 21);
            this.rbtnTime.Name = "rbtnTime";
            this.rbtnTime.Size = new System.Drawing.Size(59, 16);
            this.rbtnTime.TabIndex = 1;
            this.rbtnTime.TabStop = true;
            this.rbtnTime.Text = "时间轴";
            this.rbtnTime.UseVisualStyleBackColor = true;
            // 
            // rbtnDepth
            // 
            this.rbtnDepth.AutoSize = true;
            this.rbtnDepth.Location = new System.Drawing.Point(32, 21);
            this.rbtnDepth.Name = "rbtnDepth";
            this.rbtnDepth.Size = new System.Drawing.Size(59, 16);
            this.rbtnDepth.TabIndex = 0;
            this.rbtnDepth.TabStop = true;
            this.rbtnDepth.Text = "深度轴";
            this.rbtnDepth.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer
            // 
            this.toolStripContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(999, 544);
            this.toolStripContainer.Location = new System.Drawing.Point(3, 63);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(999, 569);
            this.toolStripContainer.TabIndex = 2;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gb_Left_Buttom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gb_Right_Buttom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gb_Right_Top, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gb_Left_Top, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(996, 541);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gb_Left_Buttom
            // 
            this.gb_Left_Buttom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Left_Buttom.Location = new System.Drawing.Point(3, 273);
            this.gb_Left_Buttom.Name = "gb_Left_Buttom";
            this.gb_Left_Buttom.Size = new System.Drawing.Size(492, 265);
            this.gb_Left_Buttom.TabIndex = 2;
            this.gb_Left_Buttom.TabStop = false;
            this.gb_Left_Buttom.Text = "扭矩";
            // 
            // gb_Right_Buttom
            // 
            this.gb_Right_Buttom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Right_Buttom.Location = new System.Drawing.Point(501, 273);
            this.gb_Right_Buttom.Name = "gb_Right_Buttom";
            this.gb_Right_Buttom.Size = new System.Drawing.Size(492, 265);
            this.gb_Right_Buttom.TabIndex = 3;
            this.gb_Right_Buttom.TabStop = false;
            this.gb_Right_Buttom.Text = "钻速";
            // 
            // gb_Right_Top
            // 
            this.gb_Right_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Right_Top.Location = new System.Drawing.Point(501, 3);
            this.gb_Right_Top.Name = "gb_Right_Top";
            this.gb_Right_Top.Size = new System.Drawing.Size(492, 264);
            this.gb_Right_Top.TabIndex = 1;
            this.gb_Right_Top.TabStop = false;
            this.gb_Right_Top.Text = "钻压";
            // 
            // gb_Left_Top
            // 
            this.gb_Left_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Left_Top.Location = new System.Drawing.Point(3, 3);
            this.gb_Left_Top.Name = "gb_Left_Top";
            this.gb_Left_Top.Size = new System.Drawing.Size(492, 264);
            this.gb_Left_Top.TabIndex = 0;
            this.gb_Left_Top.TabStop = false;
            this.gb_Left_Top.Text = "钻盘钻速";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnStart,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbtnStart
            // 
            this.tsbtnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStart.Image")));
            this.tsbtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStart.Name = "tsbtnStart";
            this.tsbtnStart.Size = new System.Drawing.Size(23, 22);
            this.tsbtnStart.Text = "toolStripButton1";
            this.tsbtnStart.Click += new System.EventHandler(this.tsbtnStart_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainContainer.BackgroundImage = global::Drilling.Properties.Resources._01;
            this.panelMainContainer.Controls.Add(this.tContainer);
            this.panelMainContainer.Location = new System.Drawing.Point(0, 28);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1031, 678);
            this.panelMainContainer.TabIndex = 0;
            // 
            // DrawFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::Drilling.Properties.Resources._01;
            this.ClientSize = new System.Drawing.Size(1031, 711);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawFrm";
            this.Text = "数据处理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DrawFrm_FormClosed);
            this.Resize += new System.EventHandler(this.DrawFrm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tContainer.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbTop.ResumeLayout(false);
            this.gbTop.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelMainContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccident;
        private System.Windows.Forms.ToolStripMenuItem tsmiAccident2;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.TabControl tContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_Left_Top;
        private System.Windows.Forms.GroupBox gbTop;
        private System.Windows.Forms.RadioButton rbtnTime;
        private System.Windows.Forms.RadioButton rbtnDepth;
        private System.Windows.Forms.GroupBox gb_Left_Buttom;
        private System.Windows.Forms.GroupBox gb_Right_Buttom;
        private System.Windows.Forms.GroupBox gb_Right_Top;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnStart;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}