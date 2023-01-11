namespace Melton
{
    partial class Startmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startmenu));
            this.titel = new System.Windows.Forms.Label();
            this.subtitel = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.btn_character = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.titelbild = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titelbild)).BeginInit();
            this.SuspendLayout();
            // 
            // titel
            // 
            this.titel.AutoSize = true;
            this.titel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel.Location = new System.Drawing.Point(500, 456);
            this.titel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titel.Name = "titel";
            this.titel.Size = new System.Drawing.Size(240, 79);
            this.titel.TabIndex = 1;
            this.titel.Text = "Melton";
            // 
            // subtitel
            // 
            this.subtitel.AutoSize = true;
            this.subtitel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subtitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitel.Location = new System.Drawing.Point(400, 535);
            this.subtitel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.subtitel.Name = "subtitel";
            this.subtitel.Size = new System.Drawing.Size(417, 37);
            this.subtitel.TabIndex = 2;
            this.subtitel.Text = "Rougelike / Dungeoncrawler";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(216, 612);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(352, 190);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "Start Game";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // btn_character
            // 
            this.btn_character.Location = new System.Drawing.Point(626, 612);
            this.btn_character.Margin = new System.Windows.Forms.Padding(4);
            this.btn_character.Name = "btn_character";
            this.btn_character.Size = new System.Drawing.Size(352, 190);
            this.btn_character.TabIndex = 4;
            this.btn_character.Text = "Characters";
            this.btn_character.UseVisualStyleBackColor = true;
            this.btn_character.Click += new System.EventHandler(this.btn_character_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(216, 837);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(352, 190);
            this.btn_Settings.TabIndex = 5;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(626, 837);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(352, 190);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exit_MouseClick);
            // 
            // titelbild
            // 
            this.titelbild.Image = ((System.Drawing.Image)(resources.GetObject("titelbild.Image")));
            this.titelbild.Location = new System.Drawing.Point(408, 54);
            this.titelbild.Margin = new System.Windows.Forms.Padding(4);
            this.titelbild.Name = "titelbild";
            this.titelbild.Size = new System.Drawing.Size(400, 400);
            this.titelbild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titelbild.TabIndex = 0;
            this.titelbild.TabStop = false;
            // 
            // Startmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 1134);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_character);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.subtitel);
            this.Controls.Add(this.titel);
            this.Controls.Add(this.titelbild);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Startmenu";
            this.Text = "Startmenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Startmenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.titelbild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox titelbild;
        private System.Windows.Forms.Label titel;
        private System.Windows.Forms.Label subtitel;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button btn_character;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button exit;
    }
}