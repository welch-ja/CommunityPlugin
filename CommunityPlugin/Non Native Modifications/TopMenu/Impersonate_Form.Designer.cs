namespace CommunityPlugin.Non_Native_Modifications.TopMenu
{
    partial class Impersonate_Form
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnImpersonate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 162);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(181, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return to Myself";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(12, 35);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(181, 121);
            this.lbResults.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 8);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // btnImpersonate
            // 
            this.btnImpersonate.Location = new System.Drawing.Point(118, 6);
            this.btnImpersonate.Name = "btnImpersonate";
            this.btnImpersonate.Size = new System.Drawing.Size(75, 23);
            this.btnImpersonate.TabIndex = 4;
            this.btnImpersonate.Text = "Impersonate";
            this.btnImpersonate.UseVisualStyleBackColor = true;
            this.btnImpersonate.Click += new System.EventHandler(this.BtnImpersonate_Click);
            // 
            // Impersonate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 193);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnImpersonate);
            this.Name = "Impersonate_Form";
            this.Text = "Impersonate_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnImpersonate;
    }
}