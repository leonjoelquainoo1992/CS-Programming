﻿
namespace Assignments.DayThree { 

    //Assignment 10
    public class LabTestRepository
    {
        private double[] labTestCharge;
        private string[] labTestId;

        static LabTestRepository()
        {

        }

        public LabTestRepository()
        {
            LabTestCharge = new double[] { 500, 200, 700, 900 };
            LabTestId = new string[] { "L1", "L2", "L3", "L4" };
        }

        public double[] LabTestCharge
        {
            get
            {
                return labTestCharge;
            }

            set
            {
                labTestCharge = value;
            }
        }

        public string[] LabTestId
        {
            get
            {
                return labTestId;
            }

            set
            {
                labTestId = value;
            }
        }

        public double GetCharge(string testId)
        {
            for(int i = 0; i < LabTestId.Length; i++)
            {
                if (testId.ToLower().Equals(LabTestId[i].ToLower())){
                   return LabTestCharge[i];
                }  
            }
            return 0;
        }
    }
}
