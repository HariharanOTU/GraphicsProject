using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI _timer; 
    public int _time = 60;
    private int _currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = _currentTime; i < _time;)
        {
            StartCoroutine(Timer(_time));
        }
    }

    // Update is called once per frame
    void Update()
    {
          
    }
    IEnumerator Timer(int seconds)
    {
        Debug.Log("Timer of 60 seconds has started");
        yield return new WaitForSeconds(1);
        
        if (_currentTime >= _time)
        {
            Win();
        }
        _currentTime++;
        _timer.text = "Time: " + seconds;
        Debug.Log("Timer has ended");
    }

    public void Win()
    {
        Debug.Log("Win Screen");
        SceneManager.LoadScene("Win");
    }
    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }
}
