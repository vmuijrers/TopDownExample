using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{

    public UnityEvent OnUseEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Use();
        }
    }

    public void Use()
    {
        //ItemEffect[] allEffects = GetComponents<ItemEffect>();
        //foreach (ItemEffect effect in allEffects)
        //{
        //    effect.OnUse();
        //}

        OnUseEvent?.Invoke();
    }
}
