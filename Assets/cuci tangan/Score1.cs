using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class Score1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Text scoreText;
    public int score;
    public GameObject winScreen;
    public GameObject buttonwin;
    public GameObject aa;

    //Detect current clicks on the GameObject (the one with the script attached)
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        scoreText.text = "Score: " + score;
        score++;
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        // You may not need this. I just wanted to show you that it does exist.
        // If you delete this, remove IPointerUpHandler from up top as well.
        // Because the IPointerHandler's do require their equivalent function.
    }

    void Update()
    {
        if (score >= 30)
        {
            winScreen.SetActive(true);
            buttonwin.SetActive(true);
            aa.SetActive(false);
        }
    }
}
