using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part7 : MonoBehaviour
{
    int num = 0;
    string text = "가나다라마바사";
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            num = i;
            print(i);
        }

        foreach (char a in text)
        {
            print(a);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
