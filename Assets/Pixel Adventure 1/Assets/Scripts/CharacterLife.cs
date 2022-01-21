using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterLife : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Animator _anim;
    [SerializeField] private AudioSource killSoundEffect;
    [SerializeField] private AudioSource restartSoundEffect;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        killSoundEffect.Play();
        _rb.bodyType = RigidbodyType2D.Static;
        _anim.SetTrigger("kill");
    }

    private void Restart()
    {
        restartSoundEffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
