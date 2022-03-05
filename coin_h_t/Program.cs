int coin_head = 1;
Random random = new Random();
int Coincheck = random.Next(0, 2);
if (Coincheck == coin_head)
{
    Console.WriteLine("coin is head");
}
else
{
    Console.WriteLine("coin is tails");
}