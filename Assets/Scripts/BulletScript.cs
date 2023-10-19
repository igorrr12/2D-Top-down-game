using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float rotationSpeed;
    private Vector3 mousePos;


    void Start()
    {
        Destroy(gameObject, 2);
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector2 direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;
    }

    void FixedUpdate()
    {
        rb.velocity = transform.up * Time.deltaTime * speed;
    }
}
