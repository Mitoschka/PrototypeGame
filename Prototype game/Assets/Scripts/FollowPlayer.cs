using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Transform position of camera
        transform.position = player.transform.position + offset;
        //Transform rotation of camera
        transform.rotation = Quaternion.Euler(22, 0, 0);
    }
}
