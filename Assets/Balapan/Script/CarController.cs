using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{

    public float carSpeed;
    public float maxPos = 3.6f;

    Vector2 position;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(4);
        }
    }


    public void MoveUp()
    {
        rb.velocity = new Vector2 (0, carSpeed);
    }

    public void MoveDown()
    {
        rb.velocity = new Vector2 (0, -carSpeed);
    }

    public void SetVelocityZero()
    {
        rb.velocity = Vector2.zero;
    }
}
