
namespace ABC_Institute_Dashboard
{
    partial class MainDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.btnGenerateTimetable = new Guna.UI.WinForms.GunaButton();
            this.btnStatistics = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnStatistics);
            this.gunaPanel1.Controls.Add(this.btnGenerateTimetable);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(250, 729);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(250, 100);
            this.gunaPanel2.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::ABC_Institute_Dashboard.Properties.Resources.Logo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(73, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(84, 61);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.BackColor = System.Drawing.Color.White;
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(256, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(1094, 729);
            this.gunaPanel3.TabIndex = 1;
            // 
            // btnGenerateTimetable
            // 
            this.btnGenerateTimetable.AnimationHoverSpeed = 0.07F;
            this.btnGenerateTimetable.AnimationSpeed = 0.03F;
            this.btnGenerateTimetable.BaseColor = System.Drawing.Color.Transparent;
            this.btnGenerateTimetable.BorderColor = System.Drawing.Color.Black;
            this.btnGenerateTimetable.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerateTimetable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerateTimetable.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerateTimetable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateTimetable.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateTimetable.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateTimetable.Image")));
            this.btnGenerateTimetable.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerateTimetable.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenerateTimetable.Location = new System.Drawing.Point(0, 100);
            this.btnGenerateTimetable.Name = "btnGenerateTimetable";
            this.btnGenerateTimetable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnGenerateTimetable.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerateTimetable.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerateTimetable.OnHoverImage = null;
            this.btnGenerateTimetable.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerateTimetable.Padding = new System.Windows.Forms.Padding(10);
            this.btnGenerateTimetable.Size = new System.Drawing.Size(250, 40);
            this.btnGenerateTimetable.TabIndex = 1;
            this.btnGenerateTimetable.Text = "Generate Timetable";
            // 
            // btnStatistics
            // 
            this.btnStatistics.AnimationHoverSpeed = 0.07F;
            this.btnStatistics.AnimationSpeed = 0.03F;
            this.btnStatistics.BaseColor = System.Drawing.Color.Transparent;
            this.btnStatistics.BorderColor = System.Drawing.Color.Black;
            this.btnStatistics.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FocusedColor = System.Drawing.Color.Empty;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistics.ForeColor = System.Drawing.Color.Black;
            this.btnStatistics.Image = null;
            this.btnStatistics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStatistics.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStatistics.Location = new System.Drawing.Point(0, 140);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnStatistics.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStatistics.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStatistics.OnHoverImage = null;
            this.btnStatistics.OnPressedColor = System.Drawing.Color.Black;
            this.btnStatistics.Padding = new System.Windows.Forms.Padding(10);
            this.btnStatistics.Size = new System.Drawing.Size(250, 40);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDashboard";
            this.Text = "ABC Institute";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaButton btnStatistics;
        private Guna.UI.WinForms.GunaButton btnGenerateTimetable;
    }
}

