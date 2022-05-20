// <copyright file="IngredientType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassHierarchy_hw.Classes
{
    internal class IngredientType
    {
        private string name { get; set; };
        private int maxQuantity { get; set; };
        private Ingredient[] selectedIngredients { get; set; };

        public IngredientType(string name, int maxQuantity = 1)
        {
            this.Name = name;
            this.MaxQuantity = maxQuantity;
            this.SelectedIngredients = new Ingredient[0];
        }

        public string IsMaxAmountReached()
        {
            // Counts number of ingredient of the same type
            return " ";
        }
    }
}
