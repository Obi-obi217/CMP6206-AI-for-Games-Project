using UnityEngine;

public class Blind : MonoBehaviour
{
    StateManager sm = new StateManager();
    int stateIndex = 0;
    void Start()
    {
        sm.ChangeState(new IdleState(this));
    }

    // Update is called once per frame
    void Update()
    {
        sm.Update();

        if (Input.GetKeyDown(KeyCode.F) && stateIndex == 4)
        {
            sm.ChangeState(new IdleState(this));
            stateIndex = 0;
        }
        if (Input.GetKeyDown(KeyCode.G) && (stateIndex == 0 || stateIndex == 2 || stateIndex == 4))
        {
            sm.ChangeState(new AlertedState(this));
            stateIndex = 1;
        }
        if (Input.GetKeyDown(KeyCode.H) && stateIndex == 1)
        {
            sm.ChangeState(new InvestigateState(this));
            stateIndex = 2;
        }
        if (Input.GetKeyDown(KeyCode.J) && stateIndex == 2)
        {
            sm.ChangeState(new SearchState(this));
            stateIndex = 3;
        }
        if (Input.GetKeyDown(KeyCode.K) && stateIndex == 3)
        {
            sm.ChangeState(new ReturningState(this));
            stateIndex = 4;
        }
    }
}
