using System;

class Program
{
    // Row class
    class Row
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

    // Matrix class
    class Matrix
    {
        private Row[] rows;

        public Matrix(int rowCount, int colCount)
        {
            rows = new Row[rowCount];
            for (int i = 0; i < rowCount; i++)
                rows[i] = new Row(colCount);
        }

        public Row GetRow(int index)
        {
            return rows[index];
        }

        public int GetRowCount()
        {
            return rows.Length;
        }

        public int GetColCount()
        {
            return rows[0].GetSize();
        }
    }

    // Vector class
    class Vector
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

        public int GetSize()
        {
            return values.Length;
        }
    }

    // Dimension validator
    class DimensionValidator
    {
        public bool ValidateMatrix(Matrix m1, Matrix m2)
        {
            return m1.GetRowCount() == m2.GetRowCount() && m1.GetColCount() == m2.GetColCount();
        }

        public bool ValidateVector(Vector v1, Vector v2)
        {
            return v1.GetSize() == v2.GetSize();
        }
    }

    // Matrix calculator
    class MatrixCalculator
    {
        private DimensionValidator validator = new DimensionValidator();

        public Matrix Add(Matrix m1, Matrix m2)
        {
            if (!validator.ValidateMatrix(m1, m2))
                throw new InvalidOperationException("Matrix dimensions not compatible");

            Matrix result = new Matrix(m1.GetRowCount(), m1.GetColCount());

            for (int i = 0; i < m1.GetRowCount(); i++)
                for (int j = 0; j < m1.GetColCount(); j++)
                    result.GetRow(i).SetValue(j, m1.GetRow(i).GetValue(j) + m2.GetRow(i).GetValue(j));

            return result;
        }
    }

    // Vector calculator
    class VectorCalculator
    {
        private DimensionValidator validator = new DimensionValidator();

        public Vector Add(Vector v1, Vector v2)
        {
            if (!validator.ValidateVector(v1, v2))
                throw new InvalidOperationException("Vector sizes not compatible");

            Vector result = new Vector(v1.GetSize());

            for (int i = 0; i < v1.GetSize(); i++)
                result.SetValue(i, v1.GetValue(i) + v2.GetValue(i));

            return result;
        }
    }

    // Input handler
    class InputHandler
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

    static void Main()
    {
        InputHandler input = new InputHandler();

        Console.WriteLine("=== Matrix 1 ===");
        Matrix m1 = input.CreateMatrix();

        Console.WriteLine("=== Matrix 2 ===");
        Matrix m2 = input.CreateMatrix();

        MatrixCalculator mCalc = new MatrixCalculator();
        Matrix mResult = mCalc.Add(m1, m2);

        Console.WriteLine("Matrix Result:");
        for (int i = 0; i < mResult.GetRowCount(); i++)
        {
            for (int j = 0; j < mResult.GetColCount(); j++)
                Console.Write(mResult.GetRow(i).GetValue(j) + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\n=== Vector 1 ===");
        Vector v1 = input.CreateVector();

        Console.WriteLine("=== Vector 2 ===");
        Vector v2 = input.CreateVector();

        VectorCalculator vCalc = new VectorCalculator();
        Vector vResult = vCalc.Add(v1, v2);

        Console.WriteLine("Vector Result:");
        for (int i = 0; i < vResult.GetSize(); i++)
            Console.Write(vResult.GetValue(i) + " ");

            }
}
