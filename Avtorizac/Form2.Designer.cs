namespace Avtorizac
{
    partial class Form2
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
            this.buttonOtpravka = new System.Windows.Forms.Button();
            this.listBoxForum = new System.Windows.Forms.ListBox();
            this.tB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOtpravka
            // 
            this.buttonOtpravka.Location = new System.Drawing.Point(769, 562);
            this.buttonOtpravka.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOtpravka.Name = "buttonOtpravka";
            this.buttonOtpravka.Size = new System.Drawing.Size(103, 35);
            this.buttonOtpravka.TabIndex = 0;
            this.buttonOtpravka.Text = "Отправить";
            this.buttonOtpravka.UseVisualStyleBackColor = true;
            this.buttonOtpravka.Click += new System.EventHandler(this.buttonOtpravka_Click);
            // 
            // listBoxForum
            // 
            this.listBoxForum.FormattingEnabled = true;
            this.listBoxForum.ItemHeight = 21;
            this.listBoxForum.Location = new System.Drawing.Point(9, 8);
            this.listBoxForum.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxForum.Name = "listBoxForum";
            this.listBoxForum.Size = new System.Drawing.Size(863, 550);
            this.listBoxForum.TabIndex = 1;
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(9, 562);
            this.tB.Multiline = true;
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(749, 35);
            this.tB.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 608);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.listBoxForum);
            this.Controls.Add(this.buttonOtpravka);
            this.Font = new System.Drawing.Font("Karnac One", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtpravka;
        private System.Windows.Forms.ListBox listBoxForum;
        private System.Windows.Forms.TextBox tB;

    }
}