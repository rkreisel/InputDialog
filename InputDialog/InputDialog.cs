﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;

namespace InputDialog;


public static class InputDialog
{
    private static readonly Form frm = new();
    private static string _ResultValue = null;
    private static DialogResult _dialogResult;
    private static ButtonTexts _buttonTexts;
    public enum IDIcon
    {
        Error,
        Exclamation,
        Information,
        Question,
        Nothing
    }
    public enum IDType
    {
        ComboBox,
        TextBox,
        MsgBox
    }
    public enum IDButton
    {
        Ok,
        OkCancel,
        YesNo,
        YesNoCancel
    }

    /// <summary>
    /// This form is like a MessageBox, but you can select type of controls on it. 
    /// This form returning a DialogResult value.
    /// </summary>
    /// <param name="message">Message in dialog(as System.String)</param>
    /// <param name="title">Title of dialog (as System.String)</param>
    /// <param name="icon">Select icon (as InputBox.Icon)</param>
    /// <param name="button">Select icon (as InputBox.Buttons)</param>
    /// <param name="type">Type of control in Input box (as InputBox.Type)</param>
    /// <param name="listItems">Array of ComboBox items (as List<string>)</param>
    /// <param name="formFont">Font in form (as Font)</param>
    /// <param name="defaultText">Default text in populate the input window</param>
    /// <returns></returns>
    /// 
    public static IDResult ShowDialog(
        string message,
        string title = "",
        IDIcon icon = IDIcon.Information,
        IDButton button = IDButton.Ok,
        IDType type = IDType.MsgBox,
        IList<string>? listItems = null,
        bool showInTaskBar = false,
        Font formFont = null,
        ButtonTexts buttonTexts = null,
        string defaultText = "")
    {
        //setup
        frm.Controls.Clear();
        frm.Cursor = Cursors.Default;
        _ResultValue = "";
        _buttonTexts = buttonTexts ?? new ButtonTexts();

        //Form definition
        frm.MaximizeBox = false;
        frm.MinimizeBox = false;
        frm.FormBorderStyle = FormBorderStyle.FixedDialog;
        frm.Size = new Size(350, 170);
        frm.Text = title;
        frm.ShowIcon = false;
        frm.ShowInTaskbar = showInTaskBar;
        frm.FormClosing += new FormClosingEventHandler(Frm_FormClosing);
        frm.StartPosition = FormStartPosition.CenterParent;

        //Panel definition
        Panel panel = new()
        {
            Location = new Point(0, 0),
            Size = new Size(340, 97),
            BackColor = Color.White
        };
        frm.Controls.Add(panel);

        //Add icon in to panel
        panel.Controls.Add(Picture(icon));

        //Label definition (message)
        Label label = new()
        {
            Text = message,
            Size = new Size(245, 60),
            Location = new Point(90, 10),
            TextAlign = ContentAlignment.MiddleLeft
        };
        panel.Controls.Add(label);

        //Add buttons to the form
        foreach (Button btn in Btns(button))
            frm.Controls.Add(btn);

        //Add ComboBox or TextBox to the form
        Control ctrl = Cntrl(type, listItems);
        panel.Controls.Add(ctrl);
        if (!string.IsNullOrWhiteSpace(defaultText))
            ctrl.Text = defaultText;

        //Get automatically cursor to the TextBox
        if (ctrl.Name == "textBox")
            frm.ActiveControl = ctrl;

        //Set label font
        if (formFont != null)
            label.Font = formFont;
        frm.ShowDialog();

        //Return text value
        switch (type)
        {
            case IDType.MsgBox:
                break;
            default:
                if (_dialogResult == DialogResult.OK || _dialogResult == DialogResult.Yes)
                    _ResultValue = ctrl.Text;
                else
                    _ResultValue = "";
                break;
        }
        return new IDResult { DialogResult = _dialogResult, ResultText = _ResultValue };
    }

    private static void Button_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        _dialogResult = button.Name switch
        {
            "Yes" => DialogResult.Yes,
            "No" => DialogResult.No,
            "Cancel" => DialogResult.Cancel,
            _ => DialogResult.OK,
        };
        frm.Close();
    }

    private static void TextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            _dialogResult = DialogResult.OK;
            frm.Close();
        }
    }
    private static void Frm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // DialogRes = DialogResult.None;
    }

    private static PictureBox Picture(IDIcon icon)
    {
        PictureBox picture = new();
        //Set icon
        switch (icon)
        {
            case IDIcon.Error:
                picture.Image = SystemIcons.Error.ToBitmap();
                break;
            case IDIcon.Exclamation:
                picture.Image = SystemIcons.Exclamation.ToBitmap();
                break;
            case IDIcon.Information:
                picture.Image = SystemIcons.Information.ToBitmap();
                break;
            case IDIcon.Question:
                picture.Image = SystemIcons.Question.ToBitmap();
                break;
            case IDIcon.Nothing:
                picture.Image = SystemIcons.WinLogo.ToBitmap();
                break;
        }
        picture.SizeMode = PictureBoxSizeMode.StretchImage;
        picture.Size = new Size(60, 60);
        picture.Location = new Point(10, 10);
        return picture;
    }
    private static Button[] Btns(IDButton button)
    {
        //Buttons field for return
        Button[] returnButtons = new Button[3];
        //Buttons instances
        Button OkButton = new();
        Button CancelButton = new();
        Button YesButton = new();
        Button NoButton = new();
        //Set buttons names and text
        OkButton.Text = _buttonTexts.OKText;
        OkButton.Name = "OK";

        YesButton.Text = _buttonTexts.YesText;
        YesButton.Name = "Yes";

        NoButton.Text = _buttonTexts.NoText;
        NoButton.Name = "No";

        CancelButton.Text = _buttonTexts.CancelText;
        CancelButton.Name = "Cancel";

        //Set buttons position
        switch (button)
        {
            case IDButton.Ok:
                OkButton.Location = new Point(250, 101);
                returnButtons[0] = OkButton;
                break;
            case IDButton.OkCancel:
                OkButton.Location = new Point(170, 101);
                returnButtons[0] = OkButton;
                CancelButton.Location = new Point(250, 101);
                returnButtons[1] = CancelButton;
                break;
            case IDButton.YesNo:
                YesButton.Location = new Point(170, 101);
                returnButtons[0] = YesButton;
                NoButton.Location = new Point(250, 101);
                returnButtons[1] = NoButton;
                break;
            case IDButton.YesNoCancel:
                YesButton.Location = new Point(90, 101);
                returnButtons[0] = YesButton;
                NoButton.Location = new Point(170, 101);
                returnButtons[1] = NoButton;
                CancelButton.Location = new Point(250, 101);
                returnButtons[2] = CancelButton;
                break;
        }
        //Set size and event for all used buttons
        foreach (Button btn in returnButtons)
        {
            if (btn != null)
            {
                btn.Size = new Size(75, 23);
                btn.Click += new EventHandler(Button_Click);
            }
        }
        return returnButtons;
    }
    private static Control Cntrl(IDType type, IList<string> listItems)
    {
        Control returnControl = new();
        switch (type)
        {
            case IDType.ComboBox:
                if (listItems == null)
                    listItems = new List<string> { "No Items provided!"};
                ComboBox comboBox = new()
                {
                    Size = new Size(180, 22),
                    Location = new Point(90, 70),
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Name = "comboBox"
                };
                if (listItems != null)
                {
                    foreach (string item in listItems)
                        comboBox.Items.Add(item);
                    comboBox.SelectedIndex = 0;
                }
                returnControl = comboBox;
                break;
            case IDType.TextBox:
                TextBox textBox = new()
                {
                    Size = new Size(180, 23),
                    Location = new Point(90, 70)
                };
                textBox.KeyDown += new KeyEventHandler(TextBox_KeyDown);
                textBox.Name = "textBox";
                returnControl = textBox;
                break;
        }
        return returnControl;
    }
}
