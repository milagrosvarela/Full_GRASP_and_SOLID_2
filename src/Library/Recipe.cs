//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_and_SOLID_2.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // Se le asigna la responsabilidad de generar el texto pero no de imprimirlo por el principio SRP.
        public string TextResult()
        {
            string result = ($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                result += ($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");

            // Se le agrega al final de la impresión de la receta el costo total de producción.
            result = result + $"Costo de producción: {this.GetProductionCost()}";

            return result;
            }
            
            // Se le agrega al final de la impresión de la receta el costo total de producción.
            Console.WriteLine($"Costo de producción: {this.GetProductionCost()}");

        }

        // Se le asigna la responsabilidad de calcular el costo total a la clase Recipe por el principio Expert.
        public double GetProductionCost()
        {
            double result = 0;

            foreach (Step step in this.steps)
            {
                result = result + step.StepCost();
            }

            return result;
        }

        // Se le asigna la responsabilidad de calcular el costo total a la clase Recipe por el principio Expert.
        public double GetProductionCost()
        {
            double result = 0;

            foreach (Step step in this.steps)
            {
                result = result + step.StepCost();
            }

            return result;
        }
    }
}