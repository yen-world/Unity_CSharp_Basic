using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part2 : MonoBehaviour
{
    // byte (0~255) 1byte
    // sbyte (-128~127) 1byte
    // short (-30000~30000) 2byte
    // int (-2100000000~2100000000) 4byte
    // long 8byte
    // float f = 4.0f 
    // doube d = 4.0
    // decimal m  = 4.0m (오차범위 double보다 작음)
    // char c = 'A'
    // string s = "abcdefg"

    // int a = 100;
    // float b = 100.15f;
    // int sum1;
    // float sum2;

    int a = 100;
    string b;

    // Start is called before the first frame update
    void Start()
    {
        // sum1 = (int)(a + b);
        // sum2 = a + b;

        // print(sum1);
        // print(sum2);

        // ToString() => 정수를 문자열로 변환
        // b = a.ToString();
        // print(b);

        // int.Parse(value) => String type value를 int type으로 change(double.Parse(), short.Parse()...)
        string b = "100";
        a = int.Parse(b);
        print(a);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
