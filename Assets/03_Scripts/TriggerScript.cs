using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public int healthAdded = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Doe hier je code
            //other.gameObject.GetComponent<Health>().AddHealth(healthAdded);
            Destroy(gameObject);
        }
    }
}
