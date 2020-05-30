using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ya : MonoBehaviour
{
    public GameObject win;
    public GameObject wuhu;
    public GameObject asi;
    public GameObject asu;

    // Start is called before the first frame update
    public void wenak()
    {
        win.SetActive(true);
        wuhu.SetActive(true);
        asi.SetActive(false);
        asu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
