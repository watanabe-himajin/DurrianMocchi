using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishName : MonoBehaviour
{
    //River
    [SerializeField] private GameObject CarpPrefab;
    private GameObject Carp;
    [SerializeField] private GameObject CatfishPrefab;
    private GameObject Catfish;
    [SerializeField] private GameObject SweetfishPrefab;
    private GameObject Sweetfish;
    [SerializeField] private GameObject BlackbassPrefab;
    private GameObject Blackbass;
    [SerializeField] private GameObject CrayfishPrefab;
    private GameObject Crayfish;
    string[] RiverFish = new string[5] { "Carp", "Catfish", "Sweetfish", "Blackbass", "Crayfish" };

    //Swamp

    //Sea


    // Update is called once per frame
    void Update()
    {
        
    }
}
