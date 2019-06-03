using System.Collections.Generic;
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

    public List<Statistic> statList = new List<Statistic> ();

    protected virtual void Awake () {
        //statList.Add (Strength = new Attribute (this));
        //statList.Add (Dexterity = new Attribute (this));
        //statList.Add (Constitution = new Attribute (this));
        //statList.Add (Wisdom = new Attribute (this));
        //statList.Add (Intelligence = new Attribute (this));
        //statList.Add (Health = new Health (this));
        //statList.Add (Mana = new Mana (this));
        //statList.Add (Armor = new Armor (this));
        //statList.Add (StrengthDamage = new StrengthDamage (this));
        //statList.Add (DexterityDamage = new DexterityDamage (this));
        //statList.Add (IntelligenceDamage = new IntelligenceDamage (this));

        List<string> stringList = new List<string> ();
        stringList.AddRange (System.Enum.GetNames (typeof (StatType)));

        List<int> valueList = new List<int> ();
        valueList.AddRange ((int [])System.Enum.GetValues (typeof (StatType)));
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
