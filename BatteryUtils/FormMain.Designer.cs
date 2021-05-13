using System.Windows.Forms;
using System.IO;

namespace BatteryUtils
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private string defaultConfigFilePath = "d:\\batteryUtils.conf";

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
            this.labelConfigFilePath = new System.Windows.Forms.Label();
            this.labelStartThreshold = new System.Windows.Forms.Label();
            this.labelStopThreshold = new System.Windows.Forms.Label();
            this.startThreshold = new System.Windows.Forms.NumericUpDown();
            this.stopThreshold = new System.Windows.Forms.NumericUpDown();
            this.monitorOFF = new System.Windows.Forms.Button();
            this.applyThreshold = new System.Windows.Forms.Button();
            this.configFilePath = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.startThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopThreshold)).BeginInit();
            this.SuspendLayout();

            // config file label
            this.labelConfigFilePath.AutoSize = true;
            this.labelConfigFilePath.Location = new System.Drawing.Point(15, 8);
            this.labelConfigFilePath.Name = "labelConfigFilePath";
            this.labelConfigFilePath.Size = new System.Drawing.Size(149, 12);
            this.labelConfigFilePath.TabIndex = 6;
            this.labelConfigFilePath.Text = "config file";

            // config file path text box
            this.configFilePath.Text = this.defaultConfigFilePath;
            this.configFilePath.Enabled = true;
            this.configFilePath.Location = new System.Drawing.Point(90, 5);
            this.configFilePath.Name = "config file path";
            this.configFilePath.Size = new System.Drawing.Size(155, 25);
            this.configFilePath.Multiline = false;
            this.configFilePath.MaxLength = (int)64;
            // 
            // labelStartThreshold
            // 
            this.labelStartThreshold.AutoSize = true;
            this.labelStartThreshold.Location = new System.Drawing.Point(15, 34);
            this.labelStartThreshold.Name = "labelStartThreshold";
            this.labelStartThreshold.Size = new System.Drawing.Size(149, 12);
            this.labelStartThreshold.TabIndex = 0;
            this.labelStartThreshold.Text = "start charge threshold %";
            // 
            // labelStopThreshold
            // 
            this.labelStopThreshold.AutoSize = true;
            this.labelStopThreshold.Location = new System.Drawing.Point(15, 61);
            this.labelStopThreshold.Name = "labelStopThreshold";
            this.labelStopThreshold.Size = new System.Drawing.Size(143, 12);
            this.labelStopThreshold.TabIndex = 1;
            this.labelStopThreshold.Text = "stop charge threshold %";
            // 
            // startThreshold
            // 
            this.startThreshold.Location = new System.Drawing.Point(175, 32);
            this.startThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startThreshold.Name = "startThreshold";
            this.startThreshold.Size = new System.Drawing.Size(70, 25);
            this.startThreshold.TabIndex = 2;
            this.startThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopThreshold
            // 
            this.stopThreshold.Location = new System.Drawing.Point(175, 59);
            this.stopThreshold.Minimum = this.startThreshold.Value;
            this.stopThreshold.Name = "stopThreshold";
            this.stopThreshold.Size = new System.Drawing.Size(70, 25);
            this.stopThreshold.TabIndex = 3;
            this.stopThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // monitorOFF
            // 
            this.monitorOFF.Location = new System.Drawing.Point(37, 86);
            this.monitorOFF.Name = "monitorOFF";
            this.monitorOFF.Size = new System.Drawing.Size(93, 34);
            this.monitorOFF.TabIndex = 4;
            this.monitorOFF.Text = "Monitor OFF";
            this.monitorOFF.UseVisualStyleBackColor = true;
            this.monitorOFF.Click += new System.EventHandler(this.monitorOFF_Click);
            // 
            // applyThreshold
            // 
            this.applyThreshold.Location = new System.Drawing.Point(136, 86);
            this.applyThreshold.Name = "applyThreshold";
            this.applyThreshold.Size = new System.Drawing.Size(102, 34);
            this.applyThreshold.TabIndex = 5;
            this.applyThreshold.Text = "Apply";
            this.applyThreshold.UseVisualStyleBackColor = true;
            this.applyThreshold.Click += new System.EventHandler(this.applyThreshold_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 141);
            this.Controls.Add(this.applyThreshold);
            this.Controls.Add(this.monitorOFF);
            this.Controls.Add(this.stopThreshold);
            this.Controls.Add(this.startThreshold);
            this.Controls.Add(this.labelStopThreshold);
            this.Controls.Add(this.labelStartThreshold);
            this.Controls.Add(this.labelConfigFilePath);
            this.Controls.Add(this.configFilePath);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Utils";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label labelConfigFilePath;

        #endregion

        private System.Windows.Forms.Label labelStartThreshold;
        private System.Windows.Forms.Label labelStopThreshold;
        private System.Windows.Forms.NumericUpDown startThreshold;
        private System.Windows.Forms.NumericUpDown stopThreshold;
        private System.Windows.Forms.Button monitorOFF;
        private System.Windows.Forms.Button applyThreshold;
        private TextBox configFilePath;
    }
}

