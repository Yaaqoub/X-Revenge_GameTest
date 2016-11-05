/**
 * YAAQOUB SEMLALI & YASSINE CHETOUANE ;
 * semlali.yaaqoub@gmail.com ;
 * GameName : XRevenge ( FPS Game ) | Final Year Project ;
 **/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderMusicVolume : MonoBehaviour 
{
    public Slider mainSlider;
    public AudioSource audio;

    void Awake()
    {
        mainSlider.value = 0.39f;
    }
    public void SubmitSliderSetting()
    {
        //Debug.Log(mainSlider.value);
        audio.volume = mainSlider.value /1;
    }
}
