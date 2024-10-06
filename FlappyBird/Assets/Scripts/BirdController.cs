using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{

    public Vector3 force;
    public Rigidbody2D birdRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        birdRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            birdRigidBody.AddForce(force);
        }
    }
}
