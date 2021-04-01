using System;

namespace ArvoreBinaria
{
	class ProgramaArvoreBinaria
	{
		static void Main(string[] args)
		{
			Console.WriteLine("arvore binaria!");
			
			ArvoreBinaria arvoreBinaria = new ArvoreBinaria();
			// parte 1
			//arvoreBinaria.CriarArvore();
			
			/*
			arvoreBinaria.Exibir();
			Console.WriteLine();
			Console.WriteLine("pre-ordem: ");
			arvoreBinaria.PercorrerPreOrdem();
			Console.WriteLine();
			Console.WriteLine("em ordem: ");
			arvoreBinaria.PercorrerEmOrdem();
			Console.WriteLine();
			Console.WriteLine("pos-ordem: ");
			arvoreBinaria.PercorrerPosOrdem();
			Console.WriteLine();
			Console.WriteLine("ordenado por nivel: ");
			arvoreBinaria.PercorrerOrdemPorNivel();
			Console.WriteLine();
			*/

			//Console.WriteLine("altura da arvore: " + arvoreBinaria.ObterAltura());
			
			// parte 2
      Console.WriteLine("Digite 0 para iniciar uma nova árvore:");
      var x = Console.ReadLine();
      int y = int.Parse(x);

      switch(y){

      case 0:
      
      Console.WriteLine("Escreva o numero de nós do percurso:");
      var num = Console.ReadLine();
      int n = int.Parse(num);


      for(int i=0; i<n; i++){
      
      var p = Console.ReadLine();
      char per = char.Parse(p);

      arvoreBinaria.Inserir(per);
      }
			arvoreBinaria.Exibir();
      break;
      }

			Console.WriteLine(arvoreBinaria.GetValorMinimo());
			Console.WriteLine(arvoreBinaria.GetValorMaximo());
      Console.WriteLine("em ordem: ");
			arvoreBinaria.PercorrerEmOrdem();
      Console.WriteLine("pre-ordem: ");
			arvoreBinaria.PercorrerPreOrdem();
			Console.WriteLine("pos-ordem: ");
			arvoreBinaria.PercorrerPosOrdem();

			//arvoreBinaria.Remover('A');
			//arvoreBinaria.Remover('B');
			//arvoreBinaria.Remover('C');
			//arvoreBinaria.Remover('D');
			//arvoreBinaria.Remover('F');

			// parte 3

			// parte 4
    }
	}
}