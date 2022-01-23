namespace InputDialog;
public class ButtonTexts
{
    public string OKText { get; set; }
    public string CancelText { get; set; }
    public string YesText { get; set; }
    public string NoText { get; set; }

    public ButtonTexts(
        string okText = "Ok",
        string cancelText = "Cancel",
        string yesText = "Yes",
        string noText = "No"
    )
    {
        OKText = okText;
        CancelText = cancelText;
        YesText = yesText;
        NoText = noText;
    }
}

