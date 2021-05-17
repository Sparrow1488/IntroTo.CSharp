using Strategy.Base;
using Strategy.Example;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var menu = new Menu();
            menu.SetAnimation(new Animation1());
            menu.ExecuteAnimation();

            menu.SetAnimation(new Animation2());
            menu.ExecuteAnimation();
        }
        private static void Example()
        {
            var context = new Context();
            context.NewStrategy(new ConcreteStrategy1());
            context.ExecuteAlgorithm();

            context.NewStrategy(new ConcreteStrategy());
            context.ExecuteAlgorithm();
        }
    }
}
