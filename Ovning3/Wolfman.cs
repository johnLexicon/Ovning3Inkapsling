using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Ovning3.Ovning3Tests1")]
namespace Ovning3
{
    public class Wolfman : Wolf, IPerson
    {
        public void Talk() 
        {
            Ui.Print("Öööööh");
        }
    }
}
