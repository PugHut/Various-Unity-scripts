using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongShuffler : MonoBehaviour
{
    public List<AudioClip> songs;
    public AudioSource audioSource;
    public Button skipButton;
    public Button rewindButton;
    
    private int lastIndex = -1;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(songs.Count + " songs loaded");
        if (audioSource == null) audioSource = GetComponent<AudioSource>();
        PlayRandomSong();
        
        Button btn = skipButton.GetComponent<Button>();
        btn.onClick.AddListener(UISkip);
        
        Button btnR = rewindButton.GetComponent<Button>();
        btnR.onClick.AddListener(UIrewind);
    }

    void UISkip()
    {
        PlayRandomSong();
    }

    void UIrewind()
    {
        rewindSong();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayRandomSong();
        }

        
        if (!audioSource.isPlaying)
        {
            PlayRandomSong();
        }
    }

    void PlayRandomSong()
    {
        if (songs == null || songs.Count == 0)
        {
            Debug.LogError("No songs loaded");
            return;
        }
        int index = Random.Range(0, songs.Count);

        while (songs.Count > 1 && index == lastIndex)
        {
            index = Random.Range(0, songs.Count);
        }
        
        audioSource.clip = songs[index];
        audioSource.Play();
        lastIndex = index;
        Debug.Log(songs[lastIndex].name + " is playing");
    }
    
    void rewindSong()
    {
        if (songs == null || songs.Count == 0)
        {
            Debug.LogError("No songs loaded");
            return;
        }

        if (lastIndex == -1)
        {
            Debug.LogError("No last song");
        }
        
        audioSource.clip = songs[lastIndex];
        audioSource.Play();
        Debug.Log("rewind");
    }
}
