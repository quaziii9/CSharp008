

namespace CSharp008
{
    internal class Inventory
    {
        // 아이템 클래스
        // 플레이어 클래스
        // 리스트에 아이템을 담는다
        // 플레이어는 가지고 있는 아이템을 사용함(데이터에서 삭제)
        // ㄴ 사용한 아이템은 리스트에서 제거되야한다.
        // hp +=200; 리스트에서 날라가야함

        class Item
        {
            public string name;
            public int hp;
            public int mp;

            public Item(string name, int hp, int mp)
            {
                this.name = name;
                this.hp = hp;
                this.mp = mp;
            }
            public void print(Item item)
            {
                Console.WriteLine($"{this.name}, {this.hp}, {this.mp} ");
            }
        }

        class Player
        {
            int hp = 100;
            int mp = 100;

            public void Use(Item item)
            {
                this.hp += item.hp;
                this.mp += item.mp;
            }

            public void Print()
            {
                Console.WriteLine($"현재 플레이어 체력 : {hp}, 현제 플레이어 마력 : {mp}");
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
                Player player = new Player();

                Item red = new Item("빨간포션", 50, 5);
                Item blue = new Item("파란포션", 5, 30);


                List<Item> itemList = new List<Item>();
                itemList.Add(red);
                itemList.Add(blue);
                List<Item> inven = new List<Item>();

                Console.WriteLine("아이템 추가 가능한 목록(번호를 입력하시오)");
                Console.WriteLine("1. 빨간포션, 2. 파란포션, 3. 나가기");

                Console.WriteLine();
                string plus = "0";
                string minus = "0";

                while (plus != "3")
                {
                    plus = Console.ReadLine();

                    if (plus == "1") inven.Add(red);
                    else if (plus == "2") inven.Add(blue);
                    else if (plus == "3") break;
                    else Console.WriteLine("준비된 아이템이 없습니다");
                }

                Console.Write("내 인벤토리 : ");
                foreach (Item item in inven)
                {
                    Console.Write(item.name + "    ");
                }

                Console.WriteLine("사용할 아이템을 입력하시오");
                Console.WriteLine("1.빨간포션, 2. 파란포션");

                minus = Console.ReadLine();

                Item findA = inven.Find(element => element.name == "빨간포션");
                Item findB = inven.Find(element => element.name == "파란포션");

                if (minus == "1" && findA.name == "빨간포션")
                {
                    player.Use(red);
                    inven.Remove(red);
                    Console.WriteLine($"{red.name}을 사용하였습니다! 체력 {red.hp} , 마력 {red.mp} 증가! ");
                }
                if (minus == "2" && findB.name == "파란포션")
                {
                    player.Use(blue);
                    inven.Remove(blue);
                    Console.WriteLine("파란 포션을 사용하셨습니다!");
                    Console.WriteLine($"{blue.name}을 사용하였습니다! 체력 {blue.hp} , 마력 {blue.mp} 증가! ");
                }
                if (!(minus == "1" || minus == "2")) Console.WriteLine("준비되지 않은 아이템입니다");

                Console.WriteLine();
                Console.Write("내 인벤토리 : ");
                foreach (Item item in inven)
                {
                    Console.Write(item.name + "    ");
                }
                Console.WriteLine();

                player.Print();
            }
        }
    }
}

