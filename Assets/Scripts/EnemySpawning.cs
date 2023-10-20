using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject enemy1;
    private bool spawn;
    public float delay;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            spawn = true;
        }
        else if (timer > 0)
        {
            timer -= Time.deltaTime;
            spawn = false;
        }
        if (spawn)
        {
            Instantiate(enemy1, transform.position, Quaternion.identity, transform);
            spawn = false;
            timer = delay;
        } 
    }
}
