internal class Program
{
    private static string base10To2(string x)
    {
        string res = "";
        int nr = int.Parse(x);
        while (nr > 0)
        {
            res = res + nr % 2;
            nr /= 2;
        }
        return res;
    }

    private static void binaryClock(string time, ref string result)
    {
        string[] hourMinutesSeconds = time.Split(":");

        string hour = base10To2(hourMinutesSeconds[0]);
        string minutes = base10To2(hourMinutesSeconds[1]);
        string seconds = base10To2(hourMinutesSeconds[2]);

        result = hour + ":" + minutes + ":" + seconds;
    }

    private static void Main(string[] args)
    {
        string result = "";
        string time = DateTime.Now.ToString("HH:mm:ss");
        binaryClock(time, ref result);


        Console.WriteLine($"Time: {time} in binary format is: {result}");
    }
}