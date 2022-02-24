using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayEngineSystem : MonoBehaviour
{
    [SerializeField]
    private Image accelerateDisplay;
    [SerializeField]
    private Image breakDisplay;
    [SerializeField]
    private Slider accSlider;
    [SerializeField]
    private Slider brSlider;

    private Color tempColor;

    private Engine _eng;

    private void Awake()
    {
        _eng = GetComponent<Engine>();

        //accSlider.value = 0.5f;
        //brSlider.value = 0.5f;
    }

    private void OnEnable()
    {
        _eng.OnAccelerate += DisplayAccelerate;
        _eng.OnBreak += DisplayBreak;
        _eng.OnStopAccelerate += DisplayStopAccelerate;
        _eng.OnStopBreak += DisplayStopBreak;
    }

    private void OnDisable()
    {
        _eng.OnAccelerate -= DisplayAccelerate;
        _eng.OnBreak -= DisplayBreak; 
        _eng.OnStopAccelerate -= DisplayStopAccelerate;
        _eng.OnStopBreak -= DisplayStopBreak;
    }

    public void DisplayAccelerate(float maxFront, float maxBack, float counterFront, float counterBack)
    {
        ChangeOp(accelerateDisplay, 1f);

        ChangeSliderValue(maxFront, maxBack, counterFront, counterBack, accSlider, brSlider);
    }

    public void DisplayStopAccelerate()
    {
        ChangeOp(accelerateDisplay, 0.60f);
    }

    public void DisplayBreak(float maxFront, float maxBack, float counterFront, float counterBack)
    {
        ChangeOp(breakDisplay, 1f);

        ChangeSliderValue(maxFront, maxBack, counterFront, counterBack, accSlider, brSlider);
    }

    public void DisplayStopBreak()
    {
        ChangeOp(breakDisplay, 0.60f);
    }

    private void ChangeOp(Image image, float op)
    {
        tempColor = image.color;

        tempColor.a = op;

        image.color = tempColor;
    }

    private void ChangeSliderValue(float maxFront, float maxBack, float frontCounter, float backCounter, Slider sliderAcc, Slider sliderBr)
    {
        sliderAcc.maxValue = 1;
        sliderBr.maxValue = 1;

        sliderAcc.value = -frontCounter;
        sliderBr.value = -backCounter;
    }
}
