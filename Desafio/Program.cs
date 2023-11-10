using Desafio.Models;
//Crias os modelos de hóspedes e cadastra na lista de hóspedes.
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Renato", sobrenome: "Lage");
Pessoa p2 = new Pessoa(nome: "Maíra", sobrenome: "Rocha");
Pessoa p3 = new Pessoa(nome: "Luiz", sobrenome: "Santos");
hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

//Cria a Suite.
Suite suite = new Suite(tipoSuite:"Luxo", capacidade:3, valorDiaria:150.00m);

//Cria uma nova reserva.
Reserva reserva = new Reserva(diasReservados: 10);

reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");

