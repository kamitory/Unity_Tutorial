using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
}

public class Test : MonoBehaviour
{
    private AudioSource theAudio;

    [SerializeField] private AudioClip[] clip;



    void Start()
    {
        theAudio = GetComponent<AudioSource>();
    }

    public void PlaySE()
    {
        int _temp = Random.Range(0, 4);

        theAudio.clip = clip[_temp];
        theAudio.Play();
    }

}
