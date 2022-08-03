using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IWriterMessageRepository:IGenericRepository<WriterMessage>
    {
        List<WriterMessage> GetListReceiverMessage(string p);
        List<WriterMessage> GetListSenderrMessage(string p);
    }
}
