using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointUpDownTest : MonoBehaviour
{
    bool pointupdown = false;
    [SerializeField] private int UpDown;
    [SerializeField] private int UpDownTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var y = Mathf.PingPong(Time.time, 2);
        if(Input.GetKeyDown(KeyCode.Space) && pointupdown == false)
        {
            transform.localPosition = new Vector3(0, y, 0);
        }
    }
}
