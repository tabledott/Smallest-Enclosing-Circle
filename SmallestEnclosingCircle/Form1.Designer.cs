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
            this.ClearPoints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainDrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDrawingArea
            // 
            this.MainDrawingArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainDrawingArea.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainDrawingArea.Location = new System.Drawing.Point(23, 12);
            this.MainDrawingArea.Name = "MainDrawingArea";
            this.MainDrawingArea.Size = new System.Drawing.Size(1009, 522);
            this.MainDrawingArea.TabIndex = 0;
            this.MainDrawingArea.TabStop = false;
            this.MainDrawingArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainDrawingArea_MouseClick);
            // 
            // ClearPoints
            // 
            this.ClearPoints.Location = new System.Drawing.Point(437, 569);
            this.ClearPoints.Name = "ClearPoints";
            this.ClearPoints.Size = new System.Drawing.Size(107, 36);
            this.ClearPoints.TabIndex = 3;
            this.ClearPoints.Text = "ClearPoints";
            this.ClearPoints.UseVisualStyleBackColor = true;
            this.ClearPoints.Click += new System.EventHandler(this.ClearPoints_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 639);
            this.Controls.Add(this.ClearPoints);
            this.Controls.Add(this.MainDrawingArea);
            this.Name = "Form1";
            this.Text = "Smallest Enclosing Circle";
            ((System.ComponentModel.ISupportInitialize)(this.MainDrawingArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainDrawingArea;
        private System.Windows.Forms.Button ClearPoints;
    }
}

