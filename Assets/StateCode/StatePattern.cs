using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace StateMachine
{
    public interface ITrafficLightState
    {
        void EnterState();
        void UpdateState();
        void ExitState();
    }
    public class RedLightState : ITrafficLightState
    {
        private readonly TrafficLight trafficLight;

        public RedLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
        }

        public void EnterState()
        {
            Debug.Log("Red light on");
            trafficLight.SetLightColor(Color.red);
        }

        public void UpdateState()
        {
            // Implement any behavior specific to the Red light state.
        }

        public void ExitState()
        {
            Debug.Log("Red light off");
        }
    }

    public class YellowLightState : ITrafficLightState
    {
        private readonly TrafficLight trafficLight;

        public YellowLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
        }

        public void EnterState()
        {
            Debug.Log("Yellow light on");
            trafficLight.SetLightColor(Color.yellow);
        }

        public void UpdateState()
        {
            // Implement any behavior specific to the Yellow light state.
        }

        public void ExitState()
        {
            Debug.Log("Yellow light off");
        }
    }

    public class GreenLightState : ITrafficLightState
    {
        private readonly TrafficLight trafficLight;

        public GreenLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
        }

        public void EnterState()
        {
            Debug.Log("Green light on");
            trafficLight.SetLightColor(Color.green);
        }

        public void UpdateState()
        {
            // Implement any behavior specific to the Green light state.
        }

        public void ExitState()
        {
            Debug.Log("Green light off");
        }
    }
}
