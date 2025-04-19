using UnityEngine;

public class DieBehaviour : IBehaviour
{
    private Nps _nps;

    public DieBehaviour(Nps nps)
    {
        _nps = nps;
    }

    public void Enter()
    {
        Update();
    }

    public void Update()
    {
        _nps.DieffectPrefab.transform.position = _nps.transform.position;
        _nps.DieffectPrefab.OnDieEffect();

        Object.Destroy(_nps.gameObject, 0.5f);
    }

    public void Exit()
    {
    }
}