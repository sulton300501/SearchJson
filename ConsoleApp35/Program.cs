using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"[
            {
                ""title"": ""Дирхам ОАЭ"",
                ""code"": ""AED"",
                ""cb_price"": ""3361.32"",
                ""nbu_buy_price"": """",
                ""nbu_cell_price"": """",
                ""date"": ""10.01.2024""
            },
            {
                ""title"": ""Австралийский доллар"",
                ""code"": ""AUD"",
                ""cb_price"": ""8332.96"",
                ""nbu_buy_price"": """",
                ""nbu_cell_price"": """",
                ""date"": ""10.01.2024""
            }, 
      {
        ""title"": ""Канадский доллар"",
        ""code"": ""CAD"",
        ""cb_price"": ""9263.94"",
        ""nbu_buy_price"": """",
        ""nbu_cell_price"": """",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Швейцарский франк"",
        ""code"": ""CHF"",
        ""cb_price"": ""14498.09"",
        ""nbu_buy_price"": ""14100.00"",
        ""nbu_cell_price"": ""15100.00"",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Китайский юань"",
        ""code"": ""CNY"",
        ""cb_price"": ""1727.73"",
        ""nbu_buy_price"": """",
        ""nbu_cell_price"": """",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Датская крона"",
        ""code"": ""DKK"",
        ""cb_price"": ""1810.27"",
        ""nbu_buy_price"": """",
        ""nbu_cell_price"": """",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Египетский фунт"",
        ""code"": ""EGP"",
        ""cb_price"": ""399.52"",
        ""nbu_buy_price"": """",
        ""nbu_cell_price"": """",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Евро"",
        ""code"": ""EUR"",
        ""cb_price"": ""13501.86"",
        ""nbu_buy_price"": ""13400.00"",
        ""nbu_cell_price"": ""13650.00"",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Английский фунт стерлингов"",
        ""code"": ""GBP"",
        ""cb_price"": ""15589.42"",
        ""nbu_buy_price"": ""15600.00"",
        ""nbu_cell_price"": ""16300.00"",
        ""date"": ""10.01.2024""
    },
    {
        ""title"": ""Исландская крона"",
        ""code"": ""ISK"",
        ""cb_price"": ""89.59"",
        ""nbu_buy_price"": """",
        ""nbu_cell_price"": """",
        ""date"": ""10.01.2024""
    },

        ]";

        JArray jsonArray = JArray.Parse(json);
        Console.WriteLine("Valyutani tanlang: Masalan:" +
            " ISK ,GBP,EUR,EGP,DKK,DKK,DKK,CHF,CAD,AUD,AED,GBP  ");
        string valyuta = Console.ReadLine();
        Console.WriteLine("Miqdorni kiriting: ");
        double dollor = double.Parse(Console.ReadLine());

        for (int i = 0; i < jsonArray.Count; i++)
        {
            if (valyuta == (string)jsonArray[i]["code"])
            {
                double res = (double)jsonArray[i]["cb_price"] * dollor;
                double result = res / 1000;


                Console.WriteLine("Uzs: " + result + " so'm");
            }
            
        }

       
    }
}
