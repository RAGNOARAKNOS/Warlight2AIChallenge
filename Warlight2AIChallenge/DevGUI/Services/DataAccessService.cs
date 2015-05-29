using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using DevGUI.Model;

namespace DevGUI.Services
{
    public class DataAccessService : IDataAccessService
    {
        TOOTSEntities context;
   
        public DataAccessService()
        {
            context = new TOOTSEntities();
        }

        public ObservableCollection<Name> GetNames()
        {
            ObservableCollection<Name> Names = new ObservableCollection<Name>();

            foreach(var item in context.Names)
            {
                Names.Add(item);
            }

            return Names;
        }

        public int CreateName(Name newName)
        {
            context.Names.Add(newName);
            context.SaveChanges();
            return newName.NameID;
        }
    }
}
