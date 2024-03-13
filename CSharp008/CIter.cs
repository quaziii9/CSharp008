using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharp008
{
    internal class CIter
    {
        // 반복기(Iterator)
        // 자료구조와 종류와 무관하게 순회가 가능
        // 자료구조에 저장되어 있는 요소들을 순차적으로 접근
        // 대부분 자료구조는 iterator를 포함
        // 그렇다는건 자료구조 종류와 내부구조와는 무관하게 순회할 수 있다(반복기를 사용하는 이유)

        // IEnumerable : 자료구조의 반복기 생성 인터페이스
        // IEnumerator : 자료구조의 반복기 객체 인터페이스
        

        void Test()
        {
            List<int> list = new List<int>() { 0, 1, 2, 3, 4, 5 };

            // 반복기 객체 생성
            IEnumerator<int> iter = list.GetEnumerator();

            // 반복기 객체가 현제 가리키는 데이터
            Console.WriteLine($"{iter.Current}");   

            while(iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        void Test01()
        {
            int size = 5;
            List<int> list = new List<int>();

            for(int i =0; i< size; i++)
            {
                list.Add(i);
            }
            
            // 반복기를 사용안하는 경우
            for(int i = 0; i< list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // 반복기 사용 x(내부 구조를 이용해서)
            LinkedList<int> list2 = new LinkedList<int>();
            for(LinkedListNode<int>node = list2.First; node!= null; node=node.Next)
            {

            }
            // 반복기 사용
            for(IEnumerator<int> iter = list2.GetEnumerator(); iter.MoveNext();) 
            {
                
            }



            // 반복기를 사용하는 경우

            for(IEnumerator<int>iter = list.GetEnumerator(); iter.MoveNext();)
            {
                Console.Write(iter.Current);
            }
        }

        void Test02() 
        {
            int size = 5;
            int[] array = new int[size];

            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            SortedSet<int> set = new SortedSet<int>();

            for (int i = 0; i < size; i++)
            {
                array[i] = i;
                list.Add(i);
                stack.Push(i);
                queue.Enqueue(i);
                set.Add(i);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


        }

        static void Main()
        {
            CIter cIter = new CIter();
            cIter.Test();

            // list와 LinkedList동작
            // 반복기를 들고 있으면 forach를 통해서 내부적으로 순회 가능
            // 반복기를 쓰는 이유는 자료구조 종류와 내부구조와는 무관하게 돌릴 수 있음
        }
        
        
    }
}
