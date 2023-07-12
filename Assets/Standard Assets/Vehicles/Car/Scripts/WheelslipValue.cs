using UnityEngine;

public class WheelslipValue : MonoBehaviour
{
    WheelCollider WheelC;

    public float RoadForwardStiffness = 3f;
    public float TerraintForwardStiffness = 0.8f;
    public float RoadSidewaysStiffness = 1.1f;
    public float TerrainSidewaysStiffness;
    public float SlidingForwardStiffness = 0.5f;
    public float SlidingSidewaysStiffness = 1.5f;

    private bool SlideChange = false;
    private bool Changed = false;

    private void Start()
    {
        WheelC = GetComponent<WheelCollider>();
        SaveScript.BrakeSlide = false;
    }

    private void Update()
    {
        if (!SaveScript.BrakeSlide)
        {
            if (SaveScript.OnTheRoad)
            {
                if (!Changed)
                {
                    Changed = true;
                    WheelFrictionCurve fFriction = WheelC.forwardFriction;
                    fFriction.stiffness = RoadForwardStiffness;
                    WheelC.forwardFriction = fFriction;

                    WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                    sFriction.stiffness = RoadSidewaysStiffness;
                    WheelC.sidewaysFriction = sFriction;
                }
            }

            if (SaveScript.OnTheTerrain)
            {
                if (Changed)
                {
                    Changed = false;
                    WheelFrictionCurve fFriction = WheelC.forwardFriction;
                    fFriction.stiffness = TerraintForwardStiffness;
                    WheelC.forwardFriction = fFriction;

                    WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                    sFriction.stiffness = TerrainSidewaysStiffness;
                    WheelC.sidewaysFriction = sFriction;
                }
            }
        }

        if (SaveScript.BrakeSlide)
        {
            if (SlideChange)
            {
                SlideChange = false;
                WheelFrictionCurve fFriction = WheelC.forwardFriction;
                fFriction.stiffness = SlidingForwardStiffness;
                WheelC.forwardFriction = fFriction;

                WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                sFriction.stiffness = SlidingSidewaysStiffness;
                WheelC.sidewaysFriction = sFriction;
            }
            if (!SlideChange)
            {
                SlideChange = true;
                WheelFrictionCurve fFriction = WheelC.forwardFriction;
                fFriction.stiffness = RoadForwardStiffness;
                WheelC.forwardFriction = fFriction;

                WheelFrictionCurve sFriction = WheelC.sidewaysFriction;
                sFriction.stiffness = RoadSidewaysStiffness;
                WheelC.sidewaysFriction = sFriction;
            }
        }
    }
}
