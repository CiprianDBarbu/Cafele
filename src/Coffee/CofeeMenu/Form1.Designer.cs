namespace CofeeMenu
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lstCoffee = new System.Windows.Forms.CheckedListBox();
            this.btnFinishOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstSyroup = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(51, 65);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(248, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyUp);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(51, 42);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(164, 17);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Please Enter Your Name";
            // 
            // lstCoffee
            // 
            this.lstCoffee.FormattingEnabled = true;
            this.lstCoffee.Location = new System.Drawing.Point(54, 120);
            this.lstCoffee.Name = "lstCoffee";
            this.lstCoffee.Size = new System.Drawing.Size(245, 225);
            this.lstCoffee.TabIndex = 3;
            // 
            // btnFinishOrder
            // 
            this.btnFinishOrder.Location = new System.Drawing.Point(51, 370);
            this.btnFinishOrder.Name = "btnFinishOrder";
            this.btnFinishOrder.Size = new System.Drawing.Size(75, 43);
            this.btnFinishOrder.TabIndex = 4;
            this.btnFinishOrder.Text = "Finish Order";
            this.btnFinishOrder.UseVisualStyleBackColor = true;
            this.btnFinishOrder.Click += new System.EventHandler(this.btnFinishOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(174, 370);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // lstSyroup
            // 
            this.lstSyroup.FormattingEnabled = true;
            this.lstSyroup.Location = new System.Drawing.Point(408, 120);
            this.lstSyroup.Name = "lstSyroup";
            this.lstSyroup.Size = new System.Drawing.Size(224, 225);
            this.lstSyroup.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstSyroup);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFinishOrder);
            this.Controls.Add(this.lstCoffee);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.CheckedListBox lstCoffee;
        private System.Windows.Forms.Button btnFinishOrder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckedListBox lstSyroup;
    }
}

