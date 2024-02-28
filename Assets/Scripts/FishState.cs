using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishState : MonoBehaviour
{
    [SerializeField] private float ChangeTime;
    private float TimeCount;
    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedZ;
    [SerializeField] private bool Stay;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(new Vector3(SpeedX, 0, SpeedZ));

        TimeCount += Time.deltaTime;
        if(TimeCount > ChangeTime)
        {
            Vector3 course = new Vector3(0, Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);
            TimeCount = 0;
        }

        if (Stay == false)
        {
            Destroy(this.gameObject);
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
