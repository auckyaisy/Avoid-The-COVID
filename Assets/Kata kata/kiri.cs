using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kiri : MonoBehaviour
{
    public GameObject wino;
    public GameObject wuhuo;
    public GameObject asi;
    public GameObject asu;

    // Start is called before the first frame update
    public void wenak()
    {
        wino.SetActive(true);
        wuhuo.SetActive(true);
        asi.SetActive(false);
        asu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
