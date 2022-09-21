//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public enum Destination
    {
        Console,
        File
    }

    public class AllInOnePrinter
    {
        public void PrintRecipe(Recipe recipe, Destination destination)
        {
            if (destination == Destination.Console)
            {
                Console.WriteLine(recipe.GetTextToPrint());
            }
            else
            {
                File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
            }
        }
    }
}
/*Esta clase es incorrecta ya que viola lo que el patrón de polimorfismo dice que no hay que hacer. Esto se debe a que el código que varía según su destino debería de estar en diferentes clases, y deberíamos utilizar una operación polimórfica para solucionarlo. En este caso, utilizaré un tipo IPrinter y dos clases FilePrinter y ConsolePrinten que lo implementen.*/