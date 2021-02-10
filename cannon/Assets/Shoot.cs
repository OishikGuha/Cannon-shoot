using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject missile;
    public float recoilForce = 5f;
    // I am too lazy to complete recoil lol
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            var missileInstantiate = Instantiate(missile, transform);
            rb.AddForce(-recoilForce, 0f, 0f);
        }
    }
}
