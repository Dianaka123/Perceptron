namespace Perceptron
{
    partial class RecognitionClassTableControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableControl1 = new Perceptron.TableControl();
            this.tableControl2 = new Perceptron.TableControl();
            this.tableControl3 = new Perceptron.TableControl();
            this.tableControl4 = new Perceptron.TableControl();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.tableControl4);
            this.MainPanel.Controls.Add(this.tableControl3);
            this.MainPanel.Controls.Add(this.tableControl2);
            this.MainPanel.Controls.Add(this.tableControl1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(875, 617);
            this.MainPanel.TabIndex = 0;
            // 
            // tableControl1
            // 
            this.tableControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableControl1.GroupText = "Lambdas";
            this.tableControl1.IsReadOnly = false;
            this.tableControl1.Location = new System.Drawing.Point(0, 0);
            this.tableControl1.Name = "tableControl1";
            this.tableControl1.Size = new System.Drawing.Size(858, 213);
            this.tableControl1.TabIndex = 0;
            // 
            // tableControl2
            // 
            this.tableControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableControl2.GroupText = "Sum";
            this.tableControl2.IsReadOnly = false;
            this.tableControl2.Location = new System.Drawing.Point(0, 213);
            this.tableControl2.Name = "tableControl2";
            this.tableControl2.Size = new System.Drawing.Size(858, 213);
            this.tableControl2.TabIndex = 1;
            // 
            // tableControl3
            // 
            this.tableControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableControl3.GroupText = "Y";
            this.tableControl3.IsReadOnly = false;
            this.tableControl3.Location = new System.Drawing.Point(0, 426);
            this.tableControl3.Name = "tableControl3";
            this.tableControl3.Size = new System.Drawing.Size(858, 213);
            this.tableControl3.TabIndex = 2;
            // 
            // tableControl4
            // 
            this.tableControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableControl4.GroupText = "Sigma1, R1, R2";
            this.tableControl4.IsReadOnly = false;
            this.tableControl4.Location = new System.Drawing.Point(0, 639);
            this.tableControl4.Name = "tableControl4";
            this.tableControl4.Size = new System.Drawing.Size(858, 213);
            this.tableControl4.TabIndex = 3;
            // 
            // RecognitionClassTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "RecognitionClassTableControl";
            this.Size = new System.Drawing.Size(875, 617);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private TableControl tableControl4;
        private TableControl tableControl3;
        private TableControl tableControl2;
        private TableControl tableControl1;
    }
}
