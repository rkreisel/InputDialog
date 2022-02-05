namespace InputDialogUsageSample
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
            this.components = new System.ComponentModel.Container();
            this.btnSimpleTextInput = new System.Windows.Forms.Button();
            this.cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmLongText = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDefaultInput = new System.Windows.Forms.Button();
            this.btnChangeButtonName = new System.Windows.Forms.Button();
            this.btnSimpleMsgBox = new System.Windows.Forms.Button();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.btnComboBoxWithError = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.FontDialog();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnChangeForeColor = new System.Windows.Forms.Button();
            this.btnChangeBothColors = new System.Windows.Forms.Button();
            this.btnBackgroundImage = new System.Windows.Forms.Button();
            this.cm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimpleTextInput
            // 
            this.btnSimpleTextInput.ContextMenuStrip = this.cm;
            this.btnSimpleTextInput.Location = new System.Drawing.Point(3, 2);
            this.btnSimpleTextInput.Name = "btnSimpleTextInput";
            this.btnSimpleTextInput.Size = new System.Drawing.Size(143, 23);
            this.btnSimpleTextInput.TabIndex = 0;
            this.btnSimpleTextInput.Text = "Simple Text Input";
            this.tt.SetToolTip(this.btnSimpleTextInput, "Right click to enable long text input test");
            this.btnSimpleTextInput.UseVisualStyleBackColor = true;
            this.btnSimpleTextInput.Click += new System.EventHandler(this.btnSimpleTextInput_Click);
            // 
            // cm
            // 
            this.cm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmLongText});
            this.cm.Name = "cm";
            this.cm.ShowCheckMargin = true;
            this.cm.Size = new System.Drawing.Size(141, 26);
            // 
            // cmLongText
            // 
            this.cmLongText.CheckOnClick = true;
            this.cmLongText.Name = "cmLongText";
            this.cmLongText.ShowShortcutKeys = false;
            this.cmLongText.Size = new System.Drawing.Size(140, 22);
            this.cmLongText.Text = "Long Text";
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
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(3, 176);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(143, 23);
            this.btnChangeFont.TabIndex = 6;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Location = new System.Drawing.Point(3, 205);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(143, 23);
            this.btnChangeBackColor.TabIndex = 7;
            this.btnChangeBackColor.Text = "Change Back Color";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnChangeForeColor
            // 
            this.btnChangeForeColor.Location = new System.Drawing.Point(3, 234);
            this.btnChangeForeColor.Name = "btnChangeForeColor";
            this.btnChangeForeColor.Size = new System.Drawing.Size(143, 23);
            this.btnChangeForeColor.TabIndex = 8;
            this.btnChangeForeColor.Text = "Change Fore Color";
            this.btnChangeForeColor.UseVisualStyleBackColor = true;
            this.btnChangeForeColor.Click += new System.EventHandler(this.btnChangeForeColor_Click);
            // 
            // btnChangeBothColors
            // 
            this.btnChangeBothColors.Location = new System.Drawing.Point(3, 263);
            this.btnChangeBothColors.Name = "btnChangeBothColors";
            this.btnChangeBothColors.Size = new System.Drawing.Size(143, 23);
            this.btnChangeBothColors.TabIndex = 9;
            this.btnChangeBothColors.Text = "Change Both Colors";
            this.btnChangeBothColors.UseVisualStyleBackColor = true;
            this.btnChangeBothColors.Click += new System.EventHandler(this.btnChangeBothColors_Click);
            // 
            // btnBackgroundImage
            // 
            this.btnBackgroundImage.Location = new System.Drawing.Point(3, 292);
            this.btnBackgroundImage.Name = "btnBackgroundImage";
            this.btnBackgroundImage.Size = new System.Drawing.Size(143, 23);
            this.btnBackgroundImage.TabIndex = 10;
            this.btnBackgroundImage.Text = "Add BG Image";
            this.btnBackgroundImage.UseVisualStyleBackColor = true;
            this.btnBackgroundImage.Click += new System.EventHandler(this.btnBackgroundImage_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 322);
            this.Controls.Add(this.btnBackgroundImage);
            this.Controls.Add(this.btnChangeBothColors);
            this.Controls.Add(this.btnChangeForeColor);
            this.Controls.Add(this.btnChangeBackColor);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnComboBoxWithError);
            this.Controls.Add(this.btnComboBox);
            this.Controls.Add(this.btnSimpleMsgBox);
            this.Controls.Add(this.btnChangeButtonName);
            this.Controls.Add(this.btnDefaultInput);
            this.Controls.Add(this.btnSimpleTextInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.cm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSimpleTextInput;
        private Button btnDefaultInput;
        private Button btnChangeButtonName;
        private Button btnSimpleMsgBox;
        private Button btnComboBox;
        private Button btnComboBoxWithError;
        private Button btnChangeFont;
        private FontDialog fd;
        private ContextMenuStrip cm;
        private ToolStripMenuItem cmLongText;
        private ToolTip tt;
        private Button btnChangeBackColor;
        private Button btnChangeForeColor;
        private Button btnChangeBothColors;
        private Button btnBackgroundImage;
    }
}