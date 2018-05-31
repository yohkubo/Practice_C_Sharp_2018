﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P033_Classes_Objects
{
    public class Card
    {
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
