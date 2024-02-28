using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    [SerializeField] private float ChangeTime;
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedZ;
    [SerializeField] private bool Stay;
    private float TimeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(SpeedX, 0, SpeedZ));

        if (Stay == false)
        {
            Destroy(this.gameObject);
        }

        TimeCount += Time.deltaTime;

        if(TimeCount > ChangeTime)
        {
            Vector3 course = new Vector3(0, Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);
            TimeCount = 0;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Area"))
        {
            Stay = false;
        }
    }
}
