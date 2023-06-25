using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Controller : MonoBehaviour
{
    [SerializeField] private float velocity = 2f;
    private float leftLimit = -3.5f;
    // Start is called before the first frame update
    void Update()
    {
        this.transform.position += Vector3.left * velocity * Time.deltaTime;
            if (this.transform.position.x < leftLimit)
            {
                Destroy(this.gameObject);
            }
    }
}
