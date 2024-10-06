using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiasController : MonoBehaviour
{

    public float speed;
    public Rigidbody2D tuberiaRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        tuberiaRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isDead)
        {
            tuberiaRigidbody.velocity = Vector2.left * speed;

            if (transform.position.x < -6)
            {
                Destroy(this.gameObject);
            }
        }
        else {
            tuberiaRigidbody.velocity = new Vector2(0,0);
        }

    }
}
