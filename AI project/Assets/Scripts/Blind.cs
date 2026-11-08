using UnityEngine;

public class Agent : MonoBehaviour
{
    StateManager sm = new StateManager();
    bool stateChange = false;
    void Start()
    {
        sm.ChangeState(new MonitorState(this));
    }

    // Update is called once per frame
    void Update()
    {
        // Update the state manager
        sm.Update();
        if (Input.GetKeyDown(KeyCode.Space) && !stateChange)
        {
            sm.ChangeState(new DetectState(this));
            stateChange = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && stateChange)
        {
            sm.ChangeState(new MonitorState(this));
            stateChange = false;
        }
    }
}
