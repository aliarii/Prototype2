using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timer <= 0.5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timer = 1;
            }
        }
        timer -= 1 * Time.deltaTime;
    }
}
