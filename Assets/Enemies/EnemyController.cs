using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    CharacterController EnemCtrl;
    [SerializeField] private float gravity;
    public bool Grounded = true;
    private Vector3 moveEnemy;

    [Tooltip("Useful for rough ground")]
    public float GroundedOffset = -0.14f;
    [Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
    public float GroundedRadius = 0.28f;
    [Tooltip("What layers the character uses as ground")]
    public LayerMask GroundLayers;

    private float _verticalVelocity;
    private float _terminalVelocity = 53.0f;

    // Start is called before the first frame update
    void Start()
    {
        EnemCtrl = GetComponent<CharacterController>();
        gravity = -15F;
    }

    // Update is called once per frame
    void Update()
    {
        SetGravity();
        EnemCtrl.Move(moveEnemy * Time.deltaTime);
    }


    private void GroundedCheck()
    {
        // set sphere position, with offset
        Vector3 spherePosition = new Vector3(transform.position.x, transform.position.y - GroundedOffset,
            transform.position.z);
        Grounded = Physics.CheckSphere(spherePosition, GroundedRadius, GroundLayers,
            QueryTriggerInteraction.Ignore);
        // update animator if using character
    }

    void SetGravity()
    {
        moveEnemy.y = gravity * Time.deltaTime;
    }
}
