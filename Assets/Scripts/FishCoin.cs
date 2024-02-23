using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCoin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Carps), 3.0f);
    }

    // Update is called once per frame
    public void Carps()
    {
        ChangeScene.Coin += 10;
        Destroy(this.gameObject);
    }
}
