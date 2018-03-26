namespace WF_3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2_Mask_Search_Title = new System.Windows.Forms.Label();
            this.textBox2_Mask_Search_Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label2_ShowCountFind_Files = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(540, 420);
            this.listBox1.TabIndex = 0;
            // 
            // label2_Mask_Search_Title
            // 
            this.label2_Mask_Search_Title.AutoSize = true;
            this.label2_Mask_Search_Title.BackColor = System.Drawing.Color.Transparent;
            this.label2_Mask_Search_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_Mask_Search_Title.ForeColor = System.Drawing.Color.Black;
            this.label2_Mask_Search_Title.Location = new System.Drawing.Point(4, 40);
            this.label2_Mask_Search_Title.Name = "label2_Mask_Search_Title";
            this.label2_Mask_Search_Title.Size = new System.Drawing.Size(177, 20);
            this.label2_Mask_Search_Title.TabIndex = 1;
            this.label2_Mask_Search_Title.Text = "Маска поиска файлов";
            // 
            // textBox2_Mask_Search_Input
            // 
            this.textBox2_Mask_Search_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2_Mask_Search_Input.Location = new System.Drawing.Point(21, 80);
            this.textBox2_Mask_Search_Input.Name = "textBox2_Mask_Search_Input";
            this.textBox2_Mask_Search_Input.Size = new System.Drawing.Size(143, 26);
            this.textBox2_Mask_Search_Input.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "(*.doc / *.txt)";
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTileButton1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = global::WF_3.Properties.Resources.folder;
            this.bunifuTileButton1.ImagePosition = 18;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 36;
            this.bunifuTileButton1.LabelText = "Выбрать папку";
            this.bunifuTileButton1.Location = new System.Drawing.Point(21, 165);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(143, 129);
            this.bunifuTileButton1.TabIndex = 4;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuCards1.Controls.Add(this.bunifuTileButton1);
            this.bunifuCards1.Controls.Add(this.label2_Mask_Search_Title);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.textBox2_Mask_Search_Input);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(569, 84);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(186, 312);
            this.bunifuCards1.TabIndex = 5;
            // 
            // label2_ShowCountFind_Files
            // 
            this.label2_ShowCountFind_Files.AutoSize = true;
            this.label2_ShowCountFind_Files.BackColor = System.Drawing.Color.Transparent;
            this.label2_ShowCountFind_Files.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2_ShowCountFind_Files.ForeColor = System.Drawing.Color.White;
            this.label2_ShowCountFind_Files.Location = new System.Drawing.Point(5, 29);
            this.label2_ShowCountFind_Files.Name = "label2_ShowCountFind_Files";
            this.label2_ShowCountFind_Files.Size = new System.Drawing.Size(0, 24);
            this.label2_ShowCountFind_Files.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WF_3.Properties.Resources.searcher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(767, 510);
            this.Controls.Add(this.label2_ShowCountFind_Files);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2_Mask_Search_Title;
        private System.Windows.Forms.TextBox textBox2_Mask_Search_Input;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label2_ShowCountFind_Files;
    }
}