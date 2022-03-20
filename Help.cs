using System.IO;
using System.Windows.Forms;

namespace Optimum
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            SetUp();
        }

        public void SetUp()
        {
            using (FileStream stream = new FileStream("Help.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    HelpBox.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
