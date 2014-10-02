namespace Tester
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
            this.worldClock2 = new OurClassLibApplication.WorldClock();
            this.worldClock1 = new OurClassLibApplication.WorldClock();
            this.SuspendLayout();
            // 
            // worldClock2
            // 
            this.worldClock2.Address = "Kitchener";
            this.worldClock2.Difference = OurClassLibApplication.WorldClock.Deviation.Add;
            this.worldClock2.Hour = 0;
            this.worldClock2.Location = new System.Drawing.Point(44, 223);
            this.worldClock2.Minute = 0;
            this.worldClock2.Name = "worldClock2";
            this.worldClock2.Size = new System.Drawing.Size(864, 209);
            this.worldClock2.TabIndex = 1;
            // 
            // worldClock1
            // 
            this.worldClock1.Address = "California";
            this.worldClock1.Difference = OurClassLibApplication.WorldClock.Deviation.Subtract;
            this.worldClock1.Hour = 3;
            this.worldClock1.Location = new System.Drawing.Point(44, 22);
            this.worldClock1.Minute = 0;
            this.worldClock1.Name = "worldClock1";
            this.worldClock1.Size = new System.Drawing.Size(864, 209);
            this.worldClock1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 560);
            this.Controls.Add(this.worldClock2);
            this.Controls.Add(this.worldClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OurClassLibApplication.WorldClock worldClock1;
        private OurClassLibApplication.WorldClock worldClock2;

    }
}

