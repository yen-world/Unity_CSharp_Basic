using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part6 : MonoBehaviour
{

    int input = 10;
    int num = 10;
    bool result;
    string str = "가나다";
    // Start is called before the first frame update
    void Start()
    {
        result = input > num;
        if (input == num)
            print("input의 값이 num과 같습니다");

        else if (result)
            print("input의 값이 num보다 큽니다.");

        else if (!result)
            print("input의 값이 num보다 작습니다.");

        switch (str)
        {
            case "가":
                print("가");
                break;
            case "나":
                print("나");
                break;
            case "다":
                print("다");
                break;
            case "가나다":
                print("가나다");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
