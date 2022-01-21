using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    private AudioSource endSound;

    private bool lvlComplete = false;
    void Start()
    {
        endSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Character" && !lvlComplete)
        {
            endSound.Play();
            lvlComplete = true;
            Invoke("LevelComplete", 2f);
        }
    }

    private void LevelComplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
