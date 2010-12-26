namespace SmallestEnclosingCircle
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
            this.MainDrawingArea = new System.Windows.Forms.PictureBox();
            this.DrawCircle = new System.Windows.Forms.Button();
            this.ClearPoints = new System.Windows.Forms.Button();
            this.DrawNextStep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDrawingArea
            // 
            this.MainDrawingArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDrawingArea.Location = new System.Drawing.Point(23, 105);
            this.MainDrawingArea.Name = "MainDrawingArea";
            this.MainDrawingArea.Size = new System.Drawing.Size(1009, 522);
            this.MainDrawingArea.TabIndex = 0;
            this.MainDrawingArea.TabStop = false;
            this.MainDrawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainDrawingArea_MouseClick);
            // 
            // DrawCircle
            // 
            this.DrawCircle.Location = new System.Drawing.Point(76, 33);
            this.DrawCircle.Name = "DrawCircle";
            this.DrawCircle.Size = new System.Drawing.Size(109, 37);
            this.DrawCircle.TabIndex = 1;
            this.DrawCircle.Text = "DrawCircle";
            this.DrawCircle.UseVisualStyleBackColor = true;
            this.DrawCircle.Click += new System.EventHandler(this.DrawCircle_Click);
            // 
            // ClearPoints
            // 
            this.ClearPoints.Location = new System.Drawing.Point(607, 37);
            this.ClearPoints.Name = "ClearPoints";
            this.ClearPoints.Size = new System.Drawing.Size(107, 36);
            this.ClearPoints.TabIndex = 2;
            this.ClearPoints.Text = "ClearPoints";
            this.ClearPoints.UseVisualStyleBackColor = true;
            this.ClearPoints.Click += new System.EventHandler(this.ClearPoints_Click);
            // 
            // DrawNextStep
            // 
            this.DrawNextStep.Location = new System.Drawing.Point(363, 37);
            this.DrawNextStep.Name = "DrawNextStep";
            this.DrawNextStep.Size = new System.Drawing.Size(89, 33);
            this.DrawNextStep.TabIndex = 3;
            this.DrawNextStep.Text = "DrawNextStep";
            this.DrawNextStep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 639);
            this.Controls.Add(this.DrawNextStep);
            this.Controls.Add(this.ClearPoints);
            this.Controls.Add(this.DrawCircle);
            this.Controls.Add(this.MainDrawingArea);
            this.Name = "Form1";
            this.Text = "Smallest Enclosing Circle";
            ((System.ComponentModel.ISupportInitialize)(this.MainDrawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainDrawingArea;
        private System.Windows.Forms.Button DrawCircle;
        private System.Windows.Forms.Button ClearPoints;
        private System.Windows.Forms.Button DrawNextStep;
    }
}

