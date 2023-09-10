using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    private int a;
    public int b;
    public static int c; // static은 공유하는 자원
    public void Abc()
    {

    }

    private void Abc2()
    {

    }
}

public class Part4 : MonoBehaviour
{
    // int a = 5;

    // void Abc()
    // {
    //     // 지역변수와 전역변수의 이름이 같아 충돌이 일어날때는 지역변수의 우선순위가 높기 때문에 전역변수는 무시된다.
    //     int a = 5;
    //     a = 6;
    //     int b = 5;
    //     print(b);
    // }

    // void Abc2()
    // {
    //     int b = 10;
    //     print(b);
    // }

    // void Abc3(float _parameter)
    // {

    // }

    Test aaa;

    void Abc()
    {
        aaa.b = 5;
        // aaa.a = 5;

        aaa.Abc();
        // aaa.Abc2();
    }

    // new 키워드를 사용하여 클래스의 객체를 생성하지 않으면 Test 클래스의 변수를 생성한다 하더라도 사용 할 수 없다.
    // => 인스턴스를 사용하기 위해서는 new 키워드로 객체를 생성해야한다는 말
    Test a1 = new Test();
    Test a2 = new Test();
    Test a3 = new Test();

    void Start()
    {
        Abc2();
    }
    void Abc2()
    {
        a1.b = 1;
        a2.b = 5;
        a3.b = 10;

        // static 변수에 접근하려면 객체가 아닌 클래스로 접근해야함(객체가 가지고 있는 고유한 자원이 아니기 때문에)
        // static 변수는 클래스에 하나만 존재할 수 있으며, 모든 멤버가 공유하고 사용 할 수 있는 자원이다.
        Test.c = 100;

        print(a1.b);
        print(a2.b);
        print(a3.b);

        print(Test.c);


    }
}
