using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tips : MonoBehaviour
{

    [Header("UI组件")]
    public TextMeshProUGUI help;

    [Header("文本文件")]
    public List<TextAsset> textFile;
    public float textSpeed;
    public int index;

    private int cnt = 0;

    bool textfinished;
    bool canceltyping;



    List<string> textList = new List<string>();

    // Start is called before the first frame update

    private void OnEnable()
    {
        gameObject.SetActive(true);
        if(cnt>=textFile.Count) cnt= 0;
        GetTextFormFile(textFile[cnt++]);
        textfinished = true;
        StartCoroutine(SetTextUI());
    }

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        StartCoroutine(closeself());
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    if (textfinished && !canceltyping)
        //    {
        //        StartCoroutine(SetTextUI());
        //    }
        //    else if (!textfinished)
        //    {
        //        canceltyping = !canceltyping;
        //    }
        //}
    }

    private IEnumerator closeself()
    {
        yield return new WaitForSeconds(2);
        close1();
    }

    private void close1()
    {
        gameObject.SetActive(false);
    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var lineData = file.text.Split('\n');

        foreach (var line in lineData)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textfinished = false;
        help.text = "";

        for (int i = 0; i < textList[index].Length && (!canceltyping); i++)
        {
            help.text += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }
        help.text = textList[index];
        canceltyping = false;
        textfinished = true;
        index++;
    }



}
