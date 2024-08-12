using System;

public class Aresta(Vertice origem, Vertice destino, object conteudo, bool direcionada)
{
    public object Conteudo { get; set; } = conteudo;
    public Vertice Origem { get; set; } = origem;
    public Vertice Destino { get; set; } = destino;

    public bool Direcionada { get; set; } = direcionada;
}