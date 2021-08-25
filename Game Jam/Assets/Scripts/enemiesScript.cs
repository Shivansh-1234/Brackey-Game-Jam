using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiesScript : MonoBehaviour
{
    public Transform target;
    public Transform startPos;

    public float moveSpeed;
    public float waitTime;
    private float currentTime;
    private bool Spawned;

    private void Awake()
    {

    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        InvokeRepeating("SpawnEnemy", 3f, 5f);

/*        if (currentTime == 0)
        {
            SpawnEnemy();
        }

        if (Spawned && currentTime < waitTime)
        {
            currentTime += 1 * Time.deltaTime;
        }

        if (currentTime >= waitTime)
        {
            currentTime = 0;
        }*/

    }


/*    IEnumerator Starts()
    {
        Instantiate(this.gameObject, startPos);

        yield return new WaitForSecondsRealtime(5f);
    }*/

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
        
    }

    void SpawnEnemy()
    {
        Instantiate(this.gameObject, startPos);
    }
}
