using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distancecalculation : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
    public double Distance;

    public double FinalDistance;

    public double HitScore;
    public GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        style.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(obj1.transform.position, obj2.transform.position);
        FinalDistance = Math.Truncate(Distance * 100) / 100;
        HitScore = FinalDistance * 100;
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(50,150,200,200), "Score :" + HitScore, style) ;
    }
}