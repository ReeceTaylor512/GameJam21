using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;
    public float speed;

    public float horizontal;
    public float vertical;


    public SpriteRenderer torso;
    public SpriteRenderer head;

    public Sprite bodyFront;
    public Sprite bodyBack;
    public Sprite bodySide;
    public Sprite headFront;
    public Sprite headBack;
    public Sprite headSide;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        vertical = Input.GetAxisRaw("Vertical");
        ChangeSpriteUp();
        ChangeSpriteLeftRight();
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * speed, vertical * speed);
    }
    void ChangeSpriteUp()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            torso.sprite = bodyBack;
            head.sprite = headBack;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            torso.sprite = bodyFront;
            head.sprite = headFront;
        }
    }

    void ChangeSpriteLeftRight()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {

            head.sprite = headSide;
            head.flipX = true;
            torso.sprite = bodySide;

             
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            head.sprite = headSide;
            head.flipX = false;
            torso.sprite = bodySide;

        }

    }


}
