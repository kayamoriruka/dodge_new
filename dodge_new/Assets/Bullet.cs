using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 100f;
    private Rigidbody bulletRigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 20f);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerDie playerDie = other.GetComponent<PlayerDie>();

            if (playerDie != null)
            {
                playerDie.Die();

            }
        }
    }


}
