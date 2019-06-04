using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerEarth : MonoBehaviour
{
    float speed_ = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        Director d = GameObject.Find("Director").GetComponent<Director>();
        d.RegistUpdateRevolutionSpeed(OnUpdateRevolutionSpeed);

        OnUpdateRevolutionSpeed(d.GetRevolutionSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), speed_ * Time.deltaTime);
    }

    void OnUpdateRevolutionSpeed(float v)
    {
        speed_ = v * (-365.0f);// 自転は公転の365倍速い
    }
}
