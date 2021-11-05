using System;
using System.Collections.Generic;
using System.Text;

namespace StudentPortal.Services.Service
{
    public abstract class Calculation
    {
        public abstract float getPercentage(float m1, float m2, float m3);
        public float GetTotalMarks(float marks1 , float marks2 , float marks3)
        {
            float total = (marks1 + marks2 + marks3) ;
            return total;
        }
    }
   public class CalculatePercentage : Calculation
    {

        //float marks1, marks2, marks3;

        //public CalculatePercentage(float m1, float m2, float m3)
        //{

        //    marks1 = m1;

        //    marks2 = m2;

        //    marks3 = m3;

        //}

        public override float getPercentage(float m1, float m2, float m3)
        {

            float total = (GetTotalMarks(m1,m2,m3) / (float)300) * 100;

            return total;

        }
    }
}
