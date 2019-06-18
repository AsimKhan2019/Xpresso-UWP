using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpresso.Views.Menu
{

    public class HomePageMenuItem
    {
     
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }

        public HomePageMenuItem(int Id, string Title, Type Target)
        {
            this.Id = Id;
            this.Title = Title;
            this.TargetType = Target;
        }
    }
}