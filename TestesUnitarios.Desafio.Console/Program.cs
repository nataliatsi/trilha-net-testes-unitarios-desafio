using TestesUnitarios.Desafio.Console.Services;

var validacoesLista = new ValidacoesLista();

// Teste do método RemoverNumerosNegativos
var listaComNegativos = new List<int> { -1, 2, -3, 4, -5 };
var listaSemNegativos = validacoesLista.RemoverNumerosNegativos(listaComNegativos);
Console.WriteLine("RemoverNumerosNegativos:");
Console.WriteLine(string.Join(", ", listaSemNegativos)); // Esperado: 2, 4

// Teste do método ListaContemDeterminadoNumero
var lista = new List<int> { 1, 2, 3 };
bool contem = validacoesLista.ListaContemDeterminadoNumero(lista, 2);
Console.WriteLine("ListaContemDeterminadoNumero (2):");
Console.WriteLine(contem); // Esperado: True

contem = validacoesLista.ListaContemDeterminadoNumero(lista, 4);
Console.WriteLine("ListaContemDeterminadoNumero (4):");
Console.WriteLine(contem); // Esperado: False

// Teste do método MultiplicarNumerosLista
var listaParaMultiplicar = new List<int> { 1, 2, 3 };
var listaMultiplicada = validacoesLista.MultiplicarNumerosLista(listaParaMultiplicar, 2);
Console.WriteLine("MultiplicarNumerosLista:");
Console.WriteLine(string.Join(", ", listaMultiplicada)); // Esperado: 2, 4, 6

// Teste do método RetornarMaiorNumeroLista
var listaParaMaiorNumero = new List<int> { 1, 2, 3, 4, 5 };
int maiorNumero = validacoesLista.RetornarMaiorNumeroLista(listaParaMaiorNumero);
Console.WriteLine("RetornarMaiorNumeroLista:");
Console.WriteLine(maiorNumero); // Esperado: 5

// Teste do método RetornarMenorNumeroLista
var listaParaMenorNumero = new List<int> { 1, 2, 3, 4, 5 };
int menorNumero = validacoesLista.RetornarMenorNumeroLista(listaParaMenorNumero);
Console.WriteLine("RetornarMenorNumeroLista:");
Console.WriteLine(menorNumero); // Esperado: 1