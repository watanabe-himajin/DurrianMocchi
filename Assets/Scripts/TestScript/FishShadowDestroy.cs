using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishShadowDestroy : MonoBehaviour
{
    private bool Pointing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {/*
        if(FishingTest.Fishing == true && Pointing == true)
        {
            Destroy(this.gameObject);
        }
       */ 
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("FishingFloat"))
        {
            Pointing = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("FishingFloat"))
        {
            Pointing = false;
        }
    }
}
