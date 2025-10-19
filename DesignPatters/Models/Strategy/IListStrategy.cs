using System.Text;

namespace DesignPatters.Models.Strategy;

public interface IListStrategy
{
    void Start(StringBuilder sb);
    void End(StringBuilder sb);
    void Add(StringBuilder sb, string item);
}