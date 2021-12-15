using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeTopZ = 15;
    public float spawnRangeBottomZ = 1;
    private float[] spawnPosX = { -24f, 24f };

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private float rotate;
    private void Start()
    {
        InvokeRepeating(nameof(SpawnHorizontalRandomAnimal), startDelay, spawnInterval);
    }
    void Update()
    {
        //SpawnAnimals();
    }
    public void SpawnHorizontalRandomAnimal()
    {
        int spawnPosIndex = Random.Range(0, spawnPosX.Length);
        if (spawnPosIndex == 0)
        {
            rotate = 90f;
        }
        else
        {
            rotate = -90f;
        }
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX[spawnPosIndex], 0, Random.Range(spawnRangeBottomZ, spawnRangeTopZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, rotate, 0));


    }
}
