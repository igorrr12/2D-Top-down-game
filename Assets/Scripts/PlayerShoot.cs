using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    private bool canShoot;
    public float delay;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
            canShoot = true;
        } else if (timer > 0)
        {
            timer -= Time.deltaTime;
            canShoot = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timer = delay;
        }
    }
}
