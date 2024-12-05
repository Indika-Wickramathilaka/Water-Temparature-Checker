namespace Water_Demo
{
    partial class frmWaterDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaterDemo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterTemparature = new System.Windows.Forms.TextBox();
            this.btnFormofWater = new System.Windows.Forms.Button();
            this.picWater = new System.Windows.Forms.PictureBox();
            this.picIce = new System.Windows.Forms.PictureBox();
            this.picGas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picTemparatureText = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTemparatureText)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Temparature";
            // 
            // txtEnterTemparature
            // 
            this.txtEnterTemparature.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterTemparature.Location = new System.Drawing.Point(289, 37);
            this.txtEnterTemparature.Name = "txtEnterTemparature";
            this.txtEnterTemparature.Size = new System.Drawing.Size(65, 29);
            this.txtEnterTemparature.TabIndex = 1;
            this.txtEnterTemparature.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterTemparature_KeyPress);
            // 
            // btnFormofWater
            // 
            this.btnFormofWater.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormofWater.Location = new System.Drawing.Point(93, 109);
            this.btnFormofWater.Name = "btnFormofWater";
            this.btnFormofWater.Size = new System.Drawing.Size(249, 31);
            this.btnFormofWater.TabIndex = 2;
            this.btnFormofWater.Text = "Form of Water";
            this.btnFormofWater.UseVisualStyleBackColor = true;
            this.btnFormofWater.Click += new System.EventHandler(this.btnFormofWater_Click);
            // 
            // picWater
            // 
            this.picWater.BackColor = System.Drawing.Color.Transparent;
            this.picWater.Image = ((System.Drawing.Image)(resources.GetObject("picWater.Image")));
            this.picWater.Location = new System.Drawing.Point(109, 235);
            this.picWater.Name = "picWater";
            this.picWater.Size = new System.Drawing.Size(249, 217);
            this.picWater.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWater.TabIndex = 3;
            this.picWater.TabStop = false;
            // 
            // picIce
            // 
            this.picIce.BackColor = System.Drawing.Color.Transparent;
            this.picIce.Image = ((System.Drawing.Image)(resources.GetObject("picIce.Image")));
            this.picIce.Location = new System.Drawing.Point(109, 235);
            this.picIce.Name = "picIce";
            this.picIce.Size = new System.Drawing.Size(249, 217);
            this.picIce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIce.TabIndex = 4;
            this.picIce.TabStop = false;
            // 
            // picGas
            // 
            this.picGas.BackColor = System.Drawing.Color.Transparent;
            this.picGas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGas.Image = ((System.Drawing.Image)(resources.GetObject("picGas.Image")));
            this.picGas.Location = new System.Drawing.Point(109, 235);
            this.picGas.Name = "picGas";
            this.picGas.Size = new System.Drawing.Size(249, 217);
            this.picGas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGas.TabIndex = 5;
            this.picGas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEnterTemparature);
            this.groupBox1.Controls.Add(this.btnFormofWater);
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(401, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 38);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(360, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Celcious";
            // 
            // picTemparatureText
            // 
            this.picTemparatureText.Image = ((System.Drawing.Image)(resources.GetObject("picTemparatureText.Image")));
            this.picTemparatureText.Location = new System.Drawing.Point(109, 235);
            this.picTemparatureText.Name = "picTemparatureText";
            this.picTemparatureText.Size = new System.Drawing.Size(249, 217);
            this.picTemparatureText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTemparatureText.TabIndex = 3;
            this.picTemparatureText.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(401, 414);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmWaterDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(510, 537);
            this.Controls.Add(this.picTemparatureText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picGas);
            this.Controls.Add(this.picIce);
            this.Controls.Add(this.picWater);
            this.Name = "frmWaterDemo";
            this.Text = "Water Demo";
            this.Load += new System.EventHandler(this.frmWaterDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTemparatureText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterTemparature;
        private System.Windows.Forms.Button btnFormofWater;
        private System.Windows.Forms.PictureBox picWater;
        private System.Windows.Forms.PictureBox picIce;
        private System.Windows.Forms.PictureBox picGas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picTemparatureText;
        private System.Windows.Forms.Button btnClear;
    }
}

