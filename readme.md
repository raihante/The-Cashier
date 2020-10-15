
# The Cashier V.10

## Function
Program Calculator Aplikasi ini berfungsi untuk menambahkan sebuah item, biasanya di gunakan untuk menjual sebuah barang/jasa

## How it works?

Diawali dengan deklarasi  **public MainWindows** pada class "MainWindows.xaml.cs" dapat kita lihat fungsi Insialisasi Komponen dan deklarasi Class calculator dan listbox. Tidak lupa denggan button add / **Addbutton**

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox.ItemsSource = calculator.getListItem();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string title = itemNameBox.Text;
            int quantity = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(), title, quantity, type, price);
            calculator.AddItem(item);
            double total = calculator.getTotal();

            totalLabel.Content = string.Format("Rp {0}", total);

            listBox.Items.Refresh();

kemudian Class Item "Item.cs"

    class Item
        {
            private int id;
            public string title { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
            public double subtotal { get; set; }
            private string type;
    
            public Item(int id, string title, int quantity, string type, double price)
            {
                this.id = id;
                this.title = title;
                this.quantity = quantity;
                this.type = type;
                this.price = price;
                this.subtotal = subtotal;
    
            }
            public string getTitle()
            {
                return title;
            }
            public int getQuantity()
            {
                return quantity;
            }
            public double getPrice()
            {
                return price;
            }
            public double getSubTotal()
            {
                subtotal = price * quantity;
                return subtotal;
            }
            public string getType()
            {
                return type;

Kemudian ini adalah class perhitungannya "Calculator.cs"

    class Calculator
    {
        private List<Item> ListItem;
        private double total = 0;

        public Calculator()
        {
            this.ListItem = new List<Item>();
        }
        public void AddItem(Item item)
        {
            this.ListItem.Add(item);
            this.total += item.getSubTotal();
        }
        public double getTotal()
        {
            return total;
        }
        public List<Item> getListItem()
        {
            return ListItem;