using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PLayer Data")]

public class PlayerData : ScriptableObject
{
    [SerializeField] private string PlayerName;
    [SerializeField] private int PlayerHealth;
}
