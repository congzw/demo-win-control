﻿namespace DemoApp
{
    partial class MainForm
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
            this.btnSwitchFullScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwitchFullScreen
            // 
            this.btnSwitchFullScreen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSwitchFullScreen.Location = new System.Drawing.Point(0, 427);
            this.btnSwitchFullScreen.Name = "btnSwitchFullScreen";
            this.btnSwitchFullScreen.Size = new System.Drawing.Size(800, 23);
            this.btnSwitchFullScreen.TabIndex = 2;
            this.btnSwitchFullScreen.Text = "SwitchFullScreen";
            this.btnSwitchFullScreen.UseVisualStyleBackColor = true;
            this.btnSwitchFullScreen.Click += new System.EventHandler(this.btnSwitchFullScreen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitchFullScreen);
            this.Name = "MainForm";
            this.Text = "DemoApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchFullScreen;
    }
}

