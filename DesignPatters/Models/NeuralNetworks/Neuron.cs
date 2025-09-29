using System.Collections;

namespace DesignPatters.Models.NeuralNetworks;

public class Neuron : IEnumerable<Neuron>
{
    public float Value { get; set; }
    public List<Neuron> In { get; set; }
    public List<Neuron> Out { get; set; }

    // public void ConnectTo(Neuron other)
    // {
    //     Out.Add(other);
    //     other.In.Add(this);
    // }

    public IEnumerator<Neuron> GetEnumerator()
    {
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}