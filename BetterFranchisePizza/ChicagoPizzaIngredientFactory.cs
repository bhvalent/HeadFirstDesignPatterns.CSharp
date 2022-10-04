using BetterFranchisePizza.Ingredients;

namespace BetterFranchisePizza
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IAmCheese CreateCheese() => new MozzarellaCheese();

        public IAmDough CreateDough() => new ThickCrustDough();

        public IAmSauce CreateSauce() => new PlumTomatoSauce();

        public List<IAmTopping> CreateTopping() => new List<IAmTopping> { new Parmesan(), new Oregano() };
    }
}
