namespace BL2SkillRandomizer
{
    partial class Randomizer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.zero = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.kronk = new System.Windows.Forms.TabPage();
            this.Zer0 = new System.Windows.Forms.Timer(this.components);
            this.KriegButton = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.Krieg = new System.Windows.Forms.Timer(this.components);
            this.DialogSaver = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.zero.SuspendLayout();
            this.kronk.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.zero);
            this.tabControl1.Controls.Add(this.kronk);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 461);
            this.tabControl1.TabIndex = 0;
            // 
            // zero
            // 
            this.zero.Controls.Add(this.progressBar1);
            this.zero.Controls.Add(this.ZeroButton);
            this.zero.Location = new System.Drawing.Point(4, 22);
            this.zero.Name = "zero";
            this.zero.Padding = new System.Windows.Forms.Padding(3);
            this.zero.Size = new System.Drawing.Size(734, 435);
            this.zero.TabIndex = 0;
            this.zero.Text = "Zer0";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(718, 46);
            this.progressBar1.TabIndex = 1;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(7, 7);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(718, 67);
            this.ZeroButton.TabIndex = 0;
            this.ZeroButton.Text = "Randomize Skills";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // kronk
            // 
            this.kronk.Controls.Add(this.progressBar2);
            this.kronk.Controls.Add(this.KriegButton);
            this.kronk.Location = new System.Drawing.Point(4, 22);
            this.kronk.Name = "kronk";
            this.kronk.Padding = new System.Windows.Forms.Padding(3);
            this.kronk.Size = new System.Drawing.Size(734, 434);
            this.kronk.TabIndex = 1;
            this.kronk.Text = "Krieg";
            this.kronk.UseVisualStyleBackColor = true;
            // 
            // Zer0
            // 
            this.Zer0.Interval = 1;
            this.Zer0.Tick += new System.EventHandler(this.Loader_Tick);
            // 
            // KriegButton
            // 
            this.KriegButton.Location = new System.Drawing.Point(10, 3);
            this.KriegButton.Name = "KriegButton";
            this.KriegButton.Size = new System.Drawing.Size(718, 67);
            this.KriegButton.TabIndex = 1;
            this.KriegButton.Text = "Randomize Skills";
            this.KriegButton.UseVisualStyleBackColor = true;
            this.KriegButton.Click += new System.EventHandler(this.KriegButton_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(13, 385);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(718, 46);
            this.progressBar2.TabIndex = 2;
            // 
            // Krieg
            // 
            this.Krieg.Tick += new System.EventHandler(this.Krieg_Tick);
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 464);
            this.Controls.Add(this.tabControl1);
            this.Name = "Randomizer";
            this.Text = "Borderlands 2 Skill Randomizer";
            this.Load += new System.EventHandler(this.Randomizer_Load);
            this.tabControl1.ResumeLayout(false);
            this.zero.ResumeLayout(false);
            this.kronk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage zero;
        private System.Windows.Forms.TabPage kronk;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Timer Zer0;
        private System.Windows.Forms.Button KriegButton;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer Krieg;
        private System.Windows.Forms.SaveFileDialog DialogSaver;
    }
}

