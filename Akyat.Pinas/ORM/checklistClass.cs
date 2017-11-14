using SQLite;
namespace Akyat.Pinas.ORM
{
    [Table("Checklist")]

    public class ChecklistClass

    {
        [PrimaryKey, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string backpackValue { get; set; }
        [MaxLength(50)]
        public string bootsValue { get; set; }
        [MaxLength(50)]
        public string plasticbagValue { get; set; }
        [MaxLength(50)]
        public string toiletriesValue { get; set; }
        [MaxLength(50)]
        public string outdoorclothesValue { get; set; }
        [MaxLength(50)]
        public string trailfoodValue { get; set; }
        [MaxLength(50)]
        public string packedlunchValue { get; set; }
        [MaxLength(50)]
        public string trailwaterValue { get; set; }
        [MaxLength(50)]
        public string firstaidkitValue { get; set; }
        [MaxLength(50)]
        public string survivalkitValue { get; set; }
        [MaxLength(50)]
        public string messkitValue { get; set; }
        [MaxLength(50)]
        public string drinkingcupValue { get; set; }
        [MaxLength(50)]
        public string spoonforkValue { get; set; }
        [MaxLength(50)]
        public string identificationValue { get; set; }
        [MaxLength(50)]
        public string whistleValue { get; set; }
        [MaxLength(50)]
        public string raingearValue { get; set; }
        [MaxLength(50)]
        public string jacketValue { get; set; }
        [MaxLength(50)]
        public string sunprotectionValue { get; set; }
        [MaxLength(50)]
        public string flashlightValue { get; set; }
        [MaxLength(50)]
        public string multitoolValue { get; set; }
        [MaxLength(50)]
        public string mobilephoneValue { get; set; }
        [MaxLength(50)]
        public string camerabatteriesValue { get; set; }
        [MaxLength(50)]
        public string trekkingpoleValue { get; set; }
        [MaxLength(50)]
        public string blanketValue { get; set; }
        [MaxLength(50)]
        public string extraclothesValue { get; set; }
        [MaxLength(50)]
        public string sandalsValue { get; set; }
        [MaxLength(50)]
        public string campwaterValue { get; set; }
        [MaxLength(50)]
        public string precookfoodValue { get; set; }
        [MaxLength(50)]
        public string riceValue { get; set; }
        [MaxLength(50)]
        public string tyingstringValue { get; set; }
        [MaxLength(50)]
        public string stovefuelValue { get; set; }
        [MaxLength(50)]
        public string lighterValue { get; set; }
        [MaxLength(50)]
        public string matchesValue { get; set; }
        [MaxLength(50)]
        public string boloValue { get; set; }
        [MaxLength(50)]
        public string mapcompassValue { get; set; }
        [MaxLength(50)]
        public string stoveValue { get; set; }
        [MaxLength(50)]
        public string cooksetValue { get; set; }
        [MaxLength(50)]
        public string flagValue { get; set; }
        [MaxLength(50)]
        public string tentValue { get; set; }
        [MaxLength(50)]
        public string groundsheetValue { get; set; }
        [MaxLength(50)]
        public string ropeValue { get; set; }
        [MaxLength(50)]
        public string trowelValue { get; set; }
        [MaxLength(50)]
        public string othersValue { get; set; }
        
    }
}