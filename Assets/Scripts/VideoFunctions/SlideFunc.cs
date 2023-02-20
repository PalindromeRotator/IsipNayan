using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class SlideFunc : MonoBehaviour
{
    // Start is called before the first frame update
    public VideoPlayer videoPlayer;
    public Slider videoSlider;
    void Start()
    {
        videoSlider.maxValue = (float)videoPlayer.clip.length;
    }

    public void SetVideoTime(float value)
    {
        videoPlayer.time = value;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
