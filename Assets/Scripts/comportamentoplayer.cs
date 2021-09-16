using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamentoplayer : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float aceleracao;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direcao = transform.up * aceleracao;
            myRigidbody.AddForce(direcao, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.rotation += velocidadeAngular * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.rotation -= velocidadeAngular * Time.deltaTime;
        }

        if (myRigidbody.velocity.magnitude > velocidadeMaxima)
        {
            myRigidbody.velocity = Vector2.ClampMagnitude(
                myRigidbody.velocity,velocidadeMaxima);
        }
    }
}
