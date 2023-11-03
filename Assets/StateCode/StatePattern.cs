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
        Color color { get; set; }
    }
    public class RedLightState : ITrafficLightState
    {
        private readonly TrafficLight trafficLight;
        public Color color { get; set; }

        public RedLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
            this.color = Color.red;
        }

        public void EnterState()
        {
            Debug.Log("Red light on");
            trafficLight.SetLightColor(color);
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
        public Color color { get; set; }

        public YellowLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
            this.color = Color.yellow;
        }

        public void EnterState()
        {
            Debug.Log("Yellow light on");
            trafficLight.SetLightColor(color);
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
        public Color color { get; set; }

        public GreenLightState(TrafficLight trafficLight)
        {
            this.trafficLight = trafficLight;
            this.color = Color.green;
        }

        public void EnterState()
        {
            Debug.Log("Green light on");
            trafficLight.SetLightColor(color);
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
