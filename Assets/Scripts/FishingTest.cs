using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishingTest : MonoBehaviour
{
    public bool Fishing;
    [SerializeField] private GameObject ExclamationPrefab;
    private GameObject Exclamation;
    [SerializeField] private GameObject CarpPrefab;
    private GameObject Carp;
    [SerializeField] private GameObject CatfishPrefab;
    private GameObject Catfish;
    [SerializeField] private GameObject SweetfishPrefab;
    private GameObject Sweetfish;

    string[] Fish = new string[5] { "a", "b", "c", "d", "e" };
    int max = 5;
    int strage = 0;
    int chanseholder = 0;
    int chance = Random.Range(0, 5);
    void Start()
    {
        Fishing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (chance > 2)
        {
            Invoke(nameof(RandomNumber), 1.0f);
        }
        else if (chance <= 2)
        {
            Fishing = true;
            Exclamation = Instantiate(ExclamationPrefab, transform.position, ExclamationPrefab.transform.rotation);
            Invoke(nameof(ChangeFlag), 1.0f);
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(strage < max)
            {
                if(Fishing == true)
                {
                    int random = Random.Range(0, 5);
                    Debug.Log(Fish[random]);
                    switch (random)
                    {
                        case 0:
                            Carp = Instantiate(CarpPrefab, transform.position, CarpPrefab.transform.rotation);
                            ChangeScene.Coin += 2;
                            break;
                        case 1:
                            Catfish = Instantiate(CatfishPrefab, transform.position, CatfishPrefab.transform.rotation);
                            ChangeScene.Coin += 3;
                            break;
                        case 2:
                            Sweetfish = Instantiate(SweetfishPrefab, transform.position, SweetfishPrefab.transform.rotation);
                            ChangeScene.Coin += 4;
                            break;
                        case 3:
                            ChangeScene.Coin += 3;
                            break;
                        case 4:
                            ChangeScene.Coin += 5;
                            break;
                        default:
                            break;
                    }
                    strage++;
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
            Debug.Log(ChangeScene.Coin);
        }
    }
    private void ChangeFlag()
    {
        Fishing = false;
    }
    private void RandomNumber()
    {
        int chance = Random.Range(0, 101);
    }
}

