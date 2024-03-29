﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLogic
{
    public class Supplies
    {
        Dictionary<string, Ingredient> supplyDict;
        public Supplies()
        {
            this.supplyDict = new Dictionary<string, Ingredient>();

        }

        public void addSupply(Ingredient ingredient)
        {
            this.supplyDict.Add(ingredient.Name, ingredient);
        }
        
        // Fields

        /// <summary>
        /// Name of the Inventory Supply
        /// </summary>
        private string _supplyName;

        /// <summary>
        /// Ammount of the Inventory Supply
        /// </summary>
        private int _supplyAmmount;

        /// <summary>
        /// Event Handler to Notify Inventory Ran Out of Supply
        /// </summary>
        /// <param name="sender">Supplies</param>
        /// <param name="e">Message</param>
        public delegate void SupplyRanOut(object sender, EventArgs e);
        public event SupplyRanOut OnSupplyDimenished;

        // Properties

        public string SupplyName
        {
            get { return this._supplyName; }
            set { this._supplyName = value; }
        }

        public int SupplyAmmount
        {
            get { return this._supplyAmmount; }
            set
            {
                this._supplyAmmount = value;
                if (this._supplyAmmount == 0)
                {
                    // Notify Manager or Supplier when Supply Runs Out
                    this.OnSupplyDimenished(this, new EventArgs());
                }
            }
        } 
        
        // Methods

        /// <summary>
        /// Update the supply ammount for an ingredient
        /// </summary>
        /// <param name="i"></param>
        public void Update(Ingredient ingredient)
        {
            Ingredient newIngredient;
            this.supplyDict.TryGetValue(ingredient.Name, out newIngredient);
            newIngredient.UnitAmmount -= ingredient.UnitAmmount;
        }
    }
}
