namespace DesignPatters.Models.NullObjectPattern;

public interface ILog
{
    int Info(string msg);
    void Warn(string msg);
    
    public static ILog Null => NullLog.Instance;
    
    private sealed class NullLog : ILog
    {
        private static readonly Lazy<NullLog> LazyInstance = new(() => new NullLog());
        public static NullLog Instance => LazyInstance.Value;
    
        private NullLog()
        {
        
        }
    
        public int Info(string msg)
        {
            return 0;
        }

        public void Warn(string msg)
        {
        }
    }
}