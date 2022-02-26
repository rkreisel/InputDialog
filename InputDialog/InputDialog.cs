//Acknowledging origin of this code
//https://www.codeproject.com/tips/822756/input-box-in-csharp-for-windowsforms
//It has been modified significantly, converted to .net 6 and turned into a nuget package.

using InputDialog.Utilities;
using Microsoft.Win32;
using System.Reflection.Metadata;

namespace InputDialog;

public static class InputDialog
{
    private static readonly Form frm = new();
    private static string? _ResultValue = null;
    private static DialogResult _dialogResult;
    private static ButtonTexts _buttonTexts;
    private static Size txtSize = new(230, 50);
    private static ToolTip? _tt = null;
    private static Font _defaultFormFont = new("Segoe UI", 9, FontStyle.Regular);
    private static Size _defaultSize = new Size(350, 170);

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
    /// This form functions like a MessageBox, with the added feature of accepting input via a textbox or combobox.
    /// This form returns a IDResult containing the DialogResult and the input/selected text.
    /// All inputs except Message have default values.
    /// Default operation mode is MessageBox.
    /// </summary>
    /// <param name="message">Message in dialog(as System.String)</param>
    /// <param name="title">Title of dialog (as System.String) [Show Dialog]</param>
    /// <param name="icon">Select icon (as InputBox.IDIcon) [Icon.Information]</param>
    /// <param name="button">Select icon (as InputBox.IDButton) [IDButton.Ok]</param>
    /// <param name="type">Type of control in Input box (as InputBox.IDType) [IDType.MsgBox]</param>
    /// <param name="listItems">Array of ComboBox items (as List<string>) {null}</param>
    /// <param name="showInTaskBar">Adds an icon ot the task bar. [false]</param>
    /// <param name="buttonTexts">An instance of a ButtonTexts class (if null defaults to English text) [OK, Cancel, Yes, No (in English)]</param>
    /// <param name="formFont">Font in form (as Font - created as new (Font(parameters...) Note that selected size is ignored for all form controls except the prompt.) [System default for forms]]</param>
    /// <param name="defaultText">Default text for the response box. (Does not apply to the dropdown style) [String.Empty] </param>
    /// <param name="backgroundImage">A Bitmap that will be placed on the form. [null]</param>
    /// <param name="foregroundColor">A for the text. (As System,Color) [null defauilts to Black]</param>
    /// <param name="backgroundColor">A color for the background. (As System,Color) [null defaults to White]</param>
    /// <returns>IDResult containing the DialogResult and the input/selected text</returns>
    public static IDResult ShowDialog(
        string message,
        string title = "Show Dialog",
        IDIcon icon = IDIcon.Information,
        IDButton button = IDButton.Ok,
        IDType type = IDType.MsgBox,
        IList<string>? listItems = null,
        bool showInTaskBar = false,
        Font? formFont = null,
        ButtonTexts? buttonTexts = null,
        string defaultText = "",
        Image? backgroundImage = null,
        ImageLayout? backgroundImageLayout = null,
        Color? foregroundColor = null,
        Color? backgroundColor = null)
    {
        //setup

        //set the default Font for everything
        var fixedFormFontSize = frm.Font.Size;
        var workingFont = formFont ?? frm.Font;
        _defaultFormFont = new Font(workingFont.FontFamily, fixedFormFontSize, workingFont.Style);
        frm.BackgroundImage = null;
        frm.Font = _defaultFormFont;
        frm.Controls.Clear();
        frm.Cursor = Cursors.Default;
        frm.BackColor = backgroundColor ?? Color.White;
        frm.ForeColor = foregroundColor ?? Color.Black;

        _ResultValue = "";
        _buttonTexts = buttonTexts ?? new ButtonTexts();
        if (string.IsNullOrEmpty(defaultText))
            defaultText = string.Empty;

        //Form definition
        frm.MaximizeBox = false;
        frm.MinimizeBox = false;
        frm.FormBorderStyle = FormBorderStyle.FixedDialog;
        frm.Size = _defaultSize;
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
            BackColor = Color.Transparent,
            ForeColor = foregroundColor ?? Color.Black
        };
        if (backgroundImage != null)
        {
            var newSize = backgroundImage.CalcFitSize(_defaultSize.Width, _defaultSize.Height);
            frm.BackgroundImage = backgroundImage.ResizeImage(newSize.Width, newSize.Height);
            frm.BackgroundImageLayout = backgroundImageLayout ?? ImageLayout.Stretch;
        }
        frm.Controls.Add(panel);

        //Add icon in to panel
        panel.Controls.Add(Picture(icon));

        //Add Message
        var ts = MeasureText(panel, message, formFont ?? _defaultFormFont);
        if (ts.Width > (txtSize.Width * .98))
        {
            TextBox text = new()
            {
                Text = message,
                Size = txtSize,
                Location = new Point(90, 10),
                ReadOnly = true,
                Multiline = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                ScrollBars = ScrollBars.Vertical
            };
            //Set label font
            text.Font = formFont ?? _defaultFormFont;            
            panel.Controls.Add(text);
        }
        else
        {
            //Label definition (message)
            Label label = new()
            {
                Text = message,
                Size = new Size(240, 60),
                Location = new Point(90, 10),
                TextAlign = ContentAlignment.MiddleLeft,
                BackColor = Color.Transparent
            };            
            //Set label font
            label.Font = formFont ?? _defaultFormFont;
            panel.Controls.Add(label);
        }

        //Add buttons to the form
        foreach (Button btn in Btns(button))
            frm.Controls.Add(btn);

        //Add ComboBox or TextBox to the form
        Control ctrl = Cntrl(type, listItems, defaultText);
        panel.Controls.Add(ctrl);

        //Move cursor to the TextBox
        if (ctrl.Name == "textBox")
            frm.ActiveControl = ctrl;
        
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

    private static SizeF MeasureText(Control control, string text, Font font)
    {
        var g = Graphics.FromHwnd(control.Handle);
        var ts = g.MeasureString(text, font);
        return ts;
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
        picture.BackColor = Color.Transparent;
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
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Font = _defaultFormFont;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                var tl = MeasureText(btn, btn.Text, _defaultFormFont);

                //if the button text is too wide, add a tool tip with the text
                if (tl.Width > btn.Width * .9)
                {
                    btn.AutoEllipsis = true;
                    GetTooTipControl().SetToolTip(btn, btn.Text);
                }
                btn.Click += new EventHandler(Button_Click);
            }
        }
        return returnButtons;
    }

    private static Control Cntrl(IDType type, IList<string>? listItems, string defaultText = "")
    {
        Control returnControl = new();
        switch (type)
        {
            case IDType.ComboBox:
                if (listItems == null)
                    listItems = new List<string> { "No Items provided!" };
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
                if (!string.IsNullOrEmpty(defaultText?.Trim()))
                {
                    var targetIndex = comboBox.Items.IndexOf(defaultText.Trim());
                    if (targetIndex != 0)
                    {
                        comboBox.SelectedIndex = targetIndex;
                    }
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
                textBox.Text = defaultText;
                returnControl = textBox;
                break;
        }
        return returnControl;
    }

    private static ToolTip GetTooTipControl()
    {
        if (_tt == null)
        {
            _tt = new ToolTip();
        }
        return _tt;
    }
}
