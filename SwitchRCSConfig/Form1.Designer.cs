namespace SwitchRCSConfig
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttbSourcePath = new System.Windows.Forms.TextBox();
            this.ttbDestPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttbCurrentPath = new System.Windows.Forms.TextBox();
            this.lblCurrentLoadedConfig = new System.Windows.Forms.Label();
            this.lblCurrentWeapon = new System.Windows.Forms.Label();
            this.ttbWeaponConfigPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLoadWeaponConfig = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblMainWeaponTitle = new System.Windows.Forms.Label();
            this.lblSecWeaponTitle = new System.Windows.Forms.Label();
            this.lblMainWeaponText = new System.Windows.Forms.Label();
            this.lblSecWeaponText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "當前執行檔目錄";
            // 
            // ttbSourcePath
            // 
            this.ttbSourcePath.Location = new System.Drawing.Point(115, 68);
            this.ttbSourcePath.Name = "ttbSourcePath";
            this.ttbSourcePath.Size = new System.Drawing.Size(663, 22);
            this.ttbSourcePath.TabIndex = 2;
            this.ttbSourcePath.TextChanged += new System.EventHandler(this.ttbSourcePath_TextChanged);
            // 
            // ttbDestPath
            // 
            this.ttbDestPath.Location = new System.Drawing.Point(115, 96);
            this.ttbDestPath.Name = "ttbDestPath";
            this.ttbDestPath.Size = new System.Drawing.Size(663, 22);
            this.ttbDestPath.TabIndex = 3;
            this.ttbDestPath.TextChanged += new System.EventHandler(this.ttbDestPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "設定檔案目錄";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "取代設定目錄";
            // 
            // ttbCurrentPath
            // 
            this.ttbCurrentPath.Location = new System.Drawing.Point(115, 40);
            this.ttbCurrentPath.Name = "ttbCurrentPath";
            this.ttbCurrentPath.ReadOnly = true;
            this.ttbCurrentPath.Size = new System.Drawing.Size(663, 22);
            this.ttbCurrentPath.TabIndex = 6;
            // 
            // lblCurrentLoadedConfig
            // 
            this.lblCurrentLoadedConfig.AutoSize = true;
            this.lblCurrentLoadedConfig.Location = new System.Drawing.Point(249, 23);
            this.lblCurrentLoadedConfig.Name = "lblCurrentLoadedConfig";
            this.lblCurrentLoadedConfig.Size = new System.Drawing.Size(137, 12);
            this.lblCurrentLoadedConfig.TabIndex = 7;
            this.lblCurrentLoadedConfig.Text = "當前讀取的人物設定檔：";
            // 
            // lblCurrentWeapon
            // 
            this.lblCurrentWeapon.AutoSize = true;
            this.lblCurrentWeapon.Location = new System.Drawing.Point(473, 23);
            this.lblCurrentWeapon.Name = "lblCurrentWeapon";
            this.lblCurrentWeapon.Size = new System.Drawing.Size(0, 12);
            this.lblCurrentWeapon.TabIndex = 8;
            // 
            // ttbWeaponConfigPath
            // 
            this.ttbWeaponConfigPath.Location = new System.Drawing.Point(115, 124);
            this.ttbWeaponConfigPath.Name = "ttbWeaponConfigPath";
            this.ttbWeaponConfigPath.Size = new System.Drawing.Size(663, 22);
            this.ttbWeaponConfigPath.TabIndex = 9;
            this.ttbWeaponConfigPath.TextChanged += new System.EventHandler(this.ttbWeaponConfigPath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "武器設定目錄";
            // 
            // btnLoadWeaponConfig
            // 
            this.btnLoadWeaponConfig.Location = new System.Drawing.Point(319, 152);
            this.btnLoadWeaponConfig.Name = "btnLoadWeaponConfig";
            this.btnLoadWeaponConfig.Size = new System.Drawing.Size(128, 23);
            this.btnLoadWeaponConfig.TabIndex = 11;
            this.btnLoadWeaponConfig.Text = "讀取武器設定檔";
            this.btnLoadWeaponConfig.UseVisualStyleBackColor = true;
            this.btnLoadWeaponConfig.Click += new System.EventHandler(this.btnLoadWeaponConfig_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblMainWeaponTitle
            // 
            this.lblMainWeaponTitle.AutoSize = true;
            this.lblMainWeaponTitle.Location = new System.Drawing.Point(453, 157);
            this.lblMainWeaponTitle.Name = "lblMainWeaponTitle";
            this.lblMainWeaponTitle.Size = new System.Drawing.Size(29, 12);
            this.lblMainWeaponTitle.TabIndex = 12;
            this.lblMainWeaponTitle.Text = "主：";
            // 
            // lblSecWeaponTitle
            // 
            this.lblSecWeaponTitle.AutoSize = true;
            this.lblSecWeaponTitle.Location = new System.Drawing.Point(609, 157);
            this.lblSecWeaponTitle.Name = "lblSecWeaponTitle";
            this.lblSecWeaponTitle.Size = new System.Drawing.Size(29, 12);
            this.lblSecWeaponTitle.TabIndex = 13;
            this.lblSecWeaponTitle.Text = "副：";
            // 
            // lblMainWeaponText
            // 
            this.lblMainWeaponText.AutoSize = true;
            this.lblMainWeaponText.Location = new System.Drawing.Point(473, 157);
            this.lblMainWeaponText.Name = "lblMainWeaponText";
            this.lblMainWeaponText.Size = new System.Drawing.Size(0, 12);
            this.lblMainWeaponText.TabIndex = 14;
            // 
            // lblSecWeaponText
            // 
            this.lblSecWeaponText.AutoSize = true;
            this.lblSecWeaponText.Location = new System.Drawing.Point(633, 157);
            this.lblSecWeaponText.Name = "lblSecWeaponText";
            this.lblSecWeaponText.Size = new System.Drawing.Size(0, 12);
            this.lblSecWeaponText.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 189);
            this.Controls.Add(this.lblSecWeaponText);
            this.Controls.Add(this.lblMainWeaponText);
            this.Controls.Add(this.lblSecWeaponTitle);
            this.Controls.Add(this.lblMainWeaponTitle);
            this.Controls.Add(this.btnLoadWeaponConfig);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttbWeaponConfigPath);
            this.Controls.Add(this.lblCurrentWeapon);
            this.Controls.Add(this.lblCurrentLoadedConfig);
            this.Controls.Add(this.ttbCurrentPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttbDestPath);
            this.Controls.Add(this.ttbSourcePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttbSourcePath;
        private System.Windows.Forms.TextBox ttbDestPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttbCurrentPath;
        private System.Windows.Forms.Label lblCurrentLoadedConfig;
        private System.Windows.Forms.Label lblCurrentWeapon;
        private System.Windows.Forms.TextBox ttbWeaponConfigPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLoadWeaponConfig;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblMainWeaponTitle;
        private System.Windows.Forms.Label lblSecWeaponTitle;
        private System.Windows.Forms.Label lblMainWeaponText;
        private System.Windows.Forms.Label lblSecWeaponText;
    }
}

