using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yena.World;
using Yena;

namespace Yena
{
    public class Youtube
    {
        public int subscribe;

    }
    namespace World
    {
        public class Youtube
        {
            int like;

            public void SetLike(int value)
            {
                like = value;
            }

            public bool IsLike()
            {
                return like != 0;
            }
        }
    }
}

public class Part10 : MonoBehaviour
{
    Yena.Youtube yena = new Yena.Youtube();

    // Start is called before the first frame update
    void Start()
    {
        yena.subscribe = 5;
        print(yena.subscribe);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
