public class Veiculo
{
    public string placa;
    public string numeMotor;
    public string niv;
    public string renavan;
    public string modelo;
    public string marca;

    public Veiculo(string placa, string numeMotor, string niv, string renavan, string modelo, string marca)
    {
        this.placa = placa;
        this.numeMotor = numeMotor;
        this.niv = niv;
        this.renavan = renavan;
        this.modelo = modelo;
        this.marca = marca;
    }
}

public class VeiculoDAO
{
    public List<Veiculo> listaVeiculos = new List<Veiculo>();

    public void Cadastrar(Veiculo v)
    {
        listaVeiculos.Add(v);
    }

    public List<Veiculo> ListarTodos() 
    { 
        return listaVeiculos; 
    }

    public void Deletar(string placa)
    {
       Veiculo vExcluir = listaVeiculos.First(p => p.placa == placa);
        listaVeiculos.Remove(vExcluir);
    }

    public Veiculo Consultar(string placa)
    {
        Veiculo veiculo = listaVeiculos.First(p => p.placa == placa);
        return veiculo;  
    }
}