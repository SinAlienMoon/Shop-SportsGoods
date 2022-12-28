namespace Shop_SportsGoods
{
    partial class Caphca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caphca));
            this.btnObnov = new System.Windows.Forms.Button();
            this.btnEnt = new System.Windows.Forms.Button();
            this.TextEnter = new System.Windows.Forms.TextBox();
            this.BoxCap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BoxCap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObnov
            // 
            this.btnObnov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObnov.Location = new System.Drawing.Point(14, 179);
            this.btnObnov.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnObnov.Name = "btnObnov";
            this.btnObnov.Size = new System.Drawing.Size(88, 27);
            this.btnObnov.TabIndex = 0;
            this.btnObnov.Text = "Обновить ";
            this.btnObnov.UseVisualStyleBackColor = true;
            this.btnObnov.Click += new System.EventHandler(this.btnObnov_Click);
            // 
            // btnEnt
            // 
            this.btnEnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnt.Location = new System.Drawing.Point(246, 179);
            this.btnEnt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEnt.Size = new System.Drawing.Size(88, 27);
            this.btnEnt.TabIndex = 1;
            this.btnEnt.Text = "Подтвердить";
            this.btnEnt.UseVisualStyleBackColor = true;
            // 
            // TextEnter
            // 
            this.TextEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextEnter.Location = new System.Drawing.Point(108, 182);
            this.TextEnter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextEnter.Name = "TextEnter";
            this.TextEnter.Size = new System.Drawing.Size(130, 23);
            this.TextEnter.TabIndex = 2;
            // 
            // BoxCap
            // 
            this.BoxCap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxCap.Location = new System.Drawing.Point(91, 61);
            this.BoxCap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BoxCap.Name = "BoxCap";
            this.BoxCap.Size = new System.Drawing.Size(164, 111);
            this.BoxCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoxCap.TabIndex = 3;
            this.BoxCap.TabStop = false;
            this.BoxCap.Click += new System.EventHandler(this.BoxCap_Click);
            // 
            // Caphca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 240);
            this.Controls.Add(this.BoxCap);
            this.Controls.Add(this.TextEnter);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.btnObnov);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Caphca";
            this.Text = "Потвердите что вы не робот";
            this.Load += new System.EventHandler(this.Caphca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoxCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObnov;
        private System.Windows.Forms.Button btnEnt;
        private System.Windows.Forms.TextBox TextEnter;
        private System.Windows.Forms.PictureBox BoxCap;
    }
}