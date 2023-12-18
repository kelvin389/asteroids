using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour
{
    public Slider slider;
    public PlayerStats stats;

    // Update is called once per frame
    void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, stats.health, 1);
    }
}
