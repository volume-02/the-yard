using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class FanSwitch : MonoBehaviour
{
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchFan()
    {
        animator.SetBool("isWorking", !animator.GetBool("isWorking"));
    }
}
