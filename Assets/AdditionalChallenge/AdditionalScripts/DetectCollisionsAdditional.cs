using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsAdditional : MonoBehaviour
{

    [SerializeField] private float maxFeed = 3;
    [SerializeField] private float currentFeed = 0;
    public HealtBar HealtBar;
    // Start is called before the first frame update
    void Start()
    {
        HealtBar.SetHealth(currentFeed, maxFeed);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentFeed == maxFeed)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.tag == "Projectile")
        {
            currentFeed++;
            HealtBar.SetHealth(currentFeed, maxFeed);
            //Destroy(gameObject);
            Destroy(other.gameObject);
            Score.score++;
            Debug.Log(Score.score);
        }
        if (other.gameObject.transform.tag == "Player")
        {
            //Destroy(other.gameObject);
            if (Score.lives <= 0)
            {

                Debug.Log("Game Over!");
            }
            Score.lives--;
        }
    }
}
