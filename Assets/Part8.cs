using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part8 : MonoBehaviour
{
    int[] exp = { 50, 100, 150, 200, 250, 300, 350, 400 };
    int[] array = new int[10];
    int[,] array2 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < exp.Length; i++)
        {
            print(exp[i]);
        }

        print(array2.Length);
        foreach (int element in array2)
        {
            print(element);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
