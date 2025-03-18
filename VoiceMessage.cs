using System;
using System.Media;


namespace ChatBotCyberSecurityApp
{
   

    internal class VoiceMessage
    {
        public VoiceMessage()
        {
            PlayVoiceMessage("Greeting Voice Over.wav");
        }

        public static void PlayVoiceMessage(string fileName)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = fileName;
            player.Play();
        }
    }

}