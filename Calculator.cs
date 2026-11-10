// Paskaidrojums (a): Calculator balstās uz interfeisu ILogger, nevis uz konkrēto ConsoleLogger, lai
// žurnāla veidu varētu nomainīt (konsole vai atmiņa), nemainot Calculator kodu. To prasa
// Dependency Inversion princips (D) – kods balstās uz abstrakcijām, nevis konkrētām klasēm.
public class Calculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public int Add(int a, int b)
    {
        int result = a + b;
        _logger.Log($"{a} + {b} = {result}");
        return result;
    }
}
