namespace SashaHeyburgh_19336832_GADE5111_Exam
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
            this.lblMinesweeper = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.lblXPos = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMinesweeper
            // 
            this.lblMinesweeper.AutoSize = true;
            this.lblMinesweeper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinesweeper.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinesweeper.Location = new System.Drawing.Point(32, 110);
            this.lblMinesweeper.Name = "lblMinesweeper";
            this.lblMinesweeper.Size = new System.Drawing.Size(70, 20);
            this.lblMinesweeper.TabIndex = 0;
            this.lblMinesweeper.Text = "label1";
            this.lblMinesweeper.Click += new System.EventHandler(this.lblMinesweeper_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(382, 32);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(98, 22);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(382, 75);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(241, 22);
            this.lblActions.TabIndex = 2;
            this.lblActions.Text = "Actions Remaining: 56";
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXPos.Location = new System.Drawing.Point(383, 147);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(108, 18);
            this.lblXPos.TabIndex = 3;
            this.lblXPos.Text = "X Position";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYPos.Location = new System.Drawing.Point(515, 147);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(108, 18);
            this.lblYPos.TabIndex = 4;
            this.lblYPos.Text = "Y Position";
            // 
            // txtXPos
            // 
            this.txtXPos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXPos.Location = new System.Drawing.Point(386, 182);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(108, 26);
            this.txtXPos.TabIndex = 5;
            // 
            // txtYPos
            // 
            this.txtYPos.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYPos.Location = new System.Drawing.Point(518, 182);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(105, 26);
            this.txtYPos.TabIndex = 6;
            // 
            // btnReveal
            // 
            this.btnReveal.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReveal.Location = new System.Drawing.Point(386, 253);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(237, 36);
            this.btnReveal.TabIndex = 7;
            this.btnReveal.Text = "Reveal Tile";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlag.Location = new System.Drawing.Point(386, 295);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(237, 36);
            this.btnFlag.TabIndex = 8;
            this.btnFlag.Text = "Flag Mine";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(382, 108);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 22);
            this.lblInfo.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 354);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.txtYPos);
            this.Controls.Add(this.txtXPos);
            this.Controls.Add(this.lblYPos);
            this.Controls.Add(this.lblXPos);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMinesweeper);
            this.Name = "Form2";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinesweeper;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Label lblInfo;
    }
}