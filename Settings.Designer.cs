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
			this.Themes = new System.Windows.Forms.Label();
			this.Layouts = new System.Windows.Forms.Label();
			this.change_layout = new System.Windows.Forms.Button();
			this.Light_Theme = new System.Windows.Forms.CheckBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Helligkeit
			// 
			this.Helligkeit.AutoSize = true;
			this.Helligkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Helligkeit.Location = new System.Drawing.Point(86, 131);
			this.Helligkeit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Helligkeit.Name = "Helligkeit";
			this.Helligkeit.Size = new System.Drawing.Size(182, 46);
			this.Helligkeit.TabIndex = 0;
			this.Helligkeit.Text = "Helligkeit";
			// 
			// Themes
			// 
			this.Themes.AutoSize = true;
			this.Themes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Themes.Location = new System.Drawing.Point(86, 229);
			this.Themes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Themes.Name = "Themes";
			this.Themes.Size = new System.Drawing.Size(163, 46);
			this.Themes.TabIndex = 1;
			this.Themes.Text = "Themes";
			// 
			// Layouts
			// 
			this.Layouts.AutoSize = true;
			this.Layouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Layouts.Location = new System.Drawing.Point(86, 326);
			this.Layouts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Layouts.Name = "Layouts";
			this.Layouts.Size = new System.Drawing.Size(160, 46);
			this.Layouts.TabIndex = 2;
			this.Layouts.Text = "Layouts";
			// 
			// change_layout
			// 
			this.change_layout.Location = new System.Drawing.Point(512, 326);
			this.change_layout.Margin = new System.Windows.Forms.Padding(2);
			this.change_layout.Name = "change_layout";
			this.change_layout.Size = new System.Drawing.Size(117, 43);
			this.change_layout.TabIndex = 3;
			this.change_layout.Text = "change_layout";
			this.change_layout.UseVisualStyleBackColor = true;
			// 
			// Light_Theme
			// 
			this.Light_Theme.AutoSize = true;
			this.Light_Theme.Location = new System.Drawing.Point(512, 257);
			this.Light_Theme.Margin = new System.Windows.Forms.Padding(2);
			this.Light_Theme.Name = "Light_Theme";
			this.Light_Theme.Size = new System.Drawing.Size(103, 20);
			this.Light_Theme.TabIndex = 4;
			this.Light_Theme.Text = "Light Theme";
			this.Light_Theme.UseVisualStyleBackColor = true;
			this.Light_Theme.CheckedChanged += new System.EventHandler(this.Light_Theme_CheckedChanged_1);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(512, 154);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 22);
			this.textBox1.TabIndex = 5;
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Light_Theme);
			this.Controls.Add(this.change_layout);
			this.Controls.Add(this.Layouts);
			this.Controls.Add(this.Themes);
			this.Controls.Add(this.Helligkeit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Settings";
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Helligkeit;
        private System.Windows.Forms.Label Themes;
        private System.Windows.Forms.Label Layouts;
        private System.Windows.Forms.Button change_layout;
        private System.Windows.Forms.CheckBox Light_Theme;
        private System.Windows.Forms.TextBox textBox1;
    }
}