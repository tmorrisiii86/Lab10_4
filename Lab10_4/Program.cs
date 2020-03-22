using System;

namespace Lab10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Artist prince = new Artist("Prince");
            prince.AddToPlaylist("Purple Rain");
            prince.AddToPlaylist("Little Red Corvette");
            prince.AddToPlaylist("Kiss");
            prince.AddToPlaylist("When Doves Cry");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(prince);

            AudioBook howTo = new AudioBook("How to Win Friends and Influence People", "Dale Carnegie");
            player.PlayMedia(howTo);

            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars");
            starWars.SelectTrack("Opening Credits Theme");
            player.PlayMedia(starWars);
        }
    }
}
