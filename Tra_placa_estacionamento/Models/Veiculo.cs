internal class veiculo
{
    protected string _placa;
    protected string _id;

    public string Placa
    {
        get => _placa;
        set => _placa = value;
    }
    public string Id
    {
        get => _id;
        set => _id = value;
    }
    public Veiculo
    {
        _placa = string.Empty;
        _id = string.Empty;

    }

    public Veiculo(
        string placa,
        string id)
    {
        _placa = Placa;
        _id = Id;
    }

    public virtual void Mostra()
    {
        Console.WriteLine("Placa: "+ _placa);
        Console.WriteLine("Descrição: "+ _id);
    }
}