using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes_Generator : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    private float minHeigth = -2.5f;
    private float maxHeigth = 1.5f;
    [SerializeField] private float interval = 3f;
    void Start()
    {
        InvokeRepeating("PipeCreator", 0, interval);
    }

    private void PipeCreator()
    {
        Vector2 initialPosition;
        initialPosition.x = this.transform.position.x;
        initialPosition.y = Random.Range(minHeigth, maxHeigth);
        Instantiate(pipes, initialPosition, Quaternion.identity);

    }
}
