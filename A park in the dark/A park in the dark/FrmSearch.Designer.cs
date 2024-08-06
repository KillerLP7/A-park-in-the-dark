namespace A_park_in_the_dark
{
    partial class FrmSearch
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.cbxSearchType = new System.Windows.Forms.ComboBox();
            this.tbxSearchNameplate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 166);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.Location = new System.Drawing.Point(13, 65);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(120, 95);
            this.lbxSearchResults.TabIndex = 13;
            // 
            // cbxSearchType
            // 
            this.cbxSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchType.FormattingEnabled = true;
            this.cbxSearchType.Location = new System.Drawing.Point(12, 12);
            this.cbxSearchType.Name = "cbxSearchType";
            this.cbxSearchType.Size = new System.Drawing.Size(121, 21);
            this.cbxSearchType.TabIndex = 12;
            // 
            // tbxSearchNameplate
            // 
            this.tbxSearchNameplate.Location = new System.Drawing.Point(12, 39);
            this.tbxSearchNameplate.Name = "tbxSearchNameplate";
            this.tbxSearchNameplate.Size = new System.Drawing.Size(121, 20);
            this.tbxSearchNameplate.TabIndex = 11;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 199);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbxSearchResults);
            this.Controls.Add(this.cbxSearchType);
            this.Controls.Add(this.tbxSearchNameplate);
            this.Name = "FrmSearch";
            this.Text = "FrmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.ComboBox cbxSearchType;
        private System.Windows.Forms.TextBox tbxSearchNameplate;
    }
}