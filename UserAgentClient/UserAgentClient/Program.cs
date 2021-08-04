using System;
using System.Threading.Tasks;
using SIPSorcery.Media;
using SIPSorcery.SIP.App;
using SIPSorceryMedia.Windows;


namespace UserAgentClient
{
    class Program
    {
        private static string DESTINATION = "helloworld@sipsorcery.cloud";

        static async Task Main()
        {
            Console.WriteLine("SIP Get Started");

            var userAgent = new SIPUserAgent();
            var winAudio = new WindowsAudioEndPoint(new AudioEncoder());
            var voipMediaSession = new VoIPMediaSession(winAudio.ToMediaEndPoints());

            // Place the call and wait for the result.
            bool callResult = await userAgent.Call(DESTINATION, null, null, voipMediaSession);
            Console.WriteLine($"Call result {((callResult) ? "success" : "failure")}.");

            Console.WriteLine("Press any key to hangup and exit.");
            Console.ReadLine();
        }
    }
}
