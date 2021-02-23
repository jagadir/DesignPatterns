public class CalculateClient
{
    private ICalculateInterface _calculateStrategy;

    public CalculateClient(ICalculateInterface calculateStrategy){
        _calculateStrategy = calculateStrategy;
    }

    public int Calculate(int num1, int num2){
        return _calculateStrategy.Calculate(num1, num2);
    }

} 