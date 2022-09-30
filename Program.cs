
namespace TDE
{
	public class Program
	{
        static FilaDinamica filaPrefencial;
        static FilaDinamica filaComum; 

        static int proximaSenhaPrefencial;
        static int proximaSenhaComum;
        static No<string> SenhaAtualPreferencial;
        static No<string> SenhaAtualComum;



        static void Main(string[] args)
        {
            filaPrefencial = new FilaDinamica();
            filaComum = new FilaDinamica();
            proximaSenhaComum = 1;
            proximaSenhaPrefencial = 1;
            SenhaAtualPreferencial = null;
            SenhaAtualComum = null;
            Menu();
        }

        static void PrintarMenu(){
            Console.WriteLine("**********************************");
            Console.WriteLine("* TDE de Filas *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*   Comandos:                    *");
            Console.WriteLine("* - Para Gerar Senha Preferencial, digite 1 -*");
            Console.WriteLine("* - Para Gerar Senha Comumm, digite 2 -*");
            Console.WriteLine("* - Para Consultar Senhas, digite 3 -*");
            Console.WriteLine("* - Para Chamar Senha Prefencial, digite 4 -*");
            Console.WriteLine("* - Para Chamar Senha Comum, digite 5 -*");
            Console.WriteLine("* - Para Sair, digite 9 -*");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("*                                *");
            Console.WriteLine("**********************************");
        }


        static void Menu(){
            int opcao;
            do
            {
                PrintarMenu();
                Console.Write("Digite o comando que deseja executar: ");
                if(int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao){
                        case 1:
                            GerarSenhaPreferencial();
                            break;
                        case 2:
                            GerarSenhaComum();
                            break;
                        case 3:
                            ConsultarSenhas();
                            break;
                        case 4:
                            ChamarSenhaPreferencial();
                            break;
                         case 5:
                            ChamarSenhaComum();
                            break;
                        case 9:
                            break;
                        default:
                            Console.WriteLine("Comando inválido! Digite um comando valido");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Comando inválido! Digite um comando valido");
                }

                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            } while(opcao != 9);

            Console.WriteLine("Aperte ENTER para sair");
            Console.ReadLine();
        }

        static void GerarSenhaPreferencial(){
            string senhaGerada = $"CXP_{proximaSenhaPrefencial}";
            filaPrefencial.Enfilerar(senhaGerada);
            proximaSenhaPrefencial++;
            Console.WriteLine($"Sua senha é: {senhaGerada}");
        }

        static void GerarSenhaComum(){
            string senhaGerada = $"CXN_{proximaSenhaComum}";
            filaComum.Enfilerar(senhaGerada);
            proximaSenhaComum++;
            Console.WriteLine($"Sua senha é: {senhaGerada}");
        }

        static void ConsultarSenhas(){
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine("FILA PREFERENCIAL: ");
            Console.WriteLine($"Senha Atual {SenhaAtualPreferencial?.Valor} - Proxima Senha {filaPrefencial.Inicio?.Valor}");
            Console.WriteLine("FILA COMUM: ");
            Console.WriteLine($"Senha Atual {SenhaAtualComum?.Valor} - Proxima Senha {filaComum?.Inicio?.Valor}");
            Console.WriteLine("**********************************");
        }

        static void ChamarSenhaPreferencial(){
            if(filaPrefencial.EstaVazia()){
                SenhaAtualPreferencial = null;
                Console.Clear();
                Console.WriteLine("Fila está vazia");
                return;
            }

            SenhaAtualPreferencial = filaPrefencial.Desenfilerar();
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine($"SENHA PREFENCIAL CHAMADA: {SenhaAtualPreferencial.Valor}");
            Console.WriteLine("**********************************");
        }

        static void ChamarSenhaComum(){
            if(filaComum.EstaVazia()){
                SenhaAtualComum = null;
                Console.Clear();
                Console.WriteLine("Fila está vazia");
                return;
            }
            
            SenhaAtualComum = filaComum.Desenfilerar();
            Console.Clear();
            Console.WriteLine("**********************************");
            Console.WriteLine($"SENHA PREFENCIAL CHAMADA: {SenhaAtualComum.Valor}");
            Console.WriteLine("**********************************");
        }

    }

}

