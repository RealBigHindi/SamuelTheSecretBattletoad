using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This is a class.
 * Classes are holding variables and methods.
 **/
public class A_Variables
{
    // 1. Relevant data types

    bool boolean = true;
    char character = 's';
    string characterChain = "Hello there";
    int integer = 1;
    long doubleSizedInteger = 2l;
    double doublePrecisionFloat = 1.0;

    // 2. Relevant keywords

    readonly int cantBeChanged = 1;                                 // readonly
    public int canBeSeenFromOtherClasses;                           // public
    private int canBeSeenOnlyFromThisClass;                         // private
    protected int canBeSeenFromThisClassesAndItsChildren;           // protected
}
