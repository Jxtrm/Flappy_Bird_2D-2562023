using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rbBrid;
    private bool startPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        rbBrid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Menu_Control.intance.gameStarted)
        {
            if (!startPlayer)
            {
                startPlayer = true;
                rbBrid.gravityScale = 2f;
            }

            rbBrid.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Score")
        {
            Menu_Control.intance.SumarPuntacion();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rbBrid.velocity = new Vector2(0, 0);
        rbBrid.gravityScale = 0;
        Menu_Control.intance.GameStop();
    }
}
