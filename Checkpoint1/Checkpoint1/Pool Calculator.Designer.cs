namespace Checkpoint1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblAvgDepth = new System.Windows.Forms.Label();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.lblVolumn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAvgTemp = new System.Windows.Forms.Label();
            this.lblTableDollars = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtAvgDepth = new System.Windows.Forms.TextBox();
            this.txtSurfaceArea = new System.Windows.Forms.TextBox();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtTableAvgTemp = new System.Windows.Forms.TextBox();
            this.txtHeatingCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(122, 155);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(501, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pool Size and Cost";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(26, 65);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 3;
            this.lblLength.Text = "&Length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(26, 93);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "&Width";
            // 
            // lblAvgDepth
            // 
            this.lblAvgDepth.AutoSize = true;
            this.lblAvgDepth.Location = new System.Drawing.Point(26, 124);
            this.lblAvgDepth.Name = "lblAvgDepth";
            this.lblAvgDepth.Size = new System.Drawing.Size(79, 13);
            this.lblAvgDepth.TabIndex = 5;
            this.lblAvgDepth.Text = "Average &Depth";
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.AutoSize = true;
            this.lblSurfaceArea.Location = new System.Drawing.Point(26, 209);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(69, 13);
            this.lblSurfaceArea.TabIndex = 6;
            this.lblSurfaceArea.Text = "Surface Area";
            // 
            // lblVolumn
            // 
            this.lblVolumn.AutoSize = true;
            this.lblVolumn.Location = new System.Drawing.Point(26, 249);
            this.lblVolumn.Name = "lblVolumn";
            this.lblVolumn.Size = new System.Drawing.Size(86, 13);
            this.lblVolumn.TabIndex = 7;
            this.lblVolumn.Text = "Volume of Water";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "sq metres";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "m";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(228, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "litres at 25C";
            // 
            // lblAvgTemp
            // 
            this.lblAvgTemp.AutoSize = true;
            this.lblAvgTemp.Location = new System.Drawing.Point(350, 69);
            this.lblAvgTemp.Name = "lblAvgTemp";
            this.lblAvgTemp.Size = new System.Drawing.Size(56, 13);
            this.lblAvgTemp.TabIndex = 14;
            this.lblAvgTemp.Text = "Avg Temp";
            // 
            // lblTableDollars
            // 
            this.lblTableDollars.AutoSize = true;
            this.lblTableDollars.Location = new System.Drawing.Point(473, 69);
            this.lblTableDollars.Name = "lblTableDollars";
            this.lblTableDollars.Size = new System.Drawing.Size(65, 13);
            this.lblTableDollars.TabIndex = 15;
            this.lblTableDollars.Text = "$ Per Month";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(122, 62);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 16;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(122, 87);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 17;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAvgDepth
            // 
            this.txtAvgDepth.Location = new System.Drawing.Point(122, 117);
            this.txtAvgDepth.Name = "txtAvgDepth";
            this.txtAvgDepth.Size = new System.Drawing.Size(100, 20);
            this.txtAvgDepth.TabIndex = 18;
            this.txtAvgDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSurfaceArea
            // 
            this.txtSurfaceArea.Location = new System.Drawing.Point(122, 199);
            this.txtSurfaceArea.Name = "txtSurfaceArea";
            this.txtSurfaceArea.Size = new System.Drawing.Size(100, 20);
            this.txtSurfaceArea.TabIndex = 19;
            this.txtSurfaceArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(122, 246);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 20;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTableAvgTemp
            // 
            this.txtTableAvgTemp.Location = new System.Drawing.Point(353, 90);
            this.txtTableAvgTemp.Multiline = true;
            this.txtTableAvgTemp.Name = "txtTableAvgTemp";
            this.txtTableAvgTemp.ReadOnly = true;
            this.txtTableAvgTemp.Size = new System.Drawing.Size(100, 206);
            this.txtTableAvgTemp.TabIndex = 21;
            this.txtTableAvgTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHeatingCost
            // 
            this.txtHeatingCost.Location = new System.Drawing.Point(476, 87);
            this.txtHeatingCost.Multiline = true;
            this.txtHeatingCost.Name = "txtHeatingCost";
            this.txtHeatingCost.ReadOnly = true;
            this.txtHeatingCost.Size = new System.Drawing.Size(100, 209);
            this.txtHeatingCost.TabIndex = 22;
            this.txtHeatingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 23;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(136, 283);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(0, 13);
            this.lblCategory.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cost to heat pool to 25 degrees";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Celcius based on varying average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "daily temperature";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 385);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeatingCost);
            this.Controls.Add(this.txtTableAvgTemp);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.txtSurfaceArea);
            this.Controls.Add(this.txtAvgDepth);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblTableDollars);
            this.Controls.Add(this.lblAvgTemp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVolumn);
            this.Controls.Add(this.lblSurfaceArea);
            this.Controls.Add(this.lblAvgDepth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Pool Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblAvgDepth;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label lblVolumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAvgTemp;
        private System.Windows.Forms.Label lblTableDollars;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtAvgDepth;
        private System.Windows.Forms.TextBox txtSurfaceArea;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtTableAvgTemp;
        private System.Windows.Forms.TextBox txtHeatingCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

