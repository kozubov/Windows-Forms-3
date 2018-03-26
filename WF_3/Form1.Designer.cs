namespace WF_3
{
    partial class Form1
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
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.label1_Search_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuTileButton1.color = System.Drawing.Color.RoyalBlue;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.Image = global::WF_3.Properties.Resources.search;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Искать";
            this.bunifuTileButton1.Location = new System.Drawing.Point(310, 256);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 0;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // label1_Search_Title
            // 
            this.label1_Search_Title.AutoSize = true;
            this.label1_Search_Title.BackColor = System.Drawing.Color.Transparent;
            this.label1_Search_Title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1_Search_Title.ForeColor = System.Drawing.Color.White;
            this.label1_Search_Title.Location = new System.Drawing.Point(204, 137);
            this.label1_Search_Title.Name = "label1_Search_Title";
            this.label1_Search_Title.Size = new System.Drawing.Size(372, 45);
            this.label1_Search_Title.TabIndex = 1;
            this.label1_Search_Title.Text = "Поиск файлов по маске";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WF_3.Properties.Resources.searcher;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(767, 516);
            this.Controls.Add(this.label1_Search_Title);
            this.Controls.Add(this.bunifuTileButton1);
            this.Name = "Form1";
            this.Text = "Поиск файлов по маске";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private System.Windows.Forms.Label label1_Search_Title;
    }
}

