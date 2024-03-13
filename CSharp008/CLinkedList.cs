

namespace CSharp008
{
    internal class CLinkedList
    {
        // 리스트와 링크드 리스트 차이 : 배열기반이냐 노드기반이냐 
        //=======================================
        // [LinkedList]
        // 데이터를 포함하는 노드들을 연결식으로 만든구조
        // 데이터와 다른 데이터 지점의 참조변수를 가진 노드를 기본 단위사용

        //[삽입]
        // 새로 추가하는 노드가 이전/이후 노드를 참조한뒤 이전 노드가 새로 추가하는 노드를 참조한다
        // 

        //=======================================
        static void Main()
        {   // 노드기반
            LinkedList <string> linkedlist =new LinkedList <string> ();

            linkedlist.AddLast("d");
            linkedlist.AddLast("d");
            linkedlist.AddLast("d");


            // 데이터 추가(특정 노드에 접근해서)
            LinkedListNode<string> node0 = linkedlist.AddFirst("0번 데이터");
            LinkedListNode<string> node1 = linkedlist.AddFirst("1번 데이터");
            LinkedListNode<string> node2 = linkedlist.AddLast("2번 데이터");
            LinkedListNode<string> node3 = linkedlist.AddLast("3번 데이터");
            LinkedListNode<string> node4 = linkedlist.AddBefore(node0,"4번 데이터"); // node0 이전에 넣기
            LinkedListNode<string> node5 = linkedlist.AddAfter(node0 ,"5번 데이터"); // node 이후에 넣기

            foreach (var item in linkedlist)
            {
                Console.Write(item + " -> ");
            }

            // 데이터 삭제
            linkedlist.Remove("1번 데이터");
            linkedlist.Remove(node3);
            linkedlist.RemoveFirst();
            linkedlist.RemoveLast();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in linkedlist)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // 데이터 접근
            LinkedListNode<string> firstNode = linkedlist.First;
            LinkedListNode<string> lastNode = linkedlist.Last;
            LinkedListNode<string> prevNode = node0.Previous;
            LinkedListNode<string> nextNode = node0.Next;

            Console.WriteLine(firstNode.Value);
            Console.WriteLine(lastNode.Value);
            // Console.WriteLine(prevNode.Value);

            // 데이터 탐색
            LinkedListNode<string> findNode = linkedlist.Find("5번 데이터");

            Console.WriteLine(findNode);

        }
    }
}
