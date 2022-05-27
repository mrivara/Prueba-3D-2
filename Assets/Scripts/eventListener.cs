using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventListener : MonoBehaviour
{
    private StarterAssets.ThirdPersonController _mngrAttack;
    // Start is called before the first frame update
    void Start()
    {
        // component
        _mngrAttack = GameObject.Find("/Player_All/PlayerArmature").GetComponent<StarterAssets.ThirdPersonController>();
    }

    public void AnimEvent()
    {
        //Debug.Log("Animation End Check");
        _mngrAttack.CheckAttackPhase();
    }

    public void AnimAttackMove()
    {
        _mngrAttack.AttackMove();
    }

    public void AnimAttackStop()
    {
        _mngrAttack.AttackStop();
    }

    public void AnimHeavyAttackMove()
    {
        _mngrAttack.HeavyAttackMove();
    }

    public void AnimHeavyAttackStop()
    {
        _mngrAttack.HeavyAttackStop();
    }

    public void AnimMoveEvadeLeft()
    {
        _mngrAttack.MoveEvadeLeft();
    }
    public void AnimMoveEvadeRight()
    {
        _mngrAttack.MoveEvadeRight();
    }

    public void AnimMoveEvadeLeftOff()
    {
        _mngrAttack.MoveEvadeLeftOff();
    }
    public void AnimMoveEvadeRightOff()
    {
        _mngrAttack.MoveEvadeRightOff();
    }
    public void AnimMoveEvadeExit()
    {
        _mngrAttack.MoveEvadeExit();
    }

    public void AnimMoveOn()
    {
        _mngrAttack.moveOn();
    }

    public void AnimMoveOff()
    {
        _mngrAttack.moveOff();
    }
    public void AnimMoveOn2()
    {
        _mngrAttack.moveOn2();
    }
    public void AnimMoveOff2()
    {
        _mngrAttack.moveOff2();
    }

    public void AnimKatanaCombatOn()
    {
        _mngrAttack.KatanaInHandOn();
        _mngrAttack.KatanaOff();
    }

    public void AnimKatanaCombatOff()
    {
        _mngrAttack.KatanaInHandOff();
        _mngrAttack.KatanaOn();
    }
    public void AnimHitParticleOn()
    {
        //_mngrAttack.HitParticleOn();
    }
    public void AnimHitParticleOff()
    {
        //_mngrAttack.HitParticleOff();
    }
}
