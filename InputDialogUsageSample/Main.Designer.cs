﻿namespace InputDialogUsageSample
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimpleTextInput = new System.Windows.Forms.Button();
            this.btnDefaultInput = new System.Windows.Forms.Button();
            this.btnChangeButtonName = new System.Windows.Forms.Button();
            this.btnSimpleMsgBox = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnComboBoxWithError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleTextInput
            // 
            this.btnSimpleTextInput.Location = new System.Drawing.Point(3, 2);
            this.btnSimpleTextInput.Name = "btnSimpleTextInput";
            this.btnSimpleTextInput.Size = new System.Drawing.Size(143, 23);
            this.btnSimpleTextInput.TabIndex = 0;
            this.btnSimpleTextInput.Text = "Simple Text Input";
            this.btnSimpleTextInput.UseVisualStyleBackColor = true;
            this.btnSimpleTextInput.Click += new System.EventHandler(this.btnSimpleTextInput_Click);
            // 
            // btnDefaultInput
            // 
            this.btnDefaultInput.Location = new System.Drawing.Point(3, 31);
            this.btnDefaultInput.Name = "btnDefaultInput";
            this.btnDefaultInput.Size = new System.Drawing.Size(143, 23);
            this.btnDefaultInput.TabIndex = 1;
            this.btnDefaultInput.Text = "Text Input w/default";
            this.btnDefaultInput.UseVisualStyleBackColor = true;
            this.btnDefaultInput.Click += new System.EventHandler(this.btnDefaultInput_Click);
            // 
            // btnChangeButtonName
            // 
            this.btnChangeButtonName.Location = new System.Drawing.Point(3, 60);
            this.btnChangeButtonName.Name = "btnChangeButtonName";
            this.btnChangeButtonName.Size = new System.Drawing.Size(143, 23);
            this.btnChangeButtonName.TabIndex = 2;
            this.btnChangeButtonName.Text = "Change a button text";
            this.btnChangeButtonName.UseVisualStyleBackColor = true;
            this.btnChangeButtonName.Click += new System.EventHandler(this.btnChangeButtonName_Click);
            // 
            // btnSimpleMsgBox
            // 
            this.btnSimpleMsgBox.Location = new System.Drawing.Point(3, 89);
            this.btnSimpleMsgBox.Name = "btnSimpleMsgBox";
            this.btnSimpleMsgBox.Size = new System.Drawing.Size(143, 23);
            this.btnSimpleMsgBox.TabIndex = 3;
            this.btnSimpleMsgBox.Text = "Simple Message Box";
            this.btnSimpleMsgBox.UseVisualStyleBackColor = true;
            this.btnSimpleMsgBox.Click += new System.EventHandler(this.btnSimpleMsgBox_Click);
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(3, 118);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(143, 23);
            this.btnComboBox.TabIndex = 4;
            this.btnComboBox.Text = "Combo Box";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // btnComboBoxWithError
            // 
            this.btnComboBoxWithError.Location = new System.Drawing.Point(3, 147);
            this.btnComboBoxWithError.Name = "btnComboBoxWithError";
            this.btnComboBoxWithError.Size = new System.Drawing.Size(143, 23);
            this.btnComboBoxWithError.TabIndex = 5;
            this.btnComboBoxWithError.Text = "Combo Box w/Error";
            this.btnComboBoxWithError.UseVisualStyleBackColor = true;
            this.btnComboBoxWithError.Click += new System.EventHandler(this.btnComboBoxWithError_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 177);
            this.Controls.Add(this.btnComboBoxWithError);
            this.Controls.Add(this.btnComboBox);
            this.Controls.Add(this.btnSimpleMsgBox);
            this.Controls.Add(this.btnChangeButtonName);
            this.Controls.Add(this.btnDefaultInput);
            this.Controls.Add(this.btnSimpleTextInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSimpleTextInput;
        private Button btnDefaultInput;
        private Button btnChangeButtonName;
        private Button btnSimpleMsgBox;
        private Button button1;
        private Button btnComboBox;
        private Button btnComboBoxWithError;
    }
}