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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SkyTheme = new System.Windows.Forms.RadioButton();
			this.NatureTheme = new System.Windows.Forms.RadioButton();
			this.BloodTheme = new System.Windows.Forms.RadioButton();
			this.Theme = new System.Windows.Forms.GroupBox();
			this.Texts = new System.Windows.Forms.GroupBox();
			this.LightText = new System.Windows.Forms.RadioButton();
			this.DarkText = new System.Windows.Forms.RadioButton();
			this.DarkMode = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Theme.SuspendLayout();
			this.Texts.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Helligkeit
			// 
			this.Helligkeit.AutoSize = true;
			this.Helligkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Helligkeit.Location = new System.Drawing.Point(85, 97);
			this.Helligkeit.Name = "Helligkeit";
			this.Helligkeit.Size = new System.Drawing.Size(256, 64);
			this.Helligkeit.TabIndex = 0;
			this.Helligkeit.Text = "Helligkeit";
			// 
			// Themes
			// 
			this.Themes.AutoSize = true;
			this.Themes.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Themes.Location = new System.Drawing.Point(85, 229);
			this.Themes.Name = "Themes";
			this.Themes.Size = new System.Drawing.Size(229, 64);
			this.Themes.TabIndex = 1;
			this.Themes.Text = "Themes";
			// 
			// Layouts
			// 
			this.Layouts.AutoSize = true;
			this.Layouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Layouts.Location = new System.Drawing.Point(85, 362);
			this.Layouts.Name = "Layouts";
			this.Layouts.Size = new System.Drawing.Size(223, 64);
			this.Layouts.TabIndex = 2;
			this.Layouts.Text = "Layouts";
			// 
			// change_layout
			// 
			this.change_layout.Location = new System.Drawing.Point(612, 370);
			this.change_layout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.change_layout.Name = "change_layout";
			this.change_layout.Size = new System.Drawing.Size(117, 43);
			this.change_layout.TabIndex = 3;
			this.change_layout.Text = "change_layout";
			this.change_layout.UseVisualStyleBackColor = true;
			this.change_layout.Click += new System.EventHandler(this.change_layout_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(620, 97);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(119, 22);
			this.textBox1.TabIndex = 5;
			// 
			// SkyTheme
			// 
			this.SkyTheme.AutoSize = true;
			this.SkyTheme.Location = new System.Drawing.Point(8, 23);
			this.SkyTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.SkyTheme.Name = "SkyTheme";
			this.SkyTheme.Size = new System.Drawing.Size(100, 21);
			this.SkyTheme.TabIndex = 6;
			this.SkyTheme.TabStop = true;
			this.SkyTheme.Text = "SkyTheme";
			this.SkyTheme.UseVisualStyleBackColor = true;
			this.SkyTheme.CheckedChanged += new System.EventHandler(this.SkyTheme_CheckedChanged);
			// 
			// NatureTheme
			// 
			this.NatureTheme.AutoSize = true;
			this.NatureTheme.Location = new System.Drawing.Point(143, 23);
			this.NatureTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.NatureTheme.Name = "NatureTheme";
			this.NatureTheme.Size = new System.Drawing.Size(120, 21);
			this.NatureTheme.TabIndex = 7;
			this.NatureTheme.TabStop = true;
			this.NatureTheme.Text = "NatureTheme";
			this.NatureTheme.UseVisualStyleBackColor = true;
			this.NatureTheme.CheckedChanged += new System.EventHandler(this.NatureTheme_CheckedChanged);
			// 
			// BloodTheme
			// 
			this.BloodTheme.AutoSize = true;
			this.BloodTheme.Location = new System.Drawing.Point(284, 23);
			this.BloodTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BloodTheme.Name = "BloodTheme";
			this.BloodTheme.Size = new System.Drawing.Size(113, 21);
			this.BloodTheme.TabIndex = 8;
			this.BloodTheme.TabStop = true;
			this.BloodTheme.Text = "BloodTheme";
			this.BloodTheme.UseVisualStyleBackColor = true;
			this.BloodTheme.CheckedChanged += new System.EventHandler(this.BloodTheme_CheckedChanged);
			// 
			// Theme
			// 
			this.Theme.Controls.Add(this.SkyTheme);
			this.Theme.Controls.Add(this.NatureTheme);
			this.Theme.Controls.Add(this.BloodTheme);
			this.Theme.Location = new System.Drawing.Point(477, 171);
			this.Theme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Theme.Name = "Theme";
			this.Theme.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Theme.Size = new System.Drawing.Size(421, 64);
			this.Theme.TabIndex = 12;
			this.Theme.TabStop = false;
			this.Theme.Text = "Themes";
			// 
			// Texts
			// 
			this.Texts.Controls.Add(this.LightText);
			this.Texts.Controls.Add(this.DarkText);
			this.Texts.Location = new System.Drawing.Point(477, 265);
			this.Texts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Texts.Name = "Texts";
			this.Texts.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Texts.Size = new System.Drawing.Size(421, 64);
			this.Texts.TabIndex = 13;
			this.Texts.TabStop = false;
			this.Texts.Text = "Texts";
			// 
			// LightText
			// 
			this.LightText.AutoSize = true;
			this.LightText.Location = new System.Drawing.Point(92, 23);
			this.LightText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.LightText.Name = "LightText";
			this.LightText.Size = new System.Drawing.Size(91, 21);
			this.LightText.TabIndex = 6;
			this.LightText.TabStop = true;
			this.LightText.Text = "LightText";
			this.LightText.UseVisualStyleBackColor = true;
			this.LightText.CheckedChanged += new System.EventHandler(this.LightText_CheckedChanged);
			// 
			// DarkText
			// 
			this.DarkText.AutoSize = true;
			this.DarkText.Location = new System.Drawing.Point(221, 23);
			this.DarkText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DarkText.Name = "DarkText";
			this.DarkText.Size = new System.Drawing.Size(90, 21);
			this.DarkText.TabIndex = 8;
			this.DarkText.TabStop = true;
			this.DarkText.Text = "DarkText";
			this.DarkText.UseVisualStyleBackColor = true;
			this.DarkText.CheckedChanged += new System.EventHandler(this.DarkText_CheckedChanged);
			// 
			// DarkMode
			// 
			this.DarkMode.AutoSize = true;
			this.DarkMode.Location = new System.Drawing.Point(7, 23);
			this.DarkMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DarkMode.Name = "DarkMode";
			this.DarkMode.Size = new System.Drawing.Size(98, 21);
			this.DarkMode.TabIndex = 14;
			this.DarkMode.TabStop = true;
			this.DarkMode.Text = "DarkMode";
			this.DarkMode.UseVisualStyleBackColor = true;
			this.DarkMode.CheckedChanged += new System.EventHandler(this.DarkMode_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DarkMode);
			this.groupBox1.Location = new System.Drawing.Point(936, 229);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(115, 58);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DarkMode";
			// 
			// Settings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Texts);
			this.Controls.Add(this.Theme);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.change_layout);
			this.Controls.Add(this.Layouts);
			this.Controls.Add(this.Themes);
			this.Controls.Add(this.Helligkeit);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Settings";
			this.Theme.ResumeLayout(false);
			this.Theme.PerformLayout();
			this.Texts.ResumeLayout(false);
			this.Texts.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Helligkeit;
        private System.Windows.Forms.Label Themes;
        private System.Windows.Forms.Label Layouts;
        private System.Windows.Forms.Button change_layout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton SkyTheme;
        private System.Windows.Forms.RadioButton NatureTheme;
        private System.Windows.Forms.RadioButton BloodTheme;
        private System.Windows.Forms.GroupBox Theme;
        private System.Windows.Forms.GroupBox Texts;
        private System.Windows.Forms.RadioButton LightText;
        private System.Windows.Forms.RadioButton DarkText;
        private System.Windows.Forms.RadioButton DarkMode;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}