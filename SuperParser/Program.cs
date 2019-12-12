using System.Windows.Forms;

namespace SuperParser
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormManager());
        }
    }
}
