﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitGenerater : MonoBehaviour
{
    public float radius = 1.0f;
    public float width = 0.01f;
    public bool Static = true;
    LineRenderer renderer_;

    void setPosition()
    {
        double[] a = {
0   ,   1   ,
0.062790506 ,   0.998026729 ,
0.125333208 ,   0.992114705 ,
0.187381276 ,   0.982287258 ,
0.248689837 ,   0.968583174 ,
0.309016932 ,   0.951056536 ,
0.36812448  ,   0.929776515 ,
0.425779209 ,   0.904827091 ,
0.481753582 ,   0.87630673  ,
0.535826696 ,   0.844327989 ,
0.587785147 ,   0.809017071 ,
0.637423879 ,   0.770513334 ,
0.684546992 ,   0.728968735 ,
0.728968511 ,   0.68454723  ,
0.770513126 ,   0.637424131 ,
0.809016879 ,   0.587785411 ,
0.844327813 ,   0.535826972 ,
0.876306573 ,   0.481753869 ,
0.904826952 ,   0.425779504 ,
0.929776394 ,   0.368124784 ,
0.951056436 ,   0.309017243 ,
0.968583093 ,   0.248690153 ,
0.982287197 ,   0.187381597 ,
0.992114664 ,   0.125333532 ,
0.998026709 ,   0.062790833 ,
1   ,   3.26795E-07 ,
0.99802675  ,   -0.06279018 ,
0.992114746 ,   -0.125332883    ,
0.982287319 ,   -0.187380955    ,
0.968583255 ,   -0.24868952 ,
0.951056637 ,   -0.309016621    ,
0.929776635 ,   -0.368124176    ,
0.904827231 ,   -0.425778913    ,
0.876306888 ,   -0.481753296    ,
0.844328164 ,   -0.53582642 ,
0.809017263 ,   -0.587784882    ,
0.770513543 ,   -0.637423627    ,
0.728968959 ,   -0.684546753    ,
0.684547468 ,   -0.728968287    ,
0.637424383 ,   -0.770512918    ,
0.587785675 ,   -0.809016687    ,
0.535827247 ,   -0.844327638    ,
0.481754155 ,   -0.876306416    ,
0.4257798   ,   -0.904826813    ,
0.368125087 ,   -0.929776274    ,
0.309017554 ,   -0.951056335    ,
0.24869047  ,   -0.968583012    ,
0.187381918 ,   -0.982287136    ,
0.125333856 ,   -0.992114623    ,
0.062791159 ,   -0.998026688    ,
6.5359E-07  ,   -1  ,
-0.062789854    ,   -0.99802677 ,
-0.125332559    ,   -0.992114787    ,
-0.187380634    ,   -0.982287381    ,
-0.248689203    ,   -0.968583337    ,
-0.309016311    ,   -0.951056738    ,
-0.368123872    ,   -0.929776755    ,
-0.425778617    ,   -0.90482737 ,
-0.48175301 ,   -0.876307045    ,
-0.535826144    ,   -0.844328339    ,
-0.587784618    ,   -0.809017455    ,
-0.637423375    ,   -0.770513751    ,
-0.684546515    ,   -0.728969182    ,
-0.728968064    ,   -0.684547706    ,
-0.77051271 ,   -0.637424634    ,
-0.809016495    ,   -0.58778594 ,
-0.844327463    ,   -0.535827523    ,
-0.876306258    ,   -0.481754442    ,
-0.904826674    ,   -0.425780096    ,
-0.929776154    ,   -0.368125391    ,
-0.951056234    ,   -0.309017865    ,
-0.96858293 ,   -0.248690786    ,
-0.982287074    ,   -0.187382239    ,
-0.992114582    ,   -0.12533418 ,
-0.998026668    ,   -0.062791485    ,
-1  ,   -9.80385E-07    ,
-0.998026791    ,   0.062789528 ,
-0.992114827    ,   0.125332235 ,
-0.982287442    ,   0.187380313 ,
-0.968583418    ,   0.248688887 ,
-0.951056839    ,   0.309016    ,
-0.929776876    ,   0.368123568 ,
-0.904827509    ,   0.425778322 ,
-0.876307203    ,   0.481752723 ,
-0.844328514    ,   0.535825868 ,
-0.809017647    ,   0.587784353 ,
-0.770513959    ,   0.637423124 ,
-0.728969406    ,   0.684546277 ,
-0.684547944    ,   0.72896784  ,
-0.637424886    ,   0.770512501 ,
-0.587786204    ,   0.809016303 ,
-0.535827799    ,   0.844327288 ,
-0.481754728    ,   0.876306101 ,
-0.425780392    ,   0.904826535 ,
-0.368125695    ,   0.929776034 ,
-0.309018175    ,   0.951056133 ,
-0.248691103    ,   0.968582849 ,
-0.18738256 ,   0.982287013 ,
-0.125334504    ,   0.992114541 ,
-0.062791811    ,   0.998026647 ,
-1.30718E-06    ,   1   ,

        };
        for (int i = 0; i < 100; i++)
        {
            renderer_.SetPosition(i,
                this.gameObject.transform.TransformPoint(new Vector3(radius * (float)a[2 * i + 0], 0.0f, radius * (float)a[2 * i + 1]))
                );
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        renderer_ = gameObject.GetComponent<LineRenderer>();
        renderer_.startWidth = width;
        renderer_.endWidth = width;

        renderer_.positionCount = 100;

        if (Static) setPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Static) setPosition();
    }
}
