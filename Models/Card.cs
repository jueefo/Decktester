using System;
using System.ComponentModel.DataAnnotations;

namespace MtG_Decktester.Models
{
    public class Card
    {
        public int Id { get; set; } //Id field is required by the database for the primary key
        public string Name { get; set; }
        public int ConvertedManaCost { get; set; }
        //public string Type { get; set; }
        //TODO database to have column types (which will have in one row type and subtypes in own columns)
        //TODO Is subtype needed or specific colors in mana cost
        //TODO How to make a card to belong into a deck - column to do
        //Add a column isInDeck, decks in table Decks
    }
}