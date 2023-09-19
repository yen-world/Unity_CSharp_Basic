using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part5 : MonoBehaviour
{
    int a = 10;
    int b = 10;
    int c = 0;
    bool d = false;

    // Start is called before the first frame update
    void Start()
    {
        print(++c);
        print(c++);

        d = (a == b) || (a != b);
        print(d);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
