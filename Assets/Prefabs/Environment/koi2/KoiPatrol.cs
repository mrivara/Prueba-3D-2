using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoiPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] points;
    int current;
    public float speed;

    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
            //Vector3 movementDirection = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            //movementDirection.Normalize();

            //if (movementDirection != Vector3.zero)
            //{
            //    transform.forward = movementDirection;
            //}
        }
        else
        {
            current = (current + 1) % points.Length;
        }
    }
}
