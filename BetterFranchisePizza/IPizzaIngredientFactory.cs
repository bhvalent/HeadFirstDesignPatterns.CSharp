using BetterFranchisePizza.Ingredients;

namespace BetterFranchisePizza
{
    public interface IPizzaIngredientFactory
    {
        public IAmDough CreateDough();

        public IAmSauce CreateSauce();

        public IAmCheese CreateCheese();

        public List<IAmTopping> CreateTopping();
    }
}
