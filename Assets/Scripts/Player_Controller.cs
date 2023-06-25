using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    private Rigidbody2D rbBrid;

    // Start is called before the first frame update
    void Start()
    {
        rbBrid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rbBrid.velocity = Vector2.up * jumpForce;
        }
    }
}
