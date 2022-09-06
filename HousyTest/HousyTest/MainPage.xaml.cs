using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HousyTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);
            var animation = new Animation();

            var translateAnimation = new Animation(valor => titleLabel.TranslationX = valor, 0, titleLabel.Width, Easing.BounceIn);
            var reverseTranslateAnimation = new Animation(valor => titleLabel.TranslationX = valor, titleLabel.Width, 0, Easing.BounceIn);
            animation.Add(0,.5,translateAnimation);
            animation.Add(.5,1, reverseTranslateAnimation);

            animation.Commit(this, "animation",24,3500);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro_do_usuario());

        }
    }
}
