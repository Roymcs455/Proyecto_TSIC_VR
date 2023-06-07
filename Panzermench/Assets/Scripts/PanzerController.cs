using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PanzerController : MonoBehaviour
{
    public Transform leftHandTransform;
    public float movementSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float avance = leftHandTransform.localEulerAngles.z;
        if (avance >30 && avance < 90)
        {
            transform.position += Vector3.right * Time.deltaTime * movementSpeed;
        }
        if (avance >270 && avance < 330 )
        {
            transform.position += Vector3.left * Time.deltaTime * movementSpeed;
        }
    }
}
