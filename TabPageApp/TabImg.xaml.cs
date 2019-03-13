using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;


namespace TabPageApp
{
    public partial class TabImg : ContentPage
    {
        public TabImg()
        {
            InitializeComponent();
        }
        void RUGIDO(object sender, EventArgs e)
        {
            var player = CrossSimpleAudioPlayer.Current;
            player.Load("Growl.mp3");
                player.Play();
               
            }
        }
}
