using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishingTest : MonoBehaviour
{
    string[] Fish = new string[5] { "a", "b", "c", "d", "e" };
    int max = 5;
    int strage = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(strage < max)
            {
                int random = Random.Range(0, 5);
                Debug.Log(Fish[random]);
                strage++;
            }
            else
            {
                Debug.Log("Full!!!!!");
            }
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            strage = 0;
            ChangeScene.Coin += 10;
            Debug.Log(ChangeScene.Coin);
        }
    }
}
