using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{

    public float velocity = 1f;
    public float size = 10f;
        
    SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isDead)
        {
            _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + velocity * Time.deltaTime, _spriteRenderer.size.y);
            if (_spriteRenderer.size.x > size)
            {
                _spriteRenderer.size = _startSize;
            }
        }   
    }
}
