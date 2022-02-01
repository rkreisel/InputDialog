using InputDialog;

namespace InputDialogUsageSample;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
    }

    private void btnSimpleTextInput_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter text",
            "Title",
            InputDialog.InputDialog.IDIcon.Question,
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
            InputDialog.InputDialog.IDIcon.Question, 
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
            InputDialog.InputDialog.IDIcon.Question, 
            InputDialog.InputDialog.IDButton.OkCancel, 
            InputDialog.InputDialog.IDType.TextBox, 
            buttonTexts: new ButtonTexts { OKText = "Do It" });
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnSimpleMsgBox_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.", 
            "Title", 
            InputDialog.InputDialog.IDIcon.Question,
            InputDialog.InputDialog.IDButton.OkCancel);
    }

    private void btnComboBox_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.", 
            "Title", 
            InputDialog.InputDialog.IDIcon.Question,
            InputDialog.InputDialog.IDButton.OkCancel, 
            type: InputDialog.InputDialog.IDType.ComboBox, 
            listItems: new List<string> { "Item 1", "Item2", "Item 3" });
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }

    private void btnComboBoxWithError_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.", 
            "Title", 
            InputDialog.InputDialog.IDIcon.Question, 
            InputDialog.InputDialog.IDButton.OkCancel, 
            type: InputDialog.InputDialog.IDType.ComboBox);
        if (rslt.DialogResult == DialogResult.OK)
            ShowResult(rslt.ResultText);
    }
    private static void ShowResult(string rslt)
    {
        MessageBox.Show(rslt, "InputDialog Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnChangeFont_Click(object sender, EventArgs e)
    {
        if(fd.ShowDialog() == DialogResult.OK)
        {
            var rslt = InputDialog.InputDialog.ShowDialog(
                "Enter text",
                "Title",
                InputDialog.InputDialog.IDIcon.Question,
                InputDialog.InputDialog.IDButton.OkCancel,
                InputDialog.InputDialog.IDType.TextBox,
                formFont : new Font(fd.Font.FontFamily, fd.Font.Size, fd.Font.Style));
            if (rslt.DialogResult == DialogResult.OK)
                ShowResult(rslt.ResultText);
        }
    }
}
