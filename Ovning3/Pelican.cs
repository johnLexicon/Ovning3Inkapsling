using System.Security.Cryptography.X509Certificates;

namespace Ovning3
{
    class Pelican : Bird
    {
        public int beakVolume { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Beak volume: {beakVolume.ToString()}";
        }

        public override void DoSound()
        {
            System.Console.WriteLine("Pelican sound");
        }
    }
}
