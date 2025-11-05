using Hospedagem.Models;

List<Pessoa> hospedes = new()
{
    new Pessoa("Diogo"),
    new Pessoa("Lucas")
};

Suite suite = new("Premium", 2, 150);

Reserva reserva = new(12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria():C}");