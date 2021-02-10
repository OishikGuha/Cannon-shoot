using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{

    public float speed;
    Rigidbody rb;
    
    public float secondsToApplyForce = 10;

    public bool addingForce = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine("DisableForce");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(addingForce)
            rb.AddForce(-speed, speed * 3f, 0f);
    }

    IEnumerator DisableForce()
    {
        yield return new WaitForSeconds(secondsToApplyForce);
        Debug.Log("Disabled!");
        addingForce = false;
    }
}
