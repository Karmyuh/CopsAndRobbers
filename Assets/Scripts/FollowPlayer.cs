using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;
    float rotSpeed = 3.0f, moveSpeed = 3.0f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) > 2)
        {
            Walk();
        }
       
    }

    void Walk() 
    {
        /* Look at Player*/
        transform.rotation = Quaternion.Slerp(transform.rotation
        , Quaternion.LookRotation(player.position - transform.position)
        , rotSpeed * Time.deltaTime);

        /* Move at Player*/
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
    

