using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour
{

    [SerializeField] protected SpriteRenderer _renderer;
    [SerializeField] private GameObject _highlight;
    Tile tile;
    public virtual void Init(int x, int y)
    {

    }

    void OnMouseEnter()
    {
        _highlight.SetActive(true);

    }

    void OnMouseDown()
    {
        Debug.Log(this.gameObject.name);
    }

    void OnMouseExit()
    {
        _highlight.SetActive(false);
    }
}