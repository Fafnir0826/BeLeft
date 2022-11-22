using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerController : NetworkBehaviour
{
    public NetworkCharacterControllerPrototype _cc;
    protected CharacterStates characterStates;

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
            _cc.Move(speed * Runner.DeltaTime * data.direction);

        }
    }
    void Update()
    {
    }
}
