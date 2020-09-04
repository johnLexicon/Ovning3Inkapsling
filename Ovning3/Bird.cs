namespace Ovning3
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }

        public override void DoSound()
        {
            Ui.Print("Tweet");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Wingspan: {WingSpan.ToString()}";
        }
    }
}
