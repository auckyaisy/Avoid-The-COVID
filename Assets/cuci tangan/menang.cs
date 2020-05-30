using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menang : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winScreen;
    public int score;
    void Start()
    {
        // Set to that object in editor public GameObject winScreen;
       
            
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= 10)
        {
            winScreen.SetActive(true);
        }
    }
}
