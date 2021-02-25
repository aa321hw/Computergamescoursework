using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    //public CharacterController control;
    public Transform Player;
    public Transform respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.position = respawn.position;

        }          
    }
}
