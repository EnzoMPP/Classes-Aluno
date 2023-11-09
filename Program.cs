using _02;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno[] alunos= new Aluno[200];
        int i=0;
        int opção;
        do
        {
            Console.Clear();
            Console.WriteLine("1- Registrar aluno.\n2- Imprimir lista de alunos\n3- Alunos com mais de 5 faltas\n4-Imprimir pela inicial ");
            Console.WriteLine("Escolha a sua opção: ");
            opção=Convert.ToInt32(Console.ReadLine());
            if(opção==1)
            {
                StringBuilder maiusculo=new StringBuilder();
                alunos[i]=new Aluno();
                Console.WriteLine("Informe o nome do aluno: ");
                alunos[i].Nome=Console.ReadLine()??"";
                    if(alunos[i].Nome[0]>='a'&& alunos[i].Nome[0]<='z')
                    {
                        maiusculo.Append(Convert.ToChar(alunos[i].Nome[0]-'a'+'A'));
                    }
                    else
                    {
                        maiusculo.Append(alunos[i].Nome[0]);
                    }
                for(int j=1; j<alunos[i].Nome.Length;j++)
                {
                   if(j!=0 && alunos[i].Nome[j-1]==' '&& alunos[i].Nome[j]>='a'&& alunos[i].Nome[j]<='z')
                    {
                        maiusculo.Append(Convert.ToChar(alunos[i].Nome[j]-'a'+'A'));
                    }
                    else
                    {
                        maiusculo.Append(alunos[i].Nome[j]);
                    }
                }
                alunos[i].Nome=maiusculo.ToString();
                Console.WriteLine("Informe as faltas do aluno: ");
                alunos[i].Faltas=Convert.ToInt32(Console.ReadLine());
                i++;
               
            }
            else if(opção==2)
            {
                Console.WriteLine();
                for(int j=0;j<i;j++)
                {
                    
                    Console.WriteLine("Aluno: {0}\nFaltas: {1}",alunos[j].Nome,alunos[j].Faltas);
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            else if(opção==3)
            {
                Console.WriteLine();
                Console.WriteLine("Os seguintes alunos possuem mais de 5 faltas: ");
                for(int j=0;j<i;j++)
                {
                    if(alunos[j].Faltas>5)
                    {
                        Console.WriteLine("Aluno: {0} Possue: {1} Faltas",alunos[j].Nome, alunos[j].Faltas);
                        
                    }
                }
                Console.ReadKey();
                
            }
            if(opção==4)
            {
                char letra;
                Console.WriteLine("Informe a letra inicial: ");
                letra=Convert.ToChar(Console.ReadLine());
                if(letra>='a'&& letra<='z')
                {
                    letra=Convert.ToChar(letra-'a'+'A');
                }
                Console.WriteLine();
                for(int j=0;j<i;j++)
                {
                    if(alunos[j].Nome[0]==letra)
                    {
                        Console.WriteLine(alunos[j].Nome);
                        Console.WriteLine(alunos[j].Faltas);
                    }
                }
                Console.ReadKey();
                
            }
        }while(opção<=4 && opção>=1);
        Console.WriteLine("Programa encerrado!!!");
        
    }
}