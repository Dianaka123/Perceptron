namespace Perceptron
{
    partial class RecognitionControl
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UploadedPathLabel = new System.Windows.Forms.Label();
            this.UploadButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RecognitionResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UploadedImagePictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 61);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ResetButton);
            this.panel3.Controls.Add(this.UploadedPathLabel);
            this.panel3.Controls.Add(this.UploadButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 61);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uploaded file:";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(137, 31);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(125, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // UploadedPathLabel
            // 
            this.UploadedPathLabel.AutoSize = true;
            this.UploadedPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UploadedPathLabel.Location = new System.Drawing.Point(101, 9);
            this.UploadedPathLabel.Name = "UploadedPathLabel";
            this.UploadedPathLabel.Size = new System.Drawing.Size(55, 16);
            this.UploadedPathLabel.TabIndex = 1;
            this.UploadedPathLabel.Text = "<Path>";
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(6, 31);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(125, 23);
            this.UploadButton.TabIndex = 2;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RecognitionResultLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(412, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 61);
            this.panel2.TabIndex = 4;
            // 
            // RecognitionResultLabel
            // 
            this.RecognitionResultLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RecognitionResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecognitionResultLabel.Location = new System.Drawing.Point(59, 0);
            this.RecognitionResultLabel.Name = "RecognitionResultLabel";
            this.RecognitionResultLabel.Size = new System.Drawing.Size(165, 61);
            this.RecognitionResultLabel.TabIndex = 5;
            this.RecognitionResultLabel.Text = "NONE";
            this.RecognitionResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result:";
            // 
            // UploadedImagePictureBox
            // 
            this.UploadedImagePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UploadedImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UploadedImagePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UploadedImagePictureBox.Location = new System.Drawing.Point(0, 61);
            this.UploadedImagePictureBox.Name = "UploadedImagePictureBox";
            this.UploadedImagePictureBox.Size = new System.Drawing.Size(636, 391);
            this.UploadedImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UploadedImagePictureBox.TabIndex = 3;
            this.UploadedImagePictureBox.TabStop = false;
            // 
            // RecognitionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UploadedImagePictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "RecognitionControl";
            this.Size = new System.Drawing.Size(636, 452);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UploadedImagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RecognitionResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox UploadedImagePictureBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label UploadedPathLabel;
        private System.Windows.Forms.Button UploadButton;
    }
}
