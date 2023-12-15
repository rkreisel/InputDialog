# ﻿Input Dialog

Input Dialog is a simple .net 6-windows, Winforms Input dialog in a nuget package.

### Nuget Link

https://www.nuget.org/packages/InputDialog/

### Usage

See the sample usage apps in GitHub 

- https://github.com/rkreisel/InputDialog/tree/main/InputDialog
- https://github.com/rkreisel/InputDialog/tree/main/InputDialogTester
- https://github.com/rkreisel/InputDialog/tree/main/InputDialogUsageSample



```C#
using InputDialog;

namespace InputDialogUsageSample;

public partial class Main : Form
{
    InputDialog.InputDialog.IDIcon selectedIcon = InputDialog.InputDialog.IDIcon.Question;

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
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnDefaultInput_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter text",
            "Title",
            selectedIcon,
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox,
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
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox,
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
            InputDialog.InputDialog.IDButton.OkCancel);
    }

    private void btnComboBoxWithError_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.",
            "Title",
            selectedIcon,
            InputDialog.InputDialog.IDButton.OkCancel,
            type: InputDialog.InputDialog.IDType.ComboBox);
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
                InputDialog.InputDialog.IDButton.OkCancel,
                InputDialog.InputDialog.IDType.TextBox,
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
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox,
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
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox,
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
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox,
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
            InputDialog.InputDialog.IDButton.OkCancel,
            InputDialog.InputDialog.IDType.TextBox,
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
           InputDialog.InputDialog.IDButton.OkCancel,
           type: InputDialog.InputDialog.IDType.ComboBox,
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
            InputDialog.InputDialog.IDButton.OkCancel,
            type: InputDialog.InputDialog.IDType.ComboBox,
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
                selectedIcon = InputDialog.InputDialog.IDIcon.Error;
                mnuIconSelectorError.Checked = true;
                break;
            case "Exclamation":
                selectedIcon = InputDialog.InputDialog.IDIcon.Exclamation;
                mnuIconSelectorExclamation.Checked = true;
                break;
            case "Information":
                selectedIcon = InputDialog.InputDialog.IDIcon.Information;
                mnuIconSelectorInformation.Checked = true;
                break;
            case "Question":
                selectedIcon = InputDialog.InputDialog.IDIcon.Question;
                mnuIconSelectorQuestion.Checked = true;
                break;
            default:
                selectedIcon = InputDialog.InputDialog.IDIcon.Nothing;
                mnuIconSelectorNone.Checked = true;
                break;
        }
    }
}

```

