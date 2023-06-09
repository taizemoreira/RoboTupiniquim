/**
Input:
    5 5
    1 2 N
    EMEMEMEMM
    3 3 L
    MMDMMDMDDM
**/

/*
 Output
    Output esperado:
    1 3 N
    5 1 L
*/

namespace RoboTupiniquim
{
    public class Robo
    {
        public static void Main(string[] args)
        {
            string[] comandos = new string[2];
            string[] localizacoes = new string[2];

            Console.WriteLine("Digite o tamanho da área: ");
            string area = Console.ReadLine();

            Console.WriteLine("Informe a localização do robô 01: ");
            localizacoes[0] = Console.ReadLine();

            Console.WriteLine("Informe o comando do robô 01: ");
            comandos[0] = Console.ReadLine();

            Console.WriteLine("Informe a localização do robô 02: ");
            localizacoes[1] = Console.ReadLine();

            Console.WriteLine("Informe o comando do robô 02: ");
            comandos[1] = Console.ReadLine();            

            #region Processamento
            for (int j = 0; j < comandos.Length; j++)
            {
                string[] inputRobo = localizacoes[j].Split(" "); //split -> quebrar uma string em char

                int posicaoX = Convert.ToInt32(inputRobo[0]);
                int posicaoY = Convert.ToInt32(inputRobo[0]);

                char direcao = Convert.ToChar(inputRobo[2]);

                string comando = comandos[j];
                
                char[] instrucoes = comando.ToCharArray();
               
                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if (instrucoes[i] == 'M')
                    {
                        if (direcao == 'N')
                            posicaoY = posicaoY + 1;

                        else if (direcao == 'O')
                            posicaoX = posicaoX - 1;

                        else if (direcao == 'S')
                            posicaoY = posicaoY - 1;

                        else if (direcao == 'L')
                            posicaoX = posicaoX + 1;
                    }
                    else if (instrucoes[i] == 'E') // virar esquerda
                    {
                        if (direcao == 'N')
                            direcao = 'O';

                        else if (direcao == 'O')
                            direcao = 'S';

                        else if (direcao == 'S')
                            direcao = 'L';

                        else if (direcao == 'L')
                            direcao = 'N';
                    }
                    else if (instrucoes[i] == 'D')
                    {
                        switch (direcao)
                        {
                            case 'N': direcao = 'L'; break;
                            case 'O': direcao = 'N'; break;
                            case 'S': direcao = 'O'; break;
                            case 'L': direcao = 'S'; break;

                            default:
                                break;
                        }
                    }
                }
                #endregion

                #region Output de Dados
                Console.WriteLine(posicaoX + posicaoY + " " + direcao);
                #endregion
            }
            Console.ReadLine();           
        }
    }
}
