namespace Perceptron
{
    partial class RecognitionClassControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UploadButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TablePanel = new System.Windows.Forms.Panel();
            this.ImageStackControl = new Perceptron.ImageStackControl();
            this.recognitionClassTableControl1 = new Perceptron.RecognitionClassTableControl();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(894, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 494);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(172, 436);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Images";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ImageStackControl);
            this.panel2.Controls.Add(this.UploadButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8);
            this.panel2.Size = new System.Drawing.Size(168, 419);
            this.panel2.TabIndex = 0;
            // 
            // UploadButton
            // 
            this.UploadButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UploadButton.Location = new System.Drawing.Point(8, 8);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(152, 23);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClassNameLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassNameLabel.Location = new System.Drawing.Point(2, 15);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(168, 41);
            this.ClassNameLabel.TabIndex = 0;
            this.ClassNameLabel.Text = "<ClassName>";
            this.ClassNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // TablePanel
            // 
            this.TablePanel.AutoScroll = true;
            this.TablePanel.Controls.Add(this.recognitionClassTableControl1);
            this.TablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablePanel.Location = new System.Drawing.Point(0, 0);
            this.TablePanel.Name = "TablePanel";
            this.TablePanel.Size = new System.Drawing.Size(894, 494);
            this.TablePanel.TabIndex = 1;
            // 
            // ImageStackControl
            // 
            this.ImageStackControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageStackControl.Location = new System.Drawing.Point(8, 31);
            this.ImageStackControl.Margin = new System.Windows.Forms.Padding(2);
            this.ImageStackControl.Name = "ImageStackControl";
            this.ImageStackControl.Size = new System.Drawing.Size(152, 380);
            this.ImageStackControl.TabIndex = 2;
            // 
            // recognitionClassTableControl1
            // 
            this.recognitionClassTableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recognitionClassTableControl1.Location = new System.Drawing.Point(0, 0);
            this.recognitionClassTableControl1.Name = "recognitionClassTableControl1";
            this.recognitionClassTableControl1.Size = new System.Drawing.Size(894, 494);
            this.recognitionClassTableControl1.TabIndex = 0;
            // 
            // RecognitionClassControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TablePanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RecognitionClassControl";
            this.Size = new System.Drawing.Size(1066, 494);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.TablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ClassNameLabel;
        private ImageStackControl ImageStackControl;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel TablePanel;
        private RecognitionClassTableControl recognitionClassTableControl1;
    }
}
