namespace InputDialogTester
{
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();
            SetAllDefaults();
        }

        #region Defaults
        public void SetAllDefaults()
        {
            SetDefaultBackgroundColor();
            SetDefaultBackGroundImage();
            SetDefaultButton();
            SetDefaultButtonTexts();
            SetDefaultFont();
            SetDefaultForegroundColor();
            SetDefaultIcon();
            SetDefaultMessage();
            SetDefaultPromptItems();
            SetDefaultPromptType();
            SetDefaultResponseText();
            SetDefaultShowInTaskbar();
            SetDefaultTitle();
        }

        public void SetDefaultMessage() => 
            txtMessage.Text = String.Empty;

        public void SetDefaultTitle() =>
            txtTitle.Text = "ShowDialog";

        public void SetDefaultIcon() =>
            cbIcon.SelectedItem = cbIcon.Items[2];

        public void SetDefaultButton() =>
            cbButtons.SelectedItem = cbButtons.Items[0];

        public void SetDefaultPromptType() =>
            cbPrompt.SelectedItem = cbPrompt .SelectedItem = cbPrompt .Items[2];

        public void SetDefaultPromptItems() =>
            txtComboItems.Text = string.Empty;

        public void SetDefaultShowInTaskbar() =>
            chkShowInTaskbar.Checked = true;

        public void SetDefaultFont () =>
            txtFont.Text = String.Empty;

        public void SetDefaultButtonTexts()
        {
            txtOkButton.Text = "Ok";
            txtCancelButton.Text = "Cancel";
            txtYesButton.Text = "Yes";
            txtNoButton.Text = "No";
        }

        public void SetDefaultResponseText() =>
            txtDefaultText.Text = String.Empty;

        public void SetDefaultBackGroundImage() =>
            txtBackgroundImage.Text = String.Empty;

        public void SetDefaultBackgroundImageLayout() =>
            cbImageLayout.Text = String.Empty;

        public void SetDefaultForegroundColor() =>
            txtForegroundColor.Text = String.Empty;

        public void SetDefaultBackgroundColor() =>
            txtBackgroundColor.Text = String.Empty;

        #endregion

        private void mnuMainResetAll_Click(object sender, EventArgs e)
        {
            SetAllDefaults();
        }

        private void mnuMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}