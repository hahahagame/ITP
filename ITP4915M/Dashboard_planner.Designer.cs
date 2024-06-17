namespace ITP4915M
{
    partial class Dashboard_planner
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
            this.manageDangerleveBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deptlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkStocklevelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageDangerleveBtn
            // 
            this.manageDangerleveBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDangerleveBtn.Location = new System.Drawing.Point(0, 182);
            this.manageDangerleveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.manageDangerleveBtn.Name = "manageDangerleveBtn";
            this.manageDangerleveBtn.Size = new System.Drawing.Size(200, 50);
            this.manageDangerleveBtn.TabIndex = 2;
            this.manageDangerleveBtn.Text = "Manage Danger Level";
            this.manageDangerleveBtn.UseVisualStyleBackColor = true;
            this.manageDangerleveBtn.Click += new System.EventHandler(this.inventoryControlBtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 298);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Data Maintenance";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 356);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "System Control";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.deptlbl);
            this.panel1.Controls.Add(this.namelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 91);
            this.panel1.TabIndex = 6;
            // 
            // deptlbl
            // 
            this.deptlbl.AutoSize = true;
            this.deptlbl.Font = new System.Drawing.Font("Calibri", 10F);
            this.deptlbl.Location = new System.Drawing.Point(98, 33);
            this.deptlbl.Name = "deptlbl";
            this.deptlbl.Size = new System.Drawing.Size(42, 17);
            this.deptlbl.TabIndex = 1;
            this.deptlbl.Text = "label7";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Calibri", 10F);
            this.namelbl.Location = new System.Drawing.Point(98, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(42, 17);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "label5";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkStocklevelBtn);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.manageDangerleveBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 91);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 851);
            this.panel3.TabIndex = 7;
            // 
            // checkStocklevelBtn
            // 
            this.checkStocklevelBtn.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkStocklevelBtn.Location = new System.Drawing.Point(0, 240);
            this.checkStocklevelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkStocklevelBtn.Name = "checkStocklevelBtn";
            this.checkStocklevelBtn.Size = new System.Drawing.Size(200, 50);
            this.checkStocklevelBtn.TabIndex = 3;
            this.checkStocklevelBtn.Text = "Check Stock Level";
            this.checkStocklevelBtn.UseVisualStyleBackColor = true;
            this.checkStocklevelBtn.Click += new System.EventHandler(this.checkStocklevelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITP4915M.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard_planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 942);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard_planner";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button manageDangerleveBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button checkStocklevelBtn;
        private System.Windows.Forms.Label deptlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}