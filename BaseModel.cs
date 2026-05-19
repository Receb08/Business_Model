using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biznes_Model
{
    public class BaseModel
    {
        private int id;
        private DateTime createdDate;

        public int GetId() { return id; }
        public void SetId(int newId) { id = newId; }

        public DateTime GetCreatedDate() { return createdDate; }
        public void SetCreatedDate(DateTime date) { createdDate = date; }
    }
}
