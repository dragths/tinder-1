namespace tinder_1
{
    partial class MainWindowMore
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
            pctGrey = new PictureBox();
            pctInfo = new PictureBox();
            btnPhoto = new Button();
            btnLike = new Button();
            btnDisLike = new Button();
            label1 = new Label();
            lbl = new Label();
            lblMusic = new Label();
            lblRelationship = new Label();
            lblMusicc = new Label();
            lblAboutme = new Label();
            ((System.ComponentModel.ISupportInitialize)pctGrey).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctInfo).BeginInit();
            SuspendLayout();
            // 
            // pctGrey
            // 
            pctGrey.BackColor = Color.Gainsboro;
            pctGrey.Location = new Point(186, 51);
            pctGrey.Name = "pctGrey";
            pctGrey.Size = new Size(516, 503);
            pctGrey.TabIndex = 0;
            pctGrey.TabStop = false;
            // 
            // pctInfo
            // 
            pctInfo.BackColor = SystemColors.ButtonHighlight;
            pctInfo.Location = new Point(215, 88);
            pctInfo.Name = "pctInfo";
            pctInfo.Size = new Size(466, 413);
            pctInfo.TabIndex = 1;
            pctInfo.TabStop = false;
            // 
            // btnPhoto
            // 
            btnPhoto.Location = new Point(215, 65);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(150, 29);
            btnPhoto.TabIndex = 2;
            btnPhoto.Text = "Фото";
            btnPhoto.UseVisualStyleBackColor = true;
            // 
            // btnLike
            // 
            btnLike.Location = new Point(503, 507);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(42, 29);
            btnLike.TabIndex = 3;
            btnLike.Text = ">";
            btnLike.UseVisualStyleBackColor = true;
            // 
            // btnDisLike
            // 
            btnDisLike.Location = new Point(342, 507);
            btnDisLike.Name = "btnDisLike";
            btnDisLike.Size = new Size(42, 29);
            btnDisLike.TabIndex = 4;
            btnDisLike.Text = "<";
            btnDisLike.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(215, 110);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = SystemColors.ControlLightLight;
            lbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl.Location = new Point(221, 110);
            lbl.Name = "lbl";
            lbl.Size = new Size(98, 25);
            lbl.TabIndex = 6;
            lbl.Text = "Увлечения";
            // 
            // lblMusic
            // 
            lblMusic.AutoSize = true;
            lblMusic.BackColor = SystemColors.ControlLightLight;
            lblMusic.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMusic.Location = new Point(440, 110);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(125, 25);
            lblMusic.TabIndex = 7;
            lblMusic.Text = "Жанр музыки";
            // 
            // lblRelationship
            // 
            lblRelationship.AutoSize = true;
            lblRelationship.BackColor = SystemColors.ControlLightLight;
            lblRelationship.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblRelationship.Location = new Point(221, 171);
            lblRelationship.Name = "lblRelationship";
            lblRelationship.Size = new Size(172, 25);
            lblRelationship.TabIndex = 8;
            lblRelationship.Text = "Вредные привычки";
            // 
            // lblMusicc
            // 
            lblMusicc.AutoSize = true;
            lblMusicc.BackColor = SystemColors.ControlLightLight;
            lblMusicc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblMusicc.Location = new Point(440, 176);
            lblMusicc.Name = "lblMusicc";
            lblMusicc.Size = new Size(137, 25);
            lblMusicc.TabIndex = 9;
            lblMusicc.Text = "Жанр фильмов";
            // 
            // lblAboutme
            // 
            lblAboutme.AutoSize = true;
            lblAboutme.BackColor = SystemColors.ControlLightLight;
            lblAboutme.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblAboutme.Location = new Point(221, 244);
            lblAboutme.Name = "lblAboutme";
            lblAboutme.Size = new Size(67, 25);
            lblAboutme.TabIndex = 10;
            lblAboutme.Text = "О себе";
            // 
            // MainWindowMore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 591);
            Controls.Add(lblAboutme);
            Controls.Add(lblMusicc);
            Controls.Add(lblRelationship);
            Controls.Add(lblMusic);
            Controls.Add(lbl);
            Controls.Add(label1);
            Controls.Add(btnDisLike);
            Controls.Add(btnLike);
            Controls.Add(btnPhoto);
            Controls.Add(pctInfo);
            Controls.Add(pctGrey);
            Name = "MainWindowMore";
            Text = "MainWindowMore";
            Load += MainWindowMore_Load;
            ((System.ComponentModel.ISupportInitialize)pctGrey).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctGrey;
        private PictureBox pctInfo;
        private Button btnPhoto;
        private Button btnLike;
        private Button btnDisLike;
        private Label label1;
        private Label lbl;
        private Label lblMusic;
        private Label lblRelationship;
        private Label lblMusicc;
        private Label lblAboutme;
    }
}