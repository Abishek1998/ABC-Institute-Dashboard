
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
            this.panelSideMenu = new Guna.UI.WinForms.GunaPanel();
            this.btnStatistics = new Guna.UI.WinForms.GunaButton();
            this.btnGenerateTimetable = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnAddWorkingDaysHours = new Guna.UI.WinForms.GunaButton();
            this.btnManageWorkingDaysHours = new Guna.UI.WinForms.GunaButton();
            this.panelSideMenu.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.Controls.Add(this.gunaPanel1);
            this.panelSideMenu.Controls.Add(this.gunaButton1);
            this.panelSideMenu.Controls.Add(this.btnStatistics);
            this.panelSideMenu.Controls.Add(this.btnGenerateTimetable);
            this.panelSideMenu.Controls.Add(this.gunaPanel2);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 729);
            this.panelSideMenu.TabIndex = 0;
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
            this.btnStatistics.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnStatistics.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnStatistics.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnStatistics.OnHoverImage = null;
            this.btnStatistics.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnStatistics.Size = new System.Drawing.Size(250, 40);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
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
            this.btnGenerateTimetable.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnGenerateTimetable.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnGenerateTimetable.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnGenerateTimetable.OnHoverImage = null;
            this.btnGenerateTimetable.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnGenerateTimetable.Padding = new System.Windows.Forms.Padding(10);
            this.btnGenerateTimetable.Size = new System.Drawing.Size(250, 40);
            this.btnGenerateTimetable.TabIndex = 1;
            this.btnGenerateTimetable.Text = "Generate Timetable";
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
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 180);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.gunaButton1.Size = new System.Drawing.Size(250, 40);
            this.gunaButton1.TabIndex = 3;
            this.gunaButton1.Text = "Working Days & Hours";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnManageWorkingDaysHours);
            this.gunaPanel1.Controls.Add(this.btnAddWorkingDaysHours);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 220);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(250, 90);
            this.gunaPanel1.TabIndex = 4;
            // 
            // btnAddWorkingDaysHours
            // 
            this.btnAddWorkingDaysHours.AnimationHoverSpeed = 0.07F;
            this.btnAddWorkingDaysHours.AnimationSpeed = 0.03F;
            this.btnAddWorkingDaysHours.BaseColor = System.Drawing.Color.Transparent;
            this.btnAddWorkingDaysHours.BorderColor = System.Drawing.Color.Black;
            this.btnAddWorkingDaysHours.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddWorkingDaysHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddWorkingDaysHours.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddWorkingDaysHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddWorkingDaysHours.ForeColor = System.Drawing.Color.Black;
            this.btnAddWorkingDaysHours.Image = null;
            this.btnAddWorkingDaysHours.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddWorkingDaysHours.Location = new System.Drawing.Point(0, 0);
            this.btnAddWorkingDaysHours.Name = "btnAddWorkingDaysHours";
            this.btnAddWorkingDaysHours.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnAddWorkingDaysHours.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAddWorkingDaysHours.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddWorkingDaysHours.OnHoverImage = null;
            this.btnAddWorkingDaysHours.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnAddWorkingDaysHours.Size = new System.Drawing.Size(250, 42);
            this.btnAddWorkingDaysHours.TabIndex = 0;
            this.btnAddWorkingDaysHours.Text = "Add Working Days, Hours";
            // 
            // btnManageWorkingDaysHours
            // 
            this.btnManageWorkingDaysHours.AnimationHoverSpeed = 0.07F;
            this.btnManageWorkingDaysHours.AnimationSpeed = 0.03F;
            this.btnManageWorkingDaysHours.BaseColor = System.Drawing.Color.Transparent;
            this.btnManageWorkingDaysHours.BorderColor = System.Drawing.Color.Black;
            this.btnManageWorkingDaysHours.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManageWorkingDaysHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageWorkingDaysHours.FocusedColor = System.Drawing.Color.Empty;
            this.btnManageWorkingDaysHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnManageWorkingDaysHours.ForeColor = System.Drawing.Color.Black;
            this.btnManageWorkingDaysHours.Image = null;
            this.btnManageWorkingDaysHours.ImageSize = new System.Drawing.Size(20, 20);
            this.btnManageWorkingDaysHours.Location = new System.Drawing.Point(0, 42);
            this.btnManageWorkingDaysHours.Name = "btnManageWorkingDaysHours";
            this.btnManageWorkingDaysHours.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnManageWorkingDaysHours.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnManageWorkingDaysHours.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnManageWorkingDaysHours.OnHoverImage = null;
            this.btnManageWorkingDaysHours.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.btnManageWorkingDaysHours.Size = new System.Drawing.Size(250, 42);
            this.btnManageWorkingDaysHours.TabIndex = 1;
            this.btnManageWorkingDaysHours.Text = "Mange Working Days, Hours";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainDashboard";
            this.Text = "ABC Institute";
            this.panelSideMenu.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel panelSideMenu;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnStatistics;
        private Guna.UI.WinForms.GunaButton btnGenerateTimetable;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnAddWorkingDaysHours;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton btnManageWorkingDaysHours;
    }
}

