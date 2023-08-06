using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 3.0f; // seconds
    public float maxOffset = 10.0f;

    private float time = 0.0f; //seconds
    private float curSpawnRate; // seconds

    void Start()
    {
        SpawnPipe();
        curSpawnRate = spawnRate;
    }

    void Update()
    {
        curSpawnRate = spawnRate - GameLogic.userScore / 10.0f;
        if (curSpawnRate < 1.0f)
            curSpawnRate = 1.0f;

        if (time < curSpawnRate)
        {
            time += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            time = 0;
        }
    }

    private void SpawnPipe()
    {
        float lowest = transform.position.y - maxOffset;
        float highest = transform.position.y + maxOffset;
        Vector3 pos = new Vector3(transform.position.x, Random.Range(lowest, highest), transform.position.z);
        Instantiate(pipe, pos, transform.rotation); // transform=same as parent
    }
}
