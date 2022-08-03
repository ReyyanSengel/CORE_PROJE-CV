using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : GenericService<WriterMessage>,IWriterMessageService
    {
        private readonly IWriterMessageRepository _writerMessageRepository;
        public WriterMessageManager(IGenericRepository<WriterMessage> repository, IUnitOfWork unitOfWork, IWriterMessageRepository writerMessageRepository) : base(repository, unitOfWork)
        {
            _writerMessageRepository = writerMessageRepository;
        }

        public List<WriterMessage> GetByFilter(string p)
        {
            return _writerMessageRepository.GetListReceiverMessage(p);
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageRepository.GetListReceiverMessage(p);
        }

        public List<WriterMessage> GetListSenderrMessage(string p)
        {
            return _writerMessageRepository.GetListSenderrMessage(p);
        }
    }
}
