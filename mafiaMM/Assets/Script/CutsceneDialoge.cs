using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CutsceneDialoge : MonoBehaviour
{
    public TextMeshProUGUI textCom;
    public string[] lines;
    public float textSpeed;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        textCom.text = string.Empty;
        startDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        //Supposed to be Input.touchCount > 0
        if (Input.GetMouseButtonDown(0))
        {
            if(textCom.text == lines[index])
            {
                nextLine();
            }
            else
            {
                StopAllCoroutines();
                textCom.text = lines[index];
            }
        }
    }
    void startDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        //Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textCom.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    void nextLine()
    {
        if (index < lines.Length - 1) 
        {
            index++;
            textCom.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
