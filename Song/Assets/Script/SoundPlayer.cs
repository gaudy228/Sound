using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource shootSourse;
    [SerializeField] private AudioClip shootSound;
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    shootSourse.Play();
        //}
    }
}
