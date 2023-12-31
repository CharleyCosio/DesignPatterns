﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Builder
{
    public class PrepareAlcoholicDrinkConcreteBuilder : IBuilder
    {

        private PrepareDrink _prepareDrink;

        public PrepareAlcoholicDrinkConcreteBuilder()
        {
            Reset();
        }

        public void AddIngredients(string ingredients)
        {
            if (_prepareDrink.Ingredients == null)
                _prepareDrink.Ingredients = new List<string>();

            _prepareDrink.Ingredients.Add(ingredients);
        }

        public void Mix()
        {
            string ingredients = _prepareDrink.Ingredients.Aggregate((i,j)=>i+", "+j);
            _prepareDrink.Result =$"Bebida preparada con {_prepareDrink.Alcohol} de alcohol; Ingredientes: {ingredients}";
            Console.WriteLine("Mezclamos Ingredientes");
        }

        public void Reset()
        {
            _prepareDrink = new PrepareDrink();
        }

        public void Rest(int time)
        {
            Thread.Sleep(time);
            Console.WriteLine("Listo para beberse");
        }

        public void SetAlcohol(decimal alcohol)
        {
            _prepareDrink.Alcohol = alcohol;
        }

        public void SetMilk(int milk)
        {
            _prepareDrink.Milk = milk;
        }

        public void SetWater(int water)
        {
            _prepareDrink.Water = water;
        }


        public PrepareDrink GetPrepareDrink() => _prepareDrink;
    }
}
