using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator _aniEnemy;

    void Start()
    {
        _aniEnemy = GetComponent<Animator>();
        Invoke("FearMode", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FearMode()
    {
        _aniEnemy.SetBool("Fear", true);
    }

}
