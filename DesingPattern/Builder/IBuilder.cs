using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetAlcohol(decimal alcohol);
        void SetWater(int water);
        void SetMilk(int milk);
        void AddIngredients(string ingredients);
        void Mix();
        void Rest(int time);
    }
}
