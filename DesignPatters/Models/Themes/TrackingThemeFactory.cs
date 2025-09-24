using System.Text;

namespace DesignPatters.Models.Themes;

public class TrackingThemeFactory
{
    private readonly List<WeakReference<ITheme>> _themes = new();
    
    public ITheme CreateTheme(bool dark)
    {
        ITheme theme = dark ? new DarkTheme() : new LightTheme();
        _themes.Add(new WeakReference<ITheme>(theme));
        return theme;
    }

    public string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var reference in _themes)
            {
                if (reference.TryGetTarget(out var theme))
                {
                    var isDark = theme is DarkTheme;
                    sb.Append(isDark ? "Dark" : "Light")
                        .AppendLine(" theme");
                }
            }
            return sb.ToString();
        }
    }
}