namespace Ovning3
{
    class Pelican : Bird
    {
        public int beakVolume { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Beak volume: {beakVolume.ToString()}";
        }
    }
}
