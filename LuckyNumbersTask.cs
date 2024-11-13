namespace MKR_1;

public class LuckyNumbersTask
{
    
    private readonly List<int> _numbers = [];
    
    public int Handle(int N)
    {
        _numbers.Clear();

        if (N > 1032)
        {
            throw new ArgumentException();
        }
        
        GenerateLuckyNumbers("", N);

        return _numbers.Count;
    }
    
    private void GenerateLuckyNumbers(string current, int n)
    {
        if (current != "")
        {
            var luckyNumber = int.Parse(current);
            if (luckyNumber > n) return;

            if (!_numbers.Contains(luckyNumber))
            {
                _numbers.Add(luckyNumber);
            }
        }
        
        GenerateLuckyNumbers(current + "4", n);
        GenerateLuckyNumbers(current + "7", n);
    }
    
}