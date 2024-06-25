using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    public float speed = 20.0f;
    private float horizontalInput;
    public Animator animator;    
    private Rigidbody2D rb;
    public float jumpValue = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(horizontalInput != 0){
            animator.SetBool("Running",true);
        }
        else{
            animator.SetBool("Running",false);
        }
            //animator.SetFloat("Speed",1);
            //animator.SetFloat("Speed", 1);
        //Move o veiculo pra frente
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (horizontalInput > 0) {
            gameObject.transform.localScale = new Vector2(1,1);
        }
        else if (horizontalInput < 0) {
            gameObject.transform.localScale = new Vector2(-1,1);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(Vector2.up * jumpValue,ForceMode2D.Impulse);
        }
    }
}
