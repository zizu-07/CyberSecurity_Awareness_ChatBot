using System; // Importing the System namespace for basic functionalities
using System.Media; // Importing the System.Media namespace to handle sound playback

namespace ChatBotCyberSecurityApp // Defining a namespace for the application
{
    internal class VoiceMessage // Declaring an internal class named VoiceMessage
    {
        public VoiceMessage() // Constructor for the VoiceMessage class
        {
            PlayVoiceMessage("Greeting Voice Over.wav"); // Calling the method to play a specific voice message
        }

        public static void PlayVoiceMessage(string fileName) // Static method to play a voice message
        {
            SoundPlayer player = new SoundPlayer(); // Creating an instance of SoundPlayer to handle sound playback
            player.SoundLocation = fileName; // Setting the location of the sound file to be played
            player.Play(); // Playing the sound file
        }
    }
}
