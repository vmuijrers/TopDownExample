using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class FollowTargetTopDown : MonoBehaviour
{
    public GameObject target;
    public Vector3 offSet;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offSet;
    }
}
