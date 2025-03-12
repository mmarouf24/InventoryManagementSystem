using InventoryManagementSystem.Tables;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        EFModel _Context;
        public Form1()
        {
            InitializeComponent();

            _Context = new EFModel();
            _Context.Database.EnsureCreated();
            foreach (var item in _Context.Items.ToList())
            {
                ItemIDComboBox.Items.Add(item.ItemID);
            }
            LoadItemsData();
            ItemIDComboBox.SelectedIndex = 0;
            ConfigItemsTextBoxes();
            UnitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void EditItem_Click(object sender, EventArgs e)
        {


            string name = ItemNameTextBox.Text.Trim();
            string code = ItemCodeTextBox.Text.Trim();
            int quantity = int.Parse(ItemQuantityTextBox.Text.Trim());
            string unit = UnitComboBox.SelectedItem.ToString();

            if (!int.TryParse(ItemQuantityTextBox.Text, out int quan))
            {
                MessageBox.Show("Please Enter a Number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isCodeExists = _Context.Items.Any(i => i.Code == code && i.ItemID != int.Parse(ItemIDComboBox.SelectedItem.ToString()));

            if (isCodeExists)
            {
                MessageBox.Show("Editing Failed!, The Code you entered is already existed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var ExistedItem = _Context.Items.Find(ItemIDComboBox.SelectedItem);


            ExistedItem.Code = code;
            ExistedItem.Name = name;
            ExistedItem.Quantity = quantity;
            ExistedItem.Unit = unit;
            _Context.SaveChanges();
            MessageBox.Show("Successfully Edited Item !", "Success", MessageBoxButtons.OK);
            LoadItemsData();
        

    
        }



        private void ItemIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigItemsTextBoxes();
        }
        private void ConfigItemsTextBoxes()
        {
            var item = _Context.Items.Find(ItemIDComboBox.SelectedItem);
            ItemCodeTextBox.Text = item.Code;
            ItemNameTextBox.Text = item.Name;
            ItemQuantityTextBox.Text = item.Quantity.ToString();

            UnitComboBox.SelectedItem = item.Unit;
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {

            var ItemToDelete = _Context.Items.Find(ItemIDComboBox.SelectedItem);
            _Context.Items.Remove(ItemToDelete);
            _Context.SaveChanges();
            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK);
            LoadItemsData();

        }



        private void ItemSearchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string Term = ItemSearchTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(Term))
            {
                ItemsGridView.DataSource = _Context.Items
                    .Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit })
                    .ToList();
                return;
            }

            var ExistedItems = _Context.Items
                            .Where(i => i.Name.ToLower().Contains(Term))
                            .Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit })
                            .ToList();
            if (ExistedItems.Any())
                ItemsGridView.DataSource = ExistedItems;
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            AddNewItem addForm = new AddNewItem();
            if (addForm.ShowDialog() == DialogResult.OK) 
            {
                LoadItemsData();
            }
        }
        private void LoadItemsData()
        {
            ItemsGridView.DataSource = _Context.Items.Select(i => new { i.ItemID, i.Code, i.Name, i.Quantity, i.Unit }).ToList();

        }
    }
}
