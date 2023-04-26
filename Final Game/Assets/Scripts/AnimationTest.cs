using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    bool facingRight = true;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("AnimState", 0);
            facingRight = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("AnimState", 0);
            facingRight = true;
        }
        else
        {
            animator.SetInteger("AnimState", 1);
            facingRight = true;
        }
    }
    private void FixedUpdate()
    {
        spriteRenderer.flipX = !facingRight;
    }
}
