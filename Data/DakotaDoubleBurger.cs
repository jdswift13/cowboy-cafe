using System;

public class DakotaDoubleBurger
{
    public uint Calories
    {
        get
        {
            return 464;
        }
    }
    public double Price
    {
        get
        {
            return 5.20;
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

    public bool Tomato { get; set; } = true;
    public bool Lettuce { get; set; } = true;
    public bool Mayo { get; set; } = true;
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
            if (!Tomato) { instructions.Add("hold tomato"); }
            if (!Lettuce) { instructions.Add("hold lettuce"); }
            if (!Mayo) { instructions.Add("hold mayo"); }


            return instructions;
        }
    }
}