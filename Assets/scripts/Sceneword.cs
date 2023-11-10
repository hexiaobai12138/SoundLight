using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Sceneword : MonoBehaviour
{
    [Header("UI组件")]
    public TextMeshProUGUI textLabel;
    public TextMeshProUGUI textname;

    [Header("文本文件")]
    public List<TextAsset> textFile;
    public int scenecnt=0;
    public float textSpeed;

    bool textfinished;
    bool canceltyping;
    int index;
    List<string> ToScene= new List<string>{ "1_home", "2_classroom", "3_home", "4_hall" , "Main" };


    List<string> textList = new List<string>();

    // Start is called before the first frame update

    private void OnEnable()
    {
        GetTextFormFile(textFile[scenecnt]);
        textfinished = true;
        StartCoroutine(SetTextUI());
    }


    void Update()
    {
        if (Input.anyKeyDown && index == textList.Count)
        {            
            index = 0;
            SceneManager.LoadScene(ToScene[scenecnt]);
            return;
        }

        if (Input.anyKeyDown)
        {
            if (textfinished && !canceltyping)
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

        foreach (var line in lineData)
        {
            textList.Add(line);
        }
        if(scenecnt == 4)
        {
            textList[0] += '\n';
            textList[0] += textList[1];
            textList[0] += '\n';
            textList[0] += textList[2];
            textList.RemoveRange(1,2);
        }
    }

    IEnumerator SetTextUI()
    {
        textfinished = false;
        textLabel.text = "";
        for (int i = 0; i < textList[index].Length && (!canceltyping); i++)
        {
            textLabel.text += textList[index][i];

            yield return new WaitForSeconds(textSpeed);
        }
        textLabel.text = textList[index];
        canceltyping = false;
        textfinished = true;
        if (scenecnt == 4 && textfinished)
        {
            textname.text = "——SoundLight项目组";
        }
        index++;
    }

}
