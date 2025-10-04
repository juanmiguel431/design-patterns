namespace DesignPatters.Models.Flyweight;

public class FormattedText
{
    private readonly string _plainText;
    private bool[] _capitalize;

    public FormattedText(string plainText)
    {
        _plainText = plainText;
        _capitalize = new bool[plainText.Length];
    }

    public void Capitalize(int start, int end)
    {
        for (var i = start; i <= end; i++)
        {
            _capitalize[i] = true;
        }
    }

    public override string ToString()
    {
        var mySb = new MyStringBuilder();
        for (var i = 0; i < _plainText.Length; i++)
        {
            var c = _plainText[i];
            mySb.Append(_capitalize[i] ? char.ToUpper(c) : c);
        }
        return mySb.ToString();
    }
}

public class BetterFormattedText
{
    private readonly string _plainText;
    private readonly List<TextRange> _formatting = new();

    public BetterFormattedText(string plainText)
    {
        _plainText = plainText;
    }

    public TextRange GetRange(int start, int end)
    {
        var range = new TextRange
        {
            Start = start,
            End = end
        };
        
        _formatting.Add(range);
        return range;
    }

    public override string ToString()
    {
        var msb = new MyStringBuilder();
        for (var i = 0; i < _plainText.Length; i++)
        {
            var c = _plainText[i];
            foreach (var range in _formatting)
            {
                if (range.Covers(i))
                {
                    if (range.Capitalize)
                    {
                        c = char.ToUpper(c);
                    }
                }
            }
            
            msb.Append(c);
        }
        
        return msb.ToString();
    }

    public class TextRange
    {
        public int Start { get; set; }
        public int End { get; set; }
        public bool Capitalize { get; set; }
        public bool Bold { get; set; }
        public bool Italic { get; set; }

        public bool Covers(int position)
        {
            return position >= Start && position <= End;
        }
    }
}