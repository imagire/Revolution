using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerSlider : MonoBehaviour
{
    private Slider slider_;
    private float value_;

    // Start is called before the first frame update
    void Start()
    {
        slider_ = GetComponent<Slider>();
        value_ = slider_.value;

        slider_.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    public void ValueChangeCheck()
    {
        GameObject.Find("Director").GetComponent<Director>().SetRevolutionSpeed(GetComponent<Slider>().value);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider_.value != value_)
        {
            value_ = slider_.value;
        }
    }
}
