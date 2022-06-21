using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator _aniEnemy;
    private bool _fearMode;

    void Start()
    {
        _aniEnemy = GetComponent<Animator>();
        _fearMode = false;
        //Invoke("FearMode", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        FearMode();
    }
    private void FearMode()
    {
        if (_fearMode)
        {
           _aniEnemy.SetBool("Fear", true);
        }
        else
        {
           _aniEnemy.SetBool("Fear", false);
        }
    }

    public void FearActive()
    {
        if (!_fearMode)
        {
            _fearMode = true;
        }
        else
        {
            _fearMode = false;
        }
    }

}
