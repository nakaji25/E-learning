using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResultManager.SetScoreData(0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PushEnglishStageButton()
    {
        SceneManager.LoadScene("EnglishQuestionScene");
    }
    public void PushTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
