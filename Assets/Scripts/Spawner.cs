using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float spawnTime;
    [SerializeField] float timer;
    public GameObject pipe;
    [SerializeField] float height;


    void Start()
    {
        
    }

    void Update()
    {
        if (timer > spawnTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height),0);
            Destroy(newPipe, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
