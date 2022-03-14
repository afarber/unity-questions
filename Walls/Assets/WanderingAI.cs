using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    public float speed = 3.0f;
    public float obstacleRange = 5.0f;
    private bool isAlive;

    void Start()
    {
        isAlive = true;
    }

    void Update()
    {
        if (!isAlive)
        {
            return;
        }

        transform.Translate(0, 0, speed * Time.deltaTime); 
 
        Ray ray = new(transform.position, transform.forward);
        if (Physics.SphereCast(ray, 0.75f, out RaycastHit hit))
        {
            if (hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                transform.Rotate(0, angle, 0);
            }
        }
    }

    public void SetAlive(bool alive)
    {
        isAlive = alive;
    }
}
