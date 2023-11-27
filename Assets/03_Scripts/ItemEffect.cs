using UnityEngine;

public class ItemEffect : MonoBehaviour
{
    public virtual void OnUse()
    {
        Debug.Log("Base Usage");
    }
}
