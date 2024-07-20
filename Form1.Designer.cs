namespace Pizza_Project
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_To_Order_frm = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.Label();
            this.Name3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_To_Order_frm
            // 
            this.btn_To_Order_frm.BackColor = System.Drawing.Color.Transparent;
            this.btn_To_Order_frm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_To_Order_frm.Font = new System.Drawing.Font("Wide Latin", 9F);
            this.btn_To_Order_frm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_To_Order_frm.Location = new System.Drawing.Point(111, 254);
            this.btn_To_Order_frm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_To_Order_frm.Name = "btn_To_Order_frm";
            this.btn_To_Order_frm.Size = new System.Drawing.Size(132, 54);
            this.btn_To_Order_frm.TabIndex = 1;
            this.btn_To_Order_frm.Text = "Order Now";
            this.btn_To_Order_frm.UseVisualStyleBackColor = false;
            this.btn_To_Order_frm.Click += new System.EventHandler(this.btn_To_Order_frm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.btn_Exit.Location = new System.Drawing.Point(296, 254);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(128, 54);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.BackColor = System.Drawing.Color.Transparent;
            this.Name1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name1.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name1.Location = new System.Drawing.Point(103, 154);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(96, 22);
            this.Name1.TabIndex = 3;
            this.Name1.Text = "Make";
            // 
            // Name2
            // 
            this.Name2.AutoSize = true;
            this.Name2.BackColor = System.Drawing.Color.Transparent;
            this.Name2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name2.Font = new System.Drawing.Font("Wide Latin", 11F);
            this.Name2.ForeColor = System.Drawing.Color.White;
            this.Name2.Location = new System.Drawing.Point(215, 154);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(91, 23);
            this.Name2.TabIndex = 4;
            this.Name2.Text = "Your";
            // 
            // Name3
            // 
            this.Name3.AutoSize = true;
            this.Name3.BackColor = System.Drawing.Color.Transparent;
            this.Name3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name3.Font = new System.Drawing.Font("Wide Latin", 11F);
            this.Name3.ForeColor = System.Drawing.Color.Red;
            this.Name3.Location = new System.Drawing.Point(316, 154);
            this.Name3.Name = "Name3";
            this.Name3.Size = new System.Drawing.Size(103, 23);
            this.Name3.TabIndex = 5;
            this.Name3.Text = "Pizza";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.photo_2024_07_16_20_52_06;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name3);
            this.Controls.Add(this.Name2);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_To_Order_frm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_To_Order_frm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.Label Name2;
        private System.Windows.Forms.Label Name3;
    }
}

