using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishingTest : MonoBehaviour
{
    [SerializeField] private GameObject CarpPrefab;
    private GameObject Carp;


    string[] Fish = new string[5] { "a", "b", "c", "d", "e" };
    int max = 5;
    int strage = 0;
    int chanseholder = 0;
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
                int chanse = Random.Range(0, 101);
                if(chanse > 20)
                {
                    Debug.Log(chanse);
                }
                else if(chanse <= 20)
                {
                    int random = Random.Range(0, 5);
                    Debug.Log(Fish[random]);
                    switch (random)
                    {
                        case 0:
                            Carp = Instantiate(CarpPrefab, transform.position, CarpPrefab.transform.rotation);
                            break;
                        default:
                            break;
                    }
                    strage++;
                    Debug.Log(chanse);
                }
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

