using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Robber")
        {
            collision.gameObject.GetComponent<FollowPlayer>().enabled = true;
            //collision.gameObject.AddComponent<FollowPlayer>();
        }
    }
}
