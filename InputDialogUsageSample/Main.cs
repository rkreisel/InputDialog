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
            "Enter text", "Title", InputDialog.InputDialog.IDIcon.Question, InputDialog.InputDialog.IDButton.OkCancel, InputDialog.InputDialog.IDType.TextBox);
        MessageBox.Show(rslt.ResultText);
    }

    private void btnDefaultInput_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter text", "Title", InputDialog.InputDialog.IDIcon.Question, InputDialog.InputDialog.IDButton.OkCancel, InputDialog.InputDialog.IDType.TextBox, defaultText: "Default Text");
        MessageBox.Show(rslt.ResultText);
    }

    private void btnChangeButtonName_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "Enter text", "Title", InputDialog.InputDialog.IDIcon.Question, InputDialog.InputDialog.IDButton.OkCancel, InputDialog.InputDialog.IDType.TextBox, buttonTexts: new ButtonTexts { OKText = "Do It" });
        MessageBox.Show(rslt.ResultText);
    }

    private void btnSimpleMsgBox_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.", "Title", InputDialog.InputDialog.IDIcon.Question, InputDialog.InputDialog.IDButton.OkCancel);
        MessageBox.Show(rslt.ResultText);
    }

    private void btnComboBox_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.", "Title", InputDialog.InputDialog.IDIcon.Question, InputDialog.InputDialog.IDButton.OkCancel, type: InputDialog.InputDialog.IDType.ComboBox, listItems: new List<string> { "Item 1", "Item2", "Item 3"});
        MessageBox.Show(rslt.ResultText);
    }

    private void btnComboBoxWithError_Click(object sender, EventArgs e)
    {
        var rslt = InputDialog.InputDialog.ShowDialog(
            "This is the message.", "Title", InputDialog.InputDialog.IDIcon.Question, InputDialog.InputDialog.IDButton.OkCancel, type: InputDialog.InputDialog.IDType.ComboBox);
        MessageBox.Show(rslt.ResultText);
    }
}
