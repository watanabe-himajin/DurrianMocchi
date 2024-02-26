using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    [SerializeField] private float ChangeTime;
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedZ;
    [SerializeField] private float RangeX;
    [SerializeField] private float RangeZ;
    private float TimeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x < RangeX && this.transform.position.x > - RangeX)
        {
            transform.Translate(new Vector3(SpeedX, 0, 0));
        }

        if(this.transform.position.z < RangeZ && this.transform.position.z > - RangeZ)
        {
            transform.Translate(new Vector3(0, 0, SpeedZ));
        }

        TimeCount += Time.deltaTime;
        if(TimeCount > ChangeTime)
        {
            Vector3 course = new Vector3(0, Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);
            TimeCount = 0;
        }
    }
}
