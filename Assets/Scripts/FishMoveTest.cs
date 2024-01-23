using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMoveTest : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float RotationSpeed;
    [SerializeField] float RotationInterval;

    Rigidbody FishRigid;
    // Start is called before the first frame update
    void Start()
    {
        FishRigid = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
