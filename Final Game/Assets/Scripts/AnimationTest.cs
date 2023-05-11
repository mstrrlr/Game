using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTest : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audiosource;
    Animator animator;
    bool facingRight = true;
    bool Walk = false;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        animator = GetComponent<Animator>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("AnimState", 0);
            facingRight = false;
            Walk = true;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("AnimState", 0);
            facingRight = true;
            Walk = true;
        }
        else
        {
            animator.SetInteger("AnimState", 1);
            Walk = false;
        }
        if (Walk == true)
        {
            audiosource.mute = true;
        }
        else if (Walk == false)
        {
            audiosource.mute = false;
        }
    }
    private void FixedUpdate()
    {
        spriteRenderer.flipX = !facingRight;
    }
}
