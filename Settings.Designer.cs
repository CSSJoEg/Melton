namespace Melton
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Helligkeit = new System.Windows.Forms.Label();
            this.Darkmode = new System.Windows.Forms.Label();
            this.Layouts = new System.Windows.Forms.Label();
            this.change_layout = new System.Windows.Forms.Button();
            this.DarkmodeOn = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Helligkeit
            // 
            this.Helligkeit.AutoSize = true;
            this.Helligkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helligkeit.Location = new System.Drawing.Point(129, 205);
            this.Helligkeit.Name = "Helligkeit";
            this.Helligkeit.Size = new System.Drawing.Size(292, 73);
            this.Helligkeit.TabIndex = 0;
            this.Helligkeit.Text = "Helligkeit";
            // 
            // Darkmode
            // 
            this.Darkmode.AutoSize = true;
            this.Darkmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Darkmode.Location = new System.Drawing.Point(129, 358);
            this.Darkmode.Name = "Darkmode";
            this.Darkmode.Size = new System.Drawing.Size(328, 73);
            this.Darkmode.TabIndex = 1;
            this.Darkmode.Text = "Darkmode";
            // 
            // Layouts
            // 
            this.Layouts.AutoSize = true;
            this.Layouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Layouts.Location = new System.Drawing.Point(129, 509);
            this.Layouts.Name = "Layouts";
            this.Layouts.Size = new System.Drawing.Size(258, 73);
            this.Layouts.TabIndex = 2;
            this.Layouts.Text = "Layouts";
            // 
            // change_layout
            // 
            this.change_layout.Location = new System.Drawing.Point(768, 509);
            this.change_layout.Name = "change_layout";
            this.change_layout.Size = new System.Drawing.Size(176, 67);
            this.change_layout.TabIndex = 3;
            this.change_layout.Text = "change_layout";
            this.change_layout.UseVisualStyleBackColor = true;
            // 
            // DarkmodeOn
            // 
            this.DarkmodeOn.AutoSize = true;
            this.DarkmodeOn.Location = new System.Drawing.Point(768, 402);
            this.DarkmodeOn.Name = "DarkmodeOn";
            this.DarkmodeOn.Size = new System.Drawing.Size(176, 29);
            this.DarkmodeOn.TabIndex = 4;
            this.DarkmodeOn.Text = "Darkmode On";
            this.DarkmodeOn.UseVisualStyleBackColor = true;
            this.DarkmodeOn.CheckedChanged += new System.EventHandler(this.DarkmodeOn_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(768, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 31);
            this.textBox1.TabIndex = 5;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DarkmodeOn);
            this.Controls.Add(this.change_layout);
            this.Controls.Add(this.Layouts);
            this.Controls.Add(this.Darkmode);
            this.Controls.Add(this.Helligkeit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Helligkeit;
        private System.Windows.Forms.Label Darkmode;
        private System.Windows.Forms.Label Layouts;
        private System.Windows.Forms.Button change_layout;
        private System.Windows.Forms.CheckBox DarkmodeOn;
        private System.Windows.Forms.TextBox textBox1;
    }
}