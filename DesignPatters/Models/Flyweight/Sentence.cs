namespace DesignPatters.Models.Flyweight;

public class Sentence
{
    private readonly string[] _words;
    private readonly Dictionary<int, WordToken> _wordTokens = new();

    public Sentence(string plainText)
    {
        _words = plainText.Split(' ');
    }

    public WordToken this[int index]
    {
        get
        {
            if (index < 0 || index >= _words.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            
            var success = _wordTokens.TryGetValue(index, out var token);
            if (success)
            {
                return token;
            }
            
            var newToken = new WordToken();
            _wordTokens.Add(index, newToken);
            
            return newToken;
        }
    }
    
    public override string ToString()
    {
        var msb = new MyStringBuilder();

        for (var index = 0; index < _words.Length; index++)
        {
            var word = _words[index];
            
            var success = _wordTokens.TryGetValue(index, out var token);
            if (success)
            {
                if (token.Capitalize)
                {
                    word = word.ToUpper();
                }
            }

            if (index > 0)
            {
                msb.Append(" ");
            }
            
            msb.Append(word);
        }

        return msb.ToString();
    }

    public class WordToken
    {
        public bool Capitalize;
    }
}