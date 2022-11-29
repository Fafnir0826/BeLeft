using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerController : MonoBehaviour//NetworkBehaviour
{
  //  public NetworkCharacterControllerPrototype _cc;
    public CharacterStates characterStates;

    public float speed = 10.0f;

    void Awake()
    {
       // _cc = GetComponent<NetworkCharacterControllerPrototype>();
        characterStates = GetComponent<CharacterStates>();

    }

    void Start()
    {
        //GameManager.Instance.RigisterPlayer(characterStates);
        GameManager.Instance.RigisterPlayerList(characterStates);
    }

 
   /* public override void FixedUpdateNetwork()
    {
        if (GetInput(out NetworkInputData data))
        {
            data.direction.Normalize();          
            _cc.Move(speed * Runner.DeltaTime * data.direction);

        }
    }*/
    void Update()
    {
    }
}
