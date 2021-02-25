using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour
{

    public Transform Platform;
    public Animator anim;
    public Vector3 init_pos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        init_pos = Platform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool("activate", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("activate", false);

        Platform.position = init_pos;
    }


}
