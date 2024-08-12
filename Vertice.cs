public class Vertice(object conteudo)
{
    public object Conteudo { get; set; } = conteudo;
    public List<Aresta> ListaAdjacencia { get; set; } = [];
}