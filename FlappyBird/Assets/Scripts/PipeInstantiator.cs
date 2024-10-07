using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeInstantiator : MonoBehaviour
{
    public GameObject pipesPrefab;
    public float positionX;
    public float positionY;
    public float timer;
    public float instantiateCooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isDead)
        {
            timer += Time.deltaTime;
            if (timer > instantiateCooldown)
            {
                timer = 0;
                positionY = Random.Range(-2.2f, 2.5f);
                Instantiate(pipesPrefab);
                pipesPrefab.transform.position = new Vector3(positionX, positionY, pipesPrefab.transform.position.z);
            }
        }
    }
}
