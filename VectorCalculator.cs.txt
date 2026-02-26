public class VectorCalculator
{
    private DimensionValidator validator = new DimensionValidator();

    public Vector Add(Vector v1, Vector v2)
    {
        if (!validator.ValidateVector(v1, v2))
            throw new Exception("Vector sizes not compatible");

        Vector result = new Vector(v1.GetSize());

        for (int i = 0; i < v1.GetSize(); i++)
            result.SetValue(i, v1.GetValue(i) + v2.GetValue(i));

        return result;
    }
}
