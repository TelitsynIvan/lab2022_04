namespace Car;

public class CarComperer :IComparer<Car>
{
    public static string mode { get; set; }
    public int Compare(Car? x, Car? y)
    {
        int ans;
        switch (mode)
        {
            case "year" :
            {
                ans = x.ProductionYear.CompareTo(y.ProductionYear);
                break;
            }
            case "speed":
            {
                ans = x.MaxSpeed.CompareTo(y.MaxSpeed);
                break;
            }
            default:
            {
                ans = x.Name.CompareTo(y.Name);
                break;
            }
        }
        return ans;
    }
}