using System;
using System.Collections.Generic;
public class RustlersRibs : CowboyCafe.Data.Entree
{

    public override double Price
    {
        get
        {
            return 7.50;
        }
    }
    public override uint Calories
    {
        get
        {
            return 894;
        }
    }
    public override List<string> SpecialInstructions
    {
        get
        {
            List<string> instructions = new List<string>();


            return instructions;
        }
    }
    /// <summary>
    /// ToString function
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return "Rustler's Ribs";
    }

}