using System;
using ConvertApp.model;

namespace ConvertApp.view
{
    public class ConsoleView : IConvertingView
    {

        public ConsoleView()
        {
        }

        public void renderMenu(ref Convertable convertable)
        {
            Console.WriteLine("Entrez la phrase a convertir : ");
            convertable.input = Console.ReadLine();
        }

        public void renderOutput(ref Convertable convertable)
        {
            Console.WriteLine("Resultat de la convertion : " + convertable.output);
        }

        public void renderInputSizeError()
        {
            Console.WriteLine("ERROR : Vous devez entrez une phrase avec un nombre de charactère compris entre 1 et 8");
        }
    }
}
