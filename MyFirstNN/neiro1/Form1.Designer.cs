
namespace neiro1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonForSecondWord = new System.Windows.Forms.Button();
            this.buttonForThirdWord = new System.Windows.Forms.Button();
            this.buttonForFirstWord = new System.Windows.Forms.Button();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 27);
            this.textBox1.TabIndex = 2;
            // 
            // buttonForSecondWord
            // 
            this.buttonForSecondWord.Location = new System.Drawing.Point(329, 213);
            this.buttonForSecondWord.Name = "buttonForSecondWord";
            this.buttonForSecondWord.Size = new System.Drawing.Size(94, 49);
            this.buttonForSecondWord.TabIndex = 3;
            this.buttonForSecondWord.Text = "Запись 2-го слова";
            this.buttonForSecondWord.UseVisualStyleBackColor = true;
            this.buttonForSecondWord.Click += new System.EventHandler(this.buttonForSecondWord_Click);
            // 
            // buttonForThirdWord
            // 
            this.buttonForThirdWord.Location = new System.Drawing.Point(556, 214);
            this.buttonForThirdWord.Name = "buttonForThirdWord";
            this.buttonForThirdWord.Size = new System.Drawing.Size(94, 48);
            this.buttonForThirdWord.TabIndex = 5;
            this.buttonForThirdWord.Text = "Запись 3-го слова";
            this.buttonForThirdWord.UseVisualStyleBackColor = true;
            this.buttonForThirdWord.Click += new System.EventHandler(this.buttonForThirdWord_Click);
            // 
            // buttonForFirstWord
            // 
            this.buttonForFirstWord.Location = new System.Drawing.Point(109, 213);
            this.buttonForFirstWord.Name = "buttonForFirstWord";
            this.buttonForFirstWord.Size = new System.Drawing.Size(94, 49);
            this.buttonForFirstWord.TabIndex = 7;
            this.buttonForFirstWord.Text = "Запись 1-го слова";
            this.buttonForFirstWord.UseVisualStyleBackColor = true;
            this.buttonForFirstWord.Click += new System.EventHandler(this.buttonForFirstWord_Click);
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Location = new System.Drawing.Point(351, 332);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(94, 29);
            this.buttonStopRecord.TabIndex = 8;
            this.buttonStopRecord.Text = "Стоп";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStopRecord);
            this.Controls.Add(this.buttonForFirstWord);
            this.Controls.Add(this.buttonForThirdWord);
            this.Controls.Add(this.buttonForSecondWord);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonForSecondWord;
        private System.Windows.Forms.Button buttonForThirdWord;
        private System.Windows.Forms.Button buttonForFirstWord;
        private System.Windows.Forms.Button buttonStopRecord;
    }
}

