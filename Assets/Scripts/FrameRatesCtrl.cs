using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRatesCtrl : MonoBehaviour
{
    [SerializeField] private int limitFPS = 60;
    // Start is called before the first frame update
    void Start()
    {
      Application.targetFrameRate = limitFPS;
    }

}
