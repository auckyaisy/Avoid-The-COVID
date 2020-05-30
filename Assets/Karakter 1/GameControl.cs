using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;
    public GameObject winbutt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Kuni.locked && Mera.locked && Hijo.locked && biru.locked)
        {
            winText.SetActive(true);
            winbutt.SetActive(true);
        }
           
        

    }
}
