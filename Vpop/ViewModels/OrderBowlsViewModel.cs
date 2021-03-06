using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vpop.ViewModels
{
    public class OrderBowlsViewModel
    {
        public string Custname { get; set; }
        public string Item { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string Currdate { get; set; }
        public Dictionary<string, string> Protein1 { get; set; }
        public Dictionary<string, string> Protein2 { get; set; }
        public Dictionary<string, string> CategoryChoices { get; set; }

        public OrderBowlsViewModel(Dictionary<string, string> categorychoices, Dictionary<string, string> protein1, Dictionary<string, string> protein2)
        {
            Protein1 = protein1;
            Protein2 = protein2;
            CategoryChoices = categorychoices;
        }
        public OrderBowlsViewModel() { }
    }
}
