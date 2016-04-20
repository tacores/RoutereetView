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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBoxAltitude = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStreetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 418);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(640, 69);
            this.trackBar1.TabIndex = 2;
            // 
            // pictureBoxAltitude
            // 
            this.pictureBoxAltitude.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxAltitude.Location = new System.Drawing.Point(12, 493);
            this.pictureBoxAltitude.Name = "pictureBoxAltitude";
            this.pictureBoxAltitude.Size = new System.Drawing.Size(640, 129);
            this.pictureBoxAltitude.TabIndex = 3;
            this.pictureBoxAltitude.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open KML";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RoutereetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 634);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxAltitude);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxStreetView);
            this.Name = "RoutereetView";
            this.Text = "RoutereetView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStreetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStreetView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBoxAltitude;
        private System.Windows.Forms.Button button2;
    }
}

