// <copyright file="Ingredient.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassHierarchy_hw.Classes
{
    internal class Ingredient : IngredientType
    {
        private string name { get; set; };
        private double calories { get; set; };
        private double quantity { get; set; };
        private string measurement { get; set; };
        private string type { get; set; };

        public Ingredient(string name, double calories, double quantity, string measurement, string type)
            : base(name)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Calories = calories;
            this.Measurement = measurement;
            this.Type = type;
        }
    }
}
