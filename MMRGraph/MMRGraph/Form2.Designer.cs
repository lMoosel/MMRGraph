
namespace MMRGraph
{
    partial class Form2
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
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.lblAIRed = new System.Windows.Forms.Label();
            this.lblAIBlue = new System.Windows.Forms.Label();
            this.lblAIGreen = new System.Windows.Forms.Label();
            this.lblAIYellow = new System.Windows.Forms.Label();
            this.lblAIPurple = new System.Windows.Forms.Label();
            this.lblPlayerRed = new System.Windows.Forms.Label();
            this.lblPlayerBlue = new System.Windows.Forms.Label();
            this.lblPlayerGreen = new System.Windows.Forms.Label();
            this.lblPlayerYellow = new System.Windows.Forms.Label();
            this.lblPlayerPurple = new System.Windows.Forms.Label();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.lblRoundResult = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.txtWeights = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblTurnString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(50, 240);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 20);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(225, 240);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 20);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(400, 240);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 20);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(575, 240);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(75, 20);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.Text = "Yellow";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.Location = new System.Drawing.Point(750, 240);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(75, 20);
            this.btnPurple.TabIndex = 4;
            this.btnPurple.Text = "Purple";
            this.btnPurple.UseVisualStyleBackColor = true;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // lblAIRed
            // 
            this.lblAIRed.AutoSize = true;
            this.lblAIRed.Location = new System.Drawing.Point(68, 20);
            this.lblAIRed.Name = "lblAIRed";
            this.lblAIRed.Size = new System.Drawing.Size(35, 13);
            this.lblAIRed.TabIndex = 5;
            this.lblAIRed.Text = "label1";
            // 
            // lblAIBlue
            // 
            this.lblAIBlue.AutoSize = true;
            this.lblAIBlue.Location = new System.Drawing.Point(246, 20);
            this.lblAIBlue.Name = "lblAIBlue";
            this.lblAIBlue.Size = new System.Drawing.Size(35, 13);
            this.lblAIBlue.TabIndex = 6;
            this.lblAIBlue.Text = "label2";
            // 
            // lblAIGreen
            // 
            this.lblAIGreen.AutoSize = true;
            this.lblAIGreen.Location = new System.Drawing.Point(419, 20);
            this.lblAIGreen.Name = "lblAIGreen";
            this.lblAIGreen.Size = new System.Drawing.Size(35, 13);
            this.lblAIGreen.TabIndex = 7;
            this.lblAIGreen.Text = "label3";
            // 
            // lblAIYellow
            // 
            this.lblAIYellow.AutoSize = true;
            this.lblAIYellow.Location = new System.Drawing.Point(593, 20);
            this.lblAIYellow.Name = "lblAIYellow";
            this.lblAIYellow.Size = new System.Drawing.Size(35, 13);
            this.lblAIYellow.TabIndex = 8;
            this.lblAIYellow.Text = "label4";
            // 
            // lblAIPurple
            // 
            this.lblAIPurple.AutoSize = true;
            this.lblAIPurple.Location = new System.Drawing.Point(767, 20);
            this.lblAIPurple.Name = "lblAIPurple";
            this.lblAIPurple.Size = new System.Drawing.Size(35, 13);
            this.lblAIPurple.TabIndex = 9;
            this.lblAIPurple.Text = "label5";
            // 
            // lblPlayerRed
            // 
            this.lblPlayerRed.AutoSize = true;
            this.lblPlayerRed.Location = new System.Drawing.Point(68, 224);
            this.lblPlayerRed.Name = "lblPlayerRed";
            this.lblPlayerRed.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerRed.TabIndex = 10;
            this.lblPlayerRed.Text = "label6";
            // 
            // lblPlayerBlue
            // 
            this.lblPlayerBlue.AutoSize = true;
            this.lblPlayerBlue.Location = new System.Drawing.Point(246, 224);
            this.lblPlayerBlue.Name = "lblPlayerBlue";
            this.lblPlayerBlue.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerBlue.TabIndex = 11;
            this.lblPlayerBlue.Text = "label7";
            // 
            // lblPlayerGreen
            // 
            this.lblPlayerGreen.AutoSize = true;
            this.lblPlayerGreen.Location = new System.Drawing.Point(419, 224);
            this.lblPlayerGreen.Name = "lblPlayerGreen";
            this.lblPlayerGreen.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerGreen.TabIndex = 12;
            this.lblPlayerGreen.Text = "label8";
            // 
            // lblPlayerYellow
            // 
            this.lblPlayerYellow.AutoSize = true;
            this.lblPlayerYellow.Location = new System.Drawing.Point(593, 224);
            this.lblPlayerYellow.Name = "lblPlayerYellow";
            this.lblPlayerYellow.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerYellow.TabIndex = 13;
            this.lblPlayerYellow.Text = "label9";
            // 
            // lblPlayerPurple
            // 
            this.lblPlayerPurple.AutoSize = true;
            this.lblPlayerPurple.Location = new System.Drawing.Point(767, 224);
            this.lblPlayerPurple.Name = "lblPlayerPurple";
            this.lblPlayerPurple.Size = new System.Drawing.Size(41, 13);
            this.lblPlayerPurple.TabIndex = 14;
            this.lblPlayerPurple.Text = "label10";
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Location = new System.Drawing.Point(400, 375);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(75, 23);
            this.btnEndTurn.TabIndex = 15;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Click += new System.EventHandler(this.btnEndTurn_Click);
            // 
            // lblRoundResult
            // 
            this.lblRoundResult.AutoSize = true;
            this.lblRoundResult.Location = new System.Drawing.Point(481, 370);
            this.lblRoundResult.Name = "lblRoundResult";
            this.lblRoundResult.Size = new System.Drawing.Size(35, 13);
            this.lblRoundResult.TabIndex = 16;
            this.lblRoundResult.Text = "label1";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Location = new System.Drawing.Point(481, 397);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(35, 13);
            this.lblGameResult.TabIndex = 17;
            this.lblGameResult.Text = "label1";
            // 
            // txtWeights
            // 
            this.txtWeights.Location = new System.Drawing.Point(41, 327);
            this.txtWeights.Name = "txtWeights";
            this.txtWeights.Size = new System.Drawing.Size(100, 20);
            this.txtWeights.TabIndex = 18;
            this.txtWeights.TextChanged += new System.EventHandler(this.txtWeights_TextChanged);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(50, 353);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 19;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblTurnString
            // 
            this.lblTurnString.AutoSize = true;
            this.lblTurnString.Location = new System.Drawing.Point(647, 385);
            this.lblTurnString.Name = "lblTurnString";
            this.lblTurnString.Size = new System.Drawing.Size(25, 13);
            this.lblTurnString.TabIndex = 20;
            this.lblTurnString.Text = "000";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 459);
            this.Controls.Add(this.lblTurnString);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtWeights);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lblRoundResult);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.lblPlayerPurple);
            this.Controls.Add(this.lblPlayerYellow);
            this.Controls.Add(this.lblPlayerGreen);
            this.Controls.Add(this.lblPlayerBlue);
            this.Controls.Add(this.lblPlayerRed);
            this.Controls.Add(this.lblAIPurple);
            this.Controls.Add(this.lblAIYellow);
            this.Controls.Add(this.lblAIGreen);
            this.Controls.Add(this.lblAIBlue);
            this.Controls.Add(this.lblAIRed);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Label lblAIRed;
        private System.Windows.Forms.Label lblAIBlue;
        private System.Windows.Forms.Label lblAIGreen;
        private System.Windows.Forms.Label lblAIYellow;
        private System.Windows.Forms.Label lblAIPurple;
        private System.Windows.Forms.Label lblPlayerRed;
        private System.Windows.Forms.Label lblPlayerBlue;
        private System.Windows.Forms.Label lblPlayerGreen;
        private System.Windows.Forms.Label lblPlayerYellow;
        private System.Windows.Forms.Label lblPlayerPurple;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Label lblRoundResult;
        private System.Windows.Forms.Label lblGameResult;
        private System.Windows.Forms.TextBox txtWeights;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblTurnString;
    }
}