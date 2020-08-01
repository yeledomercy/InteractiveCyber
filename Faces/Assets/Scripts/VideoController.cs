using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController : MonoBehaviour
{
    public VideoPlayer MyPlayer;
    public List<VideoClip> MyClips = new List<VideoClip>();
    public int currentClipIndex;
    public Sprite PlayImage;
    public Sprite PauseImage;
    public Button PlayPauseButton;
    public GameObject Controller;
    private bool playing;
    // Start is called before the first frame update
    void Start()
    {
        playing = true;
        MyPlayer.loopPointReached += DoAtEndOfVideo;

    }

    public void DoAtEndOfVideo(VideoPlayer vp)
    {
        Controller.SetActive(true);

    }

    public void PlayClip(int clipIndex)
    {
        MyPlayer.clip = MyClips[clipIndex];
        MyPlayer.Play();
        Controller.SetActive(false);
    }

    public void TogglePlay()
    {
        if (playing)
        {
            MyPlayer.Pause();
            PlayPauseButton.GetComponent<UnityEngine.UI.Image>().sprite = PlayImage;
            playing = false;
        }
        else if (!playing)
        {
            MyPlayer.Play();
            PlayPauseButton.image.GetComponent<UnityEngine.UI.Image>().sprite = PauseImage;
            playing = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
