namespace Strategy.Example
{
    public class Menu
    {
        private IAnimation ButtonAnimation;
        public void SetAnimation(IAnimation btnAnimation)
        {
            ButtonAnimation = btnAnimation;
        }
        public void ExecuteAnimation()
        {
            ButtonAnimation.Animation();
        }
    }
}
