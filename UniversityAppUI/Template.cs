using MaterialSkin;

namespace UniversityAppUI
{
    public partial class Template : MaterialSkin.Controls.MaterialForm
    {
        public Template()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey900, Primary.Grey200, Accent.DeepPurple400, TextShade.WHITE);
        }
    }
}