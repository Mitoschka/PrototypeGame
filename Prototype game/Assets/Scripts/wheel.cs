using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheel : MonoBehaviour
{
    private float speed = 600.0f;
    private float rotateInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // This is where we get whell input 
        rotateInput = Input.GetAxis("Vertical");

        // We rotade the whell forward
        transform.Rotate(Vector3.right, speed * rotateInput * Time.fixedDeltaTime);
    }
}
