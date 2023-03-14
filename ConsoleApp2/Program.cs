float walletRUB;
float walletUSD;
int operation;
float exchangeMoney;
float rateUSD = 75.27f;
float rateRUB = 0.013f;
Console.WriteLine("Спасибо что выбрали наш валютообменник, курс на настоящее время");
Console.WriteLine("Загрузка...");
Console.WriteLine("1 USD - 75,27 RUB");
Console.Write("ВВедите ваш текущий баланс USD: ");
walletUSD = Convert.ToSingle(Console.ReadLine());
Console.Write("ВВедите ваш текущий баланс RUB: ");
walletRUB = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Выберите нужную вам операцию: ");
Console.WriteLine("1 - Обмен USD на RUB");
Console.WriteLine("2 - Обмен RUB на USD");
Console.Write("Ваш выбор: ");
operation = Convert.ToInt32(Console.ReadLine());
switch (operation) {
    case 1:
        Console.WriteLine("Сколько USD вы хотите обменять?");
        exchangeMoney = Convert.ToSingle(Console.ReadLine());
        if (exchangeMoney <= walletUSD) 
        {
            walletUSD -= exchangeMoney;
            walletRUB = exchangeMoney * rateUSD + walletRUB;
        }
        else  
            Console.WriteLine("Недостаточно средств."); 
        
        break;
    case 2:
        Console.WriteLine("Сколько RUB вы хотите обменять?");
        exchangeMoney = Convert.ToSingle(Console.ReadLine());
        if (exchangeMoney <= walletRUB)
        {
            walletRUB -= exchangeMoney;
            walletUSD = exchangeMoney * rateRUB + walletUSD;
        }
        else 
            Console.WriteLine("Недостаточно средств.");
             
        break;

    default:
        Console.WriteLine("Неверно выбран тип операции.");

        break;
}
Console.WriteLine($"Ваш текущий баланс: USD: {walletUSD} RUB: {walletRUB}");
