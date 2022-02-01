using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
    private Animator menuPanelAnimator;
    [SerializeField] private float waitingTimeBeforeLoad;

    private void Awake()
    {
        menuPanelAnimator = GetComponent<Animator>();
    }

    public void LoadLeaderbord()
    {
        CloseMenuPanel();
        StartCoroutine(WaitAndLoadScene("LeaderBord"));
    }

    public void LoadGameLevel()
    {
        CloseMenuPanel();
        StartCoroutine(WaitAndLoadScene("GameLevel"));
    }

    private void OpenMenuPanel()
    {
        menuPanelAnimator.SetTrigger("OpenPanel");
    }

    private void CloseMenuPanel()
    {
        menuPanelAnimator.SetTrigger("ClosePanel");
    }

    private IEnumerator WaitAndLoadScene(string sceneName)
    {

         yield return new WaitForSeconds(waitingTimeBeforeLoad);
        SceneManager.LoadScene(sceneName);

    }
}
