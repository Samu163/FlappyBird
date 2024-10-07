using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    public float velocity = 1f;
    public float size = 10f;      
    private SpriteRenderer spriteRenderer;
    private Vector2 startSize;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isDead)
        {
            spriteRenderer.size = new Vector2(spriteRenderer.size.x + velocity * Time.deltaTime, spriteRenderer.size.y);
            if (spriteRenderer.size.x > size)
            {
                spriteRenderer.size = startSize;
            }
        }   
    }
}
