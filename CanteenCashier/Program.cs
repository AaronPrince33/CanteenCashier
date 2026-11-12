string[] productName = {"Fried Rice", "Fried Noodle", "Smack Chicken", "Ice Tea", "Minerale Water" };
int[] productPrice = {15000, 12000, 18000, 5000, 4000};
int[] purchaseAmount = new int[5];
int code, amount;
string buyAgain;

for (int i = 0; i < productName.Length; i++)
{
    Console.WriteLine($"{i+1}. {productName[i]} : Rp{productPrice[i]}");
}

for (int i = 0; i < productName.Length; i++)
{
    Console.Write("Input the product code for purchase item (1/2/3/4/5): ");
    code = int.Parse(Console.ReadLine());

    Console.Write("Sales Amount: ");
    amount = int.Parse(Console.ReadLine());

    purchaseAmount[i] = amount;

    Console.Write("Do you want to purchase again? (Y/N)");
    buyAgain = Console.ReadLine();

    if (buyAgain.ToUpper() == "T")
    {
        break;
    }

}