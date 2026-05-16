using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class BaseModel
    {
        private int Id;
        private DateTime CreatedDate;

        public int GetId() { return Id; }

        public DateTime GetCreatedDate() { return CreatedDate; }
        public void SetId(int id) { Id = id; }
        public void SetCreatedDate(DateTime date) { CreatedDate = date; }
    }
}
