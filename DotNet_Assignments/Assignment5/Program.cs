/*1. Create a class called furniture which has Data Members like
• OrderId
• OrderDate
• FurnitureType
• Qty
• TotalAmt
• PaymentMode (credit/debit card)
Furniture Type can be Chair/Cot
• Derive the Chair and Cot class from Furniture class
If Chair Class then data members are
Chair type – Wood/Steel/Plastic
• purpose – Home/office
• If Wood Chair then Wood Type would be Teak Wood/Rose Wood
• If Steel Chair then it would be Gray Steel/Green Steel/Brown Steel
• If Plastic Color would be Green/Red/Blue/White
• Rate
If Cot class then Data Members are
• Cot Type – Wood / Steel
Same Data Members defined for Wood/Steel chair will be applicable for this.
• Capacity – Single/Double
• Rate
All the classes should have GetData() to accept user input and ShowData() to
display the details .
Create a Console Application to arrive at the Solution.
• Hint : Implement the solution using Inheritance Concept.*/
namespace Assignment5
{
    class Furniture
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string FurnitureType { get; set; }
        public int Qty { get; set; }
        public double TotalAmt { get; set; }
        public string PaymentMode { get; set; }

        public virtual void GetData()
        {
            Console.Write("Enter Order ID: ");
            OrderId = int.Parse(Console.ReadLine());

            Console.Write("Enter Order Date (YYYY-MM-DD): ");
            OrderDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            Qty = int.Parse(Console.ReadLine());

            Console.Write("Enter Payment Mode (credit/debit): ");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Furniture Type: " + FurnitureType);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmt);
            Console.WriteLine("Payment Mode: " + PaymentMode);
        }
    }

    // Derived Chair class
    class Chair : Furniture
    {
        public string ChairType { get; set; }
        public string Purpose { get; set; }
        public string WoodType { get; set; }
        public string SteelColor { get; set; }
        public string PlasticColor { get; set; }
        public double Rate { get; set; }

        public override void GetData()
        {
            base.GetData();
            FurnitureType = "Chair";

            Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();

            Console.Write("Enter Purpose (Home/Office): ");
            Purpose = Console.ReadLine();

            if (ChairType.ToLower() == "wood")
            {
                Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
                WoodType = Console.ReadLine();
            }
            else if (ChairType.ToLower() == "steel")
            {
                Console.Write("Enter Steel Color (Gray/Green/Brown): ");
                SteelColor = Console.ReadLine();
            }
            else if (ChairType.ToLower() == "plastic")
            {
                Console.Write("Enter Plastic Color (Green/Red/Blue/White): ");
                PlasticColor = Console.ReadLine();
            }

            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Chair Type: " + ChairType);
            Console.WriteLine("Purpose: " + Purpose);
            if (ChairType.ToLower() == "wood")
            {
                Console.WriteLine("Wood Type: " + WoodType);
            }
            else if (ChairType.ToLower() == "steel")
            {
                Console.WriteLine("Steel Color: " + SteelColor);
            }
            else if (ChairType.ToLower() == "plastic")
            {
                Console.WriteLine("Plastic Color: " + PlasticColor);
            }
            Console.WriteLine("Rate: " + Rate);
        }
    }

    // Derived Cot class
    class Cot : Furniture
    {
        public string CotType { get; set; }
        public string WoodType { get; set; }
        public string SteelColor { get; set; }
        public string Capacity { get; set; }
        public double Rate { get; set; }

        public override void GetData()
        {
            base.GetData();
            FurnitureType = "Cot";

            Console.Write("Enter Cot Type (Wood/Steel): ");
            CotType = Console.ReadLine();

            if (CotType.ToLower() == "wood")
            {
                Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
                WoodType = Console.ReadLine();
            }
            else if (CotType.ToLower() == "steel")
            {
                Console.Write("Enter Steel Color (Gray/Green/Brown): ");
                SteelColor = Console.ReadLine();
            }

            Console.Write("Enter Capacity (Single/Double): ");
            Capacity = Console.ReadLine();

            Console.Write("Enter Rate: ");
            Rate = double.Parse(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine("Cot Type: " + CotType);
            if (CotType.ToLower() == "wood")
            {
                Console.WriteLine("Wood Type: " + WoodType);
            }
            else if (CotType.ToLower() == "steel")
            {
                Console.WriteLine("Steel Color: " + SteelColor);
            }
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Rate: " + Rate);
        }
    }

    // Main Program
    class Program
    {
        static void Main()
        {
            Furniture furniture = null;

            Console.Write("Enter Furniture Type (Chair/Cot): ");
            string type = Console.ReadLine().ToLower();

            if (type == "chair")
            {
                furniture = new Chair();
            }
            else if (type == "cot")
            {
                furniture = new Cot();
            }
            else
            {
                Console.WriteLine("Invalid Furniture Type");
                return;
            }

            furniture.GetData();
            furniture.ShowData();
        }
    }
}
