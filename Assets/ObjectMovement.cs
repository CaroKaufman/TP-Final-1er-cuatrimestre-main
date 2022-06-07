using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float xSpeed = 0.05f;
    public float xFrontLimit = 1.970316f;
    public float xBackLimit = -1.970316f;
    public bool toFront;
    // Start is called before the first frame update
    void Start()
    {
        toFront = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toFront) {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xFrontLimit)
        {
            toFront = false;
        }
        else if (transform.position.x <= xBackLimit)
        {
            toFront = true;
        }
    }
}
