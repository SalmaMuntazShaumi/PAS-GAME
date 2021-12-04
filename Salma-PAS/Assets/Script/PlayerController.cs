using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody rb;
    public float speed = 10f;

    public Vector3 jump;
    public float jumpForce = 3.5f;
    public bool isGrounded;

    private float xInput;
    private float zInput;

    private int colorIndex;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
        jump = new Vector3(0.0f, 2.0f, 0.0f);

        colorIndex = Random.Range(0, 5);

        

        if (colorIndex == 0)
        {
            ChangeColor(Color.black);
        } else if (colorIndex == 1)
        {
            ChangeColor(Color.grey);
        } else if (colorIndex == 2)
        {
            ChangeColor(Color.green);
        } else if (colorIndex == 3)
        {
            ChangeColor(Color.red);
        } else if (colorIndex == 4)
        {
            ChangeColor(Color.blue);
        } else if (colorIndex == 5)
        {
            ChangeColor(Color.magenta);
        } else
        {
            ChangeColor(Color.black);
        }


    }

    // Update is called once per frame
    void Update()
    {
        ConsumeInput();

        //Jump Input
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void LateUpdate()
    {
        Move();
    }

    private void ConsumeInput()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * speed);
    }


    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }


    public void ChangeColor(Color color)
    {
        var cubeRenderer = ball.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", color);
    }

    public void ScaleUp()
    {
        ball.transform.localScale += (new Vector3(0.25f, 0.25f, 0.25f));
        
    }


}
