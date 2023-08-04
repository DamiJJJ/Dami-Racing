using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use

        public GameObject reverseLightsOff;
        public GameObject reverseLightsOn;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
            reverseLightsOn.SetActive(false);
            reverseLightsOff.SetActive(true);
        }


        private void FixedUpdate()
        {
            if (SaveScript.RaceStart)
            {
                // pass the input to the car!
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                float v = CrossPlatformInputManager.GetAxis("Vertical");

                if (SaveScript.Joypad)
                {
                    if (CrossPlatformInputManager.GetAxis("XboxAccel") > 0)
                    {
                        if(v < 100.0f)
                        {
                            v += 1.0f;
                        }
                    }
                    if (CrossPlatformInputManager.GetAxis("XboxBrake") > 0 )
                    {
                        if(v > -100.0f)
                        {
                            v -= 1.0f;
                        }
                    }
                }

                if (v < 0 && h != 0)
                {
                    SaveScript.BrakeSlide = true;
                }
                if (v >= 0)
                {
                    SaveScript.BrakeSlide = false;
                    SaveScript.isReversing = false;
                    reverseLightsOn.SetActive(false);
                    reverseLightsOff.SetActive(true);
                }

                if (v < 0 && SaveScript.Speed > 0 && SaveScript.Speed < 1)
                {
                    SaveScript.isReversing = true;
                    reverseLightsOn.SetActive(true);
                    reverseLightsOff.SetActive(false);
                }
                // if (v >= 0)
                // {
                //     SaveScript.BrakeSlide = false;
                // }
#if !MOBILE_INPUT
                float handbrake = CrossPlatformInputManager.GetAxis("Jump");
                m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
            }
        }
    }
}
