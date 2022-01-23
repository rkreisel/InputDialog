namespace InputDialog;
public class IDResult
{
    public DialogResult DialogResult { get; set; }
    public string ResultText { get; set; }

    public IDResult()
    {
        DialogResult = DialogResult.None;
        ResultText = String.Empty;
    }

    public IDResult(DialogResult dr, string txt)
    {
        DialogResult = dr;
        ResultText = txt;
    }
}

