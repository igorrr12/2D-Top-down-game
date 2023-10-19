using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private float axisX;
    private float axisY;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axisX = Input.GetAxisRaw("Horizontal");
        axisY = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(axisX, axisY) * Time.deltaTime * speed;
    }
}
