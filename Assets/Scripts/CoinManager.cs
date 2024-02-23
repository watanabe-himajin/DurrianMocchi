using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public GameObject CoinObject = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text CoinText = CoinObject.GetComponent<Text>();
        CoinText.text = "Coin:" + ChangeScene.Coin;
    }
}
