namespace DesignPatters.Models.Themes;

public class ReplaceableThemeFactory
{
    private readonly List<WeakReference<Ref<ITheme>>> _themes = new();

    private ITheme CreateThemeImp(bool dark)
    {
        return dark ? new DarkTheme() : new LightTheme();
    }
    
    public Ref<ITheme> CreateTheme(bool dark)
    {
        var reference = new Ref<ITheme>(CreateThemeImp(dark));
        _themes.Add(new (reference));
        return reference;
    }

    public void ReplaceTheme(bool dark)
    {
        foreach (var weakReference in _themes)
        {
            if (weakReference.TryGetTarget(out var reference))
            {
                reference.Value = CreateThemeImp(dark);
            }
        }
    }
}