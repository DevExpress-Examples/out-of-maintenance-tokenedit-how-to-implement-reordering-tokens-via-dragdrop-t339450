namespace T269192 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tokenEdit1 = new DevExpress.XtraEditors.TokenEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tokenEdit1
            // 
            this.tokenEdit1.Location = new System.Drawing.Point(26, 21);
            this.tokenEdit1.Name = "tokenEdit1";
            this.tokenEdit1.Properties.EditValueType = DevExpress.XtraEditors.TokenEditValueType.List;
            this.tokenEdit1.Properties.Separators.AddRange(new string[] {
            ","});
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("January", "1"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("February", "2"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("March", "3"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("April", "4"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("May", "5"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("June", "6"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("July", "7"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("August", "8"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("September", "9"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("October", "10"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("November", "11"));
            this.tokenEdit1.Properties.Tokens.Add(new DevExpress.XtraEditors.TokenEditToken("December", "12"));
            this.tokenEdit1.Size = new System.Drawing.Size(236, 20);
            this.tokenEdit1.TabIndex = 0;
            this.tokenEdit1.DragDrop += new System.Windows.Forms.DragEventHandler(this.tokenEdit1_DragDrop);
            this.tokenEdit1.DragEnter += new System.Windows.Forms.DragEventHandler(this.tokenEdit1_DragEnter);
            this.tokenEdit1.DragOver += new System.Windows.Forms.DragEventHandler(this.tokenEdit1_DragOver);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 182);
            this.Controls.Add(this.tokenEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TokenEdit tokenEdit1;
    }
}

