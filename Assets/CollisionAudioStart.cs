using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudioStart : MonoBehaviour
{

    public AudioSource enterAudio;

    public void ChangeAenter()
    {
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
