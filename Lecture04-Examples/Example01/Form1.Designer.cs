namespace Example01
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.scenepictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scenepictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yesButton.Location = new System.Drawing.Point(12, 513);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(245, 54);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "我選1";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.noButton.Location = new System.Drawing.Point(263, 513);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(248, 54);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "我選2";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // scenepictureBox
            // 
            this.scenepictureBox.Image = global::Example01.Properties.Resources._1;
            this.scenepictureBox.Location = new System.Drawing.Point(12, 3);
            this.scenepictureBox.Name = "scenepictureBox";
            this.scenepictureBox.Size = new System.Drawing.Size(499, 504);
            this.scenepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scenepictureBox.TabIndex = 0;
            this.scenepictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 576);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.scenepictureBox);
            this.Name = "Form1";
            this.Text = "上班族心事蝦狼災";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scenepictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scenepictureBox;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}

