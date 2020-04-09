namespace A3FL_Support_Client
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.staticLabelApplicantName = new System.Windows.Forms.Label();
            this.inputSupportName = new System.Windows.Forms.TextBox();
            this.inputApplicantName = new System.Windows.Forms.TextBox();
            this.staticLabelSupportName = new System.Windows.Forms.Label();
            this.inputChooseResponse = new System.Windows.Forms.ComboBox();
            this.staticLabelResponse = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.staticLabelMsgPreview = new System.Windows.Forms.Label();
            this.labelMessagePreview = new System.Windows.Forms.Label();
            this.buttonActivityLogger = new System.Windows.Forms.Button();
            this.buttonActivityStats = new System.Windows.Forms.Button();
            this.buttonSupportManual = new System.Windows.Forms.Button();
            this.buttonApplicationProcess = new System.Windows.Forms.Button();
            this.buttonCivilianApps = new System.Windows.Forms.Button();
            this.buttonSupportRoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // staticLabelApplicantName
            // 
            this.staticLabelApplicantName.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelApplicantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelApplicantName.ForeColor = System.Drawing.Color.White;
            this.staticLabelApplicantName.Location = new System.Drawing.Point(24, 48);
            this.staticLabelApplicantName.Name = "staticLabelApplicantName";
            this.staticLabelApplicantName.Size = new System.Drawing.Size(420, 35);
            this.staticLabelApplicantName.TabIndex = 5;
            this.staticLabelApplicantName.Text = "Applicant Name";
            this.staticLabelApplicantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputSupportName
            // 
            this.inputSupportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputSupportName.Location = new System.Drawing.Point(24, 176);
            this.inputSupportName.Name = "inputSupportName";
            this.inputSupportName.Size = new System.Drawing.Size(420, 35);
            this.inputSupportName.TabIndex = 4;
            // 
            // inputApplicantName
            // 
            this.inputApplicantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.inputApplicantName.Location = new System.Drawing.Point(24, 88);
            this.inputApplicantName.Name = "inputApplicantName";
            this.inputApplicantName.Size = new System.Drawing.Size(408, 35);
            this.inputApplicantName.TabIndex = 3;
            // 
            // staticLabelSupportName
            // 
            this.staticLabelSupportName.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelSupportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelSupportName.ForeColor = System.Drawing.Color.White;
            this.staticLabelSupportName.Location = new System.Drawing.Point(24, 136);
            this.staticLabelSupportName.Name = "staticLabelSupportName";
            this.staticLabelSupportName.Size = new System.Drawing.Size(420, 35);
            this.staticLabelSupportName.TabIndex = 6;
            this.staticLabelSupportName.Text = "Your Name";
            this.staticLabelSupportName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputChooseResponse
            // 
            this.inputChooseResponse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputChooseResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.inputChooseResponse.FormattingEnabled = true;
            this.inputChooseResponse.Items.AddRange(new object[] {
            "Accepted",
            "ON HOLD - Forum/RP Name Dont Match",
            "ON HOLD - Famous/Fictional Name"});
            this.inputChooseResponse.Location = new System.Drawing.Point(24, 272);
            this.inputChooseResponse.Name = "inputChooseResponse";
            this.inputChooseResponse.Size = new System.Drawing.Size(420, 33);
            this.inputChooseResponse.TabIndex = 7;
            // 
            // staticLabelResponse
            // 
            this.staticLabelResponse.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.staticLabelResponse.ForeColor = System.Drawing.Color.White;
            this.staticLabelResponse.Location = new System.Drawing.Point(24, 232);
            this.staticLabelResponse.Name = "staticLabelResponse";
            this.staticLabelResponse.Size = new System.Drawing.Size(420, 35);
            this.staticLabelResponse.TabIndex = 8;
            this.staticLabelResponse.Text = "Response";
            this.staticLabelResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonGenerate.Location = new System.Drawing.Point(56, 832);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(175, 75);
            this.buttonGenerate.TabIndex = 9;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.Transparent;
            this.buttonCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCopy.Location = new System.Drawing.Point(288, 832);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(175, 75);
            this.buttonCopy.TabIndex = 10;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(56, 936);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(408, 75);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "CLEAR INPUT DATA";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // staticLabelMsgPreview
            // 
            this.staticLabelMsgPreview.BackColor = System.Drawing.Color.Transparent;
            this.staticLabelMsgPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staticLabelMsgPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.staticLabelMsgPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.staticLabelMsgPreview.Location = new System.Drawing.Point(1216, 16);
            this.staticLabelMsgPreview.Name = "staticLabelMsgPreview";
            this.staticLabelMsgPreview.Size = new System.Drawing.Size(680, 32);
            this.staticLabelMsgPreview.TabIndex = 13;
            this.staticLabelMsgPreview.Text = "Message Preview";
            this.staticLabelMsgPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMessagePreview
            // 
            this.labelMessagePreview.BackColor = System.Drawing.Color.Transparent;
            this.labelMessagePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelMessagePreview.Location = new System.Drawing.Point(520, 16);
            this.labelMessagePreview.Name = "labelMessagePreview";
            this.labelMessagePreview.Size = new System.Drawing.Size(1376, 464);
            this.labelMessagePreview.TabIndex = 12;
            this.labelMessagePreview.Text = " ";
            // 
            // buttonActivityLogger
            // 
            this.buttonActivityLogger.BackColor = System.Drawing.Color.Transparent;
            this.buttonActivityLogger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivityLogger.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonActivityLogger.Location = new System.Drawing.Point(520, 936);
            this.buttonActivityLogger.Name = "buttonActivityLogger";
            this.buttonActivityLogger.Size = new System.Drawing.Size(175, 75);
            this.buttonActivityLogger.TabIndex = 14;
            this.buttonActivityLogger.Text = "Activity Log Form";
            this.buttonActivityLogger.UseVisualStyleBackColor = false;
            this.buttonActivityLogger.Click += new System.EventHandler(this.buttonActivityLogger_Click);
            // 
            // buttonActivityStats
            // 
            this.buttonActivityStats.BackColor = System.Drawing.Color.Transparent;
            this.buttonActivityStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActivityStats.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonActivityStats.Location = new System.Drawing.Point(752, 936);
            this.buttonActivityStats.Name = "buttonActivityStats";
            this.buttonActivityStats.Size = new System.Drawing.Size(175, 75);
            this.buttonActivityStats.TabIndex = 15;
            this.buttonActivityStats.Text = "Activity Stats";
            this.buttonActivityStats.UseVisualStyleBackColor = false;
            this.buttonActivityStats.Click += new System.EventHandler(this.buttonActivityStats_Click);
            // 
            // buttonSupportManual
            // 
            this.buttonSupportManual.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupportManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupportManual.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonSupportManual.Location = new System.Drawing.Point(1448, 936);
            this.buttonSupportManual.Name = "buttonSupportManual";
            this.buttonSupportManual.Size = new System.Drawing.Size(175, 75);
            this.buttonSupportManual.TabIndex = 17;
            this.buttonSupportManual.Text = "Support Manual";
            this.buttonSupportManual.UseVisualStyleBackColor = false;
            this.buttonSupportManual.Click += new System.EventHandler(this.buttonSupportManual_Click);
            // 
            // buttonApplicationProcess
            // 
            this.buttonApplicationProcess.BackColor = System.Drawing.Color.Transparent;
            this.buttonApplicationProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplicationProcess.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonApplicationProcess.Location = new System.Drawing.Point(984, 936);
            this.buttonApplicationProcess.Name = "buttonApplicationProcess";
            this.buttonApplicationProcess.Size = new System.Drawing.Size(175, 75);
            this.buttonApplicationProcess.TabIndex = 16;
            this.buttonApplicationProcess.Text = "Application Process";
            this.buttonApplicationProcess.UseVisualStyleBackColor = false;
            this.buttonApplicationProcess.Click += new System.EventHandler(this.buttonApplicationProcess_Click);
            // 
            // buttonCivilianApps
            // 
            this.buttonCivilianApps.BackColor = System.Drawing.Color.Transparent;
            this.buttonCivilianApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCivilianApps.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonCivilianApps.Location = new System.Drawing.Point(1216, 936);
            this.buttonCivilianApps.Name = "buttonCivilianApps";
            this.buttonCivilianApps.Size = new System.Drawing.Size(175, 75);
            this.buttonCivilianApps.TabIndex = 18;
            this.buttonCivilianApps.Text = "Civilian Applications";
            this.buttonCivilianApps.UseVisualStyleBackColor = false;
            this.buttonCivilianApps.Click += new System.EventHandler(this.buttonCivilianApps_Click);
            // 
            // buttonSupportRoster
            // 
            this.buttonSupportRoster.BackColor = System.Drawing.Color.Transparent;
            this.buttonSupportRoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupportRoster.ForeColor = System.Drawing.Color.BlueViolet;
            this.buttonSupportRoster.Location = new System.Drawing.Point(1680, 936);
            this.buttonSupportRoster.Name = "buttonSupportRoster";
            this.buttonSupportRoster.Size = new System.Drawing.Size(175, 75);
            this.buttonSupportRoster.TabIndex = 19;
            this.buttonSupportRoster.Text = "Support Roster";
            this.buttonSupportRoster.UseVisualStyleBackColor = false;
            this.buttonSupportRoster.Click += new System.EventHandler(this.buttonSupportRoster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A3FL_Support_Client.Properties.Resources.Yt_Ban;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1038);
            this.Controls.Add(this.buttonSupportRoster);
            this.Controls.Add(this.buttonCivilianApps);
            this.Controls.Add(this.buttonSupportManual);
            this.Controls.Add(this.buttonApplicationProcess);
            this.Controls.Add(this.buttonActivityStats);
            this.Controls.Add(this.buttonActivityLogger);
            this.Controls.Add(this.staticLabelMsgPreview);
            this.Controls.Add(this.labelMessagePreview);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.staticLabelResponse);
            this.Controls.Add(this.inputChooseResponse);
            this.Controls.Add(this.staticLabelSupportName);
            this.Controls.Add(this.staticLabelApplicantName);
            this.Controls.Add(this.inputSupportName);
            this.Controls.Add(this.inputApplicantName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Arna 3 Fishers Life Support Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staticLabelApplicantName;
        private System.Windows.Forms.TextBox inputSupportName;
        private System.Windows.Forms.TextBox inputApplicantName;
        private System.Windows.Forms.Label staticLabelSupportName;
        private System.Windows.Forms.ComboBox inputChooseResponse;
        private System.Windows.Forms.Label staticLabelResponse;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label staticLabelMsgPreview;
        private System.Windows.Forms.Label labelMessagePreview;
        private System.Windows.Forms.Button buttonActivityLogger;
        private System.Windows.Forms.Button buttonActivityStats;
        private System.Windows.Forms.Button buttonSupportManual;
        private System.Windows.Forms.Button buttonApplicationProcess;
        private System.Windows.Forms.Button buttonCivilianApps;
        private System.Windows.Forms.Button buttonSupportRoster;
    }
}

