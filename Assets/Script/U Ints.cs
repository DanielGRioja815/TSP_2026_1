using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //Variables de control
    static int currentIndex = 0;
    //Variables de objetos
    [SerializeField]
    public List<string> message;
    [SerializeField]
    public TextMeshProUGUI texts;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentIndex = 0;
    }

    public void CycleText()
    {
        currentIndex = (currentIndex + 1) % message.Count;
        UpdateText();
    }

    // Update is called once per frame
    public void UpdateText()
    {
        if (message.Count > 0 && texts != null)
        {
            texts.text = message[currentIndex];
        }
    }
}
