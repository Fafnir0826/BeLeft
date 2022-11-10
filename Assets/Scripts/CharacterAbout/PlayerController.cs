using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Valve.VR;
using Valve.VR.InteractionSystem;



public class PlayerController : NetworkBehaviour
{
    public NetworkCharacterControllerPrototype _cc;

    public SteamVR_Action_Vector2 vrInput;


    public float speed = 10.0f;

    void Awake()
    {
        _cc = GetComponent<NetworkCharacterControllerPrototype>();

    }
    public override void FixedUpdateNetwork()
    {
        if (GetInput(out NetworkInputData data))
        {
            data.direction.Normalize();
            data.direction = Player.instance.hmdTransform.TransformDirection(new Vector3(vrInput.axis.x, 0, vrInput.axis.y));
            _cc.Move(speed * Runner.DeltaTime * data.direction);

        }
    }
    void Update()
    {
        /*if (vrInput.axis.magnitude > 0.1f)
        {
            Vector3 direciton = Player.instance.hmdTransform.TransformDirection(new Vector3(vrInput.axis.x, 0, vrInput.axis.y));
            //transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direciton,Vector3.up);
            characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direciton, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
        }*/
    }
}
