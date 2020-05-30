using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{

    public GameObject[] cars;
    int carNo;
    public float maxPos = 3.6f;
    public float delayTimer = 1f;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 carPos = new Vector3(transform.position.x, Random.Range(-3.2f, 3.2f), transform.position.z);
            carNo = Random.Range(0,1);
            Instantiate(cars[carNo], carPos, transform.rotation);
            timer = delayTimer;
        }
    }
}
