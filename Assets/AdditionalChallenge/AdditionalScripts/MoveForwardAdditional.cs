using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardAdditional : MonoBehaviour
{

    public float speed = 15f;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
