using System.IO;
using System.Windows.Forms;

namespace Optimum
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            SetUp();
        }

        public void SetUp()
        {
            using (FileStream stream = new FileStream("About.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    AboutBox.Text = sr.ReadToEnd();
                }
            }

            using (FileStream stream = new FileStream("By.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    ByBox.Text = sr.ReadToEnd();
                }
            }
        }
    }
}
