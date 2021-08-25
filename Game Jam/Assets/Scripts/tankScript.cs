using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankScript : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;

    public float rotateSpeed;

    Vector3 yAxisLeft = new Vector3(0, -1, 0);
    Vector3 yAxisRight = new Vector3(0, 1, 0);

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, bulletPos.position , bulletPos.rotation);
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(yAxisLeft * rotateSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(yAxisRight * rotateSpeed * Time.deltaTime);
        }
    }
}
