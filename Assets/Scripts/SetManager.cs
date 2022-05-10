using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Toggle toggle;
    public Selected[] Sets;
    void Start()
    {
        for(int i = 0; i < Sets.Length; i++)
        {
            int c = i;
            Toggle a = Instantiate(toggle, transform.position, Quaternion.identity, canvas.transform);
            a.onValueChanged.AddListener((b)  => OnToggle(c, b));
            a.isOn = true;
        }
    }
    public void OnToggle(int index, bool toggled)
    {
        Debug.Log($"{index} {toggled}");
        Sets[index].enabled = toggled;
    }
}
[System.Serializable]
public class Selected
{
    public bool enabled;
    public string[] questions;
}
