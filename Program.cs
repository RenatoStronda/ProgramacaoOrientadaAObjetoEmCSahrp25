// See https://aka.ms/new-console-template for more information
//using Program;
using Classes;
namespace portA{
    class Program{
    public static void Main (string[] args){
    porta por = new porta();
    por.setCor("Vermelho");
    Console.WriteLine(por.getCor());
    por.abrirPorta();
    Console.WriteLine(por.getEstadoPorta());
    por.fecharPorta();
    Console.WriteLine(por.getEstadoPorta());
  }
}
}
/*3- Crie uma classe chamada Porta com dois atributos: cor : string e estadoPorta : boolean. Implemente o método chamado abrirPorta() 
que muda o estado do atributo estadoPorta para true. Implemente o método fecharPorta() que altera o estado do atributo 
estadoPorta para false. Ambos os métodos não possuem retorno (void). Quando um objeto do tipo porta é criado, o valor do 
atributo estadoPorta é false.*/