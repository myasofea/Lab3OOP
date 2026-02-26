using System.Collections.Generic;

public class MatrixRepository
{
    private List<Matrix> matrices = new List<Matrix>();

    public void AddMatrix(Matrix m)
    {
        matrices.Add(m);
    }

    public List<Matrix> GetMatrices()
    {
        return matrices;
    }
}
