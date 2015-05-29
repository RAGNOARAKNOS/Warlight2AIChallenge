using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using DevGUI.Model;

namespace DevGUI.Services
{
    public interface IDataAccessService
    {
        ObservableCollection<Name> GetNames();
        int CreateName(Name newName);
    }
}
