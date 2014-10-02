namespace ButtonApplication
{
    partial class RaceGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.finishLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(37, 239);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Create and Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(37, 297);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 46);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show result";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // finishLine
            // 
            this.finishLine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.finishLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finishLine.Location = new System.Drawing.Point(1035, 2);
            this.finishLine.Name = "finishLine";
            this.finishLine.Size = new System.Drawing.Size(37, 364);
            this.finishLine.TabIndex = 2;
            // 
            // RaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 388);
            this.Controls.Add(this.finishLine);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnStart);
            this.Name = "RaceGame";
            this.Text = "Race";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel finishLine;
    }
}