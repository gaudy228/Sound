using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject PanelPause;
    [SerializeField] private GameObject ButtonPause;
    [SerializeField] private Slider music;
    [SerializeField] private Slider sfx;
    [SerializeField] private AudioSource musicSourse;
    [SerializeField] private AudioSource other;
    [SerializeField] private AudioSource other1;
    [SerializeField] private AudioSource other2;
    public void Pause()
    {
        Time.timeScale = 0;
        PanelPause.SetActive(true);
        ButtonPause.SetActive(false);
    }
    public void UnPause()
    {
        Time.timeScale = 1;
        PanelPause.SetActive(false);
        ButtonPause.SetActive(true);
        musicSourse.volume = music.value;
        other.volume = sfx.value;
        other1.volume = sfx.value;
        other2.volume = sfx.value;
    }
}
