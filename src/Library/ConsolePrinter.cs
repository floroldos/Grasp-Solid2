using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}

/*Se usa el principio SRP para determinar la implementación de este cambio.
Esto es porque se le asigna la tarea de imprimir a una clase separada que hace esa acción, y después
se la llama en el Main del program para que imprima, en lugar de hacerlo en la clase Recipe.
Ahora todas las clases realizan una acción propia.*/