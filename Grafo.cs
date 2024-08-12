public class Grafo
{
    public List<Vertice> Vertices { get; set; } = new List<Vertice>();

    public void AddVertice(Vertice vertice)
    {
        Vertices.Add(vertice);
    }
}