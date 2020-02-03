using System;
using System.Collections.Generic;
public class TrailBurger
{

    public uint Calories
    {
        get
        {
            return 288;
        }
    }
    public double Price
    {
        get
        {
            return 4.50;
        }
    }
    /// <summary>
    /// If dish should be served with bread
    /// </summary>
    public bool Bun
    {
        get; set;
    } = true;

    public bool Ketchup { get; set; } = true;
    public bool Mustard { get; set; } = true;
    public bool Cheese { get; set; } = true;

    /// <summary>
    /// If dish should be served with pickle
    /// </summary>
    public bool Pickle { get; set; } = true;
    /// <summary>
    /// List which holds special instructions
    /// </summary>
    public List<string> SpecialInstructions
    {
        get
        {
            List<string> instructions = new List<string>();

            if (!Bun) { instructions.Add("hold bun"); }
            if (!Pickle) { instructions.Add("hold pickle"); }
            if (!Ketchup) { instructions.Add("hold ketchup"); }
            if (!Mustard) { instructions.Add("hold mustard"); }
            if (!Cheese) { instructions.Add("hold cheese"); }


            return instructions;
        }
    }
}
