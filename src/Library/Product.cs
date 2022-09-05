//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_and_SOLID_2.Library
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}