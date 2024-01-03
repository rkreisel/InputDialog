using InputDialog;

namespace InputDialogUsageSample;

public partial class Main : Form
{
    InputDialog.IDIcon selectedIcon = InputDialog.IDIcon.Question;

    public Main()
    {
        InitializeComponent();
        mnuIconSelectorQuestion.Checked = true;
    }

    private void btnSimpleTextInput_Click(object sender, EventArgs e)
    {
        var txt = cmLongText.Checked
            ? "This can be a long piece of text. This test is to show how the feature works. This is a really long chunk of text. I just want to see how it scrolls when it gets too long for the window."
            : "Enter Text";
        var rslt = InputDialog.InputDialog.ShowDialog(
            txt,
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnDefaultInput_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter text",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox,
            defaultText: "Default Text");
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnChangeButtonName_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter text",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox,
            buttonTexts: new ButtonTexts { OKText = "Do It long button text here" });
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnSimpleMsgBox_Click(object sender, EventArgs e)
    {
        InputDialog.InputDialog.ShowDialog(
            "This is the message.",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel);
    }

    private void btnComboBoxWithError_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            type: InputDialog.IDType.ComboBox);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnChangeFont_Click(object sender, EventArgs e)
    {
        if (fd.ShowDialog() == DialogResult.OK)
        {
            var rslt = InputDialog.InputDialog.ShowDialog(
                "Enter text",
                "Title",
                selectedIcon,
                InputDialog.IDButton.OkCancel,
                InputDialog.IDType.TextBox,
                formFont: new Font(fd.Font.FontFamily, fd.Font.Size, fd.Font.Style));
            if (rslt.DialogResult == DialogResult.OK)
                ShowResult(rslt.ResultText);
        }
    }

    private void btnChangeBackColor_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter Text",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox,
            backgroundColor: Color.AliceBlue);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnChangeForeColor_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter Text",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox,
            foregroundColor: Color.Red);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnChangeBothColors_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter Text",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox,
            foregroundColor: Color.White,
            backgroundColor: Color.DarkBlue);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnBackgroundImage_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter Text",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            InputDialog.IDType.TextBox,
            foregroundColor: Color.White,
            formFont: new Font("Arial", 28, FontStyle.Bold),
            backgroundImage: Image.FromFile(@"Images\Picture.jpg"),
            backgroundImageLayout: ImageLayout.Stretch);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private static void ShowResult(string rslt)
    {
        MessageBox.Show(rslt, "InputDialog Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnEditableComboBox_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
           "This is the message.",
           "Title",
           selectedIcon,
           InputDialog.IDButton.OkCancel,
           type: InputDialog.IDType.ComboBox,
           listItems: new List<string> { "Item 1", "Item2", "Item 3" },
           acceptsUserInput: true);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnLockedComboBox_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            type: InputDialog.IDType.ComboBox,
            listItems: new List<string> { "Item 1", "Item2", "Item 3" },
            acceptsUserInput: false);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void mnuIconSelector_Click(object sender, EventArgs e)
    {
        var sndr = sender as ToolStripMenuItem;
        mnuIconSelectorError.Checked = false;
        mnuIconSelectorExclamation.Checked = false;
        mnuIconSelectorInformation.Checked = false;
        mnuIconSelectorNone.Checked = false;
        mnuIconSelectorQuestion.Checked = false;
        var selectedItem = sndr?.Text;
        switch (selectedItem)
        {
            case "Error":
                selectedIcon = IDIcon.Error;
                mnuIconSelectorError.Checked = true;
                break;
            case "Exclamation":
                selectedIcon = IDIcon.Exclamation;
                mnuIconSelectorExclamation.Checked = true;
                break;
            case "Information":
                selectedIcon = IDIcon.Information;
                mnuIconSelectorInformation.Checked = true;
                break;
            case "Question":
                selectedIcon = IDIcon.Question;
                mnuIconSelectorQuestion.Checked = true;
                break;
            default:
                selectedIcon = IDIcon.Nothing;
                mnuIconSelectorNone.Checked = true;
                break;
        }
    }

    private void btnNumericUpDown_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Use the arrows to select a value.",
            "Title",
            selectedIcon,
            InputDialog.IDButton.OkCancel,
            type: InputDialog.IDType.Numeric,
            numericProperties: new NumericProperties 
            {
                //Try out these options that change the display
                //Increment = 1,
                //Maximum = 100,
                //Minimum = 1,
                //Value = 9999,
                //DecimalPlaces = 2, ThousandsSeparator = true,
                //UpDownAlign = LeftRightAlignment.Left,
                //HorizontalAlignment = HorizontalAlignment.Center
            },
            acceptsUserInput: true);;
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }
}
