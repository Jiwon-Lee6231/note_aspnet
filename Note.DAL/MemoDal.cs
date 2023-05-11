using Microsoft.Extensions.Configuration;
using Note.DAL.DataContext;
using Note.IDAL;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.DAL
{
    public class MemoDal : IMemoDal
    {
        private readonly IConfiguration _configuration;

        public MemoDal(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Memo> GetMemoList()
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Memos
                    .OrderByDescending(n => n.MemoNo)
                    .ToList();
            }
        }

        public Memo GetMemo(int memoNo)
        {
            using (var db = new NoteDbContext(_configuration))
            {
                return db.Memos.FirstOrDefault(n => n.MemoNo.Equals(memoNo));
            }
        }

        public bool PostMemo(Memo memo)
        {
            using (var db = new NoteDbContext(_configuration))
            {
                db.Memos.Add(memo);

                if (db.SaveChanges() > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool UpdateMemo(Memo memo)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMemo(int memoNo)
        {
            throw new NotImplementedException();
        }
    }
}
