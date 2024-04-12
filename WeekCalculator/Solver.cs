using System;
using System.Data;
namespace WeekCalculator;

public class Solver : ISolve
{

    private string operations = "";

    public void Accumulate(string s)
    {
        operations += s;
    }

    public void Clear()
    {
        operations = "";
    }

    public double Solve()
    {
        return Convert.ToDouble(new DataTable().Compute(operations, null));
    }
}
