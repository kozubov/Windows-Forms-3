namespace WF_3_3
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
            this.textBox2_EditFile = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton2_SaveFile2 = new System.Windows.Forms.Button();
            this.bunifuFlatButton2_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2_EditFile
            // 
            this.textBox2_EditFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(75)))));
            this.textBox2_EditFile.Location = new System.Drawing.Point(13, 12);
            this.textBox2_EditFile.Multiline = true;
            this.textBox2_EditFile.Name = "textBox2_EditFile";
            this.textBox2_EditFile.Size = new System.Drawing.Size(469, 323);
            this.textBox2_EditFile.TabIndex = 6;
            // 
            // bunifuFlatButton2_SaveFile2
            // 
            this.bunifuFlatButton2_SaveFile2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton2_SaveFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2_SaveFile2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2_SaveFile2.Location = new System.Drawing.Point(277, 343);
            this.bunifuFlatButton2_SaveFile2.Name = "bunifuFlatButton2_SaveFile2";
            this.bunifuFlatButton2_SaveFile2.Size = new System.Drawing.Size(205, 46);
            this.bunifuFlatButton2_SaveFile2.TabIndex = 7;
            this.bunifuFlatButton2_SaveFile2.Text = "Сохранить";
            this.bunifuFlatButton2_SaveFile2.UseVisualStyleBackColor = false;
            this.bunifuFlatButton2_SaveFile2.Click += new System.EventHandler(this.bunifuFlatButton2_SaveFile_Click_1);
            // 
            // bunifuFlatButton2_Cancel
            // 
            this.bunifuFlatButton2_Cancel.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton2_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuFlatButton2_Cancel.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2_Cancel.Location = new System.Drawing.Point(13, 343);
            this.bunifuFlatButton2_Cancel.Name = "bunifuFlatButton2_Cancel";
            this.bunifuFlatButton2_Cancel.Size = new System.Drawing.Size(203, 46);
            this.bunifuFlatButton2_Cancel.TabIndex = 8;
            this.bunifuFlatButton2_Cancel.Text = "Отменить";
            this.bunifuFlatButton2_Cancel.UseVisualStyleBackColor = false;
            this.bunifuFlatButton2_Cancel.Click += new System.EventHandler(this.bunifuFlatButton2_Cancel_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(104)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(500, 412);
            this.Controls.Add(this.bunifuFlatButton2_Cancel);
            this.Controls.Add(this.bunifuFlatButton2_SaveFile2);
            this.Controls.Add(this.textBox2_EditFile);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2_EditFile;
        private System.Windows.Forms.Button bunifuFlatButton2_SaveFile2;
        private System.Windows.Forms.Button bunifuFlatButton2_Cancel;
    }
}