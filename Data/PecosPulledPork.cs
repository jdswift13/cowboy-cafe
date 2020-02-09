using System;
using System.Collections.Generic;
public class PecosPulledPork : CowboyCafe.Data.Entree
{
    public override uint Calories
    {
        get
        {
            return 528;
        }
    }
    public override double Price
    {
        get
        {
            return 5.88;
        }
    }
    /// <summary>
    /// If dish should be served with bread
    /// </summary>
    public bool Bread
    {
        get { return Bread; }
        set { Bread = value; }
    }
    private bool bread = true;

    /// <summary>
    /// If dish should be served with pickle
    /// </summary>
    public bool Pickle { get; set; } = true;
    /// <summary>
    /// List which holds special instructions
    /// </summary>
    public override List<string> SpecialInstructions
    {
        get
        {
            List<string> instructions = new List<string>();

            if (!bread) { instructions.Add("hold bread"); }
            if (!Pickle) { instructions.Add("hold pickle"); }

            return instructions;
        }
    }
}