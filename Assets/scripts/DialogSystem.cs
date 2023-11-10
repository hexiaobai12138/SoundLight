using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogSystem : MonoBehaviour
{
    [Header("关卡组件")]
    public GameObject levelcontroller;
    public string Scenename = "";
    [Header("角色组件")]
    public GameObject character;

    [Header("UI组件")]
    public TextMeshProUGUI textLabel;
    public TextMeshProUGUI textname;

    [Header("文本文件")]
    public List<TextAsset> textFile;
    public int novelcnt ;
    public float textSpeed;
    public int index;

    bool textfinished;
    bool canceltyping;
    
    

    List<string> textList = new List<string>();

    // Start is called before the first frame update

    private void OnEnable()
    {
         GetTextFormFile(textFile[novelcnt]);
        textfinished = true;
        StartCoroutine(SetTextUI());
    }

    private void Start()
    {
        character.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)&& index==textList.Count)
        {
            gameObject.SetActive(false);
            character.SetActive(true);
            index = 0;
            if(levelcontroller.GetComponent<Level1Controll>().maxnovelcount==novelcnt)
            {
                UILevel.Levels[levelcontroller.GetComponent<Level1Controll>().Levelcnt+1] = true;
                SceneManager.LoadScene(Scenename);
            }
            return;
        }

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
        var lineData = file.text.Split('\n');

        foreach(var line in lineData)
        {
            textList.Add(line);
        }    
    }

    IEnumerator SetTextUI()
    {
        textfinished=false;
        textLabel.text = "";

        textname.text = textList[index++];

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
