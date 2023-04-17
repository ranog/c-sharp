var retangulo = new Retangulo();
retangulo.Altura = 2;
retangulo.Largura = 2;

var circulo = new Circulo();
circulo.Raio = 2;

ExibeArea(retangulo);
ExibeArea(circulo);

void ExibeArea(AreaDeObjeto areaDeObjeto)
{
    Console.WriteLine($"Area do {areaDeObjeto.TipoDeObjecto}: {areaDeObjeto.Area()}");
}

abstract class AreaDeObjeto
{
    public string TipoDeObjecto;
    public abstract float Area();
}

class Retangulo: AreaDeObjeto
{
    public float Largura;
    public float Altura;

    public Retangulo()
    {
        TipoDeObjecto = "Retangulo";
    }
    
    public override float Area()
    {
        return Largura * Altura;
    }
}

class Circulo: AreaDeObjeto
{
    public float Raio;
    
    public Circulo()
    {
        TipoDeObjecto = "Circulo";
    }
    
    public override float Area()
    {
        return (float)(Math.PI * Raio * Raio);
    }
}

