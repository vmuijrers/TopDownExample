using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 3f;
    [SerializeField] private float rotationSpeed = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 inputDirection = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 moveDir = (Vector3.forward * inputDirection.z + Vector3.right * inputDirection.x).normalized;
        transform.position += moveDir * Time.deltaTime * MoveSpeed;

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 40);
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;

        transform.rotation = Quaternion.LookRotation(lookPos, Vector3.up); // Turns Right
        //transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * rotationSpeed);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(moveDir), rotationSpeed);
    }

}
