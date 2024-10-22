namespace good_or_bad
{
    partial class GoodBad
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
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblImageStatus = new System.Windows.Forms.Label();
            this.imgBad3 = new System.Windows.Forms.PictureBox();
            this.imgBad2 = new System.Windows.Forms.PictureBox();
            this.imgBad1 = new System.Windows.Forms.PictureBox();
            this.imgGood3 = new System.Windows.Forms.PictureBox();
            this.imgGood2 = new System.Windows.Forms.PictureBox();
            this.imgGood1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.Location = new System.Drawing.Point(124, 47);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(245, 93);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "The Good Button";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.Location = new System.Drawing.Point(426, 47);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(245, 93);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "The Bad Button";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(325, 16);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(152, 13);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "Click a Button. Choose Wisely.";
            // 
            // lblImageStatus
            // 
            this.lblImageStatus.AutoSize = true;
            this.lblImageStatus.Location = new System.Drawing.Point(341, 210);
            this.lblImageStatus.Name = "lblImageStatus";
            this.lblImageStatus.Size = new System.Drawing.Size(39, 13);
            this.lblImageStatus.TabIndex = 6;
            this.lblImageStatus.Text = "Image:";
            this.lblImageStatus.Visible = false;
            // 
            // imgBad3
            // 
            this.imgBad3.Image = global::good_or_bad.Properties.Resources.thwomp;
            this.imgBad3.Location = new System.Drawing.Point(328, 226);
            this.imgBad3.Name = "imgBad3";
            this.imgBad3.Size = new System.Drawing.Size(149, 151);
            this.imgBad3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad3.TabIndex = 9;
            this.imgBad3.TabStop = false;
            this.imgBad3.Visible = false;
            // 
            // imgBad2
            // 
            this.imgBad2.Image = global::good_or_bad.Properties.Resources.sad_worry_emoji_face_800_wht;
            this.imgBad2.Location = new System.Drawing.Point(328, 226);
            this.imgBad2.Name = "imgBad2";
            this.imgBad2.Size = new System.Drawing.Size(149, 151);
            this.imgBad2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad2.TabIndex = 8;
            this.imgBad2.TabStop = false;
            this.imgBad2.Visible = false;
            // 
            // imgBad1
            // 
            this.imgBad1.Image = global::good_or_bad.Properties.Resources.smiling_face_with_horns_emoji_2048x2048_gpbfyk8h;
            this.imgBad1.Location = new System.Drawing.Point(328, 226);
            this.imgBad1.Name = "imgBad1";
            this.imgBad1.Size = new System.Drawing.Size(149, 151);
            this.imgBad1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBad1.TabIndex = 7;
            this.imgBad1.TabStop = false;
            this.imgBad1.Visible = false;
            // 
            // imgGood3
            // 
            this.imgGood3.Image = global::good_or_bad.Properties.Resources.IceCreamCone;
            this.imgGood3.Location = new System.Drawing.Point(328, 226);
            this.imgGood3.Name = "imgGood3";
            this.imgGood3.Size = new System.Drawing.Size(149, 151);
            this.imgGood3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood3.TabIndex = 5;
            this.imgGood3.TabStop = false;
            this.imgGood3.Visible = false;
            // 
            // imgGood2
            // 
            this.imgGood2.Image = global::good_or_bad.Properties.Resources.happy;
            this.imgGood2.Location = new System.Drawing.Point(328, 226);
            this.imgGood2.Name = "imgGood2";
            this.imgGood2.Size = new System.Drawing.Size(149, 151);
            this.imgGood2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood2.TabIndex = 4;
            this.imgGood2.TabStop = false;
            this.imgGood2.Visible = false;
            // 
            // imgGood1
            // 
            this.imgGood1.Image = global::good_or_bad.Properties.Resources.monopoly;
            this.imgGood1.Location = new System.Drawing.Point(328, 226);
            this.imgGood1.Name = "imgGood1";
            this.imgGood1.Size = new System.Drawing.Size(149, 151);
            this.imgGood1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGood1.TabIndex = 3;
            this.imgGood1.TabStop = false;
            this.imgGood1.Visible = false;
            // 
            // GoodBad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgBad3);
            this.Controls.Add(this.imgBad2);
            this.Controls.Add(this.imgBad1);
            this.Controls.Add(this.lblImageStatus);
            this.Controls.Add(this.imgGood3);
            this.Controls.Add(this.imgGood2);
            this.Controls.Add(this.imgGood1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "GoodBad";
            this.Text = "The Program";
            ((System.ComponentModel.ISupportInitialize)(this.imgBad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGood1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.PictureBox imgGood1;
        private System.Windows.Forms.PictureBox imgGood2;
        private System.Windows.Forms.PictureBox imgGood3;
        private System.Windows.Forms.Label lblImageStatus;
        private System.Windows.Forms.PictureBox imgBad1;
        private System.Windows.Forms.PictureBox imgBad2;
        private System.Windows.Forms.PictureBox imgBad3;
    }
}

