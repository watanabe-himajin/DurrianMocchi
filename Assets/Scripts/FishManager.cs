using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    GameObject[] tagObjects;
    [SerializeField] private int FishCount;
    [SerializeField] private GameObject FishShadowPrefab;
    private float Timer;
    [SerializeField] private float Interval;
    private GameObject FishShadow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer > Interval)
        {
            Check("FishShadow");
            Timer = 0;
        }

    }
    void Check(string tagname)
    {
        tagObjects = GameObject.FindGameObjectsWithTag(tagname);
        if(tagObjects.Length < FishCount)
        {
            FishShadow = Instantiate(FishShadowPrefab, transform.position, FishShadowPrefab.transform.rotation);
        }
    }
}
