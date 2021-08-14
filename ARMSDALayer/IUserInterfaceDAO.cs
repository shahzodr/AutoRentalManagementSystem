using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARMSDALayer
{
    interface IUserInterfaceDAO<T>
    {
        T GetRecordByID(int key);
        bool Insert(T objDTO);
        bool Update(T objDTO);
        bool Delete(int key);
        List<T> GetAllRecords();
    }
}
