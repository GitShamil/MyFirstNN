
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Check = new System.Windows.Forms.Button();
            this.ForRecording = new System.Windows.Forms.Button();
            this.AgainstRecording = new System.Windows.Forms.Button();
            this.StopRecording = new System.Windows.Forms.Button();
            this.ExampleRecording = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "обучить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Teach_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(253, 244);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(518, 32);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(105, 29);
            this.Check.TabIndex = 3;
            this.Check.Text = "Проверить";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // ForRecording
            // 
            this.ForRecording.Location = new System.Drawing.Point(401, 261);
            this.ForRecording.Name = "ForRecording";
            this.ForRecording.Size = new System.Drawing.Size(104, 29);
            this.ForRecording.TabIndex = 4;
            this.ForRecording.Text = "Слово 1";
            this.ForRecording.UseVisualStyleBackColor = true;
            this.ForRecording.Click += new System.EventHandler(this.ForRecording_Click);
            // 
            // AgainstRecording
            // 
            this.AgainstRecording.Location = new System.Drawing.Point(532, 261);
            this.AgainstRecording.Name = "AgainstRecording";
            this.AgainstRecording.Size = new System.Drawing.Size(130, 29);
            this.AgainstRecording.TabIndex = 5;
            this.AgainstRecording.Text = "Слово 2";
            this.AgainstRecording.UseVisualStyleBackColor = true;
            this.AgainstRecording.Click += new System.EventHandler(this.AgainstRecording_Click);
            // 
            // StopRecording
            // 
            this.StopRecording.Location = new System.Drawing.Point(482, 307);
            this.StopRecording.Name = "StopRecording";
            this.StopRecording.Size = new System.Drawing.Size(157, 33);
            this.StopRecording.TabIndex = 6;
            this.StopRecording.Text = "Остановка записи";
            this.StopRecording.UseVisualStyleBackColor = true;
            this.StopRecording.Click += new System.EventHandler(this.StopRecording_Click);
            // 
            // ExampleRecording
            // 
            this.ExampleRecording.Location = new System.Drawing.Point(501, 175);
            this.ExampleRecording.Name = "ExampleRecording";
            this.ExampleRecording.Size = new System.Drawing.Size(122, 52);
            this.ExampleRecording.TabIndex = 7;
            this.ExampleRecording.Text = "Запись проверки";
            this.ExampleRecording.UseVisualStyleBackColor = true;
            this.ExampleRecording.Click += new System.EventHandler(this.ExampleRecording_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(685, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Слово 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ExampleRecording);
            this.Controls.Add(this.StopRecording);
            this.Controls.Add(this.AgainstRecording);
            this.Controls.Add(this.ForRecording);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button ForRecording;
        private System.Windows.Forms.Button AgainstRecording;
        private System.Windows.Forms.Button StopRecording;
        private System.Windows.Forms.Button ExampleRecording;
        private System.Windows.Forms.Button button2;
    }
}

