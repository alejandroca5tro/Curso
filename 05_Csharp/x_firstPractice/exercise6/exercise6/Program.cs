using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = 3;

            StreamWriter textFileWriter;

            string fileName = "índices.txt";

            int weight;
            int height;
            double bMI;

            StreamReader textFileReader;

            string line;
            int index;
            int linesFollowedInWhite;

            string[] namesOfPlayers = new string[numberOfPlayers];

            string[] bMIOfPlayers = new string[numberOfPlayers];

            textFileWriter = File.CreateText(fileName);
            textFileWriter.WriteLine("REGISTRO DE JUGADORES");
            textFileWriter.WriteLine();

            Console.WriteLine("Va a crearse un registro de {0} jugadores de rugby.", numberOfPlayers.ToString());
            Console.WriteLine("A continuación escriba los datos para cada uno de los jugadores:");
            Console.WriteLine();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("JUGADOR {0}:", i + 1);
                Console.WriteLine();
                textFileWriter.WriteLine("Jugador {0}:", i + 1);
                Console.Write("Nombre: ");
                textFileWriter.WriteLine("- Nombre: {0}", Console.ReadLine());
                Console.Write("Peso (kg): ");
                weight = Convert.ToInt32(Console.ReadLine());
                textFileWriter.WriteLine("- Peso: {0}", weight.ToString());
                Console.Write("Altura (cm): ");
                height = Convert.ToInt32(Console.ReadLine());
                textFileWriter.WriteLine("- Altura: {0}", height.ToString());

                Console.WriteLine();

                bMI = Convert.ToDouble(weight) / (Convert.ToDouble(height*height)/10000);
                textFileWriter.WriteLine("- Índice de Masa Corporal: {0}", bMI.ToString("#.##"));
                textFileWriter.WriteLine();
            }
            textFileWriter.Close();

            textFileReader = File.OpenText(fileName);
            line = " ";
            index = 0;
            linesFollowedInWhite = 0;
            do
            {
                line = textFileReader.ReadLine();
                if (line != null)
                {
                    if (line.Contains("- Nombre:"))
                    {
                        namesOfPlayers[index] = line.Substring(10);
                        index++;
                        linesFollowedInWhite = 0;
                    }
                }
                else
                {
                    linesFollowedInWhite++;
                }
            } while (linesFollowedInWhite < 2);

            textFileReader.Close();

            textFileReader = File.OpenText(fileName);
            line = " ";
            index = 0;
            linesFollowedInWhite = 0;
            do
            {
                line = textFileReader.ReadLine();
                if (line != null)
                {
                    if (line.Contains("- Índice de Masa Corporal"))
                    {
                        bMIOfPlayers[index] = line.Substring(27);
                        index++;
                        linesFollowedInWhite = 0;
                    }
                }
                else
                {
                    linesFollowedInWhite++;
                }
            } while (linesFollowedInWhite < 2);

            textFileReader.Close();

            Console.WriteLine("Índices de Masa Corporal:");
            Console.WriteLine();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine(namesOfPlayers[i] + ": " + bMIOfPlayers[i]);
            }

            Console.ReadKey();                          
        }
    }
}
