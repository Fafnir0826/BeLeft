using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
   // public CharacterStates playerStates;
    public List<CharacterStates> playerstatesList = new List<CharacterStates>();

    List<IEndGameObserver> endGameObservers = new List<IEndGameObserver>();
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this);
    }
    /*public void RigisterPlayer(CharacterStates player)
    {
        playerStates = player; 
    }*/
    public void RigisterPlayerList(CharacterStates player)
    {
          playerstatesList.Add(player);
    }
  

    public void AddObserver(IEndGameObserver observer)
    {
        endGameObservers.Add(observer);
    }

    public void RemoveObserver(IEndGameObserver observer)
    {
        endGameObservers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in endGameObservers)
        {
            observer.EndNotify();
        }
    }
}
