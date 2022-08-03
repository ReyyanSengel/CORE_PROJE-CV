using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class WriterMessageRepository : GenericRepository<WriterMessage>, IWriterMessageRepository
    {
        public WriterMessageRepository(Context context) : base(context)
        {
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _context.WriterMessages.Where(x => x.Receiver == p).ToList();
        }

        public List<WriterMessage> GetListSenderrMessage(string p)
        {
            return _context.WriterMessages.Where(x => x.Sender == p).ToList();
        }
    }
}

        