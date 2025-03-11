namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            EFModel _Context = new EFModel();
            _Context.Database.EnsureCreated();
        }
    }
}
