using System.Collections;

namespace DesignPatters.Models.Proxy;

public class Monsters: IEnumerable<Monsters.MonsterProxy>
{
    private readonly int _size;
    private byte[] _age;
    private int[] _x;
    private int[] _y;

    public Monsters(int size)
    {
        _size = size;
        _age = new byte[size];
        _x = new int[size];
        _y = new int[size];
    }
    
    public IEnumerator<MonsterProxy> GetEnumerator()
    {
        for (int pos = 0; pos < _size; pos++)
        {
            yield return new MonsterProxy(this, pos);
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public struct MonsterProxy
    {
        private readonly Monsters _monsters;
        private readonly int _index;

        public MonsterProxy(Monsters monsters, int index)
        {
            _monsters = monsters;
            _index = index;
        }
        
        public ref byte Age => ref _monsters._age[_index];
        public ref int X => ref _monsters._x[_index];
        public ref int Y => ref _monsters._y[_index];
    }
}