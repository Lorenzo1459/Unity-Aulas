using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30.0f;
    public float turnSpeed = 55.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move o veiculo pra frente
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed*horizontalInput);
    }
}
