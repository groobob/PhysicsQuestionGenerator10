using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetManager : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] Toggle toggle;
    [SerializeField] Text generatedText;
    public Selected[] Sets;
    private bool isInstantiated = false;
    public void CreateToggles()
    {
        if(isInstantiated == false)
        {

            for(int i = 0; i < Sets.Length; i++)
            {
                int toggleNumber = i;
                Toggle instantiatedToggle = Instantiate(toggle, transform.position, Quaternion.identity, canvas.transform);
                instantiatedToggle.onValueChanged.AddListener((toggleEnabled)  => OnToggle(toggleNumber, toggleEnabled));
                instantiatedToggle.isOn = Sets[i].enabled;
            }
            isInstantiated = true;
        }
        else if(isInstantiated == true)
        {
            isInstantiated = false;
        }
    }
    public void OnToggle(int index, bool toggled)
    {

        Sets[index].enabled = toggled;
    }
    public void GenerateQuestion()
    {
        int generatedTopic = Random.Range(0, Sets.Length);
        if(Sets[generatedTopic].enabled == true)
        {
            int generatedQuestion = Random.Range(0, Sets[generatedTopic].questions.Length);
            generatedText.text = Sets[generatedTopic].questions[generatedQuestion].ToString();
        }
        else
        {
            GenerateQuestion();
        }
    }
}
[System.Serializable]
public class Selected
{
    public string name;
    public bool enabled;
    public string[] questions;
}
