// See https://aka.ms/new-console-template for more information
using PTI_EstruturaDados;

Console.WriteLine("PTI Estrutura de Dados");
ArvoreBinaria testeA= new ArvoreBinaria();
testeA.Inserir(50, "A");
testeA.Inserir(39, "B");
testeA.Inserir(90, "C");
testeA.Inserir(32, "D");
testeA.Inserir(38, "E");
testeA.Inserir(36, "F");
testeA.Inserir(80, "A");
testeA.Inserir(37, "B");
testeA.Inserir(78, "C");
testeA.Inserir(85, "D");
testeA.Inserir(92, "E");
testeA.Inserir(102, "F");
testeA.imprimeElementosArvore();

Console.WriteLine($"Número de nos da esquerda festiva: {testeA.ContarNosEsquerdaFestiva()}"  );

ArvoreBinaria testeB = new ArvoreBinaria(); 
testeB.Inserir(555,"A");
testeB.Inserir(333, "B");
testeB.Inserir(111, "C");
testeB.Inserir(444, "D");
testeB.Inserir(888, "E");
testeB.Inserir(999, "F");

testeB.imprimeElementosArvore();
Console.WriteLine($"Número de nos da esquerda festiva: {testeB.ContarNosEsquerdaFestiva()}");


