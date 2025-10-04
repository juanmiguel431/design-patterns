namespace DesignPatters.Models.Facade;

public class MagicSquareGenerator
{
    private readonly Generator _generator = new();
    private readonly Verifier _verifier = new();
    private readonly Splitter _splitter = new();

    public List<List<int>> Generate(int size)
    {
        do
        {
            var result = new List<List<int>>(size);

            for (int i = 0; i < size; i++)
            {
                result.Add(_generator.Generate(size));
            }

            var splitResult = _splitter.Split(result);

            if (_verifier.Verify(splitResult))
                return result;
        } while (true);
    }
}