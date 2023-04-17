var retangulo = new Retangulo();
retangulo.Altura = 2;
retangulo.Largura = 2;

var circulo = new Circulo();
circulo.Raio = 2;

ExibeArea(retangulo);
ExibeArea(circulo);

void ExibeArea(AreaDeObjeto areaDeObjeto)
{
    Console.WriteLine($"Area: {areaDeObjeto.Area()}");
}

interface AreaDeObjeto
{
    float Area();
}

class Retangulo: AreaDeObjeto
{
    public float Largura;
    public float Altura;
    public float Area()
    {
        return Largura * Altura;
    }
}

class Circulo: AreaDeObjeto
{
    public float Raio;
    public float Area()
    {
        return (float)(Math.PI * Raio * Raio);
    }
}

