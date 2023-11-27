using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healAmount = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Health>(out Health healthComponent))
        {
            Debug.Log($"Gained: {healAmount} health");
            healthComponent.GainHealth(healAmount);
            Destroy(gameObject);
        }
    }
}
