﻿namespace InputDialogTester
{
    partial class Parameters
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
            sc = new SplitContainer();
            btnShowDialog = new Button();
            txtForegroundColor = new TextBox();
            cmDialogInput = new ContextMenuStrip(components);
            cmDialogInputReset = new ToolStripMenuItem();
            label16 = new Label();
            txtBackgroundColor = new TextBox();
            label15 = new Label();
            cbImageLayout = new ComboBox();
            cmDropDowns = new ContextMenuStrip(components);
            cmDropDownsReset = new ToolStripMenuItem();
            label14 = new Label();
            txtBackgroundImage = new TextBox();
            label13 = new Label();
            txtDefaultText = new TextBox();
            label12 = new Label();
            groupBox1 = new GroupBox();
            txtNoButton = new TextBox();
            txtYesButton = new TextBox();
            txtCancelButton = new TextBox();
            txtOkButton = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtFont = new TextBox();
            label7 = new Label();
            chkShowInTaskbar = new CheckBox();
            txtComboItems = new TextBox();
            label6 = new Label();
            cbPrompt = new ComboBox();
            label5 = new Label();
            cbButtons = new ComboBox();
            label4 = new Label();
            cbIcon = new ComboBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            txtMessage = new TextBox();
            cmMessage = new ContextMenuStrip(components);
            cmMessageTwoLineTestText = new ToolStripMenuItem();
            longTestTextToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtResult = new TextBox();
            tt = new ToolTip(components);
            fd = new FontDialog();
            ofd = new OpenFileDialog();
            mnuMain = new MenuStrip();
            mnuMainFile = new ToolStripMenuItem();
            resetAllToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuMainExit = new ToolStripMenuItem();
            cd = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)sc).BeginInit();
            sc.Panel1.SuspendLayout();
            sc.Panel2.SuspendLayout();
            sc.SuspendLayout();
            cmDialogInput.SuspendLayout();
            cmDropDowns.SuspendLayout();
            groupBox1.SuspendLayout();
            cmMessage.SuspendLayout();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // sc
            // 
            sc.Cursor = Cursors.HSplit;
            sc.Dock = DockStyle.Fill;
            sc.Location = new Point(0, 24);
            sc.Name = "sc";
            sc.Orientation = Orientation.Horizontal;
            // 
            // sc.Panel1
            // 
            sc.Panel1.Controls.Add(btnShowDialog);
            sc.Panel1.Controls.Add(txtForegroundColor);
            sc.Panel1.Controls.Add(label16);
            sc.Panel1.Controls.Add(txtBackgroundColor);
            sc.Panel1.Controls.Add(label15);
            sc.Panel1.Controls.Add(cbImageLayout);
            sc.Panel1.Controls.Add(label14);
            sc.Panel1.Controls.Add(txtBackgroundImage);
            sc.Panel1.Controls.Add(label13);
            sc.Panel1.Controls.Add(txtDefaultText);
            sc.Panel1.Controls.Add(label12);
            sc.Panel1.Controls.Add(groupBox1);
            sc.Panel1.Controls.Add(txtFont);
            sc.Panel1.Controls.Add(label7);
            sc.Panel1.Controls.Add(chkShowInTaskbar);
            sc.Panel1.Controls.Add(txtComboItems);
            sc.Panel1.Controls.Add(label6);
            sc.Panel1.Controls.Add(cbPrompt);
            sc.Panel1.Controls.Add(label5);
            sc.Panel1.Controls.Add(cbButtons);
            sc.Panel1.Controls.Add(label4);
            sc.Panel1.Controls.Add(cbIcon);
            sc.Panel1.Controls.Add(label3);
            sc.Panel1.Controls.Add(txtTitle);
            sc.Panel1.Controls.Add(label2);
            sc.Panel1.Controls.Add(txtMessage);
            sc.Panel1.Controls.Add(label1);
            sc.Panel1.Cursor = Cursors.Default;
            // 
            // sc.Panel2
            // 
            sc.Panel2.Controls.Add(txtResult);
            sc.Size = new Size(731, 410);
            sc.SplitterDistance = 296;
            sc.TabIndex = 0;
            // 
            // btnShowDialog
            // 
            btnShowDialog.Location = new Point(630, 265);
            btnShowDialog.Name = "btnShowDialog";
            btnShowDialog.Size = new Size(75, 23);
            btnShowDialog.TabIndex = 0;
            btnShowDialog.Text = "Show Dialog";
            btnShowDialog.UseVisualStyleBackColor = true;
            btnShowDialog.Click += btnShowDialog_Click;
            // 
            // txtForegroundColor
            // 
            txtForegroundColor.ContextMenuStrip = cmDialogInput;
            txtForegroundColor.Location = new Point(482, 223);
            txtForegroundColor.Name = "txtForegroundColor";
            txtForegroundColor.ReadOnly = true;
            txtForegroundColor.Size = new Size(223, 23);
            txtForegroundColor.TabIndex = 26;
            tt.SetToolTip(txtForegroundColor, "Double click to select color");
            txtForegroundColor.MouseDoubleClick += txtForegroundColor_MouseDoubleClick;
            txtForegroundColor.MouseDown += SetCurrentTextBox;
            // 
            // cmDialogInput
            // 
            cmDialogInput.Items.AddRange(new ToolStripItem[] { cmDialogInputReset });
            cmDialogInput.Name = "cmDialogInput";
            cmDialogInput.Size = new Size(103, 26);
            // 
            // cmDialogInputReset
            // 
            cmDialogInputReset.Name = "cmDialogInputReset";
            cmDialogInputReset.Size = new Size(102, 22);
            cmDialogInputReset.Text = "Reset";
            cmDialogInputReset.Click += cmDialogInputReset_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(369, 223);
            label16.Name = "label16";
            label16.Size = new Size(101, 15);
            label16.TabIndex = 25;
            label16.Text = "Foreground Color";
            tt.SetToolTip(label16, "Text Color");
            // 
            // txtBackgroundColor
            // 
            txtBackgroundColor.ContextMenuStrip = cmDialogInput;
            txtBackgroundColor.Location = new Point(482, 194);
            txtBackgroundColor.Name = "txtBackgroundColor";
            txtBackgroundColor.ReadOnly = true;
            txtBackgroundColor.Size = new Size(223, 23);
            txtBackgroundColor.TabIndex = 24;
            tt.SetToolTip(txtBackgroundColor, "Double click to select color");
            txtBackgroundColor.MouseDoubleClick += txtBackgroundColor_MouseDoubleClick;
            txtBackgroundColor.MouseDown += SetCurrentTextBox;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(369, 194);
            label15.Name = "label15";
            label15.Size = new Size(103, 15);
            label15.TabIndex = 23;
            label15.Text = "Background Color";
            // 
            // cbImageLayout
            // 
            cbImageLayout.ContextMenuStrip = cmDropDowns;
            cbImageLayout.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImageLayout.FormattingEnabled = true;
            cbImageLayout.Items.AddRange(new object[] { "None", "Tile", "Center", "Stretch", "Zoom" });
            cbImageLayout.Location = new Point(482, 165);
            cbImageLayout.Name = "cbImageLayout";
            cbImageLayout.Size = new Size(223, 23);
            cbImageLayout.TabIndex = 22;
            tt.SetToolTip(cbImageLayout, "Right Click To Clear");
            cbImageLayout.SelectedValueChanged += cbImageLayout_SelectedValueChanged;
            cbImageLayout.MouseDown += SetCurrentComboBox;
            // 
            // cmDropDowns
            // 
            cmDropDowns.Items.AddRange(new ToolStripItem[] { cmDropDownsReset });
            cmDropDowns.Name = "cmDropDowns";
            cmDropDowns.Size = new Size(103, 26);
            // 
            // cmDropDownsReset
            // 
            cmDropDownsReset.Name = "cmDropDownsReset";
            cmDropDownsReset.Size = new Size(102, 22);
            cmDropDownsReset.Text = "Reset";
            cmDropDownsReset.Click += cmDropDownsReset_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(369, 165);
            label14.Name = "label14";
            label14.Size = new Size(79, 15);
            label14.TabIndex = 21;
            label14.Text = "Image Layout";
            // 
            // txtBackgroundImage
            // 
            txtBackgroundImage.ContextMenuStrip = cmDialogInput;
            txtBackgroundImage.Location = new Point(482, 136);
            txtBackgroundImage.Name = "txtBackgroundImage";
            txtBackgroundImage.ReadOnly = true;
            txtBackgroundImage.Size = new Size(223, 23);
            txtBackgroundImage.TabIndex = 20;
            tt.SetToolTip(txtBackgroundImage, "Double click to select photo");
            txtBackgroundImage.MouseDoubleClick += txtBackgroundImage_MouseDoubleClick;
            txtBackgroundImage.MouseDown += SetCurrentTextBox;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(369, 136);
            label13.Name = "label13";
            label13.Size = new Size(107, 15);
            label13.TabIndex = 19;
            label13.Text = "Background Image";
            // 
            // txtDefaultText
            // 
            txtDefaultText.Location = new Point(125, 223);
            txtDefaultText.Name = "txtDefaultText";
            txtDefaultText.Size = new Size(223, 23);
            txtDefaultText.TabIndex = 18;
            tt.SetToolTip(txtDefaultText, "Enter the default text or the exact text of the item in the drop down that yiuy want to be the default selection.");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 223);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 17;
            label12.Text = "Default Text";
            tt.SetToolTip(label12, "Preset the response");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNoButton);
            groupBox1.Controls.Add(txtYesButton);
            groupBox1.Controls.Add(txtCancelButton);
            groupBox1.Controls.Add(txtOkButton);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(369, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 95);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = " Button Texts ";
            // 
            // txtNoButton
            // 
            txtNoButton.Location = new Point(253, 60);
            txtNoButton.Name = "txtNoButton";
            txtNoButton.Size = new Size(71, 23);
            txtNoButton.TabIndex = 7;
            // 
            // txtYesButton
            // 
            txtYesButton.Location = new Point(253, 25);
            txtYesButton.Name = "txtYesButton";
            txtYesButton.Size = new Size(71, 23);
            txtYesButton.TabIndex = 6;
            // 
            // txtCancelButton
            // 
            txtCancelButton.Location = new Point(92, 59);
            txtCancelButton.Name = "txtCancelButton";
            txtCancelButton.Size = new Size(71, 23);
            txtCancelButton.TabIndex = 5;
            // 
            // txtOkButton
            // 
            txtOkButton.Location = new Point(92, 24);
            txtOkButton.Name = "txtOkButton";
            txtOkButton.Size = new Size(71, 23);
            txtOkButton.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(185, 64);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 3;
            label11.Text = "No Button";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(185, 29);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 2;
            label10.Text = "Yes Button";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 63);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 1;
            label9.Text = "Cancel Button";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 28);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 0;
            label8.Text = "Ok Button";
            // 
            // txtFont
            // 
            txtFont.ContextMenuStrip = cmDialogInput;
            txtFont.Location = new Point(125, 194);
            txtFont.Name = "txtFont";
            txtFont.ReadOnly = true;
            txtFont.Size = new Size(223, 23);
            txtFont.TabIndex = 15;
            tt.SetToolTip(txtFont, "Click to Select Font");
            txtFont.TextChanged += txtFont_TextChanged;
            txtFont.MouseDoubleClick += txtFont_MouseDoubleClick;
            txtFont.MouseDown += SetCurrentTextBox;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 194);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 14;
            label7.Text = "Font";
            tt.SetToolTip(label7, "Click to Select Font");
            // 
            // chkShowInTaskbar
            // 
            chkShowInTaskbar.AutoSize = true;
            chkShowInTaskbar.Location = new Point(369, 9);
            chkShowInTaskbar.Name = "chkShowInTaskbar";
            chkShowInTaskbar.Size = new Size(110, 19);
            chkShowInTaskbar.TabIndex = 13;
            chkShowInTaskbar.Text = "Show In Taskbar";
            chkShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // txtComboItems
            // 
            txtComboItems.Location = new Point(125, 252);
            txtComboItems.Multiline = true;
            txtComboItems.Name = "txtComboItems";
            txtComboItems.ScrollBars = ScrollBars.Vertical;
            txtComboItems.Size = new Size(223, 36);
            txtComboItems.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 252);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 10;
            label6.Text = "Combo Box Items";
            // 
            // cbPrompt
            // 
            cbPrompt.ContextMenuStrip = cmDropDowns;
            cbPrompt.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrompt.FormattingEnabled = true;
            cbPrompt.Items.AddRange(new object[] { "Locked Combo Box", "Editable Combo Box", "Text Box", "Message Box" });
            cbPrompt.Location = new Point(125, 165);
            cbPrompt.Name = "cbPrompt";
            cbPrompt.Size = new Size(223, 23);
            cbPrompt.TabIndex = 9;
            tt.SetToolTip(cbPrompt, "Right Click To Clear");
            cbPrompt.SelectedIndexChanged += cbPrompt_SelectedIndexChanged;
            cbPrompt.MouseDown += SetCurrentTextBox;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 165);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 8;
            label5.Text = "Prompt Type";
            // 
            // cbButtons
            // 
            cbButtons.ContextMenuStrip = cmDropDowns;
            cbButtons.DropDownStyle = ComboBoxStyle.DropDownList;
            cbButtons.FormattingEnabled = true;
            cbButtons.Items.AddRange(new object[] { "Ok", "Ok and Cancel", "Yes and No", "Yes, No, and Cancel" });
            cbButtons.Location = new Point(125, 136);
            cbButtons.Name = "cbButtons";
            cbButtons.Size = new Size(223, 23);
            cbButtons.TabIndex = 7;
            tt.SetToolTip(cbButtons, "Right Click To Clear");
            cbButtons.SelectedIndexChanged += cbButtons_SelectedIndexChanged;
            cbButtons.MouseDown += SetCurrentComboBox;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 136);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 6;
            label4.Text = "Buttons";
            // 
            // cbIcon
            // 
            cbIcon.ContextMenuStrip = cmDropDowns;
            cbIcon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIcon.FormattingEnabled = true;
            cbIcon.Items.AddRange(new object[] { "Error", "Exclamation", "Information", "Question", "Nothing" });
            cbIcon.Location = new Point(125, 107);
            cbIcon.Name = "cbIcon";
            cbIcon.Size = new Size(223, 23);
            cbIcon.TabIndex = 5;
            tt.SetToolTip(cbIcon, "Right Click To Clear");
            cbIcon.SelectedIndexChanged += cbIcon_SelectedIndexChanged;
            cbIcon.MouseDown += SetCurrentComboBox;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "Icon";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(125, 78);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(223, 23);
            txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // txtMessage
            // 
            txtMessage.ContextMenuStrip = cmMessage;
            txtMessage.Location = new Point(125, 9);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Vertical;
            txtMessage.Size = new Size(223, 63);
            txtMessage.TabIndex = 1;
            tt.SetToolTip(txtMessage, "Right click for default test text options");
            // 
            // cmMessage
            // 
            cmMessage.Items.AddRange(new ToolStripItem[] { cmMessageTwoLineTestText, longTestTextToolStripMenuItem });
            cmMessage.Name = "contextMenuStrip1";
            cmMessage.Size = new Size(168, 48);
            // 
            // cmMessageTwoLineTestText
            // 
            cmMessageTwoLineTestText.Name = "cmMessageTwoLineTestText";
            cmMessageTwoLineTestText.Size = new Size(167, 22);
            cmMessageTwoLineTestText.Text = "Two Line Test Text";
            cmMessageTwoLineTestText.Click += cmMessageTwoLineTestText_Click;
            // 
            // longTestTextToolStripMenuItem
            // 
            longTestTextToolStripMenuItem.Name = "longTestTextToolStripMenuItem";
            longTestTextToolStripMenuItem.Size = new Size(167, 22);
            longTestTextToolStripMenuItem.Text = "Long Test Text";
            longTestTextToolStripMenuItem.Click += longTestTextToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Message";
            tt.SetToolTip(label1, "Required");
            // 
            // txtResult
            // 
            txtResult.Dock = DockStyle.Fill;
            txtResult.Location = new Point(0, 0);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(731, 110);
            txtResult.TabIndex = 0;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuMainFile });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(731, 24);
            mnuMain.TabIndex = 1;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            mnuMainFile.DropDownItems.AddRange(new ToolStripItem[] { resetAllToolStripMenuItem, toolStripMenuItem1, mnuMainExit });
            mnuMainFile.Name = "mnuMainFile";
            mnuMainFile.Size = new Size(37, 20);
            mnuMainFile.Text = "File";
            // 
            // resetAllToolStripMenuItem
            // 
            resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            resetAllToolStripMenuItem.Size = new Size(119, 22);
            resetAllToolStripMenuItem.Text = "Reset All";
            resetAllToolStripMenuItem.Click += mnuMainResetAll_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 6);
            // 
            // mnuMainExit
            // 
            mnuMainExit.Name = "mnuMainExit";
            mnuMainExit.Size = new Size(119, 22);
            mnuMainExit.Text = "Exit";
            mnuMainExit.Click += mnuMainExit_Click;
            // 
            // Parameters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 434);
            Controls.Add(sc);
            Controls.Add(mnuMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = mnuMain;
            MinimizeBox = false;
            Name = "Parameters";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Input Dialog Tester";
            sc.Panel1.ResumeLayout(false);
            sc.Panel1.PerformLayout();
            sc.Panel2.ResumeLayout(false);
            sc.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sc).EndInit();
            sc.ResumeLayout(false);
            cmDialogInput.ResumeLayout(false);
            cmDropDowns.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            cmMessage.ResumeLayout(false);
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer sc;
        private ComboBox cbButtons;
        private Label label4;
        private ComboBox cbIcon;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
        private TextBox txtMessage;
        private Label label1;
        private ToolTip tt;
        private TextBox txtFont;
        private Label label7;
        private CheckBox chkShowInTaskbar;
        private Label label6;
        private ComboBox cbPrompt;
        private Label label5;
        private FontDialog fd;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtNoButton;
        private TextBox txtYesButton;
        private TextBox txtCancelButton;
        private TextBox txtOkButton;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtDefaultText;
        private Label label12;
        private TextBox txtBackgroundImage;
        private Label label13;
        private OpenFileDialog ofd;
        private ComboBox cbImageLayout;
        private Label label14;
        private TextBox txtBackgroundColor;
        private Label label15;
        private TextBox txtForegroundColor;
        private Label label16;
        private Button btnShowDialog;
        private TextBox txtResult;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuMainFile;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuMainExit;
        private ToolStripMenuItem resetAllToolStripMenuItem;
        private ContextMenuStrip cmDropDowns;
        private ToolStripMenuItem cmDropDownsReset;
        private ContextMenuStrip cmDialogInput;
        private ToolStripMenuItem cmDialogInputReset;
        private ColorDialog cd;
        private TextBox txtComboItems;
        private ContextMenuStrip cmMessage;
        private ToolStripMenuItem cmMessageTwoLineTestText;
        private ToolStripMenuItem longTestTextToolStripMenuItem;
    }
}