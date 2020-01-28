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
            this.buttonOtpravka.Location = new System.Drawing.Point(577, 535);
            this.buttonOtpravka.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonOtpravka.Name = "buttonOtpravka";
            this.buttonOtpravka.Size = new System.Drawing.Size(77, 34);
            this.buttonOtpravka.TabIndex = 0;
            this.buttonOtpravka.Text = "Отправить";
            this.buttonOtpravka.UseVisualStyleBackColor = true;
            this.buttonOtpravka.Click += new System.EventHandler(this.buttonOtpravka_Click);
            // 
            // listBoxForum
            // 
            this.listBoxForum.FormattingEnabled = true;
            this.listBoxForum.ItemHeight = 20;
            this.listBoxForum.Location = new System.Drawing.Point(7, 8);
            this.listBoxForum.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listBoxForum.Name = "listBoxForum";
            this.listBoxForum.Size = new System.Drawing.Size(648, 524);
            this.listBoxForum.TabIndex = 1;
            // 
            // tB
            // 
            this.tB.Location = new System.Drawing.Point(7, 535);
            this.tB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tB.Multiline = true;
            this.tB.Name = "tB";
            this.tB.Size = new System.Drawing.Size(563, 33);
            this.tB.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 579);
            this.Controls.Add(this.tB);
            this.Controls.Add(this.listBoxForum);
            this.Controls.Add(this.buttonOtpravka);
            this.Font = new System.Drawing.Font("Marta Decor Two", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOtpravka;
        private System.Windows.Forms.ListBox listBoxForum;
        private System.Windows.Forms.TextBox tB;

    }
}