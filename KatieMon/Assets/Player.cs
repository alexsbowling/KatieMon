using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    public void HandleMovement()
    {
        float x = 0;
        float y = 0;

        if (Input.GetKey(KeyCode.W))
        {
            y += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            y -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += speed;
        }

        myRigidbody.velocity = new Vector2(x,y);

    }
}
