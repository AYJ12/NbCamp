using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesonalProject01
{
    
    internal class Program
    {
        private static Character player;
        private static List<Inventory> Inven;
        private static List<GoldShop> shopList;

        //delegate void 
        static void Main(string[] args)
        {
            GameDataSetting();
            DisplayGameIntro();
        }

        static void GameDataSetting()
        {
            // 캐릭터 정보 세팅
            player = new Character("Chad", "전사", 1, 10, 5, 100, 1500);

            // 아이템 정보 세팅
            Inven = new List<Inventory> { new Inventory("무쇠갑옷","방어력 +5", "단단한 갑옷입니다.") , new Inventory("낡은 검", "공격력 +2", "낡아빠진 검입니다.") };

            shopList = new List<GoldShop>
            {
                new GoldShop("수련자 갑옷", "방어력 +5", "수련에 도움을 주는 갑옷입니다.", "1500G"),
                new GoldShop("스파르타의 갑옷", "방어력 +15", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", "3500G"),
                new GoldShop("청동 도끼", "공격력 +5", "어디선가 사용됐던거 같은 도끼입니다.", "1500G"),
                new GoldShop("스파르타의 창", "공격력 +7", "스파르타의 전사들이 사용했다는 전설의 창입니다.", "3000G")
            };

        }

        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3 . 상점");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1, 3);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    // 작업해보기
                    DisplayInventory();
                    break;
                case 3:
                    DisplayShop();
                    break;
            }
        }

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk}");
            Console.WriteLine($"방어력 : {player.Def}");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }

        static void DisplayInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리 보기");
            Console.WriteLine("인벤토리 내용을 표시합니다.\n");
            Console.WriteLine("[아이템 목록]");
            for(int i = 0; i < Inven.Count; i++)
            {
                string str1 = Inven[i].Name.PadRight(10,' ');
                string str2 = Inven[i].Stat.PadRight(10,' ');
                string str3 = Inven[i].Str.PadRight(30,' ');
                Console.WriteLine($"{str1} | {str2} | {str3}");
            }
            Console.WriteLine("\n1 . 장착관리");
            Console.WriteLine("2 . 아이템 정렬");
            Console.WriteLine("0 . 나가기");

            int input = CheckValidInput(0, 2);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    SetInventory();
                    break;
                case 2:
                    DisplayInventorySort();
                    break;
            }

        }

        static public void SetInventory()
        {
            Console.Clear();
            Console.WriteLine("장착할 아이템 번호를 누르세요.");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < Inven.Count; i++)
            {
                string str1 = Inven[i].Name.PadRight(10, ' ');
                string str2 = Inven[i].Stat.PadRight(10, ' ');
                string str3 = Inven[i].Str.PadRight(30, ' ');
                Console.WriteLine($"{i+1} {str1} | {str2} | {str3}");
            }
            Console.WriteLine("\n0 . 나가기");
            
            int input = CheckValidInput(0, Inven.Count);

            if(input == 0)
            {
                DisplayGameIntro();
            }

            if (!Inven[input - 1].Name.Contains("[E]"))
            {
                Inven[input - 1].Name = "[E] " + Inven[input - 1].Name;
                if (Inven[input - 1].Stat.Contains("공격력"))
                {
                    int plus_Atk = int.Parse(Inven[input - 1].Stat.Substring(Inven[input - 1].Stat.IndexOf('+') + 1));
                    player.Atk = player.Atk + plus_Atk;
                }else if (Inven[input - 1].Stat.Contains("방어력"))
                {
                    int plus_Def = int.Parse(Inven[input - 1].Stat.Substring(Inven[input - 1].Stat.IndexOf('+') + 1));
                    player.Def = player.Def + plus_Def;
                }
            }
            else
            {
                Inven[input - 1].Name = Inven[input - 1].Name.Substring(Inven[input - 1].Name.IndexOf(']') + 1).Trim();

                if (Inven[input - 1].Stat.Contains("공격력"))
                {
                    int plus_Atk = int.Parse(Inven[input - 1].Stat.Substring(Inven[input - 1].Stat.IndexOf('+') + 1));
                    player.Atk = player.Atk - plus_Atk;
                }
                else if (Inven[input - 1].Stat.Contains("방어력"))
                {
                    int plus_Def = int.Parse(Inven[input - 1].Stat.Substring(Inven[input - 1].Stat.IndexOf('+') + 1));
                    player.Def = player.Def - plus_Def;
                }

            }

            SetInventory();
        }

        static public void DisplayInventorySort()
        {
            Console.WriteLine("\n정렬할 기준을 선택하세요.");
            Console.WriteLine("\n1 . 이름순\n2. 스탯순");

            int input = CheckValidInput(1, 2);

            switch (input)
            {
                case 1:
                    Inven = Inven.OrderBy(x => x.Name).ToList();
                    break;
                case 2:
                    Inven = Inven.OrderBy(x => x.Stat).ToList();
                    break;
            }

            DisplayInventory();
        }

        static public void DisplayShop()
        {
            Console.Clear();
            Console.WriteLine($"보유 골드\n {player.Gold}");
            Console.WriteLine("\n[아이템 목록]");

            for(int i = 0; i < shopList.Count; i++)
            {
                string str1 = shopList[i].Name.PadRight(10, ' ');
                string str2 = shopList[i].Stat.PadRight(10, ' ');
                string str3 = shopList[i].Str.PadRight(30, ' ');
                Console.WriteLine($"{i + 1} {str1} | {str2} | {str3} | {shopList[i].Price}");
            }

            Console.WriteLine("\n1. 구매하기");
            Console.WriteLine("0 . 나가기");

            int input = CheckValidInput(0, 1);

            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    Shopping();
                    break;
            }
        }

        static public void Shopping()
        {
            Console.Clear();
            Console.WriteLine($"보유 골드\n {player.Gold}");
            Console.WriteLine("\n[아이템 목록]");

            for (int i = 0; i < shopList.Count; i++)
            {
                string str1 = shopList[i].Name.PadRight(10, ' ');
                string str2 = shopList[i].Stat.PadRight(10, ' ');
                string str3 = shopList[i].Str.PadRight(30, ' ');
                Console.WriteLine($"{i + 1} {str1} | {str2} | {str3} | {shopList[i].Price}");
            }

            Console.WriteLine("\n구매할 물건의 번호를 입력하세요.");
            Console.WriteLine("0 . 나가기");
            int input = CheckValidInput(0, shopList.Count);

            if(input == 0)
            {
                DisplayShop();
            }

            int price = int.Parse(shopList[input - 1].Price.Substring(0, shopList[input - 1].Price.Length - 1));
            if (price > player.Gold)
            {
                Console.WriteLine("골드가 부족합니다.");
                Thread.Sleep(2000);
                Shopping();
            }
            else if (shopList[input - 1].Price != "구매완료")
            {
                string str1 = shopList[input - 1].Name.PadRight(10, ' ');
                string str2 = shopList[input - 1].Stat.PadRight(10, ' ');
                string str3 = shopList[input - 1].Str.PadRight(30, ' ');
                Console.WriteLine($"{str1} | {str2} | {str3} | {shopList[input - 1].Price}");
                Console.WriteLine("구매하시겠습니까? \n[y / n]");
                string key = Console.ReadLine();
                if (key == "y")
                {
                    player.Gold -= price;
                    Inven.Add(shopList[input - 1]);
                    shopList[input - 1].Price = "구매완료";
                    Shopping();
                }
                else if (key == "n")
                {
                    Shopping();
                }
                else
                {
                    Console.WriteLine("다시 입력해주세요.");
                    Thread.Sleep(2000);
                    Shopping();
                }
            }
            else
            {
                Console.WriteLine("이미 구매한 품목입니다. 다시 선택해주세요.");
                Thread.Sleep(2000);
                Shopping();
            }

        }

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }


    public class Character
    {
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; }
        public int Gold { get; set; }

        public Character(string name, string job, int level, int atk, int def, int hp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            Atk = atk;
            Def = def;
            Hp = hp;
            Gold = gold;
        }

    }

    public class Inventory
    {
       
        public string Name { get; set; }
        public string Stat { get; set; }
        public string Str { get; set; }

        public Inventory(string name, string stat, string str)
        {
            this.Name = name;
            this.Stat = stat;
            this.Str = str;
        }

       
    }

    public class GoldShop : Inventory
    {
        public string Name { get; set; }
        public string Stat { get; set; }
        public string Str { get; set; }
        public string Price { get; set; }

        public GoldShop(string name, string stat, string str, string price) : base(name, stat, str)
        {
            this.Name = name;
            this.Stat = stat;
            this.Str = str;
            this.Price = price;
        }
    }
}
