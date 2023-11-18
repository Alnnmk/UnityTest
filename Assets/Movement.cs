using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] GameObject maincamera;
    public float speed = 5f;
    private float playerspeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;
    private Vector3 movedirection;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        movedirection = new Vector3(horizontalInput, 0, verticalInput);
        transform.Translate(movedirection * speed * Time.deltaTime);

        transform.eulerAngles += speed * new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
    }
}
