﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsClassProject
{
    internal class Fraction
    {
        public int Numerator { set; get; }

        int denominator;
        public int Denominator {
            set
            {
                if(value != 0)
                    denominator = value;
            }
            get
            {
                return denominator;
            }
        }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Fraction Add(Fraction fobj)
        {
            return new Fraction(this.Numerator * fobj.Denominator +
                    fobj.Numerator * this.Denominator,
                    this.Denominator * fobj.Denominator);
        }

        public static Fraction operator+(Fraction fobj1, Fraction fobj2)
        {
            return new Fraction(fobj1.Numerator * fobj2.Denominator +
                    fobj2.Numerator * fobj1.Denominator,
                    fobj1.Denominator * fobj2.Denominator);
        }

        public Fraction Del(Fraction fobj)
        {
            return new Fraction(this.Numerator * fobj.Denominator +
                    fobj.Numerator * this.Denominator,
                    this.Denominator * fobj.Denominator);
        }

        public static Fraction operator -(Fraction fobj1, Fraction fobj2)
        {
            return new Fraction(fobj1.Numerator * fobj2.Denominator -
                    fobj2.Numerator * fobj1.Denominator,
                    fobj1.Denominator * fobj2.Denominator);
        }

        public Fraction Mult(Fraction fobj)
        {
            return new Fraction(this.Numerator * fobj.Numerator, this.Denominator * fobj.Denominator);
        }

        public static Fraction operator *(Fraction fobj1, Fraction fobj2)
        {
            return new Fraction(fobj1.Numerator * fobj2.Numerator, fobj1.Denominator * fobj2.Denominator);
        }

        public static bool operator >(Fraction fobj1, Fraction fobj2)
        {
            return fobj1.Numerator * fobj2.Denominator > fobj2.Numerator * fobj1.Denominator;
        }

        public static bool operator <(Fraction fobj1, Fraction fobj2)
        {
            return fobj1.Numerator * fobj2.Denominator < fobj2.Numerator * fobj1.Denominator;
        }

        public static Fraction operator++(Fraction fobj)
        {
            //fobj.Numerator += fobj.Denominator;
            //return fobj;
            return new Fraction(fobj.Numerator += fobj.Denominator, fobj.Denominator);
        }

        public override string ToString()
        {
            return $"[{this.Numerator}/{this.Denominator}]";
        }
    }
}
