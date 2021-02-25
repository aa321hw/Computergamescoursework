using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practisemove : MonoBehaviour
{

    public Transform Player;
    private float horizontal;
    private float vertcial;
    private int speed = 4;
    private Vector3 movement;
    private Vector3 still = new Vector3(0, 0, 0);
    private bool canjump = true;

    public Animator anim;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("move", true);
        }
        if (movement == still)
        {
            anim.SetBool("move", false);
        }

        horizontal = Input.GetAxis("Horizontal");
        vertcial = Input.GetAxis("Vertical");

        movement = new Vector3(-horizontal, 0, -vertcial);
        movement = movement * Time.deltaTime * speed;

        Player.position += movement;
        if (movement != still)
        {
            Player.rotation = Quaternion.LookRotation(movement);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canjump){

            canjump = false;
            anim.SetBool("jump", true);
            rb.AddForce(0,8,0, ForceMode.Impulse);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "floor")
        {
            anim.SetBool("jump", false);
            canjump = true;
        }
        if (other.tag == "jump2")
        {
            rb.AddForce(0, 15, 0, ForceMode.Impulse);
        }

    }

}

