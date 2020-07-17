using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.ML.Data;

namespace MLNET
{
   public class TaxiTrip
    {
        [LoadColumn(0)]
        public string VendorId;
        [LoadColumn(1)]
        public string RateCode;
        [LoadColumn(2)]
        public string PassengerCount;
        [LoadColumn(3)]
        public string TrimTime;
        [LoadColumn(4)]
        public string TripDistance;
        [LoadColumn(5)]
        public string PaymentType;
        [LoadColumn(6)]
        public string FareAmount;
    }
    public class TaxiTripFarePrediction
    {
        [ColumnName("Score")]
        public float FareAmount;
    }
}


