using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoSwitching : MonoBehaviour
{
    // VideoQ1 //
    public void VideoPlaying1()
    {
        SceneManager.LoadScene("#1VideoPlaying");
    }
    public void VideoPlaying2()
    {
        SceneManager.LoadScene("#2VideoPlaying");
    }
    public void VideoPlaying3()
    {
        SceneManager.LoadScene("#3VideoPlaying");
    }
    public void VideoPlaying4()
    {
        SceneManager.LoadScene("#4VideoPlaying");
    }
    public void VideoPlaying5()
    {
        SceneManager.LoadScene("#5VideoPlaying");
    }
    public void VideoPlaying6()
    {
        SceneManager.LoadScene("#6VideoPlaying");
    }
    public void VideoPlaying7()
    {
        SceneManager.LoadScene("#7VideoPlaying");
    }
    public void VideoPlaying8()
    {
        SceneManager.LoadScene("#8VideoPlaying");
    }
    public void VideoPlaying9()
    {
        SceneManager.LoadScene("#9VideoPlaying");
    }
    public void Back()
    {
        SceneManager.LoadScene("VideoQuarter");
    }
    public void Home()
    {
        SceneManager.LoadScene("Categories");
    }

}
