namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AlphaTabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesTabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RecognitionControl = new Perceptron.RecognitionControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ClassesTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AlphaTabControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1052, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AlphaTabControl
            // 
            this.AlphaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlphaTabControl.Location = new System.Drawing.Point(2, 2);
            this.AlphaTabControl.Name = "AlphaTabControl";
            this.AlphaTabControl.SelectedIndex = 0;
            this.AlphaTabControl.Size = new System.Drawing.Size(1048, 631);
            this.AlphaTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesTabControl);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Size = new System.Drawing.Size(1052, 635);
            this.ClassesTabPage.TabIndex = 2;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesTabControl
            // 
            this.ClassesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesTabControl.Location = new System.Drawing.Point(2, 2);
            this.ClassesTabControl.Name = "ClassesTabControl";
            this.ClassesTabControl.SelectedIndex = 0;
            this.ClassesTabControl.Size = new System.Drawing.Size(1048, 631);
            this.ClassesTabControl.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RecognitionControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1052, 635);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recognition";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RecognitionControl
            // 
            this.RecognitionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecognitionControl.Location = new System.Drawing.Point(2, 2);
            this.RecognitionControl.Manager = null;
            this.RecognitionControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecognitionControl.Name = "RecognitionControl";
            this.RecognitionControl.Size = new System.Drawing.Size(1048, 631);
            this.RecognitionControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 661);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private RecognitionControl RecognitionControl;
        private System.Windows.Forms.TabControl ClassesTabControl;
        private System.Windows.Forms.TabControl AlphaTabControl;
    }
}

