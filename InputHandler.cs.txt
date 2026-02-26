using System;

public class InputHandler
{
    public Matrix CreateMatrix()
    {
        Console.Write("Rows: ");
        int r = int.Parse(Console.ReadLine());

        Console.Write("Columns: ");
        int c = int.Parse(Console.ReadLine());

        Matrix m = new Matrix(r, c);

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                Console.Write($"Value [{i},{j}]: ");
                m.GetRow(i).SetValue(j, double.Parse(Console.ReadLine()));
            }

        return m;
    }

    public Vector CreateVector()
    {
        Console.Write("Vector size: ");
        int size = int.Parse(Console.ReadLine());

        Vector v = new Vector(size);

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Value {i}: ");
            v.SetValue(i, double.Parse(Console.ReadLine()));
        }

        return v;
    }
}
