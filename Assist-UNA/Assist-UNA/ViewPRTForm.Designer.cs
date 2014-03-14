﻿namespace Assist_UNA
{
    partial class ViewPRTForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPRTForm));
            this.txtPRT = new System.Windows.Forms.RichTextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.panPRT = new System.Windows.Forms.Panel();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            this.panPRT.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPRT
            // 
            this.txtPRT.AcceptsTab = true;
            this.txtPRT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPRT.BackColor = System.Drawing.Color.White;
            this.txtPRT.DetectUrls = false;
            this.txtPRT.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRT.Location = new System.Drawing.Point(0, 0);
            this.txtPRT.Name = "txtPRT";
            this.txtPRT.ReadOnly = true;
            this.txtPRT.Size = new System.Drawing.Size(1067, 475);
            this.txtPRT.TabIndex = 0;
            this.txtPRT.Text = resources.GetString("txtPRT.Text");
            this.txtPRT.WordWrap = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnPrint.Location = new System.Drawing.Point(917, 533);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(998, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // dlgPrint
            // 
            this.dlgPrint.UseEXDialog = true;
            // 
            // panPRT
            // 
            this.panPRT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panPRT.Controls.Add(this.txtPRT);
            this.panPRT.Location = new System.Drawing.Point(6, 51);
            this.panPRT.Name = "panPRT";
            this.panPRT.Size = new System.Drawing.Size(1067, 475);
            this.panPRT.TabIndex = 6;
            // 
            // prtDocument
            // 
            this.prtDocument.DocumentName = "PRT";
            // 
            // ViewPRTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1079, 606);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panPRT);
            this.Name = "ViewPRTForm";
            this.Text = "ViewPRTForm";
            this.panPRT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPRT;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Windows.Forms.Panel panPRT;
        private System.Drawing.Printing.PrintDocument prtDocument;
    }
}