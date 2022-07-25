using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace WindowAnimations
{
    public class NavigationService
    {
        public event Action CurrentPageChanged;
        public Page CurrentPage { get; private set; }

        private Duration _animateDuration = new TimeSpan(0, 0, 0, 0, 250);
        public void Navigate(Page content)
        {
            content.Loaded += OnLoaded;
            CurrentPage = content;
            CurrentPageChanged?.Invoke();
        }
        public void SetStartPage(Page startPage)
        {
            CurrentPage = startPage;
        }
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            var loadedPage = sender as Page;
            BeginFromBottomAnimation(loadedPage);
        }
        private void BeginFromBottomAnimation(FrameworkElement panel)
        {
            BeginMarginAnimation(panel);
            BeginOpacityAnimation(panel);
            BeginBlurAnimation(panel);
        }
        private void BeginMarginAnimation(FrameworkElement element)
        {
            var actualThickness = new Thickness(element.Margin.Left,
                                                                                    element.Margin.Top,
                                                                                    element.Margin.Right,
                                                                                    element.Margin.Bottom);
            var hu = actualThickness.Top + 25;
            var from = new Thickness(element.Margin.Left,
                                                                                    hu,
                                                                                    element.Margin.Right,
                                                                                    element.Margin.Bottom);

            var animation = new ThicknessAnimation(from, actualThickness, _animateDuration);
            element.BeginAnimation(FrameworkElement.MarginProperty, animation);
        }
        private void BeginOpacityAnimation(FrameworkElement element)
        {
            var opacityAnim = new DoubleAnimation(0, 1, _animateDuration);
            element.BeginAnimation(UIElement.OpacityProperty, opacityAnim);
        }
        private void BeginBlurAnimation(FrameworkElement element)
        {
            element.Effect = new BlurEffect() { Radius = 0, };
            DoubleAnimation anim = new DoubleAnimation();
            anim.To = 0;
            anim.From = 10;
            anim.Duration = _animateDuration;

            Storyboard storyboard = new Storyboard();
            Storyboard.SetTargetProperty(anim, new PropertyPath("Effect.Radius"));
            storyboard.Children.Add(anim);
            element.BeginStoryboard(storyboard);
        }
    }
}
