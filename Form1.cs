namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            string name = txtItemname.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem item = new DiscountedItem(name, price, quantity, discount);
            double totalPrice = item.getTotalPrice();
            TotalAmount.Text = "Total Price: " + totalPrice.ToString("C2");

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(txtPyament.Text);
            string name = txtItemname.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            DiscountedItem item = new DiscountedItem(name, price, quantity, discount);
            item.setPayment(payment);
            double change = item.getChange();
            Change.Text = "Change: " + change.ToString("C2");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 loginForm = new Form2();
            loginForm.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }

        public virtual double getTotalPrice()
        {
            total_price = item_price * item_quantity;
            return total_price;
        }
        public void setPayment(double amount)
        {
            total_price = amount;
        }
    }
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double payment;
        private double change;
        public DiscountedItem(string name, double price, int quantity, double discount)
           : base(name, price, quantity)
        {
            item_discount = discount * 0.01; 
        }

        public override double getTotalPrice()
        {
            double discountAmount = item_price * item_discount;
            double discountedPrice = item_price - discountAmount;
            return discountedPrice * item_quantity;
        }

        public new void setPayment(double amount)
        {
            payment = amount;
            double total_price = getTotalPrice();
            change = payment - total_price;
        }

        
        public double getChange()
        {
            return change;
        }

    }



}

