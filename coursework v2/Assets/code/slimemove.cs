using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class slimemove : MonoBehaviour
{

    public NavMeshAgent slime1;
    public Transform s1;

    private Vector3 initpos1;

    public Transform Player;
    

    // Start is called before the first frame update
    void Start()
    {
        slime1 = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        slime1.SetDestination(Player.position);

    }

}
