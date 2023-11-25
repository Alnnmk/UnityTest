using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float RotationSpeed;
    [SerializeField] Vector3 rotationDirection = new Vector3();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotationSpeed * rotationDirection * Time.deltaTime);
    }
}