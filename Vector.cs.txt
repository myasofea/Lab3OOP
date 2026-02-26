public class Vector
{
    private double[] values;

    public Vector(int size)
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

    public int GetSize() => values.Length;
}
