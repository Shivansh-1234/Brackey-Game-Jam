using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPhysics : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
