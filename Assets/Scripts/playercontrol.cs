using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class playercontrol : MonoBehaviour
{
    Rigidbody2D body;
    Animator anim;

    public float force = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        anim.SetBool("isWalking", Mathf.Abs(horizontal) > float.Epsilon);

        body.AddForce(new Vector2(horizontal, vertical) * force, ForceMode2D.Impulse);
    }
}
