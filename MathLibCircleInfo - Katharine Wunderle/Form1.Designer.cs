
namespace MathLibCircleInfo___Katharine_Wunderle
{
    partial class circleInfo
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
            this.enterRadLbl = new System.Windows.Forms.Label();
            this.radiusInput = new System.Windows.Forms.TextBox();
            this.diameterLbl = new System.Windows.Forms.Label();
            this.circLbl = new System.Windows.Forms.Label();
            this.areaLbl = new System.Windows.Forms.Label();
            this.diameterOutput = new System.Windows.Forms.Label();
            this.circOutput = new System.Windows.Forms.Label();
            this.areaOutput = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterRadLbl
            // 
            this.enterRadLbl.AutoSize = true;
            this.enterRadLbl.Location = new System.Drawing.Point(9, 18);
            this.enterRadLbl.Name = "enterRadLbl";
            this.enterRadLbl.Size = new System.Drawing.Size(96, 26);
            this.enterRadLbl.TabIndex = 0;
            this.enterRadLbl.Text = "Please enter the\r\nradius of the circle:";
            this.enterRadLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radiusInput
            // 
            this.radiusInput.Location = new System.Drawing.Point(5, 56);
            this.radiusInput.Name = "radiusInput";
            this.radiusInput.Size = new System.Drawing.Size(100, 20);
            this.radiusInput.TabIndex = 1;
            this.radiusInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // diameterLbl
            // 
            this.diameterLbl.AutoSize = true;
            this.diameterLbl.Location = new System.Drawing.Point(53, 88);
            this.diameterLbl.Name = "diameterLbl";
            this.diameterLbl.Size = new System.Drawing.Size(52, 13);
            this.diameterLbl.TabIndex = 2;
            this.diameterLbl.Text = "Diameter:";
            // 
            // circLbl
            // 
            this.circLbl.AutoSize = true;
            this.circLbl.Location = new System.Drawing.Point(27, 122);
            this.circLbl.Name = "circLbl";
            this.circLbl.Size = new System.Drawing.Size(78, 13);
            this.circLbl.TabIndex = 3;
            this.circLbl.Text = "Circumference:";
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(73, 159);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(32, 13);
            this.areaLbl.TabIndex = 4;
            this.areaLbl.Text = "Area:";
            // 
            // diameterOutput
            // 
            this.diameterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterOutput.Location = new System.Drawing.Point(120, 83);
            this.diameterOutput.Name = "diameterOutput";
            this.diameterOutput.Size = new System.Drawing.Size(100, 23);
            this.diameterOutput.TabIndex = 5;
            this.diameterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // circOutput
            // 
            this.circOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circOutput.Location = new System.Drawing.Point(120, 117);
            this.circOutput.Name = "circOutput";
            this.circOutput.Size = new System.Drawing.Size(100, 23);
            this.circOutput.TabIndex = 6;
            this.circOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areaOutput
            // 
            this.areaOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areaOutput.Location = new System.Drawing.Point(120, 154);
            this.areaOutput.Name = "areaOutput";
            this.areaOutput.Size = new System.Drawing.Size(100, 23);
            this.areaOutput.TabIndex = 7;
            this.areaOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(145, 21);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // circleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 204);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.areaOutput);
            this.Controls.Add(this.circOutput);
            this.Controls.Add(this.diameterOutput);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.circLbl);
            this.Controls.Add(this.diameterLbl);
            this.Controls.Add(this.radiusInput);
            this.Controls.Add(this.enterRadLbl);
            this.Name = "circleInfo";
            this.Text = "Circle Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterRadLbl;
        private System.Windows.Forms.TextBox radiusInput;
        private System.Windows.Forms.Label diameterLbl;
        private System.Windows.Forms.Label circLbl;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Label diameterOutput;
        private System.Windows.Forms.Label circOutput;
        private System.Windows.Forms.Label areaOutput;
        private System.Windows.Forms.Button calcBtn;
    }
}

