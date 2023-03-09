using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class HealthBar : MonoBehaviour
{
    public int max;
    public int current;
    public Image mask;
    public TextMeshProUGUI amount;

    void Update()
    {
        GetCurrentFill();
    }

    private void GetCurrentFill()
    {
        mask.fillAmount = (float)current / (float)max;
        amount.text = $"{current} / {max}";
    }
}
