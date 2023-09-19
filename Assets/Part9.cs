using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part9 : MonoBehaviour
{

    // 배열
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // ArrayList
    ArrayList arrayList = new ArrayList();

    // List
    List<int> list = new List<int>();

    // HashTable
    Hashtable hashtable = new Hashtable();

    // Dictionary
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    // Queue 자료형 생략가능
    Queue<int> queue = new Queue<int>();

    // Stack 자료형 생략가능
    Stack<int> stack = new Stack<int>();

    // Start is called before the first frame update
    void Start()
    {
        // arrayList.Add(1);
        // arrayList.Add(2);
        // arrayList.Add(3);
        // arrayList.Add("가나다라");
        // arrayList.Add(4.5);

        // // Remove : 동일한 값을 찾아서 지우기
        // arrayList.Remove("가나다라");
        // // RemoveAt : 인덱스를 찾아서 지우기
        // arrayList.RemoveAt(3);
        // // RemoveRange : 인덱스를 찾아 범위만큼 지우기
        // arrayList.RemoveRange(1, 2);

        // arrayList[0] = 100;

        // arrayList.Insert(0, 500);

        // print(arrayList.Contains(100));

        // for (int i = 0; i < arrayList.Count; i++)
        // {
        //     print(arrayList[i]);
        // }




        // hashtable.Add("만", 10000);
        // hashtable.Add("백만", 1000000);
        // hashtable.Add(50, "1억");

        // print(hashtable["만"]);
        // print(hashtable[50]);




        // dictionary.Add("가", 100);
        // dictionary.Add(100, 200);




        // queue.Enqueue(5);
        // queue.Enqueue(10);
        // if (queue.Count != 0)
        //     print(queue.Dequeue());
        // if (queue.Count != 0)
        //     print(queue.Dequeue());
        // if (queue.Count != 0)
        //     print(queue.Dequeue());



        // stack.Push(5);
        // stack.Push(10);
        // stack.Push(15);
        // print(stack.Pop());
        // print(stack.Pop());
        // print(stack.Pop());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
