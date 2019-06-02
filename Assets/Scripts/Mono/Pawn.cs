using UnityEngine;

public class Pawn : MonoBehaviour
{
    public int Level { get; protected set; } = 1;

    public Health Health { get; protected set; }
    public Mana Mana { get; protected set; }

    public Attribute Strength { get; protected set; }
    public Attribute Dexterity { get; protected set; }
    public Attribute Constitution { get; protected set; }
    public Attribute Wisdom { get; protected set; }
    public Attribute Intelligence { get; protected set; }

    public Armor Armor { get; protected set; }
    public StrengthDamage StrengthDamage { get; protected set; }
    public DexterityDamage DexterityDamage { get; protected set; }
    public IntelligenceDamage IntelligenceDamage { get; protected set; }

    protected virtual void Awake () {
        Strength = new Attribute (this);
        Dexterity = new Attribute (this);
        Constitution = new Attribute (this);
        Wisdom = new Attribute (this);
        Intelligence = new Attribute (this);
        Health = new Health (this);
        Mana = new Mana (this);
    }

    protected virtual void Start () {

    }

    protected virtual void Update () {
        //Debug.Log ("HB: " + Health.BaseValue);
        //Debug.Log ("HM: " + Health.MaxValue);
        //Debug.Log ("HC: " + Health.CurrentValue);

        //Debug.Log ("MB: " + Mana.BaseValue);
        //Debug.Log ("MM: " + Mana.MaxValue);
        //Debug.Log ("MC: " + Mana.CurrentValue);

        //Debug.Log ("STR: " + Strength.MaxValue);
    }
}
