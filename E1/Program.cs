using ATIVIDADES___POO.E1;

Animais.Papagaio papagaio = new Animais.Papagaio("Loro", "Papagaio", "Verde", 5);

// Exibindo informações e chamando métodos da subclasse
Console.WriteLine($"\nNome: {papagaio.Nome}");
Console.WriteLine($"Espécie: {papagaio.Especie}");
Console.WriteLine($"Cor das penas: {papagaio.CorDasPenas}");
Console.WriteLine($"Idade: {papagaio.Idade}");
papagaio.Pular();
papagaio.Voar();
papagaio.Respirar();
papagaio.EmitirSom();
papagaio.Comer();