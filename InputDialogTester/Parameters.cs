using InputDialog;

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
        private bool acceptsUserInput = false;
        private readonly NumericProperties numericProperties = new();

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
            SetNumericProperties();
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
            cbPrompt.SelectedItem = cbPrompt.SelectedItem = cbPrompt.Items[3];
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

        public void SetNumericProperties()
        {

            nudDecimalPlaces.Value = numericProperties.DecimalPlaces;
            txtIncrement.Text = numericProperties.Increment.ToString();
            nudMaximum.Value = numericProperties.Maximum;
            nudStartValue.Value = numericProperties.Value;
            nudMinimum.Value = numericProperties.Minimum;
            chkThousandsSeparator.Checked = numericProperties.ThousandsSeparator;
            cbArrowPosition.Text = numericProperties.UpDownAlign.ToString();
            cbAlignment.Text = numericProperties.HorizontalAlignment.ToString();
        }
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
            if (currentComboBox != null)
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
            if (chosenType == IDType.Numeric)
            {
                if (!ValidateNumericProperties())
                    return;
                numericProperties.Value = nudStartValue.Value;
                numericProperties.ThousandsSeparator = chkThousandsSeparator.Checked;
                numericProperties.Maximum = nudMaximum.Value;
                numericProperties.Minimum = nudMinimum.Value;
                numericProperties.Increment = decimal.Parse(txtIncrement.Text);
                numericProperties.HorizontalAlignment = (HorizontalAlignment)Enum.Parse(typeof(HorizontalAlignment), cbAlignment.Text);
                numericProperties.UpDownAlign = (LeftRightAlignment)Enum.Parse(typeof(LeftRightAlignment), cbArrowPosition.Text);
                numericProperties.DecimalPlaces = (int)nudDecimalPlaces.Value;
            }

            ButtonTexts btnTxts = new()
            {
                CancelText = txtCancelButton.Text,
                NoText = txtNoButton.Text,
                OKText = txtOkButton.Text,
                YesText = txtYesButton.Text,
            };
            Image? bgImage = string.IsNullOrEmpty(chosenBackgroundImageFilename)
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
                backgroundColor: chosenBackgroundColor,
                acceptsUserInput: acceptsUserInput,
                numericProperties: numericProperties,
                multilineTextbox: chkMultiline.Checked);
            if (rslt.DialogResult == DialogResult.OK)
                txtResult.Text = rslt.ResultText;
        }

        private void cbPrompt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPrompt.SelectedItem.ToString())
            {
                case "Locked Combo Box":
                    chosenType = IDType.ComboBox;
                    acceptsUserInput = false;
                    break;
                case "Editable Combo Box":
                    chosenType = IDType.ComboBox;
                    acceptsUserInput = true;
                    break;
                case "Text Box":
                    chosenType = IDType.TextBox;
                    break;
                case "Message Box":
                    chosenType = IDType.MsgBox;
                    break;
                case "Numeric Selector":
                    chosenType = IDType.Numeric;
                    break;
            }
        }

        private bool ValidateNumericProperties()
        {
            var errors = new List<string>();
            if (nudMaximum.Value <= nudMinimum.Value)
                errors.Add("Maximum must the greater than the Minimum.");
            if (nudMinimum.Value >= nudMaximum.Value)
                errors.Add("Minimum must the less than the Maximum.");
            if (nudStartValue.Value > nudMaximum.Value || nudStartValue.Value < nudMinimum.Value)
                errors.Add("Start value must be between the Minimum and Maximum");
            if (errors.Any())
            {
                MessageBox.Show(string.Join($"{Environment.NewLine}", errors));
                return false;
            }
            return true;
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
            var selectorText = cbButtons.SelectedItem.ToString()?.Replace(" ", "").Replace("and", "").Replace(",", "");
            IDButton.TryParse(typeof(IDButton), selectorText, out object? btnType);
            if (btnType != null)
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
                _ => IDIcon.Nothing
            };
        }

        private void txtIncrement_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtIncrement.Text, out decimal increment))
            {
                MessageBox.Show("Please enter a numeric value.");
            }
            else
            {
                numericProperties.Increment = increment;
            }
        }
    }
}