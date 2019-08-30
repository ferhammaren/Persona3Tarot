using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace PersonaTarot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("bgm.mp3");
            player.Play();

        }


        async void OnSpreadClicked(object sender,EventArgs args)
        {
            var clickSound = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            clickSound.Load("Files/sfx/optionSelect.wav");
            clickSound.Play();
            await Navigation.PushAsync(new SelectSpread());
        }

        async void OnSettingsClicked(object sender, EventArgs args)
        {
            var clickSound = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            clickSound.Load("Files/sfx/optionSelect.wav");
            clickSound.Play();
            await Navigation.PushAsync(new TweakSettings());
        }

    }
}
