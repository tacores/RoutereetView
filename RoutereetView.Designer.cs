namespace RoutereetView
{
    partial class RoutereetView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxStreetView = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxAltitude = new System.Windows.Forms.PictureBox();
            this.buttonOpenKml = new System.Windows.Forms.Button();
            this.labelMaxAltitude = new System.Windows.Forms.Label();
            this.labelMinAltitude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStreetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStreetView
            // 
            this.pictureBoxStreetView.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxStreetView.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxStreetView.Name = "pictureBoxStreetView";
            this.pictureBoxStreetView.Size = new System.Drawing.Size(640, 400);
            this.pictureBoxStreetView.TabIndex = 0;
            this.pictureBoxStreetView.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1102, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "開く";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAltitude
            // 
            this.pictureBoxAltitude.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxAltitude.Location = new System.Drawing.Point(67, 429);
            this.pictureBoxAltitude.Name = "pictureBoxAltitude";
            this.pictureBoxAltitude.Size = new System.Drawing.Size(522, 129);
            this.pictureBoxAltitude.TabIndex = 3;
            this.pictureBoxAltitude.TabStop = false;
            this.pictureBoxAltitude.Click += new System.EventHandler(this.pictureBoxAltitude_Click);
            // 
            // buttonOpenKml
            // 
            this.buttonOpenKml.Location = new System.Drawing.Point(678, 12);
            this.buttonOpenKml.Name = "buttonOpenKml";
            this.buttonOpenKml.Size = new System.Drawing.Size(113, 41);
            this.buttonOpenKml.TabIndex = 4;
            this.buttonOpenKml.Text = "Open KML";
            this.buttonOpenKml.UseVisualStyleBackColor = true;
            this.buttonOpenKml.Click += new System.EventHandler(this.buttonOpenKml_Click);
            // 
            // labelMaxAltitude
            // 
            this.labelMaxAltitude.AutoSize = true;
            this.labelMaxAltitude.Location = new System.Drawing.Point(12, 429);
            this.labelMaxAltitude.Name = "labelMaxAltitude";
            this.labelMaxAltitude.Size = new System.Drawing.Size(0, 18);
            this.labelMaxAltitude.TabIndex = 5;
            this.labelMaxAltitude.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMinAltitude
            // 
            this.labelMinAltitude.AutoSize = true;
            this.labelMinAltitude.Location = new System.Drawing.Point(12, 540);
            this.labelMinAltitude.Name = "labelMinAltitude";
            this.labelMinAltitude.Size = new System.Drawing.Size(0, 18);
            this.labelMinAltitude.TabIndex = 6;
            this.labelMinAltitude.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // RoutereetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 583);
            this.Controls.Add(this.labelMinAltitude);
            this.Controls.Add(this.labelMaxAltitude);
            this.Controls.Add(this.buttonOpenKml);
            this.Controls.Add(this.pictureBoxAltitude);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxStreetView);
            this.Name = "RoutereetView";
            this.Text = "RoutereetView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStreetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStreetView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxAltitude;
        private System.Windows.Forms.Button buttonOpenKml;
        private System.Windows.Forms.Label labelMaxAltitude;
        private System.Windows.Forms.Label labelMinAltitude;
    }
}

