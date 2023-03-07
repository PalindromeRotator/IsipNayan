using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{
    [SerializeField] AudioSource music;
    public Button cardButton;
    void Start()
    {
        cardButton.onClick.AddListener(OffMusic);
    }
    public void OnMusic()
    {
        music.Play();
    }

    public void OffMusic()
    {
        music.Stop();
    }

}
