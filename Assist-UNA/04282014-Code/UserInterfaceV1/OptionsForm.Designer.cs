﻿namespace Assist_UNA
{
    partial class OptionsForm
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
            this.gbASSISTIOptions = new System.Windows.Forms.GroupBox();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.lblMaxSize = new System.Windows.Forms.Label();
            this.txtMaxPages = new System.Windows.Forms.TextBox();
            this.lblMaxPages = new System.Windows.Forms.Label();
            this.txtMaxInstructions = new System.Windows.Forms.TextBox();
            this.lblMaxInstructions = new System.Windows.Forms.Label();
            this.txtMaxLines = new System.Windows.Forms.TextBox();
            this.lblMaxLines = new System.Windows.Forms.Label();
            this.btnOptionsApply = new System.Windows.Forms.Button();
            this.gbASSISTUNAOptions = new System.Windows.Forms.GroupBox();
            this.gbASSISTIOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbASSISTIOptions
            // 
            this.gbASSISTIOptions.Controls.Add(this.txtMaxSize);
            this.gbASSISTIOptions.Controls.Add(this.lblMaxSize);
            this.gbASSISTIOptions.Controls.Add(this.txtMaxPages);
            this.gbASSISTIOptions.Controls.Add(this.lblMaxPages);
            this.gbASSISTIOptions.Controls.Add(this.txtMaxInstructions);
            this.gbASSISTIOptions.Controls.Add(this.lblMaxInstructions);
            this.gbASSISTIOptions.Controls.Add(this.txtMaxLines);
            this.gbASSISTIOptions.Controls.Add(this.lblMaxLines);
            this.gbASSISTIOptions.Location = new System.Drawing.Point(17, 2);
            this.gbASSISTIOptions.Name = "gbASSISTIOptions";
            this.gbASSISTIOptions.Size = new System.Drawing.Size(251, 126);
            this.gbASSISTIOptions.TabIndex = 3;
            this.gbASSISTIOptions.TabStop = false;
            this.gbASSISTIOptions.Text = " ASSIST/I Options ";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(190, 99);
            this.txtMaxSize.MaxLength = 4;
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(47, 20);
            this.txtMaxSize.TabIndex = 8;
            this.txtMaxSize.Text = "2700";
            // 
            // lblMaxSize
            // 
            this.lblMaxSize.AutoSize = true;
            this.lblMaxSize.Location = new System.Drawing.Point(17, 102);
            this.lblMaxSize.Name = "lblMaxSize";
            this.lblMaxSize.Size = new System.Drawing.Size(119, 13);
            this.lblMaxSize.TabIndex = 7;
            this.lblMaxSize.Text = "Maximum Size (in bytes)";
            // 
            // txtMaxPages
            // 
            this.txtMaxPages.Location = new System.Drawing.Point(190, 73);
            this.txtMaxPages.MaxLength = 4;
            this.txtMaxPages.Name = "txtMaxPages";
            this.txtMaxPages.Size = new System.Drawing.Size(47, 20);
            this.txtMaxPages.TabIndex = 6;
            this.txtMaxPages.Text = "900";
            // 
            // lblMaxPages
            // 
            this.lblMaxPages.AutoSize = true;
            this.lblMaxPages.Location = new System.Drawing.Point(17, 76);
            this.lblMaxPages.Name = "lblMaxPages";
            this.lblMaxPages.Size = new System.Drawing.Size(145, 13);
            this.lblMaxPages.TabIndex = 5;
            this.lblMaxPages.Text = "Maximum # of Printout Pages";
            // 
            // txtMaxInstructions
            // 
            this.txtMaxInstructions.Location = new System.Drawing.Point(190, 47);
            this.txtMaxInstructions.MaxLength = 4;
            this.txtMaxInstructions.Name = "txtMaxInstructions";
            this.txtMaxInstructions.Size = new System.Drawing.Size(47, 20);
            this.txtMaxInstructions.TabIndex = 4;
            this.txtMaxInstructions.Text = "9000";
            // 
            // lblMaxInstructions
            // 
            this.lblMaxInstructions.AutoSize = true;
            this.lblMaxInstructions.Location = new System.Drawing.Point(17, 50);
            this.lblMaxInstructions.Name = "lblMaxInstructions";
            this.lblMaxInstructions.Size = new System.Drawing.Size(167, 13);
            this.lblMaxInstructions.TabIndex = 3;
            this.lblMaxInstructions.Text = "Maximum # of Source Instructions";
            // 
            // txtMaxLines
            // 
            this.txtMaxLines.Location = new System.Drawing.Point(190, 21);
            this.txtMaxLines.MaxLength = 4;
            this.txtMaxLines.Name = "txtMaxLines";
            this.txtMaxLines.Size = new System.Drawing.Size(47, 20);
            this.txtMaxLines.TabIndex = 2;
            this.txtMaxLines.Text = "900";
            // 
            // lblMaxLines
            // 
            this.lblMaxLines.AutoSize = true;
            this.lblMaxLines.Location = new System.Drawing.Point(17, 24);
            this.lblMaxLines.Name = "lblMaxLines";
            this.lblMaxLines.Size = new System.Drawing.Size(138, 13);
            this.lblMaxLines.TabIndex = 1;
            this.lblMaxLines.Text = "Maximum # of Source Lines";
            // 
            // btnOptionsApply
            // 
            this.btnOptionsApply.Location = new System.Drawing.Point(193, 237);
            this.btnOptionsApply.Name = "btnOptionsApply";
            this.btnOptionsApply.Size = new System.Drawing.Size(75, 23);
            this.btnOptionsApply.TabIndex = 5;
            this.btnOptionsApply.Text = "Apply";
            this.btnOptionsApply.UseVisualStyleBackColor = true;
            this.btnOptionsApply.Click += new System.EventHandler(this.BtnOptionsApplyClick);
            // 
            // gbASSISTUNAOptions
            // 
            this.gbASSISTUNAOptions.Location = new System.Drawing.Point(17, 134);
            this.gbASSISTUNAOptions.Name = "gbASSISTUNAOptions";
            this.gbASSISTUNAOptions.Size = new System.Drawing.Size(251, 97);
            this.gbASSISTUNAOptions.TabIndex = 4;
            this.gbASSISTUNAOptions.TabStop = false;
            this.gbASSISTUNAOptions.Text = " ASSIST/UNA Options ";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gbASSISTIOptions);
            this.Controls.Add(this.btnOptionsApply);
            this.Controls.Add(this.gbASSISTUNAOptions);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.gbASSISTIOptions.ResumeLayout(false);
            this.gbASSISTIOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbASSISTIOptions;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.Label lblMaxSize;
        private System.Windows.Forms.TextBox txtMaxPages;
        private System.Windows.Forms.Label lblMaxPages;
        private System.Windows.Forms.TextBox txtMaxInstructions;
        private System.Windows.Forms.Label lblMaxInstructions;
        private System.Windows.Forms.TextBox txtMaxLines;
        private System.Windows.Forms.Label lblMaxLines;
        private System.Windows.Forms.Button btnOptionsApply;
        private System.Windows.Forms.GroupBox gbASSISTUNAOptions;
    }
}