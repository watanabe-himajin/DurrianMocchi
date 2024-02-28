using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishing : MonoBehaviour
{
    [SerializeField] public static bool fising;
    [SerializeField] private int FishMax;
    [SerializeField] private int FishStrage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(FishStrage < FishMax)
            {
                
            }
            else
            {
                Debug.Log("Å‘å’l‚Å‚·");
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            FishStrage = 0;
        }
    }
}
