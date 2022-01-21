using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private SpriteRenderer _sprite;
    private Animator _anim;

    private float DX;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    [SerializeField] private AudioSource jumpSoundEffect;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
        _anim = GetComponent<Animator>();
    }

   
    private void Update()
    {
        DX = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(DX * moveSpeed, _rb.velocity.y );

        if (Input.GetButtonDown("Jump"))
        {
            jumpSoundEffect.Play();
           _rb.velocity = new Vector3(_rb.velocity.x, jumpForce);
        }

        UpdateAnimationState();
        
    }

    private void UpdateAnimationState()
    {
        if (DX > 0f)
        {
            _anim.SetBool("running", true);
            _sprite.flipX = false;
        }
        else if (DX < 0f)
        {
            _anim.SetBool("running", true);
            _sprite.flipX = true;
        }
        else
        {
            _anim.SetBool("running", false);
        }
    }
}
