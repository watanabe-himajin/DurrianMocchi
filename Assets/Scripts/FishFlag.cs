using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishFlag : MonoBehaviour
{
    public static bool Hit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FishShadow"))
        {
            Hit = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("FishShadow"))
        {
            Hit = false;
        }
    }
}
