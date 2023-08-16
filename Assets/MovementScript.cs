using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    private float timer = 0f;
    private float movementTick = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");

        if (timer >= movementTick)
        {

            switch(dirX)
            {
                case 1:
                    gameObject.transform.Translate(0.16f, 0, 0);
                    timer = 0;
                    break;
                case -1:
                    gameObject.transform.Translate(-0.16f, 0, 0);
                    timer = 0;
                    break;
            }

            switch(dirY)
            {
                case 1:
                    gameObject.transform.Translate(0, 0.16f, 0);
                    timer = 0;
                    break;
                case -1:
                    gameObject.transform.Translate(0, -0.16f, 0);
                    timer = 0;
                    break;
            }

        }
        else 
        {
            timer += Time.deltaTime;
        }

        // else if (dirX == -1)
        // {
        //     transform.position.x -= 0.1592f;
        // }

        // if (dirY = 1) 
        // {
        //     transform.position.y += 0.1592f;
        // }
        // else if (dirY == -1)
        // {
        //     transform.position.y -= 0.1592f;
        // }

    }

    void Move()
    {

    }
}
