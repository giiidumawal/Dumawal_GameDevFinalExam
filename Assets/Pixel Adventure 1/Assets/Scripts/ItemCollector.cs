using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int _melon = 0;

    [SerializeField] private Text melonText;
    [SerializeField] private AudioSource collectSoundEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            _melon++;
            melonText.text = "Melons: " + _melon;
        }
    }

    
}
