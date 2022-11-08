using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    GameObject player;
    Collision col;
    float rotSpeed = 3.0f, moveSpeed = 3.0f;

    private void Awake()
    {
        col = new Collision();
    }
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > 2)
        {
            Walk();
        }
    }
    void Walk() 
    {
        /* Look at Player*/
        transform.rotation = Quaternion.Slerp(transform.rotation
        , Quaternion.LookRotation(player.transform.position - transform.position)
        , rotSpeed * Time.deltaTime);

        /* Move at Player*/
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
    

