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
            components = new System.ComponentModel.Container();
            btnSimpleTextInput = new Button();
            cm = new ContextMenuStrip(components);
            cmLongText = new ToolStripMenuItem();
            btnDefaultInput = new Button();
            btnChangeButtonName = new Button();
            btnSimpleMsgBox = new Button();
            btnLockedComboBox = new Button();
            btnComboBoxWithError = new Button();
            btnChangeFont = new Button();
            fd = new FontDialog();
            tt = new ToolTip(components);
            btnChangeBackColor = new Button();
            btnChangeForeColor = new Button();
            btnChangeBothColors = new Button();
            btnBackgroundImage = new Button();
            btnEditableComboBox = new Button();
            mnuMain = new MenuStrip();
            mnuIconSelctor = new ToolStripMenuItem();
            mnuIconSelectorError = new ToolStripMenuItem();
            mnuIconSelectorExclamation = new ToolStripMenuItem();
            mnuIconSelectorInformation = new ToolStripMenuItem();
            mnuIconSelectorQuestion = new ToolStripMenuItem();
            mnuIconSelectorNone = new ToolStripMenuItem();
            btnNumericUpDown = new Button();
            cm.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnSimpleTextInput
            // 
            btnSimpleTextInput.ContextMenuStrip = cm;
            btnSimpleTextInput.Location = new Point(3, 2);
            btnSimpleTextInput.Name = "btnSimpleTextInput";
            btnSimpleTextInput.Size = new Size(143, 23);
            btnSimpleTextInput.TabIndex = 0;
            btnSimpleTextInput.Text = "Simple Text Input";
            tt.SetToolTip(btnSimpleTextInput, "Right click to enable long text input test");
            btnSimpleTextInput.UseVisualStyleBackColor = true;
            btnSimpleTextInput.Click += btnSimpleTextInput_Click;
            // 
            // cm
            // 
            cm.Items.AddRange(new ToolStripItem[] { cmLongText });
            cm.Name = "cm";
            cm.ShowCheckMargin = true;
            cm.Size = new Size(141, 26);
            // 
            // cmLongText
            // 
            cmLongText.CheckOnClick = true;
            cmLongText.Name = "cmLongText";
            cmLongText.ShowShortcutKeys = false;
            cmLongText.Size = new Size(140, 22);
            cmLongText.Text = "Long Text";
            // 
            // btnDefaultInput
            // 
            btnDefaultInput.Location = new Point(3, 31);
            btnDefaultInput.Name = "btnDefaultInput";
            btnDefaultInput.Size = new Size(143, 23);
            btnDefaultInput.TabIndex = 1;
            btnDefaultInput.Text = "Text Input w/default";
            btnDefaultInput.UseVisualStyleBackColor = true;
            btnDefaultInput.Click += btnDefaultInput_Click;
            // 
            // btnChangeButtonName
            // 
            btnChangeButtonName.Location = new Point(3, 60);
            btnChangeButtonName.Name = "btnChangeButtonName";
            btnChangeButtonName.Size = new Size(143, 23);
            btnChangeButtonName.TabIndex = 2;
            btnChangeButtonName.Text = "Change a button text";
            btnChangeButtonName.UseVisualStyleBackColor = true;
            btnChangeButtonName.Click += btnChangeButtonName_Click;
            // 
            // btnSimpleMsgBox
            // 
            btnSimpleMsgBox.Location = new Point(3, 89);
            btnSimpleMsgBox.Name = "btnSimpleMsgBox";
            btnSimpleMsgBox.Size = new Size(143, 23);
            btnSimpleMsgBox.TabIndex = 3;
            btnSimpleMsgBox.Text = "Simple Message Box";
            btnSimpleMsgBox.UseVisualStyleBackColor = true;
            btnSimpleMsgBox.Click += btnSimpleMsgBox_Click;
            // 
            // btnLockedComboBox
            // 
            btnLockedComboBox.Location = new Point(3, 118);
            btnLockedComboBox.Name = "btnLockedComboBox";
            btnLockedComboBox.Size = new Size(143, 23);
            btnLockedComboBox.TabIndex = 4;
            btnLockedComboBox.Text = "Locked Combo Box";
            btnLockedComboBox.UseVisualStyleBackColor = true;
            btnLockedComboBox.Click += btnLockedComboBox_Click;
            // 
            // btnComboBoxWithError
            // 
            btnComboBoxWithError.Location = new Point(3, 176);
            btnComboBoxWithError.Name = "btnComboBoxWithError";
            btnComboBoxWithError.Size = new Size(143, 23);
            btnComboBoxWithError.TabIndex = 5;
            btnComboBoxWithError.Text = "Combo Box w/Error";
            btnComboBoxWithError.UseVisualStyleBackColor = true;
            btnComboBoxWithError.Click += btnComboBoxWithError_Click;
            // 
            // btnChangeFont
            // 
            btnChangeFont.Location = new Point(3, 205);
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.Size = new Size(143, 23);
            btnChangeFont.TabIndex = 6;
            btnChangeFont.Text = "Change Font";
            btnChangeFont.UseVisualStyleBackColor = true;
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // btnChangeBackColor
            // 
            btnChangeBackColor.Location = new Point(3, 234);
            btnChangeBackColor.Name = "btnChangeBackColor";
            btnChangeBackColor.Size = new Size(143, 23);
            btnChangeBackColor.TabIndex = 7;
            btnChangeBackColor.Text = "Change Back Color";
            btnChangeBackColor.UseVisualStyleBackColor = true;
            btnChangeBackColor.Click += btnChangeBackColor_Click;
            // 
            // btnChangeForeColor
            // 
            btnChangeForeColor.Location = new Point(3, 263);
            btnChangeForeColor.Name = "btnChangeForeColor";
            btnChangeForeColor.Size = new Size(143, 23);
            btnChangeForeColor.TabIndex = 8;
            btnChangeForeColor.Text = "Change Fore Color";
            btnChangeForeColor.UseVisualStyleBackColor = true;
            btnChangeForeColor.Click += btnChangeForeColor_Click;
            // 
            // btnChangeBothColors
            // 
            btnChangeBothColors.Location = new Point(3, 292);
            btnChangeBothColors.Name = "btnChangeBothColors";
            btnChangeBothColors.Size = new Size(143, 23);
            btnChangeBothColors.TabIndex = 9;
            btnChangeBothColors.Text = "Change Both Colors";
            btnChangeBothColors.UseVisualStyleBackColor = true;
            btnChangeBothColors.Click += btnChangeBothColors_Click;
            // 
            // btnBackgroundImage
            // 
            btnBackgroundImage.Location = new Point(3, 321);
            btnBackgroundImage.Name = "btnBackgroundImage";
            btnBackgroundImage.Size = new Size(143, 23);
            btnBackgroundImage.TabIndex = 10;
            btnBackgroundImage.Text = "Add BG Image";
            btnBackgroundImage.UseVisualStyleBackColor = true;
            btnBackgroundImage.Click += btnBackgroundImage_Click;
            // 
            // btnEditableComboBox
            // 
            btnEditableComboBox.Location = new Point(3, 147);
            btnEditableComboBox.Name = "btnEditableComboBox";
            btnEditableComboBox.Size = new Size(143, 23);
            btnEditableComboBox.TabIndex = 11;
            btnEditableComboBox.Text = "Editable Combo Box";
            btnEditableComboBox.UseVisualStyleBackColor = true;
            btnEditableComboBox.Click += btnEditableComboBox_Click;
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuIconSelctor });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(149, 24);
            mnuMain.TabIndex = 12;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuIconSelctor
            // 
            mnuIconSelctor.DropDownItems.AddRange(new ToolStripItem[] { mnuIconSelectorError, mnuIconSelectorExclamation, mnuIconSelectorInformation, mnuIconSelectorQuestion, mnuIconSelectorNone });
            mnuIconSelctor.Name = "mnuIconSelctor";
            mnuIconSelctor.Size = new Size(87, 20);
            mnuIconSelctor.Text = "Icon Selector";
            // 
            // mnuIconSelectorError
            // 
            mnuIconSelectorError.CheckOnClick = true;
            mnuIconSelectorError.Name = "mnuIconSelectorError";
            mnuIconSelectorError.Size = new Size(139, 22);
            mnuIconSelectorError.Text = "Error";
            mnuIconSelectorError.Click += mnuIconSelector_Click;
            // 
            // mnuIconSelectorExclamation
            // 
            mnuIconSelectorExclamation.CheckOnClick = true;
            mnuIconSelectorExclamation.Name = "mnuIconSelectorExclamation";
            mnuIconSelectorExclamation.Size = new Size(139, 22);
            mnuIconSelectorExclamation.Text = "Exclamation";
            mnuIconSelectorExclamation.Click += mnuIconSelector_Click;
            // 
            // mnuIconSelectorInformation
            // 
            mnuIconSelectorInformation.CheckOnClick = true;
            mnuIconSelectorInformation.Name = "mnuIconSelectorInformation";
            mnuIconSelectorInformation.Size = new Size(139, 22);
            mnuIconSelectorInformation.Text = "Information";
            mnuIconSelectorInformation.Click += mnuIconSelector_Click;
            // 
            // mnuIconSelectorQuestion
            // 
            mnuIconSelectorQuestion.CheckOnClick = true;
            mnuIconSelectorQuestion.Name = "mnuIconSelectorQuestion";
            mnuIconSelectorQuestion.Size = new Size(139, 22);
            mnuIconSelectorQuestion.Text = "Question";
            mnuIconSelectorQuestion.Click += mnuIconSelector_Click;
            // 
            // mnuIconSelectorNone
            // 
            mnuIconSelectorNone.CheckOnClick = true;
            mnuIconSelectorNone.Name = "mnuIconSelectorNone";
            mnuIconSelectorNone.Size = new Size(139, 22);
            mnuIconSelectorNone.Text = "None";
            mnuIconSelectorNone.Click += mnuIconSelector_Click;
            // 
            // btnNumericUpDown
            // 
            btnNumericUpDown.Location = new Point(3, 350);
            btnNumericUpDown.Name = "btnNumericUpDown";
            btnNumericUpDown.Size = new Size(143, 23);
            btnNumericUpDown.TabIndex = 13;
            btnNumericUpDown.Text = "Numeric Up Down";
            btnNumericUpDown.UseVisualStyleBackColor = true;
            btnNumericUpDown.Click += btnNumericUpDown_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(149, 383);
            Controls.Add(btnNumericUpDown);
            Controls.Add(mnuMain);
            Controls.Add(btnEditableComboBox);
            Controls.Add(btnBackgroundImage);
            Controls.Add(btnChangeBothColors);
            Controls.Add(btnChangeForeColor);
            Controls.Add(btnChangeBackColor);
            Controls.Add(btnChangeFont);
            Controls.Add(btnComboBoxWithError);
            Controls.Add(btnLockedComboBox);
            Controls.Add(btnSimpleMsgBox);
            Controls.Add(btnChangeButtonName);
            Controls.Add(btnDefaultInput);
            Controls.Add(btnSimpleTextInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = mnuMain;
            Name = "Main";
            cm.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpleTextInput;
        private Button btnDefaultInput;
        private Button btnChangeButtonName;
        private Button btnSimpleMsgBox;
        private Button btnLockedComboBox;
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
        private Button btnEditableComboBox;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuIconSelctor;
        private ToolStripMenuItem mnuIconSelectorError;
        private ToolStripMenuItem mnuIconSelectorExclamation;
        private ToolStripMenuItem mnuIconSelectorInformation;
        private ToolStripMenuItem mnuIconSelectorQuestion;
        private ToolStripMenuItem mnuIconSelectorNone;
        private Button btnNumericUpDown;
    }
}