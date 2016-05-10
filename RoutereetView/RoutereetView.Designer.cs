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
            this.pictureBoxAltitude = new System.Windows.Forms.PictureBox();
            this.buttonOpenKml = new System.Windows.Forms.Button();
            this.labelMaxAltitude = new System.Windows.Forms.Label();
            this.labelMinAltitude = new System.Windows.Forms.Label();
            this.buttonGoAhead = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.buttonTurnLeft = new System.Windows.Forms.Button();
            this.buttonTrunRight = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStreetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxStreetView
            // 
            this.pictureBoxStreetView.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxStreetView.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxStreetView.Name = "pictureBoxStreetView";
            this.pictureBoxStreetView.Size = new System.Drawing.Size(630, 420);
            this.pictureBoxStreetView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStreetView.TabIndex = 0;
            this.pictureBoxStreetView.TabStop = false;
            // 
            // pictureBoxAltitude
            // 
            this.pictureBoxAltitude.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxAltitude.Location = new System.Drawing.Point(664, 518);
            this.pictureBoxAltitude.Name = "pictureBoxAltitude";
            this.pictureBoxAltitude.Size = new System.Drawing.Size(487, 172);
            this.pictureBoxAltitude.TabIndex = 3;
            this.pictureBoxAltitude.TabStop = false;
            this.pictureBoxAltitude.Click += new System.EventHandler(this.pictureBoxAltitude_Click);
            // 
            // buttonOpenKml
            // 
            this.buttonOpenKml.Location = new System.Drawing.Point(1172, 12);
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
            this.labelMaxAltitude.Location = new System.Drawing.Point(1169, 518);
            this.labelMaxAltitude.Name = "labelMaxAltitude";
            this.labelMaxAltitude.Size = new System.Drawing.Size(0, 18);
            this.labelMaxAltitude.TabIndex = 5;
            this.labelMaxAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMinAltitude
            // 
            this.labelMinAltitude.AutoSize = true;
            this.labelMinAltitude.Location = new System.Drawing.Point(1169, 672);
            this.labelMinAltitude.Name = "labelMinAltitude";
            this.labelMinAltitude.Size = new System.Drawing.Size(0, 18);
            this.labelMinAltitude.TabIndex = 6;
            this.labelMinAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonGoAhead
            // 
            this.buttonGoAhead.Enabled = false;
            this.buttonGoAhead.Location = new System.Drawing.Point(245, 478);
            this.buttonGoAhead.Name = "buttonGoAhead";
            this.buttonGoAhead.Size = new System.Drawing.Size(103, 43);
            this.buttonGoAhead.TabIndex = 7;
            this.buttonGoAhead.Text = "進む";
            this.buttonGoAhead.UseVisualStyleBackColor = true;
            this.buttonGoAhead.Click += new System.EventHandler(this.buttonGoAhead_Click);
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Enabled = false;
            this.buttonGoBack.Location = new System.Drawing.Point(245, 614);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(103, 43);
            this.buttonGoBack.TabIndex = 8;
            this.buttonGoBack.Text = "戻る";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // buttonTurnLeft
            // 
            this.buttonTurnLeft.Enabled = false;
            this.buttonTurnLeft.Location = new System.Drawing.Point(75, 539);
            this.buttonTurnLeft.Name = "buttonTurnLeft";
            this.buttonTurnLeft.Size = new System.Drawing.Size(103, 43);
            this.buttonTurnLeft.TabIndex = 9;
            this.buttonTurnLeft.Text = "左45度";
            this.buttonTurnLeft.UseVisualStyleBackColor = true;
            this.buttonTurnLeft.Click += new System.EventHandler(this.buttonTurnLeft_Click);
            // 
            // buttonTrunRight
            // 
            this.buttonTrunRight.Enabled = false;
            this.buttonTrunRight.Location = new System.Drawing.Point(402, 539);
            this.buttonTrunRight.Name = "buttonTrunRight";
            this.buttonTrunRight.Size = new System.Drawing.Size(103, 43);
            this.buttonTrunRight.TabIndex = 10;
            this.buttonTrunRight.Text = "右45度";
            this.buttonTrunRight.UseVisualStyleBackColor = true;
            this.buttonTrunRight.Click += new System.EventHandler(this.buttonTrunRight_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxMap.Location = new System.Drawing.Point(664, 12);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(487, 487);
            this.pictureBoxMap.TabIndex = 11;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseClick);
            // 
            // RoutereetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 723);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.buttonTrunRight);
            this.Controls.Add(this.buttonTurnLeft);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonGoAhead);
            this.Controls.Add(this.labelMinAltitude);
            this.Controls.Add(this.labelMaxAltitude);
            this.Controls.Add(this.buttonOpenKml);
            this.Controls.Add(this.pictureBoxAltitude);
            this.Controls.Add(this.pictureBoxStreetView);
            this.Name = "RoutereetView";
            this.Text = "RoutereetView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStreetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStreetView;
        private System.Windows.Forms.PictureBox pictureBoxAltitude;
        private System.Windows.Forms.Button buttonOpenKml;
        private System.Windows.Forms.Label labelMaxAltitude;
        private System.Windows.Forms.Label labelMinAltitude;
        private System.Windows.Forms.Button buttonGoAhead;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.Button buttonTurnLeft;
        private System.Windows.Forms.Button buttonTrunRight;
        private System.Windows.Forms.PictureBox pictureBoxMap;
    }
}

