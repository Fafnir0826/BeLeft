using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Valve.VR;



public class PlayerController : NetworkBehaviour
{
    public NetworkCharacterControllerPrototype _cc;


    public float speed = 0.1f;
  
    void Awake()
    {
        _cc = GetComponent<NetworkCharacterControllerPrototype>();
    }
    public override void FixedUpdateNetwork()
    {
        if (GetInput(out NetworkInputData data))
        {
            data.direction.Normalize();
            _cc.Move(speed * Runner.DeltaTime * data.direction);
        }
    }
    /* void Update()
     {
         if (input.axis.magnitude > 0.1f)
         {
             Vector3 direciton = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
             //transform.position += speed * Time.deltaTime * Vector3.ProjectOnPlane(direciton,Vector3.up);
             characterController.Move(speed * Time.deltaTime * Vector3.ProjectOnPlane(direciton, Vector3.up) - new Vector3(0, 9.81f, 0) * Time.deltaTime);
         }
     }*/
}
