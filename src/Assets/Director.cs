using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    public delegate void OnUpdateRevolutionSpeed(float v);

    [Range(-2.0f, 2.0f)]
    public float log_speed = 0.0f;
    OnUpdateRevolutionSpeed notifyUpdateRevolutionSpeed_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetRevolutionSpeed()
    {
        float realscale = 360.0f / (60.0f * 60.0f * 24.0f * 365.0f);
        return Mathf.Pow(10.0f, log_speed) * (24.0f * 365.0f) * realscale;// １時間で一周
    }

    public void SetRevolutionSpeed(float v)
    {
        log_speed = v;

        // 通知
        notifyUpdateRevolutionSpeed_(GetRevolutionSpeed());
    }

    public void RegistUpdateRevolutionSpeed(OnUpdateRevolutionSpeed f )
    {
        notifyUpdateRevolutionSpeed_ += f;
    }
}

