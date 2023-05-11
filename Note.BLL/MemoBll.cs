using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.BLL
{
    public class MemoBll
    {
        private readonly IMemoDal _memoDal;

        public MemoBll(IMemoDal memoDal)
        {
            _memoDal = memoDal;
        }

        public List<Memo> GetMemoList()
        {
            return _memoDal.GetMemoList();
        }

        public Memo GetMemo(int memoNo)
        {
            return _memoDal.GetMemo(memoNo);
        }

        public bool PostMemo(Memo memo)
        {
            return _memoDal.PostMemo(memo);
        }

        public bool UpdateMemo(Memo memo)
        {
            return _memoDal.UpdateMemo(memo);
        }

        public bool DeleteMemo(int memoNo)
        {
            return _memoDal.DeleteMemo(memoNo);
        }
    }
}
