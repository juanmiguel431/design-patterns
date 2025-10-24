namespace DesignPatters.Models.AdditionalLectures;

public static class ExtensionMethods
{
    public struct BoolMarker<T>
    {
        public bool Result;
        public T Self;

        public enum Operation { None, And, Or }

        internal Operation PendingOp;

        internal BoolMarker(bool result, T self, Operation pendingOp)
        {
            Result = result;
            Self = self;
            PendingOp = pendingOp;
        }

        public BoolMarker(bool result, T self) 
            : this(result, self, Operation.None)
        {
        }
        
        public static implicit operator bool(BoolMarker<T> marker)
        {
            return marker.Result;
        }
        
        public BoolMarker<T> And => new BoolMarker<T>(Result, Self, Operation.And);
    }
    
    public static T AddTo<T>(this T self, ICollection<T> collection)
    {
        collection.Add(self);
        return self;
    }
    
    public static T AddTo<T>(this T self, params ICollection<T>[] collection)
    {
        foreach (var c in collection)
            c.Add(self);
        
        return self;
    }
    
    public static bool IsOneOf<T>(this T self, params T[] values)
    {
        return values.Contains(self);
    }

    public static bool HasNo<TSubject, T>(this TSubject self, Func<TSubject, IEnumerable<T>> props)
    {
        return !props(self).Any();
    }
    
    public static bool HasSome<TSubject, T>(this TSubject self, Func<TSubject, IEnumerable<T>> props)
    {
        return props(self).Any();
    }
    
    public static BoolMarker<TSubject> HasNoV2<TSubject, T>(this TSubject self, Func<TSubject, IEnumerable<T>> props)
    {
        // return !props(self).Any();
        return new BoolMarker<TSubject>(!props(self).Any(), self);
    }
    
    public static BoolMarker<TSubject> HasSomeV2<TSubject, T>(this TSubject self, Func<TSubject, IEnumerable<T>> props)
    {
        // return props(self).Any();
        return new BoolMarker<TSubject>(props(self).Any(), self);
    }

    public static BoolMarker<T> HasNoV2<T, U>(this BoolMarker<T> marker, Func<T, IEnumerable<U>> props)
    {
        if (marker.PendingOp == BoolMarker<T>.Operation.And && !marker.Result)
        {
            return marker;
        }
        
        return new BoolMarker<T>(!props(marker.Self).Any(), marker.Self);
    }
}

public class Lawyer
{
    public List<string> Names { get; } = [];
    public List<Lawyer> Children { get; } = [];
}