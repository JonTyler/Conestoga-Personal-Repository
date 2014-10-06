namespace ButtonApplication
{
    partial class RaceCopy
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
            this.btnResults = new System.Windows.Forms.Button();
            this.panFinishLine = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(33, 237);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(108, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Create And Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(33, 296);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(108, 23);
            this.btnResults.TabIndex = 1;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // panFinishLine
            // 
            this.panFinishLine.BackColor = System.Drawing.SystemColors.Desktop;
            this.panFinishLine.Location = new System.Drawing.Point(633, 1);
            this.panFinishLine.Name = "panFinishLine";
            this.panFinishLine.Size = new System.Drawing.Size(48, 325);
            this.panFinishLine.TabIndex = 2;
            // 
            // RaceCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 338);
            this.Controls.Add(this.panFinishLine);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.btnStart);
            this.Name = "RaceCopy";
            this.Text = "RaceCopy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Panel panFinishLine;
    }
}