namespace InputDialog;

public class NumericProperties
{
    public decimal Value { get; set; } = 0;
    public decimal Minimum { get; set; } = 0;
    public decimal Maximum { get; set; } = 100;
    public decimal Increment { get; set; } = 1;
    public int DecimalPlaces { get; set; } = 0;
    public bool ThousandsSeparator { get; set; } = false;
    public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Right;
    public LeftRightAlignment UpDownAlign { get; set; } = LeftRightAlignment.Right;
}
