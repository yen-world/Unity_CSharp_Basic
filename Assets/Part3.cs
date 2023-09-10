using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part3 : MonoBehaviour
{
    int intValue;
    float floatValue = 10.5f;
    float floatValue2 = 20.5f;

    //디폴트 매개변수는 항상 뒤에 와야함
    int FloatToInt(float _parameter, float _parameter2, string _stringParm = "Default")
    {
        return Multiply((int)(_parameter + _parameter2));
    }

    int Multiply(int _parameter)
    {
        return _parameter * _parameter;
    }
    // Start is called before the first frame update
    void Start()
    {
        print(FloatToInt(floatValue, floatValue2));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
