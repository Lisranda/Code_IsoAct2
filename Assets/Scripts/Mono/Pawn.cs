using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header ("Resource Stats")]
    [SerializeField] Resource Health;
    [SerializeField] Resource Mana;

    [Header("Attributes")]
    [SerializeField] Calculated Strength;
    [SerializeField] Calculated Dexterity;
    [SerializeField] Calculated Constitution;
    [SerializeField] Calculated Wisdom;
    [SerializeField] Calculated Intelligence;

    [Header ("Calculated Stats")]
    [SerializeField] Attribute Dodge;
    [SerializeField] Attribute ManaRegen;
    [SerializeField] Attribute HitChance;
}
