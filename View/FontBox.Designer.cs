namespace FontExplorer.View
{
    partial class FontBox
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
            this.SampleText = new System.Windows.Forms.Label();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.FontColorBlock = new System.Windows.Forms.Panel();
            this.FavoriteBtn = new System.Windows.Forms.Button();
            this.UnloadBtn = new System.Windows.Forms.Button();
            this.UnfavoriteBtn = new System.Windows.Forms.Button();
            this.FontNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SampleText
            // 
            this.SampleText.AutoSize = true;
            this.SampleText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SampleText.ForeColor = System.Drawing.Color.White;
            this.SampleText.Location = new System.Drawing.Point(55, 24);
            this.SampleText.Name = "SampleText";
            this.SampleText.Size = new System.Drawing.Size(106, 54);
            this.SampleText.TabIndex = 0;
            this.SampleText.Text = "TEST";
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.LoadBtn.FlatAppearance.BorderSize = 0;
            this.LoadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.LoadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.Image = global::FontExplorer.Properties.Resources.load;
            this.LoadBtn.Location = new System.Drawing.Point(450, 30);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(40, 40);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // FontColorBlock
            // 
            this.FontColorBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(82)))), ((int)(((byte)(237)))));
            this.FontColorBlock.Location = new System.Drawing.Point(0, 0);
            this.FontColorBlock.Name = "FontColorBlock";
            this.FontColorBlock.Size = new System.Drawing.Size(4, 100);
            this.FontColorBlock.TabIndex = 4;
            // 
            // FavoriteBtn
            // 
            this.FavoriteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FavoriteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.FavoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FavoriteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.FavoriteBtn.FlatAppearance.BorderSize = 0;
            this.FavoriteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.FavoriteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.FavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavoriteBtn.ForeColor = System.Drawing.Color.White;
            this.FavoriteBtn.Image = global::FontExplorer.Properties.Resources.favorite;
            this.FavoriteBtn.Location = new System.Drawing.Point(500, 30);
            this.FavoriteBtn.Name = "FavoriteBtn";
            this.FavoriteBtn.Size = new System.Drawing.Size(40, 40);
            this.FavoriteBtn.TabIndex = 3;
            this.FavoriteBtn.UseVisualStyleBackColor = false;
            this.FavoriteBtn.Click += new System.EventHandler(this.FavoriteBtn_Click);
            // 
            // UnloadBtn
            // 
            this.UnloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnloadBtn.CausesValidation = false;
            this.UnloadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnloadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnloadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnloadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnloadBtn.ForeColor = System.Drawing.Color.White;
            this.UnloadBtn.Image = global::FontExplorer.Properties.Resources.unload;
            this.UnloadBtn.Location = new System.Drawing.Point(450, 30);
            this.UnloadBtn.Margin = new System.Windows.Forms.Padding(0);
            this.UnloadBtn.Name = "UnloadBtn";
            this.UnloadBtn.Size = new System.Drawing.Size(40, 40);
            this.UnloadBtn.TabIndex = 4;
            this.UnloadBtn.UseVisualStyleBackColor = false;
            this.UnloadBtn.Click += new System.EventHandler(this.UnloadBtn_ClickAsync);
            // 
            // UnfavoriteBtn
            // 
            this.UnfavoriteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnfavoriteBtn.BackColor = System.Drawing.Color.Transparent;
            this.UnfavoriteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UnfavoriteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnfavoriteBtn.FlatAppearance.BorderSize = 0;
            this.UnfavoriteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnfavoriteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.UnfavoriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnfavoriteBtn.ForeColor = System.Drawing.Color.White;
            this.UnfavoriteBtn.Image = global::FontExplorer.Properties.Resources.unfavorite;
            this.UnfavoriteBtn.Location = new System.Drawing.Point(500, 30);
            this.UnfavoriteBtn.Name = "UnfavoriteBtn";
            this.UnfavoriteBtn.Size = new System.Drawing.Size(40, 40);
            this.UnfavoriteBtn.TabIndex = 5;
            this.UnfavoriteBtn.UseVisualStyleBackColor = false;
            this.UnfavoriteBtn.Click += new System.EventHandler(this.UnfavoriteBtn_Click);
            // 
            // FontNameLabel
            // 
            this.FontNameLabel.AutoSize = true;
            this.FontNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FontNameLabel.Location = new System.Drawing.Point(62, 6);
            this.FontNameLabel.Name = "FontNameLabel";
            this.FontNameLabel.Size = new System.Drawing.Size(91, 15);
            this.FontNameLabel.TabIndex = 6;
            this.FontNameLabel.Text = "FontNameLabel";
            // 
            // FontBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(570, 100);
            this.ControlBox = false;
            this.Controls.Add(this.FontColorBlock);
            this.Controls.Add(this.FontNameLabel);
            this.Controls.Add(this.UnfavoriteBtn);
            this.Controls.Add(this.UnloadBtn);
            this.Controls.Add(this.FavoriteBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.SampleText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FontBox";
            this.Text = "FontBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FontBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SampleText;
        private Button LoadBtn;
        private Button FavoriteBtn;
        private Panel FontColorBlock;
        private Button UnloadBtn;
        private Button UnfavoriteBtn;
        private Label FontNameLabel;
    }
}