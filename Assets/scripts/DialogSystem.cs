using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DialogSystem : MonoBehaviour
{
    [Header("UI组件")]
    public TextMeshProUGUI textLabel;

    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    bool textfinished;
    bool canceltyping;

    List<string> textList = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        GetTextFormFile(textFile);
    }
    private void OnEnable()
    {
        textfinished = true;
        StartCoroutine(SetTextUI());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&& index==textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            return;
        }
        //if (Input.GetKeyDown(KeyCode.R)&&textfinished)
        //{
        //    StartCoroutine(SetTextUI());
        //}
        if(Input.GetKeyDown(KeyCode.R))
        {
            if(textfinished && !canceltyping)
            {
                StartCoroutine(SetTextUI());
            }
            else if (!textfinished)
            {
                canceltyping = !canceltyping;
            }
        }
    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var lineData = file.text.Split('\r','\n');

        foreach(var line in lineData)
        {
            textList.Add(line);
        }    
    }

    IEnumerator SetTextUI()
    {
        textfinished=false;
        textLabel.text = "";
        for (int i = 0; i < textList[index].Length && (!canceltyping); i++)
        {
            textLabel.text += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }
        textLabel.text = textList[index];
        canceltyping = false;
        textfinished=true;
        index++;
    }
}
