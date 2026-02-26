public class MatrixCalculator
{
    private DimensionValidator validator = new DimensionValidator();

    public Matrix Add(Matrix m1, Matrix m2)
    {
        if (!validator.ValidateMatrix(m1, m2))
            throw new Exception("Matrix dimensions not compatible");

        Matrix result = new Matrix(m1.GetRowCount(), m1.GetColCount());

        for (int i = 0; i < m1.GetRowCount(); i++)
            for (int j = 0; j < m1.GetColCount(); j++)
                result.GetRow(i).SetValue(j,
                    m1.GetRow(i).GetValue(j) + m2.GetRow(i).GetValue(j));

        return result;
    }
}
