using System.Collections.Generic;

public class VectorRepository
{
    private List<Vector> vectors = new List<Vector>();

    public void AddVector(Vector v)
    {
        vectors.Add(v);
    }

    public List<Vector> GetVectors()
    {
        return vectors;
    }
}
