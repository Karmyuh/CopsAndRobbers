using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jail : MonoBehaviour
{
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Robber")
        {
            collision.gameObject.GetComponent<FollowPlayer>().enabled = false;
            
            
        }
    }
}
