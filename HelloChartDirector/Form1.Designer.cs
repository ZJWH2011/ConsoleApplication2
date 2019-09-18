namespace HelloChartDirector
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
            this.winChartViewer1 = new ChartDirector.WinChartViewer();
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // winChartViewer1
            // 
            this.winChartViewer1.Location = new System.Drawing.Point(28, 27);
            this.winChartViewer1.Name = "winChartViewer1";
            this.winChartViewer1.Size = new System.Drawing.Size(894, 553);
            this.winChartViewer1.TabIndex = 0;
            this.winChartViewer1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 639);
            this.Controls.Add(this.winChartViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.winChartViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChartDirector.WinChartViewer winChartViewer1;
    }
}

