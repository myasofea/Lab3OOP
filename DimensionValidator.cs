public class DimensionValidator
{
    public bool ValidateMatrix(Matrix m1, Matrix m2)
    {
        return m1.GetRowCount() == m2.GetRowCount() &&
               m1.GetColCount() == m2.GetColCount();
    }

    public bool ValidateVector(Vector v1, Vector v2)
    {
        return v1.GetSize() == v2.GetSize();
    }
}
