using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCoin : MonoBehaviour
{
    [SerializeField] private int FishNumber;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke(nameof(Carps), 3.0f);
    }

    // Update is called once per frame
    public void Carps()
    {
        Destroy(this.gameObject);
    }

    public void CatFish()
    {
        Destroy(this.gameObject);
    }

    public void SweetFish()
    {
        Destroy(this.gameObject);
    }
}
