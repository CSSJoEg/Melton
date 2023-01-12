namespace Melton
{
    partial class LoadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ce_RingProgressBar1 = new Ce_RingProgressBar();
            this.LoadingLabel = new Ce_Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ce_RingProgressBar1
            // 
            this.ce_RingProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.ce_RingProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ce_RingProgressBar1.Font = new System.Drawing.Font("Roboto", 10F);
            this.ce_RingProgressBar1.Location = new System.Drawing.Point(313, 289);
            this.ce_RingProgressBar1.Name = "ce_RingProgressBar1";
            this.ce_RingProgressBar1.PercentageColor = System.Drawing.Color.White;
            this.ce_RingProgressBar1.RingColor = System.Drawing.Color.White;
            this.ce_RingProgressBar1.ShapeColor = System.Drawing.Color.White;
            this.ce_RingProgressBar1.Size = new System.Drawing.Size(71, 71);
            this.ce_RingProgressBar1.TabIndex = 2;
            this.ce_RingProgressBar1.Text = "ce_RingProgressBar1";
            this.ce_RingProgressBar1.Value = 0F;
            // 
            // LoadingLabel
            // 
            this.LoadingLabel.AutoSize = true;
            this.LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.LoadingLabel.Font = new System.Drawing.Font("Consolas", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingLabel.ForeColor = System.Drawing.Color.White;
            this.LoadingLabel.Location = new System.Drawing.Point(183, 162);
            this.LoadingLabel.Name = "LoadingLabel";
            this.LoadingLabel.Size = new System.Drawing.Size(375, 62);
            this.LoadingLabel.TabIndex = 1;
            this.LoadingLabel.Text = "Loading Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 900);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ce_RingProgressBar1);
            this.Controls.Add(this.LoadingLabel);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Ce_RingProgressBar ce_RingProgressBar1;
        private Ce_Label LoadingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}