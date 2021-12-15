using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsAdditional : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;
    public float topBoundX = 25;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {

            Destroy(gameObject);
        }
        if (transform.position.x > topBoundX)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -topBoundX)
        {
            Destroy(gameObject);
        }

    }
}
