using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteFish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Moving1), 1.0f);
        Invoke(nameof(Destroyer), 1.0f);
    }

    // Update is called once per frame
    private void Moving1()
    {

    }
    private void Destroyer()
    {
        Destroy(this.gameObject);
    }
}
