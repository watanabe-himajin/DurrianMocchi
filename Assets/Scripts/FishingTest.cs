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
    [SerializeField] private GameObject BlackbassPrefab;
    private GameObject Blackbass;
    //[SerializeField] private GameObject Prefab;
    //private GameObject ;

    string[] Fish = new string[5] { "Carp!", "Catfish!", "Sweetfish!", "Blackbass!", "e" };
    int max = 5;
    int strage = 0;
    static int CoinStrage;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            if (strage < max)
            {     
                int a = 0;
                //FishFlag.Hit == true
                if (FishFlag.Hit == true)
                {
                    Debug.Log(a);
                    int random = Random.Range(0, 5);
                    Debug.Log(Fish[random]);
                    switch (random)
                    {
                        case 0:
                            Carp = Instantiate(CarpPrefab, transform.position, CarpPrefab.transform.rotation);
                            CoinStrage += 2;
                            break;
                        case 1:
                            Catfish = Instantiate(CatfishPrefab, transform.position, CatfishPrefab.transform.rotation);
                            CoinStrage += 3;
                            break;
                        case 2:
                            Sweetfish = Instantiate(SweetfishPrefab, transform.position, SweetfishPrefab.transform.rotation);
                            CoinStrage += 4;
                            break;
                        case 3:
                            Blackbass = Instantiate(BlackbassPrefab, transform.position, BlackbassPrefab.transform.rotation);
                            CoinStrage += 3;
                            break;
                        case 4:
                            CoinStrage += 5;
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
            ChangeScene.Coin += CoinStrage;
            CoinStrage = 0;
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

