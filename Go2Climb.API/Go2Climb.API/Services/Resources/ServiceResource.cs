﻿namespace Go2Climb.API.Resources
{
    public class ServiceResource
    {
        public int Id { get; set; }
        public int AgencyId { get; set; }
        public string Name { get; set; }
        public short Score { get; set; }
        public int Price { get; set; }
        public int NewPrice { get; set; }
        public string Location { get; set; }
        public string CreationDate { get; set; }
        public string Photos { get; set; }
        public string VideoUrl { get; set; }
        public int Reports { get; set; }
        public string Description { get; set; }
        public bool IsOffer { get; set; }
        public AgencyResource Agency { get; set; }
    }
}