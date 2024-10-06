using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{

    public int size = 0;
    public int velocity = 0;
    public Rigidbody2D rigidbody2D;
    public SpriteRenderer spriteRenderer;

    private Vector2 _startSize;

    // Start is called before the first frame update
    void Start()
    {
        //spriteRenderer = GetComponent<Rigidbody2D>();
        _startSize = spriteRenderer.bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + velocity * Time.deltaTime, spriteRenderer.size.y);
        if (spriteRenderer.bounds.size.x > size)
        {
            spriteRenderer.size = _startSize;
        }
    }
}
