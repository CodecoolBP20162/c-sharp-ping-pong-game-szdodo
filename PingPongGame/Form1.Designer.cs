namespace PingPongGame
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
            this.Floor = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Bat = new System.Windows.Forms.PictureBox();
            this.ScoreLabel1 = new System.Windows.Forms.Label();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            this.Ceiling = new System.Windows.Forms.PictureBox();
            this.LeftBorder = new System.Windows.Forms.PictureBox();
            this.RightBorder = new System.Windows.Forms.PictureBox();
            this.LvlLabel1 = new System.Windows.Forms.Label();
            this.LvlLabel2 = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.PictureBox();
            this.lvl2 = new System.Windows.Forms.PictureBox();
            this.lvl3 = new System.Windows.Forms.PictureBox();
            this.Explosion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ceiling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            this.SuspendLayout();
            // 
            // Floor
            // 
            this.Floor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Floor.Location = new System.Drawing.Point(-5, 396);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(846, 10);
            this.Floor.TabIndex = 2;
            this.Floor.TabStop = false;
            this.Floor.Visible = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(341, 134);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(31, 30);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // Bat
            // 
            this.Bat.BackColor = System.Drawing.Color.Transparent;
            this.Bat.Image = ((System.Drawing.Image)(resources.GetObject("Bat.Image")));
            this.Bat.Location = new System.Drawing.Point(276, 375);
            this.Bat.Name = "Bat";
            this.Bat.Size = new System.Drawing.Size(189, 22);
            this.Bat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bat.TabIndex = 0;
            this.Bat.TabStop = false;
            // 
            // ScoreLabel1
            // 
            this.ScoreLabel1.AutoSize = true;
            this.ScoreLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ScoreLabel1.Location = new System.Drawing.Point(692, 10);
            this.ScoreLabel1.Name = "ScoreLabel1";
            this.ScoreLabel1.Size = new System.Drawing.Size(70, 25);
            this.ScoreLabel1.TabIndex = 3;
            this.ScoreLabel1.Text = "Score:";
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScoreLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ScoreLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ScoreLabel2.Location = new System.Drawing.Point(799, 9);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(23, 25);
            this.ScoreLabel2.TabIndex = 4;
            this.ScoreLabel2.Text = "0";
            // 
            // Ceiling
            // 
            this.Ceiling.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ceiling.Location = new System.Drawing.Point(-5, -4);
            this.Ceiling.Name = "Ceiling";
            this.Ceiling.Size = new System.Drawing.Size(846, 11);
            this.Ceiling.TabIndex = 5;
            this.Ceiling.TabStop = false;
            this.Ceiling.Visible = false;
            // 
            // LeftBorder
            // 
            this.LeftBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftBorder.Location = new System.Drawing.Point(-6, -4);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(10, 401);
            this.LeftBorder.TabIndex = 6;
            this.LeftBorder.TabStop = false;
            this.LeftBorder.Visible = false;
            // 
            // RightBorder
            // 
            this.RightBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBorder.Location = new System.Drawing.Point(828, -4);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(13, 401);
            this.RightBorder.TabIndex = 7;
            this.RightBorder.TabStop = false;
            this.RightBorder.Visible = false;
            // 
            // LvlLabel1
            // 
            this.LvlLabel1.AutoSize = true;
            this.LvlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.LvlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LvlLabel1.ForeColor = System.Drawing.SystemColors.Info;
            this.LvlLabel1.Location = new System.Drawing.Point(10, 10);
            this.LvlLabel1.Name = "LvlLabel1";
            this.LvlLabel1.Size = new System.Drawing.Size(65, 25);
            this.LvlLabel1.TabIndex = 8;
            this.LvlLabel1.Text = "Level:";
            // 
            // LvlLabel2
            // 
            this.LvlLabel2.AutoSize = true;
            this.LvlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.LvlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LvlLabel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LvlLabel2.Location = new System.Drawing.Point(96, 10);
            this.LvlLabel2.Name = "LvlLabel2";
            this.LvlLabel2.Size = new System.Drawing.Size(23, 25);
            this.LvlLabel2.TabIndex = 4;
            this.LvlLabel2.Text = "1";
            // 
            // lvl1
            // 
            this.lvl1.BackColor = System.Drawing.Color.Transparent;
            this.lvl1.Image = ((System.Drawing.Image)(resources.GetObject("lvl1.Image")));
            this.lvl1.Location = new System.Drawing.Point(41, 49);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(61, 50);
            this.lvl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvl1.TabIndex = 9;
            this.lvl1.TabStop = false;
            // 
            // lvl2
            // 
            this.lvl2.BackColor = System.Drawing.Color.Transparent;
            this.lvl2.Image = ((System.Drawing.Image)(resources.GetObject("lvl2.Image")));
            this.lvl2.Location = new System.Drawing.Point(41, 49);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(76, 71);
            this.lvl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvl2.TabIndex = 10;
            this.lvl2.TabStop = false;
            // 
            // lvl3
            // 
            this.lvl3.BackColor = System.Drawing.Color.Transparent;
            this.lvl3.Image = ((System.Drawing.Image)(resources.GetObject("lvl3.Image")));
            this.lvl3.Location = new System.Drawing.Point(41, 49);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(74, 81);
            this.lvl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lvl3.TabIndex = 11;
            this.lvl3.TabStop = false;
            // 
            // Explosion
            // 
            this.Explosion.BackColor = System.Drawing.Color.Transparent;
            this.Explosion.Image = ((System.Drawing.Image)(resources.GetObject("Explosion.Image")));
            this.Explosion.Location = new System.Drawing.Point(10, 38);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(173, 140);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Explosion.TabIndex = 12;
            this.Explosion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 400);
            this.Controls.Add(this.Explosion);
            this.Controls.Add(this.lvl3);
            this.Controls.Add(this.lvl2);
            this.Controls.Add(this.lvl1);
            this.Controls.Add(this.LvlLabel2);
            this.Controls.Add(this.LvlLabel1);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.Ceiling);
            this.Controls.Add(this.ScoreLabel2);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.ScoreLabel1);
            this.Controls.Add(this.Floor);
            this.Controls.Add(this.Bat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ceiling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Floor;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Bat;
        private System.Windows.Forms.Label ScoreLabel1;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.PictureBox Ceiling;
        private System.Windows.Forms.PictureBox LeftBorder;
        private System.Windows.Forms.PictureBox RightBorder;
        private System.Windows.Forms.Label LvlLabel1;
        private System.Windows.Forms.Label LvlLabel2;
        private System.Windows.Forms.PictureBox lvl1;
        private System.Windows.Forms.PictureBox lvl2;
        private System.Windows.Forms.PictureBox lvl3;
        private System.Windows.Forms.PictureBox Explosion;
    }
}

