using System.Collections;
using System.Collections.Generic;
using StateMachine;
using UnityEngine;

public class TrafficLight : MonoBehaviour
{
    [SerializeField] Light _light;
    private ITrafficLightState _currentState;
    private float _timer = 0f;

    private void Start()
    {
        // Initial state
        ChangeState(new RedLightState(this));
        ChangeState(new YellowLightState(this));
    }

    public void ChangeState(ITrafficLightState newState)
    {
        _currentState?.ExitState();
        _currentState = newState;
        _currentState.EnterState();
    }

    public void Update()
    {
        _currentState.UpdateState();
        _timer += Time.deltaTime;

        if (_timer >= 5f)
        {
            switch (_currentState)
            {
                case RedLightState redLightState:
                    ChangeState(new GreenLightState(this));
                    break;
                case GreenLightState greenLightState:
                    ChangeState(new YellowLightState(this));
                    break;
                case YellowLightState yellowLightState:
                    ChangeState(new RedLightState(this));
                    break;
            }

            _timer = 0;
        }
    }

    public void SetLightColor(Color color)
    {
        _light.color = color;
    }
}
