namespace FlappyBirdGame
{
    partial class FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.PictureBoxCloud1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxPipeDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.pictureBoxBird = new System.Windows.Forms.PictureBox();
            this.PictureBoxCloud2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCloud2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.NavajoWhite;
            this.labelScore.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.DarkRed;
            this.labelScore.Location = new System.Drawing.Point(361, 540);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(121, 34);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score : 0";
            // 
            // PictureBoxCloud1
            // 
            this.PictureBoxCloud1.Image = global::FlappyBirdGame.Properties.Resources.clouds_png_23422;
            this.PictureBoxCloud1.Location = new System.Drawing.Point(743, 89);
            this.PictureBoxCloud1.Name = "PictureBoxCloud1";
            this.PictureBoxCloud1.Size = new System.Drawing.Size(220, 153);
            this.PictureBoxCloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCloud1.TabIndex = 8;
            this.PictureBoxCloud1.TabStop = false;
            // 
            // pictureBoxPipeUp3
            // 
            this.pictureBoxPipeUp3.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pictureBoxPipeUp3.Location = new System.Drawing.Point(12, 405);
            this.pictureBoxPipeUp3.Name = "pictureBoxPipeUp3";
            this.pictureBoxPipeUp3.Size = new System.Drawing.Size(140, 81);
            this.pictureBoxPipeUp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeUp3.TabIndex = 7;
            this.pictureBoxPipeUp3.TabStop = false;
            // 
            // pictureBoxPipeUp2
            // 
            this.pictureBoxPipeUp2.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pictureBoxPipeUp2.Location = new System.Drawing.Point(801, 279);
            this.pictureBoxPipeUp2.Name = "pictureBoxPipeUp2";
            this.pictureBoxPipeUp2.Size = new System.Drawing.Size(140, 207);
            this.pictureBoxPipeUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeUp2.TabIndex = 6;
            this.pictureBoxPipeUp2.TabStop = false;
            // 
            // pictureBoxPipeDown2
            // 
            this.pictureBoxPipeDown2.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pictureBoxPipeDown2.Location = new System.Drawing.Point(258, 0);
            this.pictureBoxPipeDown2.Name = "pictureBoxPipeDown2";
            this.pictureBoxPipeDown2.Size = new System.Drawing.Size(140, 125);
            this.pictureBoxPipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeDown2.TabIndex = 5;
            this.pictureBoxPipeDown2.TabStop = false;
            // 
            // pictureBoxPipeUp
            // 
            this.pictureBoxPipeUp.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pictureBoxPipeUp.Location = new System.Drawing.Point(327, 338);
            this.pictureBoxPipeUp.Name = "pictureBoxPipeUp";
            this.pictureBoxPipeUp.Size = new System.Drawing.Size(140, 148);
            this.pictureBoxPipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeUp.TabIndex = 3;
            this.pictureBoxPipeUp.TabStop = false;
            // 
            // pictureBoxPipeDown
            // 
            this.pictureBoxPipeDown.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pictureBoxPipeDown.Location = new System.Drawing.Point(607, 0);
            this.pictureBoxPipeDown.Name = "pictureBoxPipeDown";
            this.pictureBoxPipeDown.Size = new System.Drawing.Size(140, 184);
            this.pictureBoxPipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPipeDown.TabIndex = 2;
            this.pictureBoxPipeDown.TabStop = false;
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.Image = global::FlappyBirdGame.Properties.Resources.ground;
            this.pictureBoxGround.Location = new System.Drawing.Point(1, 483);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(993, 109);
            this.pictureBoxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGround.TabIndex = 1;
            this.pictureBoxGround.TabStop = false;
            // 
            // pictureBoxBird
            // 
            this.pictureBoxBird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.pictureBoxBird.Location = new System.Drawing.Point(21, 89);
            this.pictureBoxBird.Name = "pictureBoxBird";
            this.pictureBoxBird.Size = new System.Drawing.Size(64, 61);
            this.pictureBoxBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBird.TabIndex = 0;
            this.pictureBoxBird.TabStop = false;
            // 
            // PictureBoxCloud2
            // 
            this.PictureBoxCloud2.Image = global::FlappyBirdGame.Properties.Resources.clouds_png_23422;
            this.PictureBoxCloud2.Location = new System.Drawing.Point(127, 51);
            this.PictureBoxCloud2.Name = "PictureBoxCloud2";
            this.PictureBoxCloud2.Size = new System.Drawing.Size(125, 112);
            this.PictureBoxCloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCloud2.TabIndex = 9;
            this.PictureBoxCloud2.TabStop = false;
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(994, 593);
            this.Controls.Add(this.pictureBoxPipeUp3);
            this.Controls.Add(this.pictureBoxPipeUp2);
            this.Controls.Add(this.pictureBoxPipeDown2);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxPipeUp);
            this.Controls.Add(this.pictureBoxPipeDown);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBoxBird);
            this.Controls.Add(this.PictureBoxCloud1);
            this.Controls.Add(this.PictureBoxCloud2);
            this.Name = "FlappyBird";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FlappyBird_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCloud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBird;
        private System.Windows.Forms.PictureBox pictureBoxGround;
        private System.Windows.Forms.PictureBox pictureBoxPipeDown;
        private System.Windows.Forms.PictureBox pictureBoxPipeUp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBoxPipeDown2;
        private System.Windows.Forms.PictureBox pictureBoxPipeUp2;
        private System.Windows.Forms.PictureBox pictureBoxPipeUp3;
        private System.Windows.Forms.PictureBox PictureBoxCloud1;
        private System.Windows.Forms.PictureBox PictureBoxCloud2;
    }
}

