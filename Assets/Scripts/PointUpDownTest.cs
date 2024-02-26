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
        if(Input.GetKeyDown(KeyCode.Space) && pointupdown == false)
        {
            pointupdown = true;
            transform.Translate(new Vector3(0, UpDown, 0));
        }

        if(pointupdown == true)
        {
            Invoke(nameof(GoDown), UpDownTime);
        }
    }

    private void GoDown()
    {
        if (this.transform.position.y >= 0 && pointupdown == true)
        {
            transform.Translate(new Vector3(0, -UpDown, 0));
        }
        if(this.transform.position.y == 0)
        {
            pointupdown = false;
        }        
    }
}
