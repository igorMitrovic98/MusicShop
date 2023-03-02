
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMuzickeOpreme.Models
{
    public class ModelLogin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ModelRole Role { get; set; }
        public ModelTheme Theme { get; set; }
        
        public int Status { get; set; }
        
        public override bool Equals(Object obj)
        {
        return obj is ModelLogin model && Id == model.Id && Username == model.Username;
        }

        public override int GetHashCode()
        {
            int hash = -1774558866;
            hash = hash * -1247898887 + Id.GetHashCode();
            hash = hash * -1247898887 + EqualityComparer<string>.Default.GetHashCode(Username);
            return hash;
        }
    }
}
