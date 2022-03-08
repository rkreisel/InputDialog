using InputDialog;
using static InputDialog.InputDialog;

namespace InputDialogTester
{
    public partial class Parameters : Form
    {
        private Font? chosenFont;
        private string? chosenBackgroundImageFilename;
        private Color? chosenForegroundColor;
        private Color? chosenBackgroundColor;
        private ComboBox? currentComboBox = null;
        private TextBox? currentTextBox = null;
        private IDIcon chosenIcon;
        private IDButton chosenButton;
        private IDType chosenType;
        private ImageLayout? chosenImageLayout;

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
            SetDefaultImageLayout();
        }

        public void SetDefaultMessage() =>
            txtMessage.Text = String.Empty;

        public void SetDefaultTitle() =>
            txtTitle.Text = "ShowDialog";

        public void SetDefaultIcon()
        {
            cbIcon.SelectedItem = cbIcon.Items[2];
            chosenIcon = IDIcon.Information;
        }

        public void SetDefaultButton()
        {
            cbButtons.SelectedItem = cbButtons.Items[0];
            chosenButton = IDButton.Ok;
        }

        public void SetDefaultPromptType()
        {
            cbPrompt.SelectedItem = cbPrompt.SelectedItem = cbPrompt.Items[2];
            chosenType = IDType.MsgBox;
        }

        public void SetDefaultPromptItems() =>
            txtComboItems.Text = string.Empty;

        public void SetDefaultShowInTaskbar() =>
            chkShowInTaskbar.Checked = true;

        public void SetDefaultFont()
        {
            chosenFont = this.Font;
            txtFont.Text = $"{chosenFont.Name}, {chosenFont.Size}, {chosenFont.Style}";
        }

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

        public void SetDefaultBackgroundImageLayout()
        {
            cbImageLayout.Text = String.Empty;
            chosenImageLayout = ImageLayout.None;
        }

        public void SetDefaultForegroundColor() =>
            txtForegroundColor.Text = String.Empty;

        public void SetDefaultBackgroundColor() =>
            txtBackgroundColor.Text = String.Empty;

        public void SetDefaultImageLayout() =>
            cbImageLayout.SelectedItem = null;

        #endregion

        #region Screen Control
        private void mnuMainResetAll_Click(object sender, EventArgs e)
        {
            SetAllDefaults();
        }

        private void mnuMainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtFont_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmDropDownsReset_Click(object sender, EventArgs e)
        {
            switch (currentComboBox.Name)
            {
                case "cbIcon":
                    SetDefaultIcon();
                    break;
                case "cbButtons":
                    SetDefaultButton();
                    break;
                case "cbPrompt":
                    SetDefaultPromptType();
                    SetDefaultPromptItems();
                    break;
                case "cbImageLayout":
                    SetDefaultImageLayout();
                    break;
            }
        }

        private void SetCurrentComboBox(object sender, MouseEventArgs e) =>
            currentComboBox = sender as ComboBox;

        private void SetCurrentTextBox(object sender, MouseEventArgs e) =>
            currentTextBox = sender as TextBox;

        private void txtFont_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fd.ShowDialog() == DialogResult.OK)
            {
                chosenFont = fd.Font;
                txtFont.Text = $"{chosenFont.Name}, {chosenFont.Size}, {chosenFont.Style}";
            }
        }

        private void cmDialogInputReset_Click(object sender, EventArgs e)
        {
            if (currentTextBox == null)
                return;
            switch (currentTextBox.Name)
            {
                case "txtFont":
                    txtFont.Text = String.Empty;
                    chosenFont = null;
                    break;
                case "txtBackgroundImage":
                    txtBackgroundImage.Text = String.Empty;
                    chosenBackgroundImageFilename = null;
                    cbImageLayout.SelectedIndex = -1;
                    break;
                case "txtBackgroundColor":
                    txtBackgroundColor.Text = String.Empty;
                    chosenBackgroundColor = null;
                    break;
                case "txtForegroundColor":
                    txtForegroundColor.Text = string.Empty;
                    chosenForegroundColor = null;
                    break;
            }
        }

        private void txtBackgroundImage_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtBackgroundImage.Text = chosenBackgroundImageFilename = ofd.FileName;
                if (cbImageLayout.SelectedIndex == -1)
                {
                    cbImageLayout.SelectedIndex = 3;
                }
            }
        }

        private void txtBackgroundColor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtBackgroundColor.Text = cd.Color.Name;
                chosenBackgroundColor = cd.Color;
            }
        }

        private void txtForegroundColor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtForegroundColor.Text = cd.Color.Name;
                chosenForegroundColor = cd.Color;
            }
        }
        #endregion

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            ButtonTexts btnTxts = new ButtonTexts
            {
                CancelText = txtCancelButton.Text,
                NoText = txtNoButton.Text,
                OKText = txtOkButton.Text,
                YesText = txtYesButton.Text,
            };
            Image bgImage = string.IsNullOrEmpty(chosenBackgroundImageFilename)
                ? null
                : Image.FromFile(chosenBackgroundImageFilename);

            var rslt = InputDialog.InputDialog.ShowDialog(
                message: txtMessage.Text,
                title: txtTitle.Text,
                icon: chosenIcon,
                button: chosenButton,
                type: chosenType,
                listItems: txtComboItems.Lines.ToList(),
                showInTaskBar: chkShowInTaskbar.Checked,
                formFont: chosenFont,
                buttonTexts: btnTxts,
                defaultText: string.IsNullOrEmpty(txtDefaultText.Text?.Trim()) ? String.Empty : txtDefaultText.Text,
                backgroundImage: bgImage,
                backgroundImageLayout: chosenImageLayout,
                foregroundColor: chosenForegroundColor,
                backgroundColor: chosenBackgroundColor); ;
            if (rslt.DialogResult == DialogResult.OK)
                txtResult.Text = rslt.ResultText;
        }

        private void cbPrompt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPrompt.SelectedItem.ToString())
            {
                case "Combo Box":
                    chosenType = IDType.ComboBox;
                    break;
                case "Text Box":
                    chosenType = IDType.TextBox;
                    break;
                case "Message Box":
                    chosenType = IDType.MsgBox;
                    break;
            }
        }

        private void cbImageLayout_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbImageLayout.SelectedItem == null)
            {
                return;
            }
            ImageLayout.TryParse(typeof(ImageLayout), cbImageLayout.SelectedItem.ToString(), out object? layoutType);
            chosenImageLayout = (ImageLayout?)layoutType;
        }

        private void cbButtons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbButtons.SelectedItem == null)
                return;
            var selectorText = cbButtons.SelectedItem.ToString().Replace(" ", "").Replace("and", "").Replace(",", "");
            IDButton.TryParse(typeof(IDButton), selectorText, out object btnType);
            chosenButton = (IDButton)btnType;
        }

        private void cmMessageTwoLineTestText_Click(object sender, EventArgs e)
        {
            txtMessage.Text = Properties.Resources.TwoLineTestText;
        }

        private void longTestTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMessage.Text = Properties.Resources.LongTestText;
        }

        private void cbIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenIcon = cbIcon.SelectedIndex switch
            {
                0 => IDIcon.Error,
                1 => IDIcon.Exclamation,
                2 => IDIcon.Information,
                3 => IDIcon.Question,
                4 => IDIcon.Nothing,
                _ => IDIcon.Warning
            };
        }
    }
}