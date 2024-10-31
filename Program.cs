
VeiculoDAO vdao = new VeiculoDAO();
do
{
    Console.WriteLine("Digite 1 para cadastrar um novo veículo | 2 para listar todos | 3 para deletar um veículo | 4 para consultar | 5 para sair");
    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Veiculo v = new Veiculo();
        Console.WriteLine("Informe a placa");
        v.placa = Console.ReadLine();
        Console.WriteLine("Informe o modelo");
        v.modelo = Console.ReadLine();

        vdao.Cadastrar(v);
    }
    else if (opcao == 2)
    {
        List<Veiculo> veiculos = vdao.ListarTodos();
        foreach (Veiculo v in veiculos)
        {
            Console.WriteLine(v.modelo + " " + v.placa);
        }
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Digite a placa do veículo a ser deletado");
        string placa = Console.ReadLine();
      
        vdao.Deletar(placa);      
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Digite a placa do veícula que deseja consultar");       
        string placa = Console.ReadLine();
        Veiculo veiculo = vdao.Consultar(placa);
        Console.WriteLine(veiculo.modelo + " " + veiculo.placa);
    }
    else
    {
        break;
    }

} while (true);


