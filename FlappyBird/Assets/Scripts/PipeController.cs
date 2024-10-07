using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D pipeRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        pipeRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isDead)
        {
            pipeRigidbody.velocity = Vector2.left * speed;
            if (transform.position.x < -6)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            pipeRigidbody.velocity = new Vector2(0,0);
        }
    }
}
