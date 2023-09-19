using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 클래스와 구조체의 용도가 같음에도 구조체가 남아있는 이유 : 기존 코드와의 호환성
// 구조체는 레거시 시스템 느낌
// 구조체로 사용할때의 장점은 객체를 생성하지 않아도 사용이 가능함

// public struct Youtube
// {
//     // 구조체에는 값을 대입시킬 수 없다
//     int a;
//     int b;
//     int c;
//     int d;

//     // 생성자
//     public Youtube(int _a, int _b, int _c, int _d)
//     {
//         a = _a; b = _b; c = _c; d = _d;
//     }

//     public void GetA(int value)
//     {
//         a = value;
//     }
// }

public enum Item
{
    Weapon, Shield, Potion,
}

public class Part11 : MonoBehaviour
{
    // Youtube yena;
    // Youtube yena2 = new Youtube(1, 2, 3, 4);



    Item item;

    // Start is called before the first frame update
    void Start()
    {
        // yena.GetA(5);



        item = Item.Weapon;
        item = Item.Shield;

        print(item);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
