using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopMuzickeOpreme.Models
{
    public class ModelRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override bool Equals(object obj)
        {
            return obj is ModelRole model && Id == model.Id && Name == model.Name;
        }

        public override int GetHashCode()
        {
            int hash = -1774558866;
            hash = hash * -1247898887 + Id.GetHashCode();
            hash = hash * -1247898887 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hash;
        }
    }
}
