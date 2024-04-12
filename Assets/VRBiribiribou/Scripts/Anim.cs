using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Anim : MonoBehaviour
{
    public XRController controller = null;
    public Animator m_animator = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerTarget))
        {
            m_animator.SetBool("IsGrab",true);
        }
    }
}
