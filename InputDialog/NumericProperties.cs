namespace InputDialog;

public class NumericProperties
{
    public int Value { get; set; } = 0;
    public int Minimum { get; set; } = 0;
    public int Maximum { get; set; } = 100;
    public int Increment { get; set; } = 1;
    public int DecimalPlaces { get; set; } = 0;
    public bool ThousandsSeparator { get; set; } = false;
    public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Right;
    public LeftRightAlignment UpDownAlign { get; set; } = LeftRightAlignment.Right;
}
