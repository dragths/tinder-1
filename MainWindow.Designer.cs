namespace tinder_1
{
    partial class MainWindow
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
            pctPink = new PictureBox();
            pctPhoto = new PictureBox();
            btnLike = new Button();
            btnDislike = new Button();
            btnMore = new Button();
            lblForYou = new Label();
            lnklblMyProfile = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pctPink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).BeginInit();
            SuspendLayout();
            // 
            // pctPink
            // 
            pctPink.BackColor = Color.MistyRose;
            pctPink.Location = new Point(206, 48);
            pctPink.Name = "pctPink";
            pctPink.Size = new Size(444, 465);
            pctPink.TabIndex = 0;
            pctPink.TabStop = false;
            // 
            // pctPhoto
            // 
            pctPhoto.BackColor = SystemColors.ControlLightLight;
            pctPhoto.Location = new Point(236, 85);
            pctPhoto.Name = "pctPhoto";
            pctPhoto.Size = new Size(382, 377);
            pctPhoto.TabIndex = 1;
            pctPhoto.TabStop = false;
            pctPhoto.Click += pctPhoto_Click;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(479, 468);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(41, 29);
            btnLike.TabIndex = 2;
            btnLike.Text = ">";
            btnLike.UseVisualStyleBackColor = true;
            // 
            // btnDislike
            // 
            btnDislike.Location = new Point(330, 468);
            btnDislike.Name = "btnDislike";
            btnDislike.Size = new Size(41, 29);
            btnDislike.TabIndex = 3;
            btnDislike.Text = "<";
            btnDislike.UseVisualStyleBackColor = true;
            // 
            // btnMore
            // 
            btnMore.Location = new Point(385, 50);
            btnMore.Name = "btnMore";
            btnMore.Size = new Size(135, 29);
            btnMore.TabIndex = 4;
            btnMore.Text = "Подробнее";
            btnMore.UseVisualStyleBackColor = true;
            // 
            // lblForYou
            // 
            lblForYou.AutoSize = true;
            lblForYou.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblForYou.Location = new Point(206, 17);
            lblForYou.Name = "lblForYou";
            lblForYou.Size = new Size(190, 28);
            lblForYou.TabIndex = 5;
            lblForYou.Text = "Подобрали для вас";
            // 
            // lnklblMyProfile
            // 
            lnklblMyProfile.AutoSize = true;
            lnklblMyProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lnklblMyProfile.LinkColor = Color.Black;
            lnklblMyProfile.Location = new Point(756, 9);
            lnklblMyProfile.Name = "lnklblMyProfile";
            lnklblMyProfile.Size = new Size(142, 28);
            lnklblMyProfile.TabIndex = 6;
            lnklblMyProfile.TabStop = true;
            lnklblMyProfile.Text = "Мой профиль";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 543);
            Controls.Add(lnklblMyProfile);
            Controls.Add(lblForYou);
            Controls.Add(btnMore);
            Controls.Add(btnDislike);
            Controls.Add(btnLike);
            Controls.Add(pctPhoto);
            Controls.Add(pctPink);
            Name = "MainWindow";
            Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)pctPink).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctPink;
        private PictureBox pctPhoto;
        private Button btnLike;
        private Button btnDislike;
        private Button btnMore;
        private Label lblForYou;
        private LinkLabel lnklblMyProfile;
    }
}