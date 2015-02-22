namespace HUFLITplayer
{
    partial class Playlist
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
            this.lbName = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbSumber = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(269, 290);
            this.lbName.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(34, 317);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(102, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add to playlist";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(142, 317);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(75, 23);
            this.btRemove.TabIndex = 2;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // lbSumber
            // 
            this.lbSumber.FormattingEnabled = true;
            this.lbSumber.Location = new System.Drawing.Point(71, 125);
            this.lbSumber.Name = "lbSumber";
            this.lbSumber.Size = new System.Drawing.Size(120, 95);
            this.lbSumber.TabIndex = 3;
            this.lbSumber.Visible = false;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 422);
            this.Controls.Add(this.lbSumber);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbName);
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListBox lbSumber;
    }
}