namespace MiniMarket.GUI
{
    partial class NotifyForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.picAlertType = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblMsg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAlertFor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picAlertType)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // picAlertType
            // 
            this.picAlertType.Image = ((System.Drawing.Image)(resources.GetObject("picAlertType.Image")));
            this.picAlertType.ImageRotate = 0F;
            this.picAlertType.Location = new System.Drawing.Point(23, 23);
            this.picAlertType.Name = "picAlertType";
            this.picAlertType.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAlertType.Size = new System.Drawing.Size(71, 61);
            this.picAlertType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlertType.TabIndex = 0;
            this.picAlertType.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = false;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblMsg.Location = new System.Drawing.Point(122, 47);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(349, 61);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "Message";
            // 
            // lblAlertFor
            // 
            this.lblAlertFor.AutoSize = false;
            this.lblAlertFor.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertFor.Font = new System.Drawing.Font("Arial", 12.5F);
            this.lblAlertFor.Location = new System.Drawing.Point(122, 12);
            this.lblAlertFor.Name = "lblAlertFor";
            this.lblAlertFor.Size = new System.Drawing.Size(349, 29);
            this.lblAlertFor.TabIndex = 1;
            this.lblAlertFor.Text = "Thông báo cho Khách Hàng";
            // 
            // NotifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(495, 110);
            this.Controls.Add(this.lblAlertFor);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picAlertType);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotifyForm";
            this.Text = "NotifyForm";
            this.Load += new System.EventHandler(this.NotifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAlertType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMsg;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAlertFor;
    }
}