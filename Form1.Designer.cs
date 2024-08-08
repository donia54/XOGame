namespace XOProject
{
    partial class frmXOGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTurn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pbX0Y0 = new System.Windows.Forms.PictureBox();
            this.pbX1Y0 = new System.Windows.Forms.PictureBox();
            this.pbX2Y0 = new System.Windows.Forms.PictureBox();
            this.pbX0Y1 = new System.Windows.Forms.PictureBox();
            this.pbX1Y1 = new System.Windows.Forms.PictureBox();
            this.pbX2Y1 = new System.Windows.Forms.PictureBox();
            this.pbX0Y2 = new System.Windows.Forms.PictureBox();
            this.pbX2Y2 = new System.Windows.Forms.PictureBox();
            this.pbX1Y2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbX0Y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX1Y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX2Y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX0Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX1Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX2Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX0Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX2Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX1Y2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(56, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Turn";
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.ForeColor = System.Drawing.Color.White;
            this.lbTurn.Location = new System.Drawing.Point(36, 125);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(138, 48);
            this.lbTurn.TabIndex = 1;
            this.lbTurn.Text = "Player1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Winner";
            // 
            // lbWinner
            // 
            this.lbWinner.AutoSize = true;
            this.lbWinner.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbWinner.Location = new System.Drawing.Point(12, 262);
            this.lbWinner.Name = "lbWinner";
            this.lbWinner.Size = new System.Drawing.Size(207, 48);
            this.lbWinner.TabIndex = 3;
            this.lbWinner.Tag = "5";
            this.lbWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Black;
            this.btnRestart.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.White;
            this.btnRestart.Location = new System.Drawing.Point(20, 329);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(176, 62);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "Restat Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbHeader.Location = new System.Drawing.Point(447, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(328, 53);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "Tic-Tac-toe Game";
            // 
            // pbX0Y0
            // 
            this.pbX0Y0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX0Y0.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX0Y0.Location = new System.Drawing.Point(342, 95);
            this.pbX0Y0.Name = "pbX0Y0";
            this.pbX0Y0.Size = new System.Drawing.Size(140, 88);
            this.pbX0Y0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX0Y0.TabIndex = 7;
            this.pbX0Y0.TabStop = false;
            this.pbX0Y0.Tag = "?";
            this.pbX0Y0.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX1Y0
            // 
            this.pbX1Y0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX1Y0.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX1Y0.Location = new System.Drawing.Point(342, 227);
            this.pbX1Y0.Name = "pbX1Y0";
            this.pbX1Y0.Size = new System.Drawing.Size(140, 88);
            this.pbX1Y0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX1Y0.TabIndex = 8;
            this.pbX1Y0.TabStop = false;
            this.pbX1Y0.Tag = "?";
            this.pbX1Y0.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX2Y0
            // 
            this.pbX2Y0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX2Y0.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX2Y0.Location = new System.Drawing.Point(342, 359);
            this.pbX2Y0.Name = "pbX2Y0";
            this.pbX2Y0.Size = new System.Drawing.Size(140, 88);
            this.pbX2Y0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX2Y0.TabIndex = 9;
            this.pbX2Y0.TabStop = false;
            this.pbX2Y0.Tag = "?";
            this.pbX2Y0.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX0Y1
            // 
            this.pbX0Y1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX0Y1.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX0Y1.Location = new System.Drawing.Point(552, 95);
            this.pbX0Y1.Name = "pbX0Y1";
            this.pbX0Y1.Size = new System.Drawing.Size(140, 88);
            this.pbX0Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX0Y1.TabIndex = 10;
            this.pbX0Y1.TabStop = false;
            this.pbX0Y1.Tag = "?";
            this.pbX0Y1.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX1Y1
            // 
            this.pbX1Y1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX1Y1.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX1Y1.Location = new System.Drawing.Point(551, 227);
            this.pbX1Y1.Name = "pbX1Y1";
            this.pbX1Y1.Size = new System.Drawing.Size(140, 88);
            this.pbX1Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX1Y1.TabIndex = 11;
            this.pbX1Y1.TabStop = false;
            this.pbX1Y1.Tag = "?";
            this.pbX1Y1.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX2Y1
            // 
            this.pbX2Y1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX2Y1.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX2Y1.Location = new System.Drawing.Point(551, 359);
            this.pbX2Y1.Name = "pbX2Y1";
            this.pbX2Y1.Size = new System.Drawing.Size(140, 88);
            this.pbX2Y1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX2Y1.TabIndex = 12;
            this.pbX2Y1.TabStop = false;
            this.pbX2Y1.Tag = "?";
            this.pbX2Y1.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX0Y2
            // 
            this.pbX0Y2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX0Y2.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX0Y2.Location = new System.Drawing.Point(749, 95);
            this.pbX0Y2.Name = "pbX0Y2";
            this.pbX0Y2.Size = new System.Drawing.Size(140, 88);
            this.pbX0Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX0Y2.TabIndex = 13;
            this.pbX0Y2.TabStop = false;
            this.pbX0Y2.Tag = "?";
            this.pbX0Y2.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX2Y2
            // 
            this.pbX2Y2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX2Y2.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX2Y2.Location = new System.Drawing.Point(749, 359);
            this.pbX2Y2.Name = "pbX2Y2";
            this.pbX2Y2.Size = new System.Drawing.Size(140, 88);
            this.pbX2Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX2Y2.TabIndex = 14;
            this.pbX2Y2.TabStop = false;
            this.pbX2Y2.Tag = "?";
            this.pbX2Y2.Click += new System.EventHandler(this.Picture_Click);
            // 
            // pbX1Y2
            // 
            this.pbX1Y2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbX1Y2.Image = global::XOProject.Properties.Resources.question_mark_96;
            this.pbX1Y2.Location = new System.Drawing.Point(749, 227);
            this.pbX1Y2.Name = "pbX1Y2";
            this.pbX1Y2.Size = new System.Drawing.Size(140, 88);
            this.pbX1Y2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbX1Y2.TabIndex = 15;
            this.pbX1Y2.TabStop = false;
            this.pbX1Y2.Tag = "?";
            this.pbX1Y2.Click += new System.EventHandler(this.Picture_Click);
            // 
            // frmXOGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1124, 570);
            this.Controls.Add(this.pbX1Y2);
            this.Controls.Add(this.pbX2Y2);
            this.Controls.Add(this.pbX0Y2);
            this.Controls.Add(this.pbX2Y1);
            this.Controls.Add(this.pbX1Y1);
            this.Controls.Add(this.pbX0Y1);
            this.Controls.Add(this.pbX2Y0);
            this.Controls.Add(this.pbX1Y0);
            this.Controls.Add(this.pbX0Y0);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lbWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.label1);
            this.Name = "frmXOGame";
            this.Text = "Tic-Tac-Toe Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmXOGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbX0Y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX1Y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX2Y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX0Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX1Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX2Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX0Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX2Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbX1Y2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.PictureBox pbX0Y0;
        private System.Windows.Forms.PictureBox pbX1Y0;
        private System.Windows.Forms.PictureBox pbX2Y0;
        private System.Windows.Forms.PictureBox pbX0Y1;
        private System.Windows.Forms.PictureBox pbX1Y1;
        private System.Windows.Forms.PictureBox pbX2Y1;
        private System.Windows.Forms.PictureBox pbX0Y2;
        private System.Windows.Forms.PictureBox pbX2Y2;
        private System.Windows.Forms.PictureBox pbX1Y2;
    }
}

