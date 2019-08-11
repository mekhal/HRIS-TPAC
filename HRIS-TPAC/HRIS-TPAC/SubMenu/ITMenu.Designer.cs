namespace ShortCuter.SubMenu
{
    partial class ITMenu
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
            this.btStandard = new System.Windows.Forms.Button();
            this.btGPO = new System.Windows.Forms.Button();
            this.btForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStandard
            // 
            this.btStandard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btStandard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btStandard.FlatAppearance.BorderSize = 0;
            this.btStandard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btStandard.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStandard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btStandard.Location = new System.Drawing.Point(0, 39);
            this.btStandard.Name = "btStandard";
            this.btStandard.Size = new System.Drawing.Size(274, 66);
            this.btStandard.TabIndex = 0;
            this.btStandard.TabStop = false;
            this.btStandard.Text = "Software / Hardware มาตรฐานการใช้งานแต่ละเครื่อง";
            this.btStandard.UseVisualStyleBackColor = false;
            this.btStandard.Click += new System.EventHandler(this.btStandard_Click);
            // 
            // btGPO
            // 
            this.btGPO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btGPO.FlatAppearance.BorderSize = 0;
            this.btGPO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGPO.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGPO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGPO.Location = new System.Drawing.Point(0, 0);
            this.btGPO.Name = "btGPO";
            this.btGPO.Size = new System.Drawing.Size(274, 40);
            this.btGPO.TabIndex = 0;
            this.btGPO.TabStop = false;
            this.btGPO.Text = "Group Policy การใช้งานคอมพิวเตอร์";
            this.btGPO.UseVisualStyleBackColor = false;
            this.btGPO.Click += new System.EventHandler(this.btGPO_Click);
            // 
            // btForm
            // 
            this.btForm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btForm.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btForm.Location = new System.Drawing.Point(0, 104);
            this.btForm.Name = "btForm";
            this.btForm.Size = new System.Drawing.Size(274, 40);
            this.btForm.TabIndex = 0;
            this.btForm.TabStop = false;
            this.btForm.Text = "แบบฟอร์มต่างๆ";
            this.btForm.UseVisualStyleBackColor = false;
            this.btForm.Click += new System.EventHandler(this.btForm_Click);
            // 
            // ITMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(274, 144);
            this.Controls.Add(this.btStandard);
            this.Controls.Add(this.btForm);
            this.Controls.Add(this.btGPO);
            this.Name = "ITMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRIS-TPAC";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btStandard;
        private System.Windows.Forms.Button btGPO;
        private System.Windows.Forms.Button btForm;
    }
}