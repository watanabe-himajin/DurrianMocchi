using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int BeforeSaleCoin;
    public static int Coin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1))
        {
            Coin += BeforeSaleCoin;
            BeforeSaleCoin = 0;
        }
    }
}
