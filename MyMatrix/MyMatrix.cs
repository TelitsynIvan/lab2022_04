namespace MyMatrix;

public class MyMatrix
{
    private int[][] data;
    private static int from { set; get; }
    private static int to { set; get; }
    public MyMatrix(int m, int n)
    {
        Random rnd = new Random();
        data = new int[m][];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = new int[n];
            for (int j = 0; j < data[i].Length; j++)
            {
                data[i][j] = rnd.Next(from, to);
            }
        }
    }

    public static MyMatrix operator +(MyMatrix a, MyMatrix b)
    {
        MyMatrix ans = new MyMatrix(a.data.Length, a.data[0].Length);
        for (int i = 0; i < ans.data.Length; i++)
        {
            for (int j = 0; j < ans.data[i].Length; j++)
            {
                ans.data[i][j] = a.data[i][j] + b.data[i][j];
            }
        }
        return ans;
    }

    public static MyMatrix operator -(MyMatrix a, MyMatrix b)
    {
        MyMatrix ans = new MyMatrix(a.data.Length,a.data[0].Length);
        for (int i = 0; i < ans.data.Length; i++)
        {
            for (int j = 0; j < ans.data[i].Length; j++)
            {
                ans.data[i][j] = a.data[i][j] - b.data[i][j];
            }
        }

        return ans;
    }
    static public MyMatrix operator *(MyMatrix a, MyMatrix b)
    {
        MyMatrix ans = new MyMatrix(a.data.Length, a.data[0].Length);
        for (uint i = 0; i < a.data.Length; ++i)
        {
            for (uint j = 0; j < a.data[0].Length; ++j)
            {
                for (uint n = 0; n < b.data.GetUpperBound(0) + 1; ++n)
                {
                    ans.data[i][j] += a.data[i][n] * b.data[n][j];
                }
            }
        }
        return ans;
    }
    public static MyMatrix operator *(MyMatrix a, int bx)
    {
        MyMatrix ans = new MyMatrix(a.data.Length,a.data[0].Length);
        for (int i = 0; i < ans.data.Length; i++)
        {
            for (int j = 0; j < ans.data[i].Length; j++)
            {
                ans.data[i][j] = a.data[i][j]*bx;
            }
        }

        return ans;
    }
    public static MyMatrix operator /(MyMatrix a, int bx)
    {
        MyMatrix ans = new MyMatrix(a.data.Length,a.data[0].Length);
        for (int i = 0; i < ans.data.Length; i++)
        {
            for (int j = 0; j < ans.data[i].Length; j++)
            {
                ans.data[i][j] = a.data[i][j]/bx;
            }
        }

        return ans;
    }
    public int this[int a, int b]
    {
        get
        {
            return data[a][b];
        }
    }
}