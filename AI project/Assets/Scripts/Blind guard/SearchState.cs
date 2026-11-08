using UnityEngine;

public class SearchState : State
{
    Blind owner;
    public SearchState(Blind owner)
    {
        this.owner = owner;
    }
    public override void Enter()
    {
        Debug.Log("Entering Search State");
    }
    public override void Execute()
    {
        Debug.Log("Executing Search State");
    }
    public override void Exit()
    {
        Debug.Log("Exiting Search State");
    }
}

