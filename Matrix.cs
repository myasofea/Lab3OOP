public class Matrix
{
    private Row[] rows;

    public Matrix(int rowCount, int colCount)
    {
        rows = new Row[rowCount];
        for (int i = 0; i < rowCount; i++)
            rows[i] = new Row(colCount);
    }

    public Row GetRow(int index) => rows[index];
    public int GetRowCount() => rows.Length;
    public int GetColCount() => rows[0].GetSize();
}
