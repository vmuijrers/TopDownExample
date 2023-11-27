using UnityEngine;

public class FollowTargetThirdPerson : MonoBehaviour
{
    public GameObject target;
    public Vector3 offSet;
    private float rotationAngle = 0;
    public float mouseSensitivity = 180f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        rotationAngle += Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        transform.position = target.transform.position - Quaternion.Euler(0, rotationAngle, 0) * offSet;
        Vector3 lookDir = (target.transform.position - transform.position);
        lookDir.y = 0;
        transform.rotation = Quaternion.LookRotation(lookDir.normalized);
    }
}