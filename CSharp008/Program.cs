namespace CSharp008
{
    internal class Program
    {

        
        // ==============================================================
        // [List]
        // 동적배열기반 자료구조
        
        // 삽입 
        // 중간에 데이터를 추가하기 위해 이후 데이터를 뒤로 밀어내고 삽입한다
        
        // 삭제
        // 중간에 데이터를 삭제한뒤 빈자리를 채우기 위해 이후 데이터들을 앞으로 당긴다.
         


        // ==============================================================
        static void Main(string[] args)
        {
            // C# : 동적배열 기반의 자료구조 

            List<string> list = new List<string>();
            list.Add("0번 데이터");
            list.Add("1번 데이터");
            list.Add("2번 데이터");
            list.Add("3번 데이터");
            list.Add("4번 데이터");

            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine();
            Console.WriteLine();
            list.Insert(1, "중간 데이터 1번");
            list.Insert(3, "중간 데이터 2번");
            list.Insert(5, " 이힛 ");
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine();
            

            list.Remove("1번 데이터");
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.Write(item + " -> ");
            }
            // 배열 기반이기 때문에 바로바로 인덱스로 접근이 가능
            list[0] = "데이터1";
            string value = list[0];

            int indexOf = list.IndexOf("2번 데이터");

            //Console.WriteLine(list.Capacity); // 용량

            // list, linked list 
            // 중간에 삽입삭제 빈번하게 일어나는건 linked list
            // 탐색은 list가 빠름 인덱스로 접근
            // 환영? : 순환구조 
        }
    }
}
