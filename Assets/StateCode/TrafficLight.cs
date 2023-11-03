using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    // Start is called before the first frame updat
    private StateMachine.ITrafficLightState currentState;

    private void Start()
    {
        // Initial state
        ChangeState(new RedLightState(this));
        ChangeState(new YellowLightState(this));
    }

    public void ChangeState(ITrafficLightState newState)
    {
        currentState?.ExitState();
        currentState = newState;
        currentState.EnterState();
        currentState.ExitState();
    }

    public void Update()
    {
        currentState.UpdateState();
    }

    public void SetLightColor(Color color)
    {
    // change the traffic light color // you can use light component or renderer 
    
    }
   }
