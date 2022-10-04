using BetterFranchisePizza.Ingredients;

namespace BetterFranchisePizza
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IAmCheese CreateCheese() => new ReggianoCheese();

        public IAmDough CreateDough() => new ThinCrustDough();

        public IAmSauce CreateSauce() => new MarinaraSauce();

        public List<IAmTopping> CreateTopping() => new List<IAmTopping> { new Garlic() };
    }
}
