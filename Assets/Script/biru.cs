using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biru : MonoBehaviour
{
    [SerializeField]
    private Transform Place1;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    public static bool locked;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - Place1.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - Place1.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(Place1.position.x, Place1.position.y);
                        locked = true;
                    }
                    break;
            }
        }
    }
}
