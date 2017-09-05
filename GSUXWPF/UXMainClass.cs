using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Facebook
{
    public class UXMainClass
    {
        public void UXInit(System.Windows.Window W)
        {
            W.Background = new SolidColorBrush(Color.FromArgb(255,255,0,0));
            ChangeColor(W, Color.FromArgb(255, 255, 255, 0),new TimeSpan(0,0,2));
            Grid gr=((Grid)((StackPanel)W.Content).Children[0]); 
            ((Image)((StackPanel)((Button)gr.Children[0]).Content).Children[0]).Source = new BitmapImage(new Uri("/fenerbahce.png", UriKind.Relative));
        }

        private void WidenObject(UIElement c, int newWidth, TimeSpan duration)
        {
            DoubleAnimation animation = new DoubleAnimation(newWidth, duration);
            c.BeginAnimation(Rectangle.WidthProperty, animation);
        }
        private void ChangeColor(Control c, Color col, TimeSpan duration)
        {
            SolidColorBrush myAnimatedBrush = new SolidColorBrush();
            c.Background = myAnimatedBrush;
            SolidColorBrush DefCol = (SolidColorBrush)c.Background;
            myAnimatedBrush.Color = DefCol.Color;
            // Register the brush's name with the page
            // so that it can be targeted by storyboards.
            c.RegisterName("MyAnimatedBrush", myAnimatedBrush);
            ColorAnimation mouseEnterColorAnimation = new ColorAnimation();

            //mouse enter 
            mouseEnterColorAnimation.To =col;
            mouseEnterColorAnimation.Duration = TimeSpan.FromSeconds(1);
            Storyboard.SetTargetName(mouseEnterColorAnimation, "MyAnimatedBrush");
            Storyboard.SetTargetProperty(
                mouseEnterColorAnimation, new PropertyPath(SolidColorBrush.ColorProperty));
            Storyboard mouseEnterStoryboard = new Storyboard();
            mouseEnterStoryboard.Children.Add(mouseEnterColorAnimation);
            c.MouseEnter += delegate (object sender, MouseEventArgs e)
            {
                mouseEnterStoryboard.Begin(c);
            };

            //
            // Animate the brush's color to orange when
            // the mouse leaves the rectangle.
            //
            ColorAnimation mouseLeaveColorAnimation = new ColorAnimation();
            mouseLeaveColorAnimation.From = col;
            mouseLeaveColorAnimation.To = DefCol.Color;
            mouseLeaveColorAnimation.Duration =duration;
            Storyboard.SetTargetName(mouseLeaveColorAnimation, "MyAnimatedBrush");
            Storyboard.SetTargetProperty(
                mouseLeaveColorAnimation, new PropertyPath(SolidColorBrush.ColorProperty));
            Storyboard mouseLeaveStoryboard = new Storyboard();
            mouseLeaveStoryboard.Children.Add(mouseLeaveColorAnimation);
            c.MouseLeave += delegate (object sender, MouseEventArgs e)
            {
                mouseLeaveStoryboard.Begin(c);
            };

            //
            // Animate the brush's opacity to 0 and back when
            // the left mouse button is pressed over the rectangle.
            //
            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.To = 0.0;
            opacityAnimation.Duration = TimeSpan.FromSeconds(0.5);
            opacityAnimation.AutoReverse = true;
            Storyboard.SetTargetName(opacityAnimation, "MyAnimatedBrush");
            Storyboard.SetTargetProperty(
                opacityAnimation, new PropertyPath(SolidColorBrush.OpacityProperty));
            Storyboard mouseLeftButtonDownStoryboard = new Storyboard();
            mouseLeftButtonDownStoryboard.Children.Add(opacityAnimation);
            c.MouseLeftButtonDown += delegate (object sender, MouseButtonEventArgs e)
            {
                mouseLeftButtonDownStoryboard.Begin(c);
            };

        }
    }
}
