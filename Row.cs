public class Row
{
    private double[] values;

    public Row(int size)
    {
        values = new double[size];
    }

    public void SetValue(int index, double value)
    {
        values[index] = value;
    }

    public double GetValue(int index)
    {
        return values[index];
    }

    public int GetSize()
    {
        return values.Length;
    }
}
