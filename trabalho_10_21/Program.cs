using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace trabalho_10_21
{
    internal class Program
    {
        static void carregando_pergunta()
        {
            string mensagem = "Pressione Enter para continuar...";

            Console.SetCursorPosition(4, 13);
            Console.Write(mensagem);

            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
            }

            Console.Clear();
        }
        protected static void Box2LC(int x1, int y1, int x2, int y2)
        {
            int origCol = 0;
            int origRow = 0;
            try
            {
                //Base Inicial
                Console.SetCursorPosition(origCol + y1, origRow + x1);
                Console.Write("╔");
                for (int i = 1; i < (y2 - y1); i++)
                {
                    Console.Write("═");
                }
                Console.WriteLine("╗");
                //Base Lateral
                for (int i = 1; i < (x2 - x1); i++)
                {
                    Console.SetCursorPosition(origCol + y1, origRow + (x1 + i));
                    Console.Write("║");
                    Console.SetCursorPosition(origCol + y2, origRow + (x1 + i));
                    Console.WriteLine("║");
                }
                //Base Final
                Console.SetCursorPosition(origCol + y1, origRow + x2);
                Console.Write("╚");
                for (int i = 1; i < (y2 - y1); i++)
                {
                    Console.Write("═");
                }
                Console.WriteLine("╝");

                // colocar título simples (posição fixa)
                
                int startCol = origCol + y1 + 2; // posição fixa, simples para projeto escolar
                int titleRow = origRow + x1 + 1; // na primeira linha interna
                try
                {
                    Console.SetCursorPosition(startCol, titleRow);
                    
                }
                catch (ArgumentOutOfRangeException) { }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        protected static void Box1LC(int x1, int y1, int x2, int y2)
        {
            int origCol = 0;
            int origRow = 0;
            try
            {
                //Base Inicial
                Console.SetCursorPosition(origCol + y1, origRow + x1);
                Console.Write("┌");
                for (int i = 1; i < (y2 - y1); i++)
                {
                    Console.Write("─");
                }
                Console.WriteLine("┐");
                //Base Lateral
                for (int i = 1; i < (x2 - x1); i++)
                {
                    Console.SetCursorPosition(origCol + y1, origRow + (x1 + i));
                    Console.Write("│");
                    Console.SetCursorPosition(origCol + y2, origRow + (x1 + i));
                    Console.WriteLine("│");
                }
                //Base Final
                Console.SetCursorPosition(origCol + y1, origRow + x2);
                Console.Write("└");
                for (int i = 1; i < (y2 - y1); i++)
                {
                    Console.Write("─");
                }
                Console.WriteLine("┘");

                // colocar título simples (posição fixa)
                string titulo = "Questionário de Português";
                int startCol = origCol + y1 + 2; 
                int titleRow = origRow + x1 + 1; 
                try
                {
                    Console.SetCursorPosition(startCol, titleRow);
                    Console.Write(titulo);
                }
                catch (ArgumentOutOfRangeException) { }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            // Definindo as variavés

            int questao = 0;
            int acertos = 0;
            int a = 0;

            string opcao;

            // Instanciando as variavíes

            string[] pergunta = new string[20];
            string[,] alternativas = new string[20,20];
            string[] resposta = new string[20];

            // Criando as perguntas
            // Índice 0 | Primeira pergunta
            
            pergunta[0] = "Qual é a função principal do sujeito em uma oração?";
            alternativas[0, 0] = "A) Ser o termo sobre o qual se declara algo";
            alternativas[0, 1] = "B) Complementar o verbo";
            alternativas[0, 2] = "C) Modificar um substantivo";
            alternativas[0, 3] = "D) Indicar a ação praticada";
            resposta[0] = "A";

            pergunta[1] = "Em qual alternativa o verbo está no pretérito perfeito?";
            alternativas[1, 0] = "A) Cantava";
            alternativas[1, 1] = "B) Cantarei";
            alternativas[1, 2] = "C) Cantaria";
            alternativas[1, 3] = "D) Cantei";
            resposta[1] = "D";

            pergunta[2] = "Qual figura de linguagem consiste em uma comparação implícita?";
            alternativas[2, 0] = "A) Hipérbole";
            alternativas[2, 1] = "B) Ironia";
            alternativas[2, 2] = "C) Metáfora";
            alternativas[2, 3] = "D) Eufemismo";
            resposta[2] = "C";

            pergunta[3] = "Qual alternativa apresenta um substantivo abstrato?";
            alternativas[3, 0] = "A) Mesa";
            alternativas[3, 1] = "B) Felicidade";
            alternativas[3, 2] = "C) Cidade";
            alternativas[3, 3] = "D) Cachorro";
            resposta[3] = "B";

            pergunta[4] = "A palavra 'rapidamente' pertence a qual classe gramatical?";
            alternativas[4, 0] = "A) Advérbio";
            alternativas[4, 1] = "B) Pronome";
            alternativas[4, 2] = "C) Adjetivo";
            alternativas[4, 3] = "D) Verbo";
            resposta[4] = "A";

            pergunta[5] = "Qual alternativa apresenta um pronome possessivo?";
            alternativas[5, 0] = "A) Aquele";
            alternativas[5, 1] = "B) Isto";
            alternativas[5, 2] = "C) Meu";
            alternativas[5, 3] = "D) Quem";
            resposta[5] = "C";

            pergunta[6] = "Na frase 'Maria, venha aqui!', a vírgula separa:";
            alternativas[6, 0] = "A) O sujeito";
            alternativas[6, 1] = "B) O predicado";
            alternativas[6, 2] = "C) Uma enumeração";
            alternativas[6, 3] = "D) O vocativo";
            resposta[6] = "D";

            pergunta[7] = "Qual alternativa apresenta um verbo de ligação?";
            alternativas[7, 0] = "A) Comer";
            alternativas[7, 1] = "B) Permanecer";
            alternativas[7, 2] = "C) Estudar";
            alternativas[7, 3] = "D) Correr";
            resposta[7] = "B";

            pergunta[8] = "Qual é o plural correto de 'cidadão'?";
            alternativas[8, 0] = "A) Cidadãos";
            alternativas[8, 1] = "B) Cidadões";
            alternativas[8, 2] = "C) Cidadães";
            alternativas[8, 3] = "D) Cidadans";
            resposta[8] = "A";

            pergunta[9] = "Qual alternativa apresenta linguagem conotativa?";
            alternativas[9, 0] = "A) A água ferve a 100°C.";
            alternativas[9, 1] = "B) O céu está azul.";
            alternativas[9, 2] = "C) A sala possui vinte cadeiras.";
            alternativas[9, 3] = "D) Ela tem um coração de pedra.";
            resposta[9] = "D";

            pergunta[10] = "Qual é a principal característica do texto dissertativo-argumentativo?";
            alternativas[10, 0] = "A) Narrar fatos";
            alternativas[10, 1] = "B) Descrever pessoas";
            alternativas[10, 2] = "C) Contar histórias fictícias";
            alternativas[10, 3] = "D) Defender um ponto de vista";
            resposta[10] = "D";

            pergunta[11] = "Qual alternativa apresenta um adjetivo?";
            alternativas[11, 0] = "A) Beleza";
            alternativas[11, 1] = "B) Inteligente";
            alternativas[11, 2] = "C) Rapidamente";
            alternativas[11, 3] = "D) Caminhar";
            resposta[11] = "B";

            pergunta[12] = "Qual palavra está corretamente acentuada?";
            alternativas[12, 0] = "A) País";
            alternativas[12, 1] = "B) Heroi";
            alternativas[12, 2] = "C) Juri";
            alternativas[12, 3] = "D) Idea";
            resposta[12] = "A";

            pergunta[13] = "O predicado é o termo da oração que:";
            alternativas[13, 0] = "A) Indica o sujeito";
            alternativas[13, 1] = "B) Substitui o sujeito";
            alternativas[13, 2] = "C) Apenas liga palavras";
            alternativas[13, 3] = "D) Declara algo sobre o sujeito";
            resposta[13] = "D";

            pergunta[14] = "Qual conjunção indica oposição?";
            alternativas[14, 0] = "A) E";
            alternativas[14, 1] = "B) Porque";
            alternativas[14, 2] = "C) Mas";
            alternativas[14, 3] = "D) Portanto";
            resposta[14] = "C";

            pergunta[15] = "Qual alternativa apresenta linguagem denotativa?";
            alternativas[15, 0] = "A) Seu sorriso ilumina o mundo.";
            alternativas[15, 1] = "B) A sala possui trinta alunos.";
            alternativas[15, 2] = "C) Estou morrendo de fome.";
            alternativas[15, 3] = "D) O tempo voa.";
            resposta[15] = "B";

            pergunta[16] = "Qual é o antônimo de 'generoso'?";
            alternativas[16, 0] = "A) Egoísta";
            alternativas[16, 1] = "B) Bondoso";
            alternativas[16, 2] = "C) Simpático";
            alternativas[16, 3] = "D) Educado";
            resposta[16] = "A";

            pergunta[17] = "Qual alternativa apresenta discurso direto?";
            alternativas[17, 0] = "A) Ela disse que sairia cedo.";
            alternativas[17, 1] = "B) João perguntou: 'Você vem comigo?'";
            alternativas[17, 2] = "C) Eles contaram que viajaram.";
            alternativas[17, 3] = "D) O professor afirmou que haveria prova.";
            resposta[17] = "B";

            pergunta[18] = "Na frase 'O livro que comprei é interessante', o pronome 'que' é:";
            alternativas[18, 0] = "A) Conjunção conclusiva";
            alternativas[18, 1] = "B) Conjunção causal";
            alternativas[18, 2] = "C) Pronome relativo";
            alternativas[18, 3] = "D) Pronome indefinido";
            resposta[18] = "C";

            pergunta[19] = "Qual movimento literário brasileiro valorizava o nacionalismo e a natureza?";
            alternativas[19, 0] = "A) Modernismo.";
            alternativas[19, 1] = "B) Realismo.";
            alternativas[19, 2] = "C) Parnasianismo.";
            alternativas[19, 3] = "D) Romantismo.";
            resposta[19] = "D";

            foreach (string p in pergunta)
            {
                Console.Clear();
                Box1LC(3, 2, 12, 115);
                Box2LC(0, 40, 2, 79);
                Console.SetCursorPosition(47, 1);
                Console.WriteLine("Questionário de Português");
                Console.WriteLine();
                Console.SetCursorPosition(4, 4);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine((questao + 1) + ") " + p);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.White;

                for (a = 0; a < 4; a++)
                {
                    Console.WriteLine();
                    Console.SetCursorPosition(4, 6);
                    Console.Write(alternativas[questao, 0]);

                    Console.SetCursorPosition(64, 6);
                    Console.Write(alternativas[questao, 1]);

                    Console.SetCursorPosition(4, 8);
                    Console.Write(alternativas[questao, 2]);

                    Console.SetCursorPosition(64, 8);
                    Console.Write(alternativas[questao, 3]);
                }
                Console.WriteLine();
                Console.SetCursorPosition(4, 10);
                Console.Write("Digite sua resposta: ");

                do
                {
                    opcao = Console.ReadLine();

                    if (opcao.ToUpper() != "A" && opcao.ToUpper() != "B" && opcao.ToUpper() != "C" && opcao.ToUpper() != "D")
                    {
                        Console.SetCursorPosition(4, 10);
                        Console.Write("Digite uma opção válida (A, B, C ou D): ");
                    }
                } while (opcao.ToUpper() != "A" && opcao.ToUpper() != "B" && opcao.ToUpper() != "C" && opcao.ToUpper() != "D");

                if (opcao.ToUpper() == resposta[questao])
                {
                    Console.SetCursorPosition(4, 11);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acertou !!!");

                    Console.ForegroundColor = ConsoleColor.White;

                    carregando_pergunta();

                    acertos++;
                }
                else
                {
                    Console.SetCursorPosition(4, 11);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERRADO !!!");

                    Console.ForegroundColor = ConsoleColor.White;


                    carregando_pergunta();
                    Console.Clear();
                }
                questao++;
            }

            Console.Clear();

            Box2LC(1, 30, 11, 89);

            Console.SetCursorPosition(51, 2);
            Console.WriteLine("RESULTADO FINAL");

            Console.SetCursorPosition(35, 4);
            Console.WriteLine($"Total de perguntas: {pergunta.Length}");

            Console.SetCursorPosition(35, 5);
            Console.WriteLine($"Total de acertos:   {acertos}");

            float notas = (float)acertos / pergunta.Length * 10;

            Console.SetCursorPosition(35, 7);
            Console.Write($"Nota final: ");

            if (notas >= 6)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{notas:F1}");

                Console.SetCursorPosition(41, 9);
                Console.WriteLine("Você foi aprovado. Parabéns!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{notas:F1}");

                Console.SetCursorPosition(38, 9);
                Console.WriteLine("Você foi reprovado... Tente novamente!");
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.SetCursorPosition(0, 13);


        }
    }
}
