using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part12_2 : MonoBehaviour
{
    public void Abc(int value)
    {
        print(value + "값이 증가했습니다");
    }
    // Start is called before the first frame update
    void Start()
    {
        Part12.OnStart += Abc;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
