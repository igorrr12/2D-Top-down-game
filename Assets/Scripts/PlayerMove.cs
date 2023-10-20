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
    private Animator animator;
    private char keyPressed;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            keyPressed = 'd';
            axisY = 0f;
            axisX = 1.0f;
            animator.SetBool("isPlayerWalkingLeft", false);
            animator.SetBool("isPlayerWalkingDown", false);
            animator.SetBool("isPlayerWalkingUp", false); 
            animator.SetBool("isPlayerIdle", false);
            animator.SetBool("isPlayerWalkingRight", true);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            keyPressed = 'a';
            axisY = 0f;
            axisX = -1.0f;
            animator.SetBool("isPlayerWalkingRight", false);
            animator.SetBool("isPlayerWalkingDown", false);
            animator.SetBool("isPlayerWalkingUp", false);
            animator.SetBool("isPlayerIdle", false);
            animator.SetBool("isPlayerWalkingLeft", true);

        }

        if (Input.GetKey(KeyCode.W))
        {
            keyPressed = 'w';
            axisX = 0f;
            axisY = 1.0f;
            animator.SetBool("isPlayerWalkingRight", false);
            animator.SetBool("isPlayerWalkingLeft", false);
            animator.SetBool("isPlayerWalkingDown", false);
            animator.SetBool("isPlayerIdle", false);
            animator.SetBool("isPlayerWalkingUp", true);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            keyPressed = 's';
            axisX = 0f;
            axisY = -1.0f;
            animator.SetBool("isPlayerWalkingRight", false);
            animator.SetBool("isPlayerWalkingLeft", false);
            animator.SetBool("isPlayerWalkingUp", false);
            animator.SetBool("isPlayerIdle", false);
            animator.SetBool("isPlayerWalkingDown", true);
        }

        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D)){
            axisY = 0f;
            axisX = 0f;
        }

        if (axisX == 0 && axisY == 0)
        {
            animator.SetBool("isPlayerWalkingRight", false);
            animator.SetBool("isPlayerWalkingLeft", false);
            animator.SetBool("isPlayerWalkingDown", false);
            animator.SetBool("isPlayerWalkingUp", false);
            animator.SetBool("isPlayerIdle", true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(axisX, axisY) * Time.deltaTime * speed;
    }
}
