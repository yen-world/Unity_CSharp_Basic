using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part12 : MonoBehaviour
{
    // delegate를 활용하면 여러 함수를 클래스에 넣어서 한 번에 함수 처리를 가능하게 할 수 있다
    public delegate void ChainFunction(int value);

    // delegate를 받아서 이용하는 event는 타 클래스에서도 함수 추가가 가능하다
    public static event ChainFunction OnStart;
    // ChainFunction chain;

    int power;
    int defence;

    public void SetPower(int value)
    {
        power += value;
        print("power의 값이" + value + "만큼 증가했습니다. 총 power의 값 = " + power);
    }

    public void SetDefence(int value)
    {
        defence += value;
        print("defence의 값이" + value + "만큼 증가했습니다. 총 defence의 값 = " + defence);

    }
    // Start is called before the first frame update
    void Start()
    {
        // chain += SetPower;
        // chain += SetDefence;

        // chain -= SetDefence;
        // chain -= SetPower;

        // if (chain != null)
        //     chain(5);




        OnStart += SetPower;
        OnStart += SetDefence;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDisable()
    {
        OnStart(5);
    }
}
