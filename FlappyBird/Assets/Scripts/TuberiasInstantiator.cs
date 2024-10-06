using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuberiasInstantiator : MonoBehaviour
{

    public GameObject tuberiasPrefab;
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
        timer += Time.deltaTime;

        if (timer > instantiateCooldown)
        {
            timer = 0;
            positionY = Random.Range(-2.2f, 2.5f);
            Instantiate(tuberiasPrefab);
            tuberiasPrefab.transform.position = new Vector3(positionX, positionY, tuberiasPrefab.transform.position.z);
        }
    }
}
