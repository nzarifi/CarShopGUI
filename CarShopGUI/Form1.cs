using CarClassLibrary;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.Carlist;
            lst_Inventory.DataSource = carInventoryBindingSource;
            lst_Inventory.DisplayMember = ToString();
            cartBindingSource.DataSource = myStore.ShoppingList;
            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void Checkout_Click(object sender, System.EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$" +  total.ToString();
            // double click on checkout makes total = 0.00. how to change it
            cartBindingSource.ResetBindings(false);
        }

        private void btn_create_car_Click(object sender, System.EventArgs e)
        {
            
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text));
            //MessageBox.Show(c.ToString());
            myStore.Carlist.Add(c);
            carInventoryBindingSource.ResetBindings(false);
        }

        private void btn_addtocart_Click(object sender, System.EventArgs e)
        {
            // get the selected item from inventory
            Car selected = (Car) lst_Inventory.SelectedItem;  //cast the (Car) to make sure selecteditem is Car
            //add the car to store
            myStore.ShoppingList.Add(selected);
            // update the list box control
            cartBindingSource.ResetBindings(false);
        }
    }
}
