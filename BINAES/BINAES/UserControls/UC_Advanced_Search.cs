using System.Windows.Forms;

namespace BINAES.UserControls
{
    public partial class UC_Advanced_Search : UserControl
    {
        public bool full;
        public string title;
        public string someWords;
        public string keyWords;
        public string author;
        public bool both;
        public bool digital;
        public UC_Advanced_Search()
        {
            InitializeComponent();
        }
    }
}