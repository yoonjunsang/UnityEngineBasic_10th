using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;



public class PlayManager : MonoBehaviour
{
    //싱글톤
    public static PlayManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new GameObject().AddComponent<PlayManager>();
            }
            return _instance;

        }
    }
    private static PlayManager _instance;

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(_instance.gameObject);
        }
        _instance = this;
    }

    private Runner[] _runners = new Runner[5];
    private Runner[] _runnersFinished = new Runner[5];
    private int _runnerCount;
    private int _runnerFinishedCount;
    [SerializeField] private Transform[] _platforms; 



    public void RegisterRunner(Runner runner)
    {
        _runners[_runnerCount] = runner;
        _runnerCount++;
    }

    public void RegisterRunnerFinished(Runner runner)
    {
        _runnersFinished[_runnerFinishedCount] = runner;
        _runnerFinishedCount++;

        if(_runnerFinishedCount >= _runnerCount)
        {
            Invoke("PlaceRunnersOnPlatforms", 3.0f);
        }

    }

    private void PlaceRunnersOnPlatforms()
    {
        for(int i =0; i < _platforms.Length; i++)
        {
            _runnersFinished[i].transform.position = _platforms[i].position;
        }
    }

}

