﻿namespace WIUT
{
    partial class ParentForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            applicatnsToolStripMenuItem = new ToolStripMenuItem();
            newApplicantToolStripMenuItem = new ToolStripMenuItem();
            allApplicantsToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            newCourseToolStripMenuItem = new ToolStripMenuItem();
            allCoursesToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, applicatnsToolStripMenuItem, coursesToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // applicatnsToolStripMenuItem
            // 
            applicatnsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newApplicantToolStripMenuItem, allApplicantsToolStripMenuItem });
            applicatnsToolStripMenuItem.Name = "applicatnsToolStripMenuItem";
            applicatnsToolStripMenuItem.Size = new Size(75, 20);
            applicatnsToolStripMenuItem.Text = "Applicants";
            // 
            // newApplicantToolStripMenuItem
            // 
            newApplicantToolStripMenuItem.Name = "newApplicantToolStripMenuItem";
            newApplicantToolStripMenuItem.Size = new Size(150, 22);
            newApplicantToolStripMenuItem.Text = "New applicant";
            // 
            // allApplicantsToolStripMenuItem
            // 
            allApplicantsToolStripMenuItem.Name = "allApplicantsToolStripMenuItem";
            allApplicantsToolStripMenuItem.Size = new Size(150, 22);
            allApplicantsToolStripMenuItem.Text = "All applicants";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCourseToolStripMenuItem, allCoursesToolStripMenuItem });
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(61, 20);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // newCourseToolStripMenuItem
            // 
            newCourseToolStripMenuItem.Name = "newCourseToolStripMenuItem";
            newCourseToolStripMenuItem.Size = new Size(136, 22);
            newCourseToolStripMenuItem.Text = "New course";
            // 
            // allCoursesToolStripMenuItem
            // 
            allCoursesToolStripMenuItem.Name = "allCoursesToolStripMenuItem";
            allCoursesToolStripMenuItem.Size = new Size(136, 22);
            allCoursesToolStripMenuItem.Text = "All courses";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(180, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // ParentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ParentForm";
            Text = "WIUT";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem applicatnsToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem newApplicantToolStripMenuItem;
        private ToolStripMenuItem allApplicantsToolStripMenuItem;
        private ToolStripMenuItem newCourseToolStripMenuItem;
        private ToolStripMenuItem allCoursesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}