
class Product {
    private string name;
    private int id;
    private double price;
    private int quantity;
    private string v1;
    private string v2;
    private decimal v3;
    private int v4;

    public Product(string name, int id, double price, int quantity) {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public Product(string v1, string v2, decimal v3, int v4)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
    }

    public double GetPrice() {
        return price * quantity;
    }

    public string GetName() {
        return name;
    }

    public int GetId() {
        return id;
    }

    public int GetQuantity() {
        return quantity;
    }

     public double GetTotalPrice()
        {
            return price * quantity;
        }
}