using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public int RobberCount = 0;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Robber" || RobberCount == 0)
        {
            RobberCount++;
            //collision.gameObject.GetComponent<FollowPlayer>().enabled = true;
            collision.gameObject.AddComponent<FollowPlayer>();
        }

        if (collision.gameObject.tag == "Robber")
        {
            RobberCount++;
            //collision.gameObject.GetComponent<FollowPlayer>().enabled = true;
            collision.gameObject.AddComponent<FollowPlayer>();
        }
    }
}
