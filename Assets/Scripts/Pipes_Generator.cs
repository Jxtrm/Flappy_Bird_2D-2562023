using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes_Generator : MonoBehaviour
{
    [SerializeField] private GameObject pipes;
    [SerializeField] private float interval = 3f;
    private float minHeigth = -2.5f;
    private float maxHeigth = 1.5f;
    private float startPipes = 2f;
    private bool pipesGeneratorStopped = true;
    
    void Update()
    {
        if(Menu_Control.intance.gameStarted && pipesGeneratorStopped)
        {
            pipesGeneratorStopped = false;
            InvokeRepeating("PipeCreator", startPipes, interval);
        }
        if (!Menu_Control.intance.gameStarted && !pipesGeneratorStopped)
        {
            CancelInvoke();
        }
    }

    private void PipeCreator()
    {
        Vector2 initialPosition;
        initialPosition.x = this.transform.position.x;
        initialPosition.y = Random.Range(minHeigth, maxHeigth);
        Instantiate(pipes, initialPosition, Quaternion.identity);

    }
}
