
namespace MMRGraph
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTurns = new System.Windows.Forms.Timer(this.components);
            this.lblAITiers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPlayAI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 60);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrTurns
            // 
            this.tmrTurns.Interval = 1;
            this.tmrTurns.Tick += new System.EventHandler(this.tmrTurns_Tick);
            // 
            // lblAITiers
            // 
            this.lblAITiers.AutoSize = true;
            this.lblAITiers.Location = new System.Drawing.Point(12, 9);
            this.lblAITiers.Name = "lblAITiers";
            this.lblAITiers.Size = new System.Drawing.Size(35, 13);
            this.lblAITiers.TabIndex = 6;
            this.lblAITiers.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "End";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayAI
            // 
            this.btnPlayAI.Location = new System.Drawing.Point(470, 12);
            this.btnPlayAI.Name = "btnPlayAI";
            this.btnPlayAI.Size = new System.Drawing.Size(75, 23);
            this.btnPlayAI.TabIndex = 8;
            this.btnPlayAI.Text = "Play AI";
            this.btnPlayAI.UseVisualStyleBackColor = true;
            this.btnPlayAI.Click += new System.EventHandler(this.btnPlayAI_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 637);
            this.Controls.Add(this.btnPlayAI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAITiers);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrTurns;
        private System.Windows.Forms.Label lblAITiers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlayAI;
    }
}

