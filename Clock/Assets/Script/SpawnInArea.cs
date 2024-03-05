using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SpawnInArea : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Clock;

    public Vector3 center;
    public Vector3 size;
    public GameObject titleScreen;
    public TextMeshProUGUI finishText;
    public bool isGameActive;
    public float time;
    public float timeDelay;
    public GameObject exitButton;


    public int input = 5;

    void Start()
    {
        time = 0;
        timeDelay = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;

        if (!ObjectCheck() && isGameActive == true && time >= timeDelay)
        {
            FinishGame();
        }               
    }

    private IEnumerator SpawnClock()
    {
        yield return new WaitForSeconds(3);
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2 , size.x / 2), Random.Range(-size.y / 2 , size.y / 2), Random.Range(-size.z / 2 , size.z / 2));

        Instantiate(Clock, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }

    public void FinishGame()
    {
        
        finishText.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
        isGameActive = false;
        
    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        for (int i = 0; i < input; i++)
        {
            StartCoroutine(SpawnClock());
        }
    }

    private bool ObjectCheck()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("AlarmClock");
        return objects.Length > 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
