using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] GameObject lighting;
    private bool isOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchLight() {
        lighting.SetActive(isOn);
        isOn = !isOn;
    }
}
