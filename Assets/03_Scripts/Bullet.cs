using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 40;
    private Rigidbody rb;
    public float force = 1000;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(force * transform.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        //{
        //    return;
        //}

        if(other.gameObject.tag == "Player")
        {
            return;
        }


        if(other.gameObject.TryGetComponent<Health>(out Health healthComponent))
        {
            healthComponent.TakeDamage(damage);
        }

        Destroy(gameObject);
    }


}
