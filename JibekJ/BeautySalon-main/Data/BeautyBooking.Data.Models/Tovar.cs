namespace BeautyBooking.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using BeautyBooking.Common;
    using BeautyBooking.Data.Common.Models;

    public class Tovar 
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string count { get; set; }
        public string cost { get; set; }
        public string descrip { get; set; }
        public string comment { get; set; }
        public string dolg { get; set; }
        public string shir { get; set; }
    }
}
